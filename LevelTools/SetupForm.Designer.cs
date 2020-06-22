namespace LevelTools
{
    partial class SetupForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetupForm));
            this.loadButton = new System.Windows.Forms.Button();
            this.paramsGroup = new System.Windows.Forms.GroupBox();
            this.tileHInput = new System.Windows.Forms.TextBox();
            this.tileWInput = new System.Windows.Forms.TextBox();
            this.tileHLabel = new System.Windows.Forms.Label();
            this.tileWLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.heightInput = new System.Windows.Forms.TextBox();
            this.widthInput = new System.Windows.Forms.TextBox();
            this.heightLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.paramsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(12, 12);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(237, 37);
            this.loadButton.TabIndex = 0;
            this.loadButton.Text = "Load Level Data";
            this.loadButton.UseVisualStyleBackColor = true;
            // 
            // paramsGroup
            // 
            this.paramsGroup.Controls.Add(this.tileHInput);
            this.paramsGroup.Controls.Add(this.tileWInput);
            this.paramsGroup.Controls.Add(this.tileHLabel);
            this.paramsGroup.Controls.Add(this.tileWLabel);
            this.paramsGroup.Controls.Add(this.timeLabel);
            this.paramsGroup.Controls.Add(this.heightInput);
            this.paramsGroup.Controls.Add(this.widthInput);
            this.paramsGroup.Controls.Add(this.heightLabel);
            this.paramsGroup.Controls.Add(this.widthLabel);
            this.paramsGroup.Controls.Add(this.createButton);
            this.paramsGroup.Location = new System.Drawing.Point(12, 55);
            this.paramsGroup.Name = "paramsGroup";
            this.paramsGroup.Size = new System.Drawing.Size(237, 179);
            this.paramsGroup.TabIndex = 1;
            this.paramsGroup.TabStop = false;
            this.paramsGroup.Text = "New Level Paramaters";
            // 
            // tileHInput
            // 
            this.tileHInput.Location = new System.Drawing.Point(50, 96);
            this.tileHInput.Name = "tileHInput";
            this.tileHInput.Size = new System.Drawing.Size(129, 20);
            this.tileHInput.TabIndex = 11;
            this.tileHInput.Text = "9";
            this.tileHInput.TextChanged += new System.EventHandler(this.tileHInput_TextChanged);
            // 
            // tileWInput
            // 
            this.tileWInput.Location = new System.Drawing.Point(50, 70);
            this.tileWInput.Name = "tileWInput";
            this.tileWInput.Size = new System.Drawing.Size(129, 20);
            this.tileWInput.TabIndex = 10;
            this.tileWInput.Text = "18";
            this.tileWInput.TextChanged += new System.EventHandler(this.tileWInput_TextChanged);
            // 
            // tileHLabel
            // 
            this.tileHLabel.AutoSize = true;
            this.tileHLabel.Location = new System.Drawing.Point(6, 99);
            this.tileHLabel.Name = "tileHLabel";
            this.tileHLabel.Size = new System.Drawing.Size(38, 13);
            this.tileHLabel.TabIndex = 9;
            this.tileHLabel.Text = "Tile H:";
            // 
            // tileWLabel
            // 
            this.tileWLabel.AutoSize = true;
            this.tileWLabel.Location = new System.Drawing.Point(6, 73);
            this.tileWLabel.Name = "tileWLabel";
            this.tileWLabel.Size = new System.Drawing.Size(41, 13);
            this.tileWLabel.TabIndex = 8;
            this.tileWLabel.Text = "Tile W:";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(6, 119);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(94, 13);
            this.timeLabel.TabIndex = 7;
            this.timeLabel.Text = "Traversal Time: 0s";
            // 
            // heightInput
            // 
            this.heightInput.Location = new System.Drawing.Point(50, 44);
            this.heightInput.Name = "heightInput";
            this.heightInput.Size = new System.Drawing.Size(129, 20);
            this.heightInput.TabIndex = 6;
            this.heightInput.Text = "200";
            this.heightInput.TextChanged += new System.EventHandler(this.heightInput_TextChanged);
            // 
            // widthInput
            // 
            this.widthInput.Location = new System.Drawing.Point(50, 18);
            this.widthInput.Name = "widthInput";
            this.widthInput.Size = new System.Drawing.Size(129, 20);
            this.widthInput.TabIndex = 5;
            this.widthInput.Text = "200";
            this.widthInput.TextChanged += new System.EventHandler(this.widthInput_TextChanged);
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(6, 47);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(41, 13);
            this.heightLabel.TabIndex = 4;
            this.heightLabel.Text = "Height:";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(6, 21);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(38, 13);
            this.widthLabel.TabIndex = 3;
            this.widthLabel.Text = "Width:";
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(6, 135);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(225, 37);
            this.createButton.TabIndex = 2;
            this.createButton.Text = "Create Level";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // SetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 245);
            this.Controls.Add(this.paramsGroup);
            this.Controls.Add(this.loadButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SetupForm";
            this.Text = "Setup";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SetupForm_FormClosing);
            this.Load += new System.EventHandler(this.SetupForm_Load);
            this.paramsGroup.ResumeLayout(false);
            this.paramsGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.GroupBox paramsGroup;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.TextBox heightInput;
        private System.Windows.Forms.TextBox widthInput;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.TextBox tileHInput;
        private System.Windows.Forms.TextBox tileWInput;
        private System.Windows.Forms.Label tileHLabel;
        private System.Windows.Forms.Label tileWLabel;
    }
}