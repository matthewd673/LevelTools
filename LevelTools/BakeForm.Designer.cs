namespace LevelTools
{
    partial class BakeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BakeForm));
            this.localPaintList = new System.Windows.Forms.ListBox();
            this.localListLabel = new System.Windows.Forms.Label();
            this.masterListLabel = new System.Windows.Forms.Label();
            this.masterPaintList = new System.Windows.Forms.ListBox();
            this.loadGlobalListButton = new System.Windows.Forms.Button();
            this.bakeButton = new System.Windows.Forms.Button();
            this.outputViewer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // localPaintList
            // 
            this.localPaintList.FormattingEnabled = true;
            this.localPaintList.Location = new System.Drawing.Point(12, 32);
            this.localPaintList.Name = "localPaintList";
            this.localPaintList.Size = new System.Drawing.Size(152, 212);
            this.localPaintList.TabIndex = 0;
            // 
            // localListLabel
            // 
            this.localListLabel.AutoSize = true;
            this.localListLabel.Location = new System.Drawing.Point(12, 9);
            this.localListLabel.Name = "localListLabel";
            this.localListLabel.Size = new System.Drawing.Size(108, 13);
            this.localListLabel.TabIndex = 1;
            this.localListLabel.Text = "Project Paint Settings";
            // 
            // masterListLabel
            // 
            this.masterListLabel.AutoSize = true;
            this.masterListLabel.Location = new System.Drawing.Point(187, 9);
            this.masterListLabel.Name = "masterListLabel";
            this.masterListLabel.Size = new System.Drawing.Size(105, 13);
            this.masterListLabel.TabIndex = 3;
            this.masterListLabel.Text = "Global Paint Settings";
            // 
            // masterPaintList
            // 
            this.masterPaintList.FormattingEnabled = true;
            this.masterPaintList.Location = new System.Drawing.Point(190, 32);
            this.masterPaintList.Name = "masterPaintList";
            this.masterPaintList.Size = new System.Drawing.Size(152, 212);
            this.masterPaintList.TabIndex = 2;
            // 
            // loadGlobalListButton
            // 
            this.loadGlobalListButton.Location = new System.Drawing.Point(298, 5);
            this.loadGlobalListButton.Name = "loadGlobalListButton";
            this.loadGlobalListButton.Size = new System.Drawing.Size(29, 21);
            this.loadGlobalListButton.TabIndex = 4;
            this.loadGlobalListButton.Text = "...";
            this.loadGlobalListButton.UseVisualStyleBackColor = true;
            // 
            // bakeButton
            // 
            this.bakeButton.Location = new System.Drawing.Point(125, 250);
            this.bakeButton.Name = "bakeButton";
            this.bakeButton.Size = new System.Drawing.Size(108, 23);
            this.bakeButton.TabIndex = 5;
            this.bakeButton.Text = "Bake";
            this.bakeButton.UseVisualStyleBackColor = true;
            this.bakeButton.Click += new System.EventHandler(this.bakeButton_Click);
            // 
            // outputViewer
            // 
            this.outputViewer.Enabled = false;
            this.outputViewer.Location = new System.Drawing.Point(15, 279);
            this.outputViewer.Multiline = true;
            this.outputViewer.Name = "outputViewer";
            this.outputViewer.Size = new System.Drawing.Size(332, 276);
            this.outputViewer.TabIndex = 6;
            // 
            // BakeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 566);
            this.Controls.Add(this.outputViewer);
            this.Controls.Add(this.bakeButton);
            this.Controls.Add(this.loadGlobalListButton);
            this.Controls.Add(this.masterListLabel);
            this.Controls.Add(this.masterPaintList);
            this.Controls.Add(this.localListLabel);
            this.Controls.Add(this.localPaintList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BakeForm";
            this.Text = "Baker";
            this.Load += new System.EventHandler(this.BakeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox localPaintList;
        private System.Windows.Forms.Label localListLabel;
        private System.Windows.Forms.Label masterListLabel;
        private System.Windows.Forms.ListBox masterPaintList;
        private System.Windows.Forms.Button loadGlobalListButton;
        private System.Windows.Forms.Button bakeButton;
        private System.Windows.Forms.TextBox outputViewer;
    }
}