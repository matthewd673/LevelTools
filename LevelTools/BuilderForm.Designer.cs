namespace LevelTools
{
    partial class BuilderForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuilderForm));
            this.borderButton = new System.Windows.Forms.Button();
            this.borderInput = new System.Windows.Forms.TextBox();
            this.refStepsInput = new System.Windows.Forms.TextBox();
            this.noiseDenomInput = new System.Windows.Forms.TextBox();
            this.refineButton = new System.Windows.Forms.Button();
            this.noiseButton = new System.Windows.Forms.Button();
            this.paintContainer = new System.Windows.Forms.Panel();
            this.paintList = new System.Windows.Forms.ListBox();
            this.paintEditorContainer = new System.Windows.Forms.Panel();
            this.removePaintButton = new System.Windows.Forms.Button();
            this.addPaintButton = new System.Windows.Forms.Button();
            this.blueInput = new System.Windows.Forms.TextBox();
            this.greenInput = new System.Windows.Forms.TextBox();
            this.redInput = new System.Windows.Forms.TextBox();
            this.paintNameInput = new System.Windows.Forms.TextBox();
            this.createContainer = new System.Windows.Forms.Panel();
            this.renderPanelContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierContainer = new System.Windows.Forms.Panel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadMBDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMBDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelZoom = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelPan = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelCursor = new System.Windows.Forms.ToolStripStatusLabel();
            this.caveGenToolsContainer = new System.Windows.Forms.GroupBox();
            this.noiseNomInput = new System.Windows.Forms.TextBox();
            this.noiseDivLabel = new System.Windows.Forms.Label();
            this.refineStepsLabel = new System.Windows.Forms.Label();
            this.fillToolsContainer = new System.Windows.Forms.GroupBox();
            this.borderWidthLabel = new System.Windows.Forms.Label();
            this.brushSizeInput = new System.Windows.Forms.TextBox();
            this.bakeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStatusLabelTiles = new System.Windows.Forms.ToolStripStatusLabel();
            this.brushSizeLabel = new System.Windows.Forms.Label();
            this.setBrushButton = new System.Windows.Forms.Button();
            this.paintContainer.SuspendLayout();
            this.paintEditorContainer.SuspendLayout();
            this.renderPanelContext.SuspendLayout();
            this.modifierContainer.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.caveGenToolsContainer.SuspendLayout();
            this.fillToolsContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // borderButton
            // 
            this.borderButton.Location = new System.Drawing.Point(99, 44);
            this.borderButton.Name = "borderButton";
            this.borderButton.Size = new System.Drawing.Size(104, 20);
            this.borderButton.TabIndex = 14;
            this.borderButton.Text = "Add Border";
            this.borderButton.UseVisualStyleBackColor = true;
            this.borderButton.Click += new System.EventHandler(this.borderButton_Click);
            // 
            // borderInput
            // 
            this.borderInput.Location = new System.Drawing.Point(6, 45);
            this.borderInput.Name = "borderInput";
            this.borderInput.Size = new System.Drawing.Size(34, 20);
            this.borderInput.TabIndex = 13;
            this.borderInput.Text = "1";
            // 
            // refStepsInput
            // 
            this.refStepsInput.Location = new System.Drawing.Point(6, 45);
            this.refStepsInput.Name = "refStepsInput";
            this.refStepsInput.Size = new System.Drawing.Size(31, 20);
            this.refStepsInput.TabIndex = 3;
            this.refStepsInput.Text = "5";
            // 
            // noiseDenomInput
            // 
            this.noiseDenomInput.Location = new System.Drawing.Point(61, 19);
            this.noiseDenomInput.Name = "noiseDenomInput";
            this.noiseDenomInput.Size = new System.Drawing.Size(31, 20);
            this.noiseDenomInput.TabIndex = 2;
            this.noiseDenomInput.Text = "2";
            // 
            // refineButton
            // 
            this.refineButton.Location = new System.Drawing.Point(99, 44);
            this.refineButton.Name = "refineButton";
            this.refineButton.Size = new System.Drawing.Size(104, 20);
            this.refineButton.TabIndex = 1;
            this.refineButton.Text = "Refine";
            this.refineButton.UseVisualStyleBackColor = true;
            this.refineButton.Click += new System.EventHandler(this.refineButton_Click);
            // 
            // noiseButton
            // 
            this.noiseButton.Location = new System.Drawing.Point(99, 18);
            this.noiseButton.Name = "noiseButton";
            this.noiseButton.Size = new System.Drawing.Size(104, 20);
            this.noiseButton.TabIndex = 0;
            this.noiseButton.Text = "Add % Noise";
            this.noiseButton.UseVisualStyleBackColor = true;
            this.noiseButton.Click += new System.EventHandler(this.noiseButton_Click);
            // 
            // paintContainer
            // 
            this.paintContainer.Controls.Add(this.paintList);
            this.paintContainer.Controls.Add(this.paintEditorContainer);
            this.paintContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.paintContainer.Location = new System.Drawing.Point(0, 24);
            this.paintContainer.Name = "paintContainer";
            this.paintContainer.Size = new System.Drawing.Size(171, 513);
            this.paintContainer.TabIndex = 1;
            // 
            // paintList
            // 
            this.paintList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paintList.FormattingEnabled = true;
            this.paintList.Location = new System.Drawing.Point(0, 88);
            this.paintList.Name = "paintList";
            this.paintList.Size = new System.Drawing.Size(171, 425);
            this.paintList.TabIndex = 1;
            this.paintList.SelectedIndexChanged += new System.EventHandler(this.paintList_SelectedIndexChanged);
            // 
            // paintEditorContainer
            // 
            this.paintEditorContainer.Controls.Add(this.removePaintButton);
            this.paintEditorContainer.Controls.Add(this.addPaintButton);
            this.paintEditorContainer.Controls.Add(this.blueInput);
            this.paintEditorContainer.Controls.Add(this.greenInput);
            this.paintEditorContainer.Controls.Add(this.redInput);
            this.paintEditorContainer.Controls.Add(this.paintNameInput);
            this.paintEditorContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.paintEditorContainer.Location = new System.Drawing.Point(0, 0);
            this.paintEditorContainer.Name = "paintEditorContainer";
            this.paintEditorContainer.Size = new System.Drawing.Size(171, 88);
            this.paintEditorContainer.TabIndex = 0;
            // 
            // removePaintButton
            // 
            this.removePaintButton.Location = new System.Drawing.Point(43, 58);
            this.removePaintButton.Name = "removePaintButton";
            this.removePaintButton.Size = new System.Drawing.Size(25, 23);
            this.removePaintButton.TabIndex = 5;
            this.removePaintButton.Text = "-";
            this.removePaintButton.UseVisualStyleBackColor = true;
            this.removePaintButton.Click += new System.EventHandler(this.removePaintButton_Click);
            // 
            // addPaintButton
            // 
            this.addPaintButton.Location = new System.Drawing.Point(12, 58);
            this.addPaintButton.Name = "addPaintButton";
            this.addPaintButton.Size = new System.Drawing.Size(25, 23);
            this.addPaintButton.TabIndex = 4;
            this.addPaintButton.Text = "+";
            this.addPaintButton.UseVisualStyleBackColor = true;
            this.addPaintButton.Click += new System.EventHandler(this.addPaintButton_Click);
            // 
            // blueInput
            // 
            this.blueInput.Location = new System.Drawing.Point(108, 32);
            this.blueInput.Name = "blueInput";
            this.blueInput.Size = new System.Drawing.Size(42, 20);
            this.blueInput.TabIndex = 3;
            this.blueInput.Text = "0";
            // 
            // greenInput
            // 
            this.greenInput.Location = new System.Drawing.Point(60, 32);
            this.greenInput.Name = "greenInput";
            this.greenInput.Size = new System.Drawing.Size(42, 20);
            this.greenInput.TabIndex = 2;
            this.greenInput.Text = "0";
            // 
            // redInput
            // 
            this.redInput.Location = new System.Drawing.Point(12, 32);
            this.redInput.Name = "redInput";
            this.redInput.Size = new System.Drawing.Size(42, 20);
            this.redInput.TabIndex = 1;
            this.redInput.Text = "255";
            // 
            // paintNameInput
            // 
            this.paintNameInput.Location = new System.Drawing.Point(12, 6);
            this.paintNameInput.Name = "paintNameInput";
            this.paintNameInput.Size = new System.Drawing.Size(138, 20);
            this.paintNameInput.TabIndex = 0;
            this.paintNameInput.Text = "NEW_PAINT";
            // 
            // createContainer
            // 
            this.createContainer.BackColor = System.Drawing.Color.White;
            this.createContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.createContainer.ContextMenuStrip = this.renderPanelContext;
            this.createContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createContainer.Location = new System.Drawing.Point(171, 24);
            this.createContainer.Name = "createContainer";
            this.createContainer.Size = new System.Drawing.Size(797, 513);
            this.createContainer.TabIndex = 2;
            // 
            // renderPanelContext
            // 
            this.renderPanelContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToClipboardToolStripMenuItem});
            this.renderPanelContext.Name = "renderPanelContext";
            this.renderPanelContext.Size = new System.Drawing.Size(170, 26);
            // 
            // copyToClipboardToolStripMenuItem
            // 
            this.copyToClipboardToolStripMenuItem.Name = "copyToClipboardToolStripMenuItem";
            this.copyToClipboardToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.copyToClipboardToolStripMenuItem.Text = "Copy to clipboard";
            this.copyToClipboardToolStripMenuItem.Click += new System.EventHandler(this.copyToClipboardToolStripMenuItem_Click);
            // 
            // modifierContainer
            // 
            this.modifierContainer.Controls.Add(this.fillToolsContainer);
            this.modifierContainer.Controls.Add(this.caveGenToolsContainer);
            this.modifierContainer.Dock = System.Windows.Forms.DockStyle.Right;
            this.modifierContainer.Location = new System.Drawing.Point(968, 24);
            this.modifierContainer.Name = "modifierContainer";
            this.modifierContainer.Size = new System.Drawing.Size(216, 513);
            this.modifierContainer.TabIndex = 3;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.projectToolStripMenuItem,
            this.bakeToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip.TabIndex = 4;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.loadMBDToolStripMenuItem,
            this.saveMBDToolStripMenuItem});
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.projectToolStripMenuItem.Text = "Project";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // loadMBDToolStripMenuItem
            // 
            this.loadMBDToolStripMenuItem.Name = "loadMBDToolStripMenuItem";
            this.loadMBDToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.loadMBDToolStripMenuItem.Text = "Load .MBD";
            this.loadMBDToolStripMenuItem.Click += new System.EventHandler(this.loadMBDToolStripMenuItem_Click);
            // 
            // saveMBDToolStripMenuItem
            // 
            this.saveMBDToolStripMenuItem.Name = "saveMBDToolStripMenuItem";
            this.saveMBDToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.saveMBDToolStripMenuItem.Text = "Save .MBD";
            this.saveMBDToolStripMenuItem.Click += new System.EventHandler(this.saveMBDToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelTiles,
            this.toolStripStatusLabelZoom,
            this.toolStripStatusLabelPan,
            this.toolStripStatusLabelCursor});
            this.statusStrip.Location = new System.Drawing.Point(0, 537);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1184, 24);
            this.statusStrip.TabIndex = 5;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabelZoom
            // 
            this.toolStripStatusLabelZoom.DoubleClickEnabled = true;
            this.toolStripStatusLabelZoom.Name = "toolStripStatusLabelZoom";
            this.toolStripStatusLabelZoom.Size = new System.Drawing.Size(54, 19);
            this.toolStripStatusLabelZoom.Text = "Zoom 1x";
            this.toolStripStatusLabelZoom.ToolTipText = "The current zoom level. Double click to reset.";
            this.toolStripStatusLabelZoom.DoubleClick += new System.EventHandler(this.toolStripStatusLabelZoom_DoubleClick);
            // 
            // toolStripStatusLabelPan
            // 
            this.toolStripStatusLabelPan.DoubleClickEnabled = true;
            this.toolStripStatusLabelPan.Name = "toolStripStatusLabelPan";
            this.toolStripStatusLabelPan.Size = new System.Drawing.Size(45, 19);
            this.toolStripStatusLabelPan.Text = "Pan 0,0";
            this.toolStripStatusLabelPan.ToolTipText = "The current pan. Double click to reset.";
            this.toolStripStatusLabelPan.DoubleClick += new System.EventHandler(this.toolStripStatusLabelPan_DoubleClick);
            // 
            // toolStripStatusLabelCursor
            // 
            this.toolStripStatusLabelCursor.Name = "toolStripStatusLabelCursor";
            this.toolStripStatusLabelCursor.Size = new System.Drawing.Size(89, 19);
            this.toolStripStatusLabelCursor.Text = "Cursor 0,0 (0, 0)";
            this.toolStripStatusLabelCursor.ToolTipText = "The current cursor position (in pixels and tiles) in the viewport.";
            // 
            // caveGenToolsContainer
            // 
            this.caveGenToolsContainer.Controls.Add(this.refineStepsLabel);
            this.caveGenToolsContainer.Controls.Add(this.noiseDivLabel);
            this.caveGenToolsContainer.Controls.Add(this.noiseNomInput);
            this.caveGenToolsContainer.Controls.Add(this.noiseButton);
            this.caveGenToolsContainer.Controls.Add(this.noiseDenomInput);
            this.caveGenToolsContainer.Controls.Add(this.refineButton);
            this.caveGenToolsContainer.Controls.Add(this.refStepsInput);
            this.caveGenToolsContainer.Location = new System.Drawing.Point(3, 122);
            this.caveGenToolsContainer.Name = "caveGenToolsContainer";
            this.caveGenToolsContainer.Size = new System.Drawing.Size(209, 174);
            this.caveGenToolsContainer.TabIndex = 3;
            this.caveGenToolsContainer.TabStop = false;
            this.caveGenToolsContainer.Text = "Cave Generator";
            // 
            // noiseNomInput
            // 
            this.noiseNomInput.Location = new System.Drawing.Point(6, 19);
            this.noiseNomInput.Name = "noiseNomInput";
            this.noiseNomInput.Size = new System.Drawing.Size(31, 20);
            this.noiseNomInput.TabIndex = 3;
            this.noiseNomInput.Text = "1";
            // 
            // noiseDivLabel
            // 
            this.noiseDivLabel.AutoSize = true;
            this.noiseDivLabel.Location = new System.Drawing.Point(43, 22);
            this.noiseDivLabel.Name = "noiseDivLabel";
            this.noiseDivLabel.Size = new System.Drawing.Size(12, 13);
            this.noiseDivLabel.TabIndex = 4;
            this.noiseDivLabel.Text = "/";
            // 
            // refineStepsLabel
            // 
            this.refineStepsLabel.AutoSize = true;
            this.refineStepsLabel.Location = new System.Drawing.Point(43, 48);
            this.refineStepsLabel.Name = "refineStepsLabel";
            this.refineStepsLabel.Size = new System.Drawing.Size(32, 13);
            this.refineStepsLabel.TabIndex = 5;
            this.refineStepsLabel.Text = "steps";
            // 
            // fillToolsContainer
            // 
            this.fillToolsContainer.Controls.Add(this.setBrushButton);
            this.fillToolsContainer.Controls.Add(this.brushSizeLabel);
            this.fillToolsContainer.Controls.Add(this.brushSizeInput);
            this.fillToolsContainer.Controls.Add(this.borderWidthLabel);
            this.fillToolsContainer.Controls.Add(this.borderButton);
            this.fillToolsContainer.Controls.Add(this.borderInput);
            this.fillToolsContainer.Location = new System.Drawing.Point(3, 3);
            this.fillToolsContainer.Name = "fillToolsContainer";
            this.fillToolsContainer.Size = new System.Drawing.Size(209, 113);
            this.fillToolsContainer.TabIndex = 4;
            this.fillToolsContainer.TabStop = false;
            this.fillToolsContainer.Text = "Fill Tools";
            // 
            // borderWidthLabel
            // 
            this.borderWidthLabel.AutoSize = true;
            this.borderWidthLabel.Location = new System.Drawing.Point(46, 48);
            this.borderWidthLabel.Name = "borderWidthLabel";
            this.borderWidthLabel.Size = new System.Drawing.Size(31, 13);
            this.borderWidthLabel.TabIndex = 6;
            this.borderWidthLabel.Text = "tile(s)";
            // 
            // brushSizeInput
            // 
            this.brushSizeInput.Location = new System.Drawing.Point(6, 19);
            this.brushSizeInput.Name = "brushSizeInput";
            this.brushSizeInput.Size = new System.Drawing.Size(34, 20);
            this.brushSizeInput.TabIndex = 15;
            this.brushSizeInput.Text = "1";
            // 
            // bakeToolStripMenuItem
            // 
            this.bakeToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.bakeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bakeToolStripMenuItem.Name = "bakeToolStripMenuItem";
            this.bakeToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.bakeToolStripMenuItem.Text = "Bake";
            this.bakeToolStripMenuItem.Click += new System.EventHandler(this.bakeToolStripMenuItem_Click);
            // 
            // toolStripStatusLabelTiles
            // 
            this.toolStripStatusLabelTiles.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabelTiles.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabelTiles.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabelTiles.Name = "toolStripStatusLabelTiles";
            this.toolStripStatusLabelTiles.Size = new System.Drawing.Size(79, 19);
            this.toolStripStatusLabelTiles.Text = "View as tiles";
            this.toolStripStatusLabelTiles.ToolTipText = "Click to change the current view type.";
            this.toolStripStatusLabelTiles.Click += new System.EventHandler(this.toolStripStatusLabelTiles_Click);
            // 
            // brushSizeLabel
            // 
            this.brushSizeLabel.AutoSize = true;
            this.brushSizeLabel.Location = new System.Drawing.Point(46, 22);
            this.brushSizeLabel.Name = "brushSizeLabel";
            this.brushSizeLabel.Size = new System.Drawing.Size(31, 13);
            this.brushSizeLabel.TabIndex = 16;
            this.brushSizeLabel.Text = "tile(s)";
            // 
            // setBrushButton
            // 
            this.setBrushButton.Location = new System.Drawing.Point(99, 18);
            this.setBrushButton.Name = "setBrushButton";
            this.setBrushButton.Size = new System.Drawing.Size(104, 20);
            this.setBrushButton.TabIndex = 17;
            this.setBrushButton.Text = "Set Brush";
            this.setBrushButton.UseVisualStyleBackColor = true;
            this.setBrushButton.Click += new System.EventHandler(this.setBrushButton_Click);
            // 
            // BuilderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.createContainer);
            this.Controls.Add(this.modifierContainer);
            this.Controls.Add(this.paintContainer);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "BuilderForm";
            this.Text = "Level Tools";
            this.Load += new System.EventHandler(this.BuilderForm_Load);
            this.paintContainer.ResumeLayout(false);
            this.paintEditorContainer.ResumeLayout(false);
            this.paintEditorContainer.PerformLayout();
            this.renderPanelContext.ResumeLayout(false);
            this.modifierContainer.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.caveGenToolsContainer.ResumeLayout(false);
            this.caveGenToolsContainer.PerformLayout();
            this.fillToolsContainer.ResumeLayout(false);
            this.fillToolsContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button refineButton;
        private System.Windows.Forms.Button noiseButton;
        private System.Windows.Forms.Panel paintContainer;
        private System.Windows.Forms.Panel createContainer;
        private System.Windows.Forms.TextBox refStepsInput;
        private System.Windows.Forms.TextBox noiseDenomInput;
        private System.Windows.Forms.ContextMenuStrip renderPanelContext;
        private System.Windows.Forms.ToolStripMenuItem copyToClipboardToolStripMenuItem;
        private System.Windows.Forms.Panel paintEditorContainer;
        private System.Windows.Forms.TextBox paintNameInput;
        private System.Windows.Forms.TextBox blueInput;
        private System.Windows.Forms.TextBox greenInput;
        private System.Windows.Forms.TextBox redInput;
        private System.Windows.Forms.Button removePaintButton;
        private System.Windows.Forms.Button addPaintButton;
        private System.Windows.Forms.ListBox paintList;
        private System.Windows.Forms.Button borderButton;
        private System.Windows.Forms.TextBox borderInput;
        private System.Windows.Forms.Panel modifierContainer;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelZoom;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelPan;
        private System.Windows.Forms.ToolStripMenuItem loadMBDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveMBDToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelCursor;
        private System.Windows.Forms.GroupBox caveGenToolsContainer;
        private System.Windows.Forms.TextBox noiseNomInput;
        private System.Windows.Forms.Label noiseDivLabel;
        private System.Windows.Forms.Label refineStepsLabel;
        private System.Windows.Forms.GroupBox fillToolsContainer;
        private System.Windows.Forms.Label borderWidthLabel;
        private System.Windows.Forms.TextBox brushSizeInput;
        private System.Windows.Forms.ToolStripMenuItem bakeToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTiles;
        private System.Windows.Forms.Button setBrushButton;
        private System.Windows.Forms.Label brushSizeLabel;
    }
}

