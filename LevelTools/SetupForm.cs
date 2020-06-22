using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LevelTools
{
    public partial class SetupForm : Form
    {
        public SetupForm(BuilderForm parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        BuilderForm parent;

        int inputW = 0;
        int inputH = 0;
        int tileW = 0;
        int tileH = 0;

        private void SetupForm_Load(object sender, EventArgs e)
        {
            TopMost = true;

            //set initial values based on designer
            inputW = Convert.ToInt32(widthInput.Text);
            inputH = Convert.ToInt32(heightInput.Text);
            tileW = Convert.ToInt32(tileWInput.Text);
            tileH = Convert.ToInt32(tileHInput.Text);

            CalculateTraversalTime();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            LevelData.InitializeMap(inputW, inputH, tileW, tileH);
            Close();
        }

        private void widthInput_TextChanged(object sender, EventArgs e)
        {
            int inputVal = 0;

            if (!Int32.TryParse(((TextBox)sender).Text, out inputVal))
                inputVal = 0;

            inputW = inputVal;
            CalculateTraversalTime();
        }

        private void heightInput_TextChanged(object sender, EventArgs e)
        {
            int inputVal = 0;

            if (!Int32.TryParse(((TextBox)sender).Text, out inputVal))
                inputVal = 0;

            inputH = inputVal;
            CalculateTraversalTime();
        }

        private void tileWInput_TextChanged(object sender, EventArgs e)
        {
            int inputVal = 0;

            if (!Int32.TryParse(((TextBox)sender).Text, out inputVal))
                inputVal = 0;

            tileW = inputVal;
            CalculateTraversalTime();
        }

        private void tileHInput_TextChanged(object sender, EventArgs e)
        {
            int inputVal = 0;

            if (!Int32.TryParse(((TextBox)sender).Text, out inputVal))
                inputVal = 0;

            tileH = inputVal;
            CalculateTraversalTime();
        }

        void CalculateTraversalTime()
        {
            int pixPerSec = 60;

            int effW = inputW * tileW;
            int effH = inputH * tileH;

            double hyp = Math.Sqrt(Math.Pow(effW, 2) + Math.Pow(effH, 2));

            int time = (int)(hyp  / pixPerSec);
            timeLabel.Text = "Traversal Time: " + time.ToString() + "s";
        }

        private void SetupForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Enabled = true;
        }
    }
}
