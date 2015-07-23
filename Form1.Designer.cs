﻿namespace YATA {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.FileDropDown = new System.Windows.Forms.ToolStripDropDownButton();
            this.newFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.openFile = new System.Windows.Forms.ToolStripMenuItem();
            this.loadBgmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsFile = new System.Windows.Forms.ToolStripMenuItem();
            this.generatePreviewForCHMMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.prefToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.EditDropDown = new System.Windows.Forms.ToolStripDropDownButton();
            this.importImage = new System.Windows.Forms.ToolStripMenuItem();
            this.saveImage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.importCWAVButton = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCWAVButton = new System.Windows.Forms.ToolStripMenuItem();
            this.editCWAVsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cWAVsWavToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cWAVWAVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wAVsCWAVsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSettings = new System.Windows.Forms.ToolStripButton();
            this.SimToolStrip = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.Debug_menu = new System.Windows.Forms.ToolStripDropDownButton();
            this.printColorDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printColorOffsetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.thoseFunctionsAreOnlyForTestingDoesntAffectTheThemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusLabel = new System.Windows.Forms.ToolStripLabel();
            this.imgListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileLZ = new System.Windows.Forms.OpenFileDialog();
            this.saveTheme = new System.Windows.Forms.SaveFileDialog();
            this.savePng = new System.Windows.Forms.SaveFileDialog();
            this.openNewImg = new System.Windows.Forms.OpenFileDialog();
            this.saveCWAVDialog = new System.Windows.Forms.SaveFileDialog();
            this.openCWAVDialog = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Player = new AxWMPLib.AxWindowsMediaPlayer();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileDropDown,
            this.EditDropDown,
            this.toolStripSettings,
            this.SimToolStrip,
            this.toolStripSeparator6,
            this.toolStripButton1,
            this.toolStripSeparator7,
            this.Debug_menu,
            this.StatusLabel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(658, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // FileDropDown
            // 
            this.FileDropDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.FileDropDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFile,
            this.toolStripSeparator1,
            this.openFile,
            this.loadBgmToolStripMenuItem,
            this.saveFile,
            this.saveAsFile,
            this.generatePreviewForCHMMToolStripMenuItem,
            this.toolStripSeparator4,
            this.prefToolStrip});
            this.FileDropDown.Image = ((System.Drawing.Image)(resources.GetObject("FileDropDown.Image")));
            this.FileDropDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FileDropDown.Name = "FileDropDown";
            this.FileDropDown.Size = new System.Drawing.Size(38, 22);
            this.FileDropDown.Text = "File";
            this.FileDropDown.ToolTipText = "File";
            // 
            // newFile
            // 
            this.newFile.Name = "newFile";
            this.newFile.Size = new System.Drawing.Size(189, 22);
            this.newFile.Text = "New";
            this.newFile.Click += new System.EventHandler(this.newFile_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(186, 6);
            // 
            // openFile
            // 
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(189, 22);
            this.openFile.Text = "Open";
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // loadBgmToolStripMenuItem
            // 
            this.loadBgmToolStripMenuItem.Name = "loadBgmToolStripMenuItem";
            this.loadBgmToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.loadBgmToolStripMenuItem.Text = "Load bgm";
            this.loadBgmToolStripMenuItem.Click += new System.EventHandler(this.loadBgmToolStripMenuItem_Click);
            // 
            // saveFile
            // 
            this.saveFile.Enabled = false;
            this.saveFile.Name = "saveFile";
            this.saveFile.Size = new System.Drawing.Size(189, 22);
            this.saveFile.Text = "Save";
            this.saveFile.Click += new System.EventHandler(this.saveFile_Click);
            // 
            // saveAsFile
            // 
            this.saveAsFile.Enabled = false;
            this.saveAsFile.Name = "saveAsFile";
            this.saveAsFile.Size = new System.Drawing.Size(189, 22);
            this.saveAsFile.Text = "Save As...";
            this.saveAsFile.Click += new System.EventHandler(this.saveAsFile_Click);
            // 
            // generatePreviewForCHMMToolStripMenuItem
            // 
            this.generatePreviewForCHMMToolStripMenuItem.Enabled = false;
            this.generatePreviewForCHMMToolStripMenuItem.Name = "generatePreviewForCHMMToolStripMenuItem";
            this.generatePreviewForCHMMToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.generatePreviewForCHMMToolStripMenuItem.Text = "Generate png preview";
            this.generatePreviewForCHMMToolStripMenuItem.Click += new System.EventHandler(this.generatePreviewForCHMMToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(186, 6);
            // 
            // prefToolStrip
            // 
            this.prefToolStrip.Name = "prefToolStrip";
            this.prefToolStrip.Size = new System.Drawing.Size(189, 22);
            this.prefToolStrip.Text = "Preferences";
            this.prefToolStrip.Click += new System.EventHandler(this.prefToolStrip_Click);
            // 
            // EditDropDown
            // 
            this.EditDropDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.EditDropDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importImage,
            this.saveImage,
            this.toolStripSeparator2,
            this.importCWAVButton,
            this.saveCWAVButton,
            this.editCWAVsToolStripMenuItem,
            this.toolStripSeparator3,
            this.cWAVsWavToolStripMenuItem,
            this.cWAVWAVToolStripMenuItem,
            this.wAVsCWAVsToolStripMenuItem,
            this.toolStripSeparator5});
            this.EditDropDown.Image = ((System.Drawing.Image)(resources.GetObject("EditDropDown.Image")));
            this.EditDropDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditDropDown.Name = "EditDropDown";
            this.EditDropDown.Size = new System.Drawing.Size(40, 22);
            this.EditDropDown.Text = "Edit";
            // 
            // importImage
            // 
            this.importImage.Enabled = false;
            this.importImage.Name = "importImage";
            this.importImage.Size = new System.Drawing.Size(188, 22);
            this.importImage.Text = "Import Image";
            this.importImage.Click += new System.EventHandler(this.importToolstrip_Click);
            // 
            // saveImage
            // 
            this.saveImage.Enabled = false;
            this.saveImage.Name = "saveImage";
            this.saveImage.Size = new System.Drawing.Size(188, 22);
            this.saveImage.Text = "Save Image";
            this.saveImage.Click += new System.EventHandler(this.saveImage_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(185, 6);
            // 
            // importCWAVButton
            // 
            this.importCWAVButton.Enabled = false;
            this.importCWAVButton.Name = "importCWAVButton";
            this.importCWAVButton.Size = new System.Drawing.Size(188, 22);
            this.importCWAVButton.Text = "Import CWAVs chunk";
            this.importCWAVButton.Click += new System.EventHandler(this.importCWAVButton_Click);
            // 
            // saveCWAVButton
            // 
            this.saveCWAVButton.Enabled = false;
            this.saveCWAVButton.Name = "saveCWAVButton";
            this.saveCWAVButton.Size = new System.Drawing.Size(188, 22);
            this.saveCWAVButton.Text = "Export CWAVs chunk";
            this.saveCWAVButton.Click += new System.EventHandler(this.saveCWAVButton_Click);
            // 
            // editCWAVsToolStripMenuItem
            // 
            this.editCWAVsToolStripMenuItem.Enabled = false;
            this.editCWAVsToolStripMenuItem.Name = "editCWAVsToolStripMenuItem";
            this.editCWAVsToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.editCWAVsToolStripMenuItem.Text = "Create CWAVs chunk";
            this.editCWAVsToolStripMenuItem.Click += new System.EventHandler(this.editCWAVsToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(185, 6);
            // 
            // cWAVsWavToolStripMenuItem
            // 
            this.cWAVsWavToolStripMenuItem.Enabled = false;
            this.cWAVsWavToolStripMenuItem.Name = "cWAVsWavToolStripMenuItem";
            this.cWAVsWavToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.cWAVsWavToolStripMenuItem.Text = "CWAVs Dumper";
            this.cWAVsWavToolStripMenuItem.Click += new System.EventHandler(this.cWAVsWavToolStripMenuItem_Click);
            // 
            // cWAVWAVToolStripMenuItem
            // 
            this.cWAVWAVToolStripMenuItem.Name = "cWAVWAVToolStripMenuItem";
            this.cWAVWAVToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.cWAVWAVToolStripMenuItem.Text = "CWAV -> WAV";
            this.cWAVWAVToolStripMenuItem.Click += new System.EventHandler(this.cWAVWAVToolStripMenuItem_Click);
            // 
            // wAVsCWAVsToolStripMenuItem
            // 
            this.wAVsCWAVsToolStripMenuItem.Name = "wAVsCWAVsToolStripMenuItem";
            this.wAVsCWAVsToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.wAVsCWAVsToolStripMenuItem.Text = "WAV -> CWAV";
            this.wAVsCWAVsToolStripMenuItem.Click += new System.EventHandler(this.wAVsCWAVsToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(185, 6);
            // 
            // toolStripSettings
            // 
            this.toolStripSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSettings.Enabled = false;
            this.toolStripSettings.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSettings.Image")));
            this.toolStripSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSettings.Name = "toolStripSettings";
            this.toolStripSettings.Size = new System.Drawing.Size(92, 22);
            this.toolStripSettings.Text = "Theme settings";
            this.toolStripSettings.Click += new System.EventHandler(this.toolStripSettings_Click);
            // 
            // SimToolStrip
            // 
            this.SimToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SimToolStrip.Enabled = false;
            this.SimToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("SimToolStrip.Image")));
            this.SimToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SimToolStrip.Name = "SimToolStrip";
            this.SimToolStrip.Size = new System.Drawing.Size(57, 22);
            this.SimToolStrip.Text = "Simulate";
            this.SimToolStrip.Click += new System.EventHandler(this.SimToolStrip_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(71, 22);
            this.toolStripButton1.Text = "Images size";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // Debug_menu
            // 
            this.Debug_menu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Debug_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printColorDataToolStripMenuItem,
            this.printColorOffsetToolStripMenuItem,
            this.toolStripSeparator8,
            this.thoseFunctionsAreOnlyForTestingDoesntAffectTheThemeToolStripMenuItem});
            this.Debug_menu.Image = ((System.Drawing.Image)(resources.GetObject("Debug_menu.Image")));
            this.Debug_menu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Debug_menu.Name = "Debug_menu";
            this.Debug_menu.Size = new System.Drawing.Size(89, 22);
            this.Debug_menu.Text = "Debug menu";
            this.Debug_menu.Visible = false;
            // 
            // printColorDataToolStripMenuItem
            // 
            this.printColorDataToolStripMenuItem.Name = "printColorDataToolStripMenuItem";
            this.printColorDataToolStripMenuItem.Size = new System.Drawing.Size(399, 22);
            this.printColorDataToolStripMenuItem.Text = "Print TOPcolor data";
            this.printColorDataToolStripMenuItem.Click += new System.EventHandler(this.printColorDataToolStripMenuItem_Click);
            // 
            // printColorOffsetToolStripMenuItem
            // 
            this.printColorOffsetToolStripMenuItem.Name = "printColorOffsetToolStripMenuItem";
            this.printColorOffsetToolStripMenuItem.Size = new System.Drawing.Size(399, 22);
            this.printColorOffsetToolStripMenuItem.Text = "Print TOPcolor offset";
            this.printColorOffsetToolStripMenuItem.Click += new System.EventHandler(this.printColorOffsetToolStripMenuItem_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(396, 6);
            // 
            // thoseFunctionsAreOnlyForTestingDoesntAffectTheThemeToolStripMenuItem
            // 
            this.thoseFunctionsAreOnlyForTestingDoesntAffectTheThemeToolStripMenuItem.Name = "thoseFunctionsAreOnlyForTestingDoesntAffectTheThemeToolStripMenuItem";
            this.thoseFunctionsAreOnlyForTestingDoesntAffectTheThemeToolStripMenuItem.Size = new System.Drawing.Size(399, 22);
            this.thoseFunctionsAreOnlyForTestingDoesntAffectTheThemeToolStripMenuItem.Text = "Those functions are only for testing, doesn\'t affect the theme ";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.ForeColor = System.Drawing.Color.Red;
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(164, 22);
            this.StatusLabel.Text = "Saving theme,please wait.....";
            this.StatusLabel.Visible = false;
            // 
            // imgListBox
            // 
            this.imgListBox.FormattingEnabled = true;
            this.imgListBox.Location = new System.Drawing.Point(12, 41);
            this.imgListBox.Name = "imgListBox";
            this.imgListBox.Size = new System.Drawing.Size(196, 225);
            this.imgListBox.TabIndex = 1;
            this.imgListBox.SelectedIndexChanged += new System.EventHandler(this.imgListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Images:";
            // 
            // openFileLZ
            // 
            this.openFileLZ.FileName = "body_LZ.bin";
            // 
            // saveTheme
            // 
            this.saveTheme.Filter = "body_LZ.bin|*.bin";
            // 
            // savePng
            // 
            this.savePng.Filter = "PNG Image|*.png";
            // 
            // openNewImg
            // 
            this.openNewImg.Filter = "PNG Image|*.png";
            // 
            // saveCWAVDialog
            // 
            this.saveCWAVDialog.Filter = "CTR Wave Chunk|*.bin";
            // 
            // openCWAVDialog
            // 
            this.openCWAVDialog.Filter = "CTR Wave Chunk|*.bin";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(12, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "open in your photo editor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(618, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 33);
            this.label2.TabIndex = 5;
            this.label2.Text = "Credits";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(178, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(305, 87);
            this.label3.TabIndex = 6;
            this.label3.Text = resources.GetString("label3.Text");
            this.label3.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(214, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(971, 256);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 7;
            // 
            // Player
            // 
            this.Player.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Player.Enabled = true;
            this.Player.Location = new System.Drawing.Point(0, 315);
            this.Player.Name = "Player";
            this.Player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Player.OcxState")));
            this.Player.Size = new System.Drawing.Size(658, 44);
            this.Player.TabIndex = 8;
            this.Player.Visible = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(344, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 62);
            this.label5.TabIndex = 9;
            this.label5.Text = "\r\n\r\n  This theme doesn\'t include this image !";
            this.label5.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(152, 274);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Fixes";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 358);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imgListBox);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Player);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(674, 397);
            this.Name = "Form1";
            this.Text = "YATA PLUS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_Closing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton FileDropDown;
        private System.Windows.Forms.ToolStripMenuItem openFile;
        private System.Windows.Forms.ToolStripButton SimToolStrip;
        private System.Windows.Forms.ListBox imgListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileLZ;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripButton toolStripSettings;
        private System.Windows.Forms.ToolStripMenuItem prefToolStrip;
        private System.Windows.Forms.ToolStripMenuItem newFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton EditDropDown;
        private System.Windows.Forms.ToolStripMenuItem importImage;
        private System.Windows.Forms.ToolStripMenuItem saveFile;
        private System.Windows.Forms.ToolStripMenuItem saveAsFile;
        private System.Windows.Forms.ToolStripMenuItem saveImage;
        private System.Windows.Forms.SaveFileDialog saveTheme;
        private System.Windows.Forms.SaveFileDialog savePng;
        private System.Windows.Forms.OpenFileDialog openNewImg;
        private System.Windows.Forms.ToolStripMenuItem saveCWAVButton;
        private System.Windows.Forms.SaveFileDialog saveCWAVDialog;
        private System.Windows.Forms.ToolStripMenuItem importCWAVButton;
        private System.Windows.Forms.OpenFileDialog openCWAVDialog;
        private System.Windows.Forms.ToolStripMenuItem generatePreviewForCHMMToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem cWAVsWavToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem editCWAVsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem wAVsCWAVsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripLabel StatusLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripDropDownButton Debug_menu;
        private System.Windows.Forms.ToolStripMenuItem printColorDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printColorOffsetToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem thoseFunctionsAreOnlyForTestingDoesntAffectTheThemeToolStripMenuItem;
        private AxWMPLib.AxWindowsMediaPlayer Player;
        private System.Windows.Forms.ToolStripMenuItem loadBgmToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem cWAVWAVToolStripMenuItem;
        private System.Windows.Forms.Button button2;
    }
}

