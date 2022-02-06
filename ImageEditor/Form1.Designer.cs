
namespace ImageEditor
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.redBar = new System.Windows.Forms.TrackBar();
            this.greenBar = new System.Windows.Forms.TrackBar();
            this.blueBar = new System.Windows.Forms.TrackBar();
            this.brightnessBar = new System.Windows.Forms.TrackBar();
            this.saturationBar = new System.Windows.Forms.TrackBar();
            this.pbCrop = new System.Windows.Forms.PictureBox();
            this.pbRotate = new System.Windows.Forms.PictureBox();
            this.pbRgb = new System.Windows.Forms.PictureBox();
            this.pbSaturation = new System.Windows.Forms.PictureBox();
            this.pbBrightness = new System.Windows.Forms.PictureBox();
            this.lred = new System.Windows.Forms.Label();
            this.lgreen = new System.Windows.Forms.Label();
            this.lblue = new System.Windows.Forms.Label();
            this.btnCropSelected = new System.Windows.Forms.Button();
            this.brightnessLabel = new System.Windows.Forms.PictureBox();
            this.saturationLabel = new System.Windows.Forms.PictureBox();
            this.rotate90 = new System.Windows.Forms.PictureBox();
            this.rotate270 = new System.Windows.Forms.PictureBox();
            this.rotate180 = new System.Windows.Forms.PictureBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.writingTxt = new System.Windows.Forms.TextBox();
            this.txt = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.btnFont = new System.Windows.Forms.Button();
            this.pbTxt = new System.Windows.Forms.PictureBox();
            this.pbUndo = new System.Windows.Forms.PictureBox();
            this.pbRedo = new System.Windows.Forms.PictureBox();
            this.MenuContainer = new System.Windows.Forms.Panel();
            this.toolBar = new System.Windows.Forms.ToolTip(this.components);
            this.cropPanel = new System.Windows.Forms.Panel();
            this.brightnessPanel = new System.Windows.Forms.Panel();
            this.rgbPanel = new System.Windows.Forms.Panel();
            this.saturationPanel = new System.Windows.Forms.Panel();
            this.rotatePanel = new System.Windows.Forms.Panel();
            this.txtPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.animation = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.redBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saturationBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCrop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRotate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRgb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSaturation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBrightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saturationLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotate90)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotate270)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotate180)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUndo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRedo)).BeginInit();
            this.MenuContainer.SuspendLayout();
            this.cropPanel.SuspendLayout();
            this.brightnessPanel.SuspendLayout();
            this.rgbPanel.SuspendLayout();
            this.saturationPanel.SuspendLayout();
            this.rotatePanel.SuspendLayout();
            this.txtPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Info;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(1, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(932, 495);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.resetToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1000, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // redBar
            // 
            this.redBar.Location = new System.Drawing.Point(51, 17);
            this.redBar.Name = "redBar";
            this.redBar.Size = new System.Drawing.Size(198, 45);
            this.redBar.TabIndex = 5;
            this.redBar.Scroll += new System.EventHandler(this.redbar_Scroll);
            // 
            // greenBar
            // 
            this.greenBar.Location = new System.Drawing.Point(339, 18);
            this.greenBar.Name = "greenBar";
            this.greenBar.Size = new System.Drawing.Size(198, 45);
            this.greenBar.TabIndex = 6;
            this.greenBar.Scroll += new System.EventHandler(this.greenbar_Scroll);
            // 
            // blueBar
            // 
            this.blueBar.Location = new System.Drawing.Point(630, 17);
            this.blueBar.Name = "blueBar";
            this.blueBar.Size = new System.Drawing.Size(198, 45);
            this.blueBar.TabIndex = 7;
            this.blueBar.Scroll += new System.EventHandler(this.bluebar_Scroll);
            // 
            // brightnessBar
            // 
            this.brightnessBar.Location = new System.Drawing.Point(319, 17);
            this.brightnessBar.Name = "brightnessBar";
            this.brightnessBar.Size = new System.Drawing.Size(227, 45);
            this.brightnessBar.TabIndex = 8;
            this.brightnessBar.Scroll += new System.EventHandler(this.brightnessbar_Scroll);
            // 
            // saturationBar
            // 
            this.saturationBar.Location = new System.Drawing.Point(306, 16);
            this.saturationBar.Name = "saturationBar";
            this.saturationBar.Size = new System.Drawing.Size(227, 45);
            this.saturationBar.TabIndex = 9;
            this.saturationBar.Scroll += new System.EventHandler(this.saturation_Scroll);
            // 
            // pbCrop
            // 
            this.pbCrop.Image = ((System.Drawing.Image)(resources.GetObject("pbCrop.Image")));
            this.pbCrop.Location = new System.Drawing.Point(18, 84);
            this.pbCrop.Name = "pbCrop";
            this.pbCrop.Size = new System.Drawing.Size(43, 40);
            this.pbCrop.TabIndex = 10;
            this.pbCrop.TabStop = false;
            this.pbCrop.Click += new System.EventHandler(this.pbCrop_Click);
            this.pbCrop.MouseHover += new System.EventHandler(this.pbCrop_MouseHover);
            // 
            // pbRotate
            // 
            this.pbRotate.Image = ((System.Drawing.Image)(resources.GetObject("pbRotate.Image")));
            this.pbRotate.Location = new System.Drawing.Point(18, 146);
            this.pbRotate.Name = "pbRotate";
            this.pbRotate.Size = new System.Drawing.Size(43, 40);
            this.pbRotate.TabIndex = 11;
            this.pbRotate.TabStop = false;
            this.pbRotate.Click += new System.EventHandler(this.pbRotate_Click);
            this.pbRotate.MouseHover += new System.EventHandler(this.pbRotate_MouseHover);
            // 
            // pbRgb
            // 
            this.pbRgb.Image = ((System.Drawing.Image)(resources.GetObject("pbRgb.Image")));
            this.pbRgb.Location = new System.Drawing.Point(18, 213);
            this.pbRgb.Name = "pbRgb";
            this.pbRgb.Size = new System.Drawing.Size(43, 40);
            this.pbRgb.TabIndex = 12;
            this.pbRgb.TabStop = false;
            this.pbRgb.Click += new System.EventHandler(this.pbRgb_Click);
            this.pbRgb.MouseHover += new System.EventHandler(this.pbRgb_MouseHover);
            // 
            // pbSaturation
            // 
            this.pbSaturation.Image = ((System.Drawing.Image)(resources.GetObject("pbSaturation.Image")));
            this.pbSaturation.Location = new System.Drawing.Point(18, 288);
            this.pbSaturation.Name = "pbSaturation";
            this.pbSaturation.Size = new System.Drawing.Size(43, 40);
            this.pbSaturation.TabIndex = 13;
            this.pbSaturation.TabStop = false;
            this.pbSaturation.Click += new System.EventHandler(this.pbSaturation_Click);
            this.pbSaturation.MouseHover += new System.EventHandler(this.pbSaturation_MouseHover);
            // 
            // pbBrightness
            // 
            this.pbBrightness.Image = ((System.Drawing.Image)(resources.GetObject("pbBrightness.Image")));
            this.pbBrightness.Location = new System.Drawing.Point(18, 357);
            this.pbBrightness.Name = "pbBrightness";
            this.pbBrightness.Size = new System.Drawing.Size(43, 40);
            this.pbBrightness.TabIndex = 14;
            this.pbBrightness.TabStop = false;
            this.pbBrightness.Click += new System.EventHandler(this.pbBrightness_Click);
            this.pbBrightness.MouseHover += new System.EventHandler(this.pbBrightness_MouseHover);
            // 
            // lred
            // 
            this.lred.AutoSize = true;
            this.lred.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lred.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lred.Location = new System.Drawing.Point(37, 20);
            this.lred.Name = "lred";
            this.lred.Size = new System.Drawing.Size(21, 16);
            this.lred.TabIndex = 15;
            this.lred.Text = "R:";
            // 
            // lgreen
            // 
            this.lgreen.AutoSize = true;
            this.lgreen.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lgreen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lgreen.Location = new System.Drawing.Point(325, 20);
            this.lgreen.Name = "lgreen";
            this.lgreen.Size = new System.Drawing.Size(22, 16);
            this.lgreen.TabIndex = 16;
            this.lgreen.Text = "G:";
            // 
            // lblue
            // 
            this.lblue.AutoSize = true;
            this.lblue.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblue.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblue.Location = new System.Drawing.Point(617, 19);
            this.lblue.Name = "lblue";
            this.lblue.Size = new System.Drawing.Size(21, 16);
            this.lblue.TabIndex = 17;
            this.lblue.Text = "B:";
            // 
            // btnCropSelected
            // 
            this.btnCropSelected.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCropSelected.Location = new System.Drawing.Point(375, 22);
            this.btnCropSelected.Name = "btnCropSelected";
            this.btnCropSelected.Size = new System.Drawing.Size(124, 23);
            this.btnCropSelected.TabIndex = 18;
            this.btnCropSelected.Text = "Crop Selected";
            this.btnCropSelected.UseVisualStyleBackColor = true;
            this.btnCropSelected.Click += new System.EventHandler(this.btnCropSelected_Click);
            // 
            // brightnessLabel
            // 
            this.brightnessLabel.Image = ((System.Drawing.Image)(resources.GetObject("brightnessLabel.Image")));
            this.brightnessLabel.Location = new System.Drawing.Point(278, 17);
            this.brightnessLabel.Name = "brightnessLabel";
            this.brightnessLabel.Size = new System.Drawing.Size(22, 22);
            this.brightnessLabel.TabIndex = 19;
            this.brightnessLabel.TabStop = false;
            // 
            // saturationLabel
            // 
            this.saturationLabel.Image = ((System.Drawing.Image)(resources.GetObject("saturationLabel.Image")));
            this.saturationLabel.Location = new System.Drawing.Point(263, 16);
            this.saturationLabel.Name = "saturationLabel";
            this.saturationLabel.Size = new System.Drawing.Size(22, 22);
            this.saturationLabel.TabIndex = 20;
            this.saturationLabel.TabStop = false;
            // 
            // rotate90
            // 
            this.rotate90.Image = ((System.Drawing.Image)(resources.GetObject("rotate90.Image")));
            this.rotate90.Location = new System.Drawing.Point(151, 16);
            this.rotate90.Name = "rotate90";
            this.rotate90.Size = new System.Drawing.Size(36, 34);
            this.rotate90.TabIndex = 21;
            this.rotate90.TabStop = false;
            this.rotate90.Click += new System.EventHandler(this.rotate90_Click);
            // 
            // rotate270
            // 
            this.rotate270.Image = ((System.Drawing.Image)(resources.GetObject("rotate270.Image")));
            this.rotate270.Location = new System.Drawing.Point(583, 15);
            this.rotate270.Name = "rotate270";
            this.rotate270.Size = new System.Drawing.Size(36, 34);
            this.rotate270.TabIndex = 22;
            this.rotate270.TabStop = false;
            this.rotate270.Click += new System.EventHandler(this.rotate270_Click);
            // 
            // rotate180
            // 
            this.rotate180.Image = ((System.Drawing.Image)(resources.GetObject("rotate180.Image")));
            this.rotate180.Location = new System.Drawing.Point(364, 17);
            this.rotate180.Name = "rotate180";
            this.rotate180.Size = new System.Drawing.Size(36, 34);
            this.rotate180.TabIndex = 23;
            this.rotate180.TabStop = false;
            this.rotate180.Click += new System.EventHandler(this.rotate180_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(687, 19);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(72, 23);
            this.btnSubmit.TabIndex = 24;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // writingTxt
            // 
            this.writingTxt.Location = new System.Drawing.Point(151, 24);
            this.writingTxt.Name = "writingTxt";
            this.writingTxt.Size = new System.Drawing.Size(199, 20);
            this.writingTxt.TabIndex = 25;
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt.Location = new System.Drawing.Point(64, 25);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(81, 16);
            this.txt.TabIndex = 26;
            this.txt.Text = "Enter Text:";
            // 
            // fontDialog1
            // 
            this.fontDialog1.ShowColor = true;
            // 
            // btnFont
            // 
            this.btnFont.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFont.Location = new System.Drawing.Point(428, 20);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(118, 23);
            this.btnFont.TabIndex = 27;
            this.btnFont.Text = "Select Font Style";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // pbTxt
            // 
            this.pbTxt.Image = ((System.Drawing.Image)(resources.GetObject("pbTxt.Image")));
            this.pbTxt.Location = new System.Drawing.Point(18, 431);
            this.pbTxt.Name = "pbTxt";
            this.pbTxt.Size = new System.Drawing.Size(43, 40);
            this.pbTxt.TabIndex = 28;
            this.pbTxt.TabStop = false;
            this.pbTxt.Click += new System.EventHandler(this.pbTxt_Click);
            this.pbTxt.MouseHover += new System.EventHandler(this.pbTxt_MouseHover);
            // 
            // pbUndo
            // 
            this.pbUndo.Image = ((System.Drawing.Image)(resources.GetObject("pbUndo.Image")));
            this.pbUndo.Location = new System.Drawing.Point(26, 3);
            this.pbUndo.Name = "pbUndo";
            this.pbUndo.Size = new System.Drawing.Size(22, 22);
            this.pbUndo.TabIndex = 29;
            this.pbUndo.TabStop = false;
            this.pbUndo.Click += new System.EventHandler(this.pbUndo_Click);
            this.pbUndo.MouseHover += new System.EventHandler(this.pbUndo_MouseHover);
            // 
            // pbRedo
            // 
            this.pbRedo.Image = ((System.Drawing.Image)(resources.GetObject("pbRedo.Image")));
            this.pbRedo.Location = new System.Drawing.Point(26, 43);
            this.pbRedo.Name = "pbRedo";
            this.pbRedo.Size = new System.Drawing.Size(22, 22);
            this.pbRedo.TabIndex = 30;
            this.pbRedo.TabStop = false;
            this.pbRedo.Click += new System.EventHandler(this.pbRedo_Click);
            this.pbRedo.MouseHover += new System.EventHandler(this.pbRedo_MouseHover);
            // 
            // MenuContainer
            // 
            this.MenuContainer.BackColor = System.Drawing.Color.GhostWhite;
            this.MenuContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MenuContainer.Controls.Add(this.pbCrop);
            this.MenuContainer.Controls.Add(this.pbUndo);
            this.MenuContainer.Controls.Add(this.pbRedo);
            this.MenuContainer.Controls.Add(this.pbRotate);
            this.MenuContainer.Controls.Add(this.pbRgb);
            this.MenuContainer.Controls.Add(this.pbTxt);
            this.MenuContainer.Controls.Add(this.pbSaturation);
            this.MenuContainer.Controls.Add(this.pbBrightness);
            this.MenuContainer.Location = new System.Drawing.Point(932, 24);
            this.MenuContainer.Name = "MenuContainer";
            this.MenuContainer.Size = new System.Drawing.Size(68, 495);
            this.MenuContainer.TabIndex = 0;
            // 
            // cropPanel
            // 
            this.cropPanel.BackColor = System.Drawing.Color.DimGray;
            this.cropPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cropPanel.Controls.Add(this.btnCropSelected);
            this.cropPanel.Location = new System.Drawing.Point(68, 520);
            this.cropPanel.Name = "cropPanel";
            this.cropPanel.Size = new System.Drawing.Size(864, 61);
            this.cropPanel.TabIndex = 31;
            // 
            // brightnessPanel
            // 
            this.brightnessPanel.BackColor = System.Drawing.Color.DimGray;
            this.brightnessPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.brightnessPanel.Controls.Add(this.brightnessBar);
            this.brightnessPanel.Controls.Add(this.brightnessLabel);
            this.brightnessPanel.Location = new System.Drawing.Point(70, 520);
            this.brightnessPanel.Name = "brightnessPanel";
            this.brightnessPanel.Size = new System.Drawing.Size(864, 61);
            this.brightnessPanel.TabIndex = 32;
            // 
            // rgbPanel
            // 
            this.rgbPanel.BackColor = System.Drawing.Color.DimGray;
            this.rgbPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rgbPanel.Controls.Add(this.blueBar);
            this.rgbPanel.Controls.Add(this.redBar);
            this.rgbPanel.Controls.Add(this.lred);
            this.rgbPanel.Controls.Add(this.lgreen);
            this.rgbPanel.Controls.Add(this.lblue);
            this.rgbPanel.Controls.Add(this.greenBar);
            this.rgbPanel.Location = new System.Drawing.Point(70, 519);
            this.rgbPanel.Name = "rgbPanel";
            this.rgbPanel.Size = new System.Drawing.Size(864, 62);
            this.rgbPanel.TabIndex = 32;
            // 
            // saturationPanel
            // 
            this.saturationPanel.BackColor = System.Drawing.Color.DimGray;
            this.saturationPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.saturationPanel.Controls.Add(this.saturationLabel);
            this.saturationPanel.Controls.Add(this.saturationBar);
            this.saturationPanel.Location = new System.Drawing.Point(70, 520);
            this.saturationPanel.Name = "saturationPanel";
            this.saturationPanel.Size = new System.Drawing.Size(864, 61);
            this.saturationPanel.TabIndex = 32;
            // 
            // rotatePanel
            // 
            this.rotatePanel.BackColor = System.Drawing.Color.DimGray;
            this.rotatePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rotatePanel.Controls.Add(this.label3);
            this.rotatePanel.Controls.Add(this.label2);
            this.rotatePanel.Controls.Add(this.label1);
            this.rotatePanel.Controls.Add(this.rotate270);
            this.rotatePanel.Controls.Add(this.rotate90);
            this.rotatePanel.Controls.Add(this.rotate180);
            this.rotatePanel.Location = new System.Drawing.Point(70, 519);
            this.rotatePanel.Name = "rotatePanel";
            this.rotatePanel.Size = new System.Drawing.Size(864, 62);
            this.rotatePanel.TabIndex = 32;
            // 
            // txtPanel
            // 
            this.txtPanel.BackColor = System.Drawing.Color.DimGray;
            this.txtPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtPanel.Controls.Add(this.writingTxt);
            this.txtPanel.Controls.Add(this.btnSubmit);
            this.txtPanel.Controls.Add(this.txt);
            this.txtPanel.Controls.Add(this.btnFont);
            this.txtPanel.Location = new System.Drawing.Point(68, 519);
            this.txtPanel.Name = "txtPanel";
            this.txtPanel.Size = new System.Drawing.Size(864, 62);
            this.txtPanel.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(75, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Rotate 90";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(291, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "Flip 180";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(503, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "Rotate -90";
            // 
            // animation
            // 
            this.animation.AutoSize = true;
            this.animation.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animation.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.animation.Location = new System.Drawing.Point(421, 597);
            this.animation.Name = "animation";
            this.animation.Size = new System.Drawing.Size(214, 16);
            this.animation.TabIndex = 33;
            this.animation.Text = "Load Picture to access controls";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1000, 623);
            this.Controls.Add(this.animation);
            this.Controls.Add(this.MenuContainer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtPanel);
            this.Controls.Add(this.rotatePanel);
            this.Controls.Add(this.saturationPanel);
            this.Controls.Add(this.rgbPanel);
            this.Controls.Add(this.brightnessPanel);
            this.Controls.Add(this.cropPanel);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Photo Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.redBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saturationBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCrop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRotate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRgb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSaturation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBrightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saturationLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotate90)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotate270)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotate180)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUndo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRedo)).EndInit();
            this.MenuContainer.ResumeLayout(false);
            this.cropPanel.ResumeLayout(false);
            this.brightnessPanel.ResumeLayout(false);
            this.brightnessPanel.PerformLayout();
            this.rgbPanel.ResumeLayout(false);
            this.rgbPanel.PerformLayout();
            this.saturationPanel.ResumeLayout(false);
            this.saturationPanel.PerformLayout();
            this.rotatePanel.ResumeLayout(false);
            this.rotatePanel.PerformLayout();
            this.txtPanel.ResumeLayout(false);
            this.txtPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TrackBar redBar;
        private System.Windows.Forms.TrackBar greenBar;
        private System.Windows.Forms.TrackBar blueBar;
        private System.Windows.Forms.TrackBar brightnessBar;
        private System.Windows.Forms.TrackBar saturationBar;
        private System.Windows.Forms.PictureBox pbCrop;
        private System.Windows.Forms.PictureBox pbRotate;
        private System.Windows.Forms.PictureBox pbRgb;
        private System.Windows.Forms.PictureBox pbSaturation;
        private System.Windows.Forms.PictureBox pbBrightness;
        private System.Windows.Forms.Label lred;
        private System.Windows.Forms.Label lgreen;
        private System.Windows.Forms.Label lblue;
        private System.Windows.Forms.Button btnCropSelected;
        private System.Windows.Forms.PictureBox brightnessLabel;
        private System.Windows.Forms.PictureBox saturationLabel;
        private System.Windows.Forms.PictureBox rotate90;
        private System.Windows.Forms.PictureBox rotate270;
        private System.Windows.Forms.PictureBox rotate180;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox writingTxt;
        private System.Windows.Forms.Label txt;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.PictureBox pbTxt;
        private System.Windows.Forms.PictureBox pbUndo;
        private System.Windows.Forms.PictureBox pbRedo;
        private System.Windows.Forms.Panel MenuContainer;
        private System.Windows.Forms.ToolTip toolBar;
        private System.Windows.Forms.Panel cropPanel;
        private System.Windows.Forms.Panel brightnessPanel;
        private System.Windows.Forms.Panel rgbPanel;
        private System.Windows.Forms.Panel saturationPanel;
        private System.Windows.Forms.Panel rotatePanel;
        private System.Windows.Forms.Panel txtPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label animation;
        private System.Windows.Forms.Timer timer1;
    }
}

