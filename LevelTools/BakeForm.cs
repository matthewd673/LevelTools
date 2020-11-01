using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LevelTools
{
    public partial class BakeForm : Form
    {
        public BakeForm(Dictionary<string, TilePaint> localPaintDict)
        {
            this.localPaintDict = localPaintDict;
            InitializeComponent();
        }

        Dictionary<string, TilePaint> localPaintDict = new Dictionary<string, TilePaint>();
        Dictionary<string, TilePaint> globalPaintDict = new Dictionary<string, TilePaint>();

        private void BakeForm_Load(object sender, EventArgs e)
        {
            foreach(string k in localPaintDict.Keys)
            {
                localPaintList.Items.Add(k.ToString() + " (" + localPaintDict[k].id + ")");
            }
        }

        private void bakeButton_Click(object sender, EventArgs e)
        {
            string cavdatOutput = CavdatHelper.BakeCavdatFromLevelData("output.cavdat", localPaintDict, "CAVERNS");
            string basicOutput = CavdatHelper.BakeBasicFromLevelData("output.txt", localPaintDict);
            outputViewer.Text = "Basic preview (see output files for full):" + Environment.NewLine + basicOutput;
        }
    }
}
