﻿namespace ConvertColorApp
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.tbRGBB = new Guna.UI2.WinForms.Guna2TrackBar();
            this.tbRGBG = new Guna.UI2.WinForms.Guna2TrackBar();
            this.tbRGBR = new Guna.UI2.WinForms.Guna2TrackBar();
            this.nudRGBB = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.nudRGBG = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.nudRGBR = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.labelRGB = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.tbCMYKK = new Guna.UI2.WinForms.Guna2TrackBar();
            this.tbCMYKY = new Guna.UI2.WinForms.Guna2TrackBar();
            this.tbCMYKM = new Guna.UI2.WinForms.Guna2TrackBar();
            this.tbCMYKC = new Guna.UI2.WinForms.Guna2TrackBar();
            this.nudCMYKK = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.nudCMYKY = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.nudCMYKM = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.nudCMYKC = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.labelCMYK = new System.Windows.Forms.Label();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.tbHSVV = new Guna.UI2.WinForms.Guna2TrackBar();
            this.tbHSVS = new Guna.UI2.WinForms.Guna2TrackBar();
            this.tbHSVH = new Guna.UI2.WinForms.Guna2TrackBar();
            this.nudHSVV = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.nudHSVS = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.nudHSVH = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.labelHSV = new System.Windows.Forms.Label();
            this.btnCopyRGB = new Guna.UI2.WinForms.Guna2Button();
            this.btnCopyCMYK = new Guna.UI2.WinForms.Guna2Button();
            this.btnCopyHSV = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRGBB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRGBG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRGBR)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCMYKK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCMYKY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCMYKM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCMYKC)).BeginInit();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHSVV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHSVS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHSVH)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(420, 32);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(369, 54);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "Color Converter";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btnCopyRGB);
            this.guna2Panel1.Controls.Add(this.tbRGBB);
            this.guna2Panel1.Controls.Add(this.tbRGBG);
            this.guna2Panel1.Controls.Add(this.tbRGBR);
            this.guna2Panel1.Controls.Add(this.nudRGBB);
            this.guna2Panel1.Controls.Add(this.nudRGBG);
            this.guna2Panel1.Controls.Add(this.nudRGBR);
            this.guna2Panel1.Controls.Add(this.labelRGB);
            this.guna2Panel1.Location = new System.Drawing.Point(62, 143);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1082, 175);
            this.guna2Panel1.TabIndex = 29;
            // 
            // tbRGBB
            // 
            this.tbRGBB.LargeChange = 1;
            this.tbRGBB.Location = new System.Drawing.Point(130, 121);
            this.tbRGBB.Maximum = 255;
            this.tbRGBB.Name = "tbRGBB";
            this.tbRGBB.Size = new System.Drawing.Size(707, 35);
            this.tbRGBB.TabIndex = 37;
            this.tbRGBB.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.tbRGBB.Value = 0;
            // 
            // tbRGBG
            // 
            this.tbRGBG.LargeChange = 1;
            this.tbRGBG.Location = new System.Drawing.Point(130, 74);
            this.tbRGBG.Maximum = 255;
            this.tbRGBG.Name = "tbRGBG";
            this.tbRGBG.Size = new System.Drawing.Size(707, 43);
            this.tbRGBG.TabIndex = 36;
            this.tbRGBG.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.tbRGBG.Value = 0;
            // 
            // tbRGBR
            // 
            this.tbRGBR.LargeChange = 1;
            this.tbRGBR.Location = new System.Drawing.Point(130, 27);
            this.tbRGBR.Maximum = 255;
            this.tbRGBR.Name = "tbRGBR";
            this.tbRGBR.Size = new System.Drawing.Size(707, 39);
            this.tbRGBR.TabIndex = 35;
            this.tbRGBR.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.tbRGBR.Value = 0;
            // 
            // nudRGBB
            // 
            this.nudRGBB.BackColor = System.Drawing.Color.Transparent;
            this.nudRGBB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudRGBB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nudRGBB.Location = new System.Drawing.Point(843, 121);
            this.nudRGBB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudRGBB.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudRGBB.Name = "nudRGBB";
            this.nudRGBB.Size = new System.Drawing.Size(114, 39);
            this.nudRGBB.TabIndex = 34;
            this.nudRGBB.ValueChanged += new System.EventHandler(this.nudRGBB_ValueChanged);
            // 
            // nudRGBG
            // 
            this.nudRGBG.BackColor = System.Drawing.Color.Transparent;
            this.nudRGBG.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudRGBG.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nudRGBG.Location = new System.Drawing.Point(843, 74);
            this.nudRGBG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudRGBG.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudRGBG.Name = "nudRGBG";
            this.nudRGBG.Size = new System.Drawing.Size(114, 39);
            this.nudRGBG.TabIndex = 33;
            this.nudRGBG.ValueChanged += new System.EventHandler(this.nudRGBG_ValueChanged);
            // 
            // nudRGBR
            // 
            this.nudRGBR.BackColor = System.Drawing.Color.Transparent;
            this.nudRGBR.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudRGBR.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nudRGBR.Location = new System.Drawing.Point(843, 27);
            this.nudRGBR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudRGBR.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudRGBR.Name = "nudRGBR";
            this.nudRGBR.Size = new System.Drawing.Size(114, 39);
            this.nudRGBR.TabIndex = 32;
            this.nudRGBR.ValueChanged += new System.EventHandler(this.nudRGBR_ValueChanged);
            // 
            // labelRGB
            // 
            this.labelRGB.AutoSize = true;
            this.labelRGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRGB.Location = new System.Drawing.Point(22, 43);
            this.labelRGB.Name = "labelRGB";
            this.labelRGB.Size = new System.Drawing.Size(78, 32);
            this.labelRGB.TabIndex = 31;
            this.labelRGB.Text = "RGB";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.btnCopyCMYK);
            this.guna2Panel2.Controls.Add(this.tbCMYKK);
            this.guna2Panel2.Controls.Add(this.tbCMYKY);
            this.guna2Panel2.Controls.Add(this.tbCMYKM);
            this.guna2Panel2.Controls.Add(this.tbCMYKC);
            this.guna2Panel2.Controls.Add(this.nudCMYKK);
            this.guna2Panel2.Controls.Add(this.nudCMYKY);
            this.guna2Panel2.Controls.Add(this.nudCMYKM);
            this.guna2Panel2.Controls.Add(this.nudCMYKC);
            this.guna2Panel2.Controls.Add(this.labelCMYK);
            this.guna2Panel2.Location = new System.Drawing.Point(62, 324);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1082, 224);
            this.guna2Panel2.TabIndex = 30;
            // 
            // tbCMYKK
            // 
            this.tbCMYKK.LargeChange = 1;
            this.tbCMYKK.Location = new System.Drawing.Point(130, 150);
            this.tbCMYKK.Name = "tbCMYKK";
            this.tbCMYKK.Size = new System.Drawing.Size(707, 41);
            this.tbCMYKK.TabIndex = 42;
            this.tbCMYKK.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.tbCMYKK.Value = 0;
            // 
            // tbCMYKY
            // 
            this.tbCMYKY.LargeChange = 1;
            this.tbCMYKY.Location = new System.Drawing.Point(130, 103);
            this.tbCMYKY.Name = "tbCMYKY";
            this.tbCMYKY.Size = new System.Drawing.Size(707, 41);
            this.tbCMYKY.TabIndex = 41;
            this.tbCMYKY.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.tbCMYKY.Value = 0;
            // 
            // tbCMYKM
            // 
            this.tbCMYKM.LargeChange = 1;
            this.tbCMYKM.Location = new System.Drawing.Point(130, 56);
            this.tbCMYKM.Name = "tbCMYKM";
            this.tbCMYKM.Size = new System.Drawing.Size(707, 41);
            this.tbCMYKM.TabIndex = 40;
            this.tbCMYKM.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.tbCMYKM.Value = 0;
            // 
            // tbCMYKC
            // 
            this.tbCMYKC.LargeChange = 1;
            this.tbCMYKC.Location = new System.Drawing.Point(130, 3);
            this.tbCMYKC.Name = "tbCMYKC";
            this.tbCMYKC.Size = new System.Drawing.Size(707, 47);
            this.tbCMYKC.TabIndex = 39;
            this.tbCMYKC.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.tbCMYKC.Value = 0;
            // 
            // nudCMYKK
            // 
            this.nudCMYKK.BackColor = System.Drawing.Color.Transparent;
            this.nudCMYKK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudCMYKK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nudCMYKK.Location = new System.Drawing.Point(843, 168);
            this.nudCMYKK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudCMYKK.Name = "nudCMYKK";
            this.nudCMYKK.Size = new System.Drawing.Size(114, 39);
            this.nudCMYKK.TabIndex = 38;
            this.nudCMYKK.ValueChanged += new System.EventHandler(this.nudCMYKK_ValueChanged);
            // 
            // nudCMYKY
            // 
            this.nudCMYKY.BackColor = System.Drawing.Color.Transparent;
            this.nudCMYKY.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudCMYKY.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nudCMYKY.Location = new System.Drawing.Point(843, 121);
            this.nudCMYKY.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudCMYKY.Name = "nudCMYKY";
            this.nudCMYKY.Size = new System.Drawing.Size(114, 39);
            this.nudCMYKY.TabIndex = 34;
            this.nudCMYKY.ValueChanged += new System.EventHandler(this.nudCMYKY_ValueChanged);
            // 
            // nudCMYKM
            // 
            this.nudCMYKM.BackColor = System.Drawing.Color.Transparent;
            this.nudCMYKM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudCMYKM.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nudCMYKM.Location = new System.Drawing.Point(843, 74);
            this.nudCMYKM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudCMYKM.Name = "nudCMYKM";
            this.nudCMYKM.Size = new System.Drawing.Size(114, 39);
            this.nudCMYKM.TabIndex = 33;
            this.nudCMYKM.ValueChanged += new System.EventHandler(this.nudCMYKM_ValueChanged);
            // 
            // nudCMYKC
            // 
            this.nudCMYKC.BackColor = System.Drawing.Color.Transparent;
            this.nudCMYKC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudCMYKC.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nudCMYKC.Location = new System.Drawing.Point(843, 27);
            this.nudCMYKC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudCMYKC.Name = "nudCMYKC";
            this.nudCMYKC.Size = new System.Drawing.Size(114, 39);
            this.nudCMYKC.TabIndex = 32;
            this.nudCMYKC.ValueChanged += new System.EventHandler(this.nudCMYKC_ValueChanged);
            // 
            // labelCMYK
            // 
            this.labelCMYK.AutoSize = true;
            this.labelCMYK.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCMYK.Location = new System.Drawing.Point(22, 43);
            this.labelCMYK.Name = "labelCMYK";
            this.labelCMYK.Size = new System.Drawing.Size(99, 32);
            this.labelCMYK.TabIndex = 31;
            this.labelCMYK.Text = "CMYK";
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.btnCopyHSV);
            this.guna2Panel3.Controls.Add(this.tbHSVV);
            this.guna2Panel3.Controls.Add(this.tbHSVS);
            this.guna2Panel3.Controls.Add(this.tbHSVH);
            this.guna2Panel3.Controls.Add(this.nudHSVV);
            this.guna2Panel3.Controls.Add(this.nudHSVS);
            this.guna2Panel3.Controls.Add(this.nudHSVH);
            this.guna2Panel3.Controls.Add(this.labelHSV);
            this.guna2Panel3.Location = new System.Drawing.Point(62, 554);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(1082, 175);
            this.guna2Panel3.TabIndex = 31;
            // 
            // tbHSVV
            // 
            this.tbHSVV.LargeChange = 1;
            this.tbHSVV.Location = new System.Drawing.Point(130, 103);
            this.tbHSVV.Name = "tbHSVV";
            this.tbHSVV.Size = new System.Drawing.Size(707, 41);
            this.tbHSVV.TabIndex = 45;
            this.tbHSVV.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.tbHSVV.Value = 0;
            // 
            // tbHSVS
            // 
            this.tbHSVS.LargeChange = 1;
            this.tbHSVS.Location = new System.Drawing.Point(130, 56);
            this.tbHSVS.Name = "tbHSVS";
            this.tbHSVS.Size = new System.Drawing.Size(707, 41);
            this.tbHSVS.TabIndex = 44;
            this.tbHSVS.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.tbHSVS.Value = 0;
            // 
            // tbHSVH
            // 
            this.tbHSVH.LargeChange = 1;
            this.tbHSVH.Location = new System.Drawing.Point(130, 3);
            this.tbHSVH.Maximum = 360;
            this.tbHSVH.Name = "tbHSVH";
            this.tbHSVH.Size = new System.Drawing.Size(707, 47);
            this.tbHSVH.TabIndex = 43;
            this.tbHSVH.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.tbHSVH.Value = 0;
            // 
            // nudHSVV
            // 
            this.nudHSVV.BackColor = System.Drawing.Color.Transparent;
            this.nudHSVV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudHSVV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nudHSVV.Location = new System.Drawing.Point(843, 121);
            this.nudHSVV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudHSVV.Name = "nudHSVV";
            this.nudHSVV.Size = new System.Drawing.Size(114, 39);
            this.nudHSVV.TabIndex = 34;
            this.nudHSVV.ValueChanged += new System.EventHandler(this.nudHSVV_ValueChanged);
            // 
            // nudHSVS
            // 
            this.nudHSVS.BackColor = System.Drawing.Color.Transparent;
            this.nudHSVS.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudHSVS.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nudHSVS.Location = new System.Drawing.Point(843, 74);
            this.nudHSVS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudHSVS.Name = "nudHSVS";
            this.nudHSVS.Size = new System.Drawing.Size(114, 39);
            this.nudHSVS.TabIndex = 33;
            this.nudHSVS.ValueChanged += new System.EventHandler(this.nudHSVS_ValueChanged);
            // 
            // nudHSVH
            // 
            this.nudHSVH.BackColor = System.Drawing.Color.Transparent;
            this.nudHSVH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudHSVH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nudHSVH.Location = new System.Drawing.Point(843, 27);
            this.nudHSVH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudHSVH.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nudHSVH.Name = "nudHSVH";
            this.nudHSVH.Size = new System.Drawing.Size(114, 39);
            this.nudHSVH.TabIndex = 32;
            this.nudHSVH.ValueChanged += new System.EventHandler(this.nudHSVH_ValueChanged);
            // 
            // labelHSV
            // 
            this.labelHSV.AutoSize = true;
            this.labelHSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHSV.Location = new System.Drawing.Point(22, 43);
            this.labelHSV.Name = "labelHSV";
            this.labelHSV.Size = new System.Drawing.Size(75, 32);
            this.labelHSV.TabIndex = 31;
            this.labelHSV.Text = "HSV";
            // 
            // btnCopyRGB
            // 
            this.btnCopyRGB.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCopyRGB.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCopyRGB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCopyRGB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCopyRGB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCopyRGB.ForeColor = System.Drawing.Color.White;
            this.btnCopyRGB.Location = new System.Drawing.Point(975, 27);
            this.btnCopyRGB.Name = "btnCopyRGB";
            this.btnCopyRGB.Size = new System.Drawing.Size(93, 39);
            this.btnCopyRGB.TabIndex = 38;
            this.btnCopyRGB.Text = "Copy";
            this.btnCopyRGB.Click += new System.EventHandler(this.btnCopyRGB_Click);
            // 
            // btnCopyCMYK
            // 
            this.btnCopyCMYK.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCopyCMYK.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCopyCMYK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCopyCMYK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCopyCMYK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCopyCMYK.ForeColor = System.Drawing.Color.White;
            this.btnCopyCMYK.Location = new System.Drawing.Point(975, 27);
            this.btnCopyCMYK.Name = "btnCopyCMYK";
            this.btnCopyCMYK.Size = new System.Drawing.Size(93, 39);
            this.btnCopyCMYK.TabIndex = 43;
            this.btnCopyCMYK.Text = "Copy";
            this.btnCopyCMYK.Click += new System.EventHandler(this.btnCopyCMYK_Click);
            // 
            // btnCopyHSV
            // 
            this.btnCopyHSV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCopyHSV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCopyHSV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCopyHSV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCopyHSV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCopyHSV.ForeColor = System.Drawing.Color.White;
            this.btnCopyHSV.Location = new System.Drawing.Point(975, 27);
            this.btnCopyHSV.Name = "btnCopyHSV";
            this.btnCopyHSV.Size = new System.Drawing.Size(93, 39);
            this.btnCopyHSV.TabIndex = 46;
            this.btnCopyHSV.Text = "Copy";
            this.btnCopyHSV.Click += new System.EventHandler(this.btnCopyHSV_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 787);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.labelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRGBB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRGBG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRGBR)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCMYKK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCMYKY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCMYKM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCMYKC)).EndInit();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHSVV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHSVS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHSVH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTitle;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudHSVV;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudHSVS;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudHSVH;
        private System.Windows.Forms.Label labelHSV;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudCMYKK;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudCMYKY;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudCMYKM;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudCMYKC;
        private System.Windows.Forms.Label labelCMYK;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudRGBB;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudRGBG;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudRGBR;
        private System.Windows.Forms.Label labelRGB;
        private Guna.UI2.WinForms.Guna2TrackBar tbRGBB;
        private Guna.UI2.WinForms.Guna2TrackBar tbRGBG;
        private Guna.UI2.WinForms.Guna2TrackBar tbRGBR;
        private Guna.UI2.WinForms.Guna2TrackBar tbHSVV;
        private Guna.UI2.WinForms.Guna2TrackBar tbHSVS;
        private Guna.UI2.WinForms.Guna2TrackBar tbHSVH;
        private Guna.UI2.WinForms.Guna2TrackBar tbCMYKK;
        private Guna.UI2.WinForms.Guna2TrackBar tbCMYKY;
        private Guna.UI2.WinForms.Guna2TrackBar tbCMYKM;
        private Guna.UI2.WinForms.Guna2TrackBar tbCMYKC;
        private Guna.UI2.WinForms.Guna2Button btnCopyRGB;
        private Guna.UI2.WinForms.Guna2Button btnCopyCMYK;
        private Guna.UI2.WinForms.Guna2Button btnCopyHSV;
    }
}

