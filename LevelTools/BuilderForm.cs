using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace LevelTools
{
    public partial class BuilderForm : Form
    {
        public BuilderForm()
        {
            InitializeComponent();
        }

        Random rng;

        RenderPanel rPanel;
        double zoom = 1f;
        int rTileW = 1;
        int rTileH = 1;

        bool tileView = false;

        int offsetX = 0;
        int offsetY = 0;
        int firstDragX = 0;
        int firstDragY = 0;
        int firstOffsetX = 0;
        int firstOffsetY = 0;
        bool wasDraggingBefore = false;

        int selectedPaintId = -1;
        Dictionary<string, TilePaint> paintDict = new Dictionary<string, TilePaint>();

        int brushSize = 1;

        private void BuilderForm_Load(object sender, EventArgs e)
        {
            rng = new Random();

            //setup render panel
            rPanel = new RenderPanel();
            rPanel.Dock = DockStyle.Fill;
            createContainer.Controls.Add(rPanel);

            rPanel.Paint += RPanel_Paint;
            rPanel.MouseWheel += RPanel_MouseWheel;
            rPanel.MouseMove += RPanel_MouseMove;

            AddPaint("FLOOR", 255, 255, 255);
            AddPaint("WALL", 0, 0, 0);

            Enabled = false;

            SetupForm setupForm = new SetupForm(this);
            setupForm.Show();
        }

        #region Button Interactions

        private void noiseButton_Click(object sender, EventArgs e)
        {
            if (!LevelData.established)
                return;

            int noiseDenom = Convert.ToInt32(noiseDenomInput.Text);
            if (noiseDenom == 0)
                noiseDenom = 1;

            int noiseNom = Convert.ToInt32(noiseNomInput.Text);

            //generate noise
            for (int i = 0; i < LevelData.w; i++)
            {
                for (int j = 0; j < LevelData.h; j++)
                {
                    int noiseVal = rng.Next(noiseDenom);
                    if (noiseVal <= noiseNom - 1)
                        SetPaint("WALL", i, j);
                }
            }

            UpdateVisualization();
        }

        private void refineButton_Click(object sender, EventArgs e)
        {
            if (!LevelData.established)
                return;

            int refineSteps = Convert.ToInt32(refStepsInput.Text);

            //refine noise
            for (int k = 0; k < refineSteps; k++)
            {
                for (int i = 0; i < LevelData.w; i++)
                {
                    for (int j = 0; j < LevelData.h; j++)
                    {
                        int surroundingWalls = 0;
                        for (int m = -1; m <= 1; m++)
                        {
                            for (int n = -1; n <= 1; n++)
                            {
                                if (LevelData.PointIsSafe(i + m, j + n))
                                {
                                    if (LevelData.map[i + m, j + n] == 1)
                                        surroundingWalls++;
                                }
                            }
                        }
                        if (surroundingWalls >= 5)
                            SetPaint("WALL", i, j);
                        else
                            SetPaint("FLOOR", i, j);
                    }
                }
            }

            UpdateVisualization();
        }

        private void borderButton_Click(object sender, EventArgs e)
        {
            if (!LevelData.established)
                return;

            int borderThickness = Convert.ToInt32(borderInput.Text);

            for(int i = 0; i < LevelData.w; i++)
            {
                for(int j = 0; j < LevelData.h; j++)
                {
                    for(int k = 0; k < borderThickness; k++)
                    {
                        if(i <= k || i >= LevelData.w - k - 1 || j <= k || j >= LevelData.h - k - 1)
                        {
                            LevelData.map[i, j] = 1;
                        }
                    }
                }
            }

            UpdateVisualization();

        }

        private void bakeButton_Click(object sender, EventArgs e)
        {
            
        }

        private void copyToClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap rawBitmap = new Bitmap(rPanel.Width, rPanel.Height);
            rPanel.DrawToBitmap(rawBitmap, new Rectangle(0, 0, rPanel.Width, rPanel.Height));

            Bitmap copyBitmap = new Bitmap(LevelData.w * rTileW, LevelData.h * rTileH);
            copyBitmap = rawBitmap.Clone(new Rectangle(offsetX, offsetY, copyBitmap.Width, copyBitmap.Height), System.Drawing.Imaging.PixelFormat.DontCare);
            Clipboard.SetImage(copyBitmap);
        }        
        #endregion

        #region Misc. UI Interactions
        private void tileViewCheck_CheckedChanged(object sender, EventArgs e)
        {
            UpdateVisualization();
        }
        #endregion

        #region Rendering
        void UpdateVisualization()
        {
            rPanel.Invalidate();
        }

        private void RPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics panelBatch = e.Graphics;

            if (!LevelData.established)
                return;

            //prep rendering scale, etc.
            CalculateRenderTileSize();

            panelBatch.DrawRectangle(Pens.LightGray, new Rectangle(offsetX, offsetY, LevelData.w * rTileW, LevelData.h * rTileH));

            for (int i = 0; i < LevelData.w; i++)
            {
                for (int j = 0; j < LevelData.h; j++)
                {
                    int paintId = LevelData.map[i, j];
                    Brush b = paintDict[TilePaint.nameDict[paintId]].brush;

                    panelBatch.FillRectangle(b, new Rectangle(offsetX + (i * rTileW), offsetY + (j * rTileH), rTileW, rTileH));
                }
            }
        }

        void CalculateRenderTileSize()
        {
            rTileW = 1;
            rTileH = 1;

            if (tileView)
            {
                rTileW = LevelData.tileW;
                rTileH = LevelData.tileH;
            }

            rTileW = (int)(rTileW * zoom);
            rTileH = (int)(rTileH * zoom);
        }
        #endregion

        #region Viewport Navigation & Interaction
        private void RPanel_MouseWheel(object sender, MouseEventArgs e)
        {
            zoom += 0.001f * e.Delta;

            if (zoom < 0)
                zoom = 0;

            zoom = Math.Round(zoom, 2);

            toolStripStatusLabelZoom.Text = "Zoom " + zoom.ToString() + "x";

            UpdateVisualization();
        }

        private void RPanel_MouseMove(object sender, MouseEventArgs e)
        {

            toolStripStatusLabelCursor.Text = "Cursor " + e.X.ToString() + "," + e.Y.ToString();

            if (LevelData.established)
            {
                CalculateRenderTileSize();
                if(rTileW != 0 && rTileH != 0)
                    toolStripStatusLabelCursor.Text += " (" + ((e.X - offsetX) / rTileW).ToString() + "," + ((e.Y - offsetY) / rTileH).ToString() + ")";
            }

            switch (e.Button)
            {
                default:
                    wasDraggingBefore = false;
                    break;

                case MouseButtons.Left:
                    if (!LevelData.established)
                        break;
                    CalculateRenderTileSize();

                    if (rTileW != 0 && rTileH != 0)
                    {
                        int canvasX = (e.X - offsetX) / rTileW;
                        int canvasY = (e.Y - offsetY) / rTileH;

                        if (paintList.SelectedIndex > -1)
                        {
                            SetPaint((string)paintList.SelectedItem, canvasX, canvasY);
                        }

                        UpdateVisualization();
                    }

                    break;

                case MouseButtons.Middle:
                    if (!wasDraggingBefore)
                    {
                        firstDragX = e.X;
                        firstDragY = e.Y;
                        firstOffsetX = offsetX;
                        firstOffsetY = offsetY;
                    }

                    offsetX = firstOffsetX + (e.X - firstDragX);
                    offsetY = firstOffsetY + (e.Y - firstDragY);

                    toolStripStatusLabelPan.Text = "Pan " + offsetX.ToString() + "," + offsetY.ToString();

                    UpdateVisualization();

                    wasDraggingBefore = true;
                    break;

            }
        }
        #endregion

        #region Paint Handling
        private void addPaintButton_Click(object sender, EventArgs e)
        {
            AddPaint(
                paintNameInput.Text,
                Convert.ToInt32(redInput.Text),
                Convert.ToInt32(greenInput.Text),
                Convert.ToInt32(blueInput.Text));
        }

        private void removePaintButton_Click(object sender, EventArgs e)
        {
            RemovePaint(paintNameInput.Text);
        }

        void AddPaint(string name, int r, int g, int b)
        {
            TilePaint newPaint = new TilePaint(name, r, g, b);
            if (paintDict.ContainsKey(name))
                paintDict[name] = newPaint;
            else
                paintDict.Add(name, newPaint);

            if(!paintList.Items.Contains(name))
                paintList.Items.Add(name);
        }
        void AddPaint(TilePaint newPaint)
        {
            string name = newPaint.name;

            if (paintDict.ContainsKey(name))
                paintDict[name] = newPaint;
            else
                paintDict.Add(name, newPaint);

            if (!paintList.Items.Contains(name))
                paintList.Items.Add(name);
        }

        void RemovePaint(string name)
        {
            if (paintDict.ContainsKey(name))
                paintDict.Remove(name);

            if (paintList.Items.Contains(name))
                paintList.Items.Remove(name);
        }

        void ClearPaint()
        {
            paintDict.Clear();
            paintList.Items.Clear();
            TilePaint.nameDict.Clear();
            TilePaint.paintCt = 0;
        }

        void LoadMbdToPaint(string contents)
        {
            ClearPaint();

            contents = contents.Replace("\r", "");
            string[] lines = contents.Split('\n');
            
            foreach(string l in lines)
            {
                if (l.StartsWith("#"))
                    continue;
                if (l == "")
                    continue;

                string[] commands = l.Split(' ');
                int id = Convert.ToInt32(commands[0]);
                string name = commands[1];
                int r = Convert.ToInt32(commands[2]);
                int g = Convert.ToInt32(commands[3]);
                int b = Convert.ToInt32(commands[4]);

                TilePaint newPaint = new TilePaint(name, r, g, b, id);
                AddPaint(newPaint);
            }
        }

        private void paintList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (paintList.SelectedIndex == -1)
                return;

            string selectedName = (string) paintList.Items[paintList.SelectedIndex];

            TilePaint selectedPaint = null;

            if (paintDict.ContainsKey(selectedName))
                selectedPaint = paintDict[selectedName];

            if (selectedPaint != null)
            {
                paintNameInput.Text = selectedPaint.name;
                redInput.Text = selectedPaint.color.R.ToString();
                greenInput.Text = selectedPaint.color.G.ToString();
                blueInput.Text = selectedPaint.color.B.ToString();
            }

        }

        void SetPaint(string name, int x, int y)
        {
            if (LevelData.PointIsSafe(x, y))
                LevelData.map[x, y] = paintDict[name].id;
        }


        #endregion

        private void toolStripStatusLabelZoom_DoubleClick(object sender, EventArgs e)
        {
            zoom = 1;
            toolStripStatusLabelZoom.Text = "Zoom 1x";
            UpdateVisualization();
        }

        private void toolStripStatusLabelPan_DoubleClick(object sender, EventArgs e)
        {
            offsetX = 0;
            offsetY = 0;
            toolStripStatusLabelPan.Text = "Pan 0,0";
            UpdateVisualization();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to clear the current level?", "Clear Level", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                LevelData.InitializeMap(LevelData.w, LevelData.h, LevelData.tileW, LevelData.tileH);
                UpdateVisualization();
            }
        }

        private void loadMBDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Title = "Load MBD File";
            openDialog.DefaultExt = "*.mbd";

            if (openDialog.ShowDialog() == DialogResult.OK)
                LoadMbdToPaint(File.ReadAllText(openDialog.FileName));
            else
                MessageBox.Show("Failed to load MBD", "Failed");
        }

        private void saveMBDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Title = "Save MBD File";
            //saveDialog.DefaultExt = "*.mbd";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {

                string fileContents = "#IsoCaves Map Brush Data\n#ID NAME R G B\n";

                foreach (int key in TilePaint.nameDict.Keys)
                {
                    int id = key;
                    string name = TilePaint.nameDict[key];
                    TilePaint paint = paintDict[name];
                    int r = paint.color.R;
                    int g = paint.color.G;
                    int b = paint.color.B;

                    string output = id.ToString() + " " + name + " " + r.ToString() + " " + g.ToString() + " " + b.ToString() + "\n";
                    fileContents += output;

                }

                File.WriteAllText(saveDialog.FileName, fileContents);
            }
            else
                MessageBox.Show("Failed to save MBD", "Failed");
        }

        private void toolStripStatusLabelTiles_Click(object sender, EventArgs e)
        {
            tileView = !tileView;

            if (tileView)
                toolStripStatusLabelTiles.Text = "View as even grid";
            else
                toolStripStatusLabelTiles.Text = "View as tiles";

            UpdateVisualization();

        }

        private void bakeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BakeForm bakeForm = new BakeForm(paintDict);
            bakeForm.Show();
        }

        private void setBrushButton_Click(object sender, EventArgs e)
        {
            brushSize = Convert.ToInt32(brushSizeInput.Text);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }
}
