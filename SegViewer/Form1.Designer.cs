namespace SegViewer
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
            this.Annot1ScrollBar = new System.Windows.Forms.HScrollBar();
            this.Annot2ScrollBar = new System.Windows.Forms.HScrollBar();
            this.T1ScrollBar = new System.Windows.Forms.HScrollBar();
            this.T2ScrollBar = new System.Windows.Forms.HScrollBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.T1MRIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.T2MRIToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.annotation1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.annotation2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Annotation1 = new System.Windows.Forms.PictureBox();
            this.OriT1 = new System.Windows.Forms.PictureBox();
            this.Annotation2 = new System.Windows.Forms.PictureBox();
            this.OriT2 = new System.Windows.Forms.PictureBox();
            this.T1Index = new System.Windows.Forms.Label();
            this.T2Index = new System.Windows.Forms.Label();
            this.Annot1Index = new System.Windows.Forms.Label();
            this.Annot2Index = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.savePathDisplay = new System.Windows.Forms.Label();
            this.Question1 = new System.Windows.Forms.Label();
            this.Question2 = new System.Windows.Forms.Label();
            this.Question3 = new System.Windows.Forms.Label();
            this.Q1R1 = new System.Windows.Forms.RadioButton();
            this.Q1Box = new System.Windows.Forms.GroupBox();
            this.Q1R5 = new System.Windows.Forms.RadioButton();
            this.Q1R4 = new System.Windows.Forms.RadioButton();
            this.Q1R3 = new System.Windows.Forms.RadioButton();
            this.Q1R2 = new System.Windows.Forms.RadioButton();
            this.Q3Box = new System.Windows.Forms.GroupBox();
            this.Q3R5 = new System.Windows.Forms.RadioButton();
            this.Q3R4 = new System.Windows.Forms.RadioButton();
            this.Q3R3 = new System.Windows.Forms.RadioButton();
            this.Q3R2 = new System.Windows.Forms.RadioButton();
            this.Q3R1 = new System.Windows.Forms.RadioButton();
            this.Q2Box = new System.Windows.Forms.GroupBox();
            this.Q2R5 = new System.Windows.Forms.RadioButton();
            this.Q2R4 = new System.Windows.Forms.RadioButton();
            this.Q2R3 = new System.Windows.Forms.RadioButton();
            this.Q2R2 = new System.Windows.Forms.RadioButton();
            this.Q2R1 = new System.Windows.Forms.RadioButton();
            this.PreviousButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.ContrastReset = new System.Windows.Forms.Button();
            this.ContrastScrollbar = new System.Windows.Forms.HScrollBar();
            this.ContrastLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BrightnessScrollbar = new System.Windows.Forms.HScrollBar();
            this.BrightnessReset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.hScrollBar2 = new System.Windows.Forms.HScrollBar();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.hScrollBar3 = new System.Windows.Forms.HScrollBar();
            this.button4 = new System.Windows.Forms.Button();
            this.ContrastMonitor = new System.Windows.Forms.Label();
            this.BrightnessMonitor = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Annotation1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OriT1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Annotation2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OriT2)).BeginInit();
            this.Q1Box.SuspendLayout();
            this.Q3Box.SuspendLayout();
            this.Q2Box.SuspendLayout();
            this.SuspendLayout();
            // 
            // Annot1ScrollBar
            // 
            this.Annot1ScrollBar.Location = new System.Drawing.Point(71, 293);
            this.Annot1ScrollBar.Name = "Annot1ScrollBar";
            this.Annot1ScrollBar.Size = new System.Drawing.Size(232, 28);
            this.Annot1ScrollBar.TabIndex = 0;
            this.Annot1ScrollBar.ValueChanged += new System.EventHandler(this.A1ScrollBar_ValueChanged);
            // 
            // Annot2ScrollBar
            // 
            this.Annot2ScrollBar.Location = new System.Drawing.Point(457, 293);
            this.Annot2ScrollBar.Name = "Annot2ScrollBar";
            this.Annot2ScrollBar.Size = new System.Drawing.Size(232, 28);
            this.Annot2ScrollBar.TabIndex = 1;
            this.Annot2ScrollBar.ValueChanged += new System.EventHandler(this.A2ScrollBar_ValueChanged);
            // 
            // T1ScrollBar
            // 
            this.T1ScrollBar.Location = new System.Drawing.Point(73, 614);
            this.T1ScrollBar.Name = "T1ScrollBar";
            this.T1ScrollBar.Size = new System.Drawing.Size(232, 28);
            this.T1ScrollBar.TabIndex = 2;
            this.T1ScrollBar.ValueChanged += new System.EventHandler(this.T1ScrollBar_ValueChanged);
            // 
            // T2ScrollBar
            // 
            this.T2ScrollBar.Location = new System.Drawing.Point(457, 614);
            this.T2ScrollBar.Name = "T2ScrollBar";
            this.T2ScrollBar.Size = new System.Drawing.Size(232, 28);
            this.T2ScrollBar.TabIndex = 3;
            this.T2ScrollBar.ValueChanged += new System.EventHandler(this.T2ScrollBar_ValueChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1275, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.T1MRIToolStripMenuItem,
            this.T2MRIToolStripMenuItem1,
            this.annotation1ToolStripMenuItem,
            this.annotation2ToolStripMenuItem});
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(117, 26);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // T1MRIToolStripMenuItem
            // 
            this.T1MRIToolStripMenuItem.Name = "T1MRIToolStripMenuItem";
            this.T1MRIToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.T1MRIToolStripMenuItem.Text = "T1 MRI";
            this.T1MRIToolStripMenuItem.Click += new System.EventHandler(this.T1MRIToolStripMenuItem_Click);
            // 
            // T2MRIToolStripMenuItem1
            // 
            this.T2MRIToolStripMenuItem1.Name = "T2MRIToolStripMenuItem1";
            this.T2MRIToolStripMenuItem1.Size = new System.Drawing.Size(166, 26);
            this.T2MRIToolStripMenuItem1.Text = "T2 MRI";
            this.T2MRIToolStripMenuItem1.Click += new System.EventHandler(this.T2MRIToolStripMenuItem1_Click);
            // 
            // annotation1ToolStripMenuItem
            // 
            this.annotation1ToolStripMenuItem.Name = "annotation1ToolStripMenuItem";
            this.annotation1ToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.annotation1ToolStripMenuItem.Text = "Annotation1";
            this.annotation1ToolStripMenuItem.Click += new System.EventHandler(this.annotation1ToolStripMenuItem_Click);
            // 
            // annotation2ToolStripMenuItem
            // 
            this.annotation2ToolStripMenuItem.Name = "annotation2ToolStripMenuItem";
            this.annotation2ToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.annotation2ToolStripMenuItem.Text = "Annotation2";
            this.annotation2ToolStripMenuItem.Click += new System.EventHandler(this.annotation2ToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(117, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Annotation1
            // 
            this.Annotation1.BackColor = System.Drawing.Color.Black;
            this.Annotation1.Location = new System.Drawing.Point(24, 31);
            this.Annotation1.Name = "Annotation1";
            this.Annotation1.Size = new System.Drawing.Size(336, 259);
            this.Annotation1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Annotation1.TabIndex = 5;
            this.Annotation1.TabStop = false;
            // 
            // OriT1
            // 
            this.OriT1.BackColor = System.Drawing.Color.Black;
            this.OriT1.Location = new System.Drawing.Point(24, 352);
            this.OriT1.Name = "OriT1";
            this.OriT1.Size = new System.Drawing.Size(336, 259);
            this.OriT1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OriT1.TabIndex = 6;
            this.OriT1.TabStop = false;
            // 
            // Annotation2
            // 
            this.Annotation2.BackColor = System.Drawing.Color.Black;
            this.Annotation2.Location = new System.Drawing.Point(406, 31);
            this.Annotation2.Name = "Annotation2";
            this.Annotation2.Size = new System.Drawing.Size(336, 259);
            this.Annotation2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Annotation2.TabIndex = 7;
            this.Annotation2.TabStop = false;
            // 
            // OriT2
            // 
            this.OriT2.BackColor = System.Drawing.Color.Black;
            this.OriT2.Location = new System.Drawing.Point(406, 352);
            this.OriT2.Name = "OriT2";
            this.OriT2.Size = new System.Drawing.Size(336, 259);
            this.OriT2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OriT2.TabIndex = 8;
            this.OriT2.TabStop = false;
            // 
            // T1Index
            // 
            this.T1Index.AutoSize = true;
            this.T1Index.Location = new System.Drawing.Point(305, 622);
            this.T1Index.Name = "T1Index";
            this.T1Index.Size = new System.Drawing.Size(0, 15);
            this.T1Index.TabIndex = 9;
            // 
            // T2Index
            // 
            this.T2Index.AutoSize = true;
            this.T2Index.Location = new System.Drawing.Point(687, 622);
            this.T2Index.Name = "T2Index";
            this.T2Index.Size = new System.Drawing.Size(0, 15);
            this.T2Index.TabIndex = 10;
            // 
            // Annot1Index
            // 
            this.Annot1Index.AutoSize = true;
            this.Annot1Index.Location = new System.Drawing.Point(305, 301);
            this.Annot1Index.Name = "Annot1Index";
            this.Annot1Index.Size = new System.Drawing.Size(0, 15);
            this.Annot1Index.TabIndex = 11;
            // 
            // Annot2Index
            // 
            this.Annot2Index.AutoSize = true;
            this.Annot2Index.Location = new System.Drawing.Point(688, 301);
            this.Annot2Index.Name = "Annot2Index";
            this.Annot2Index.Size = new System.Drawing.Size(0, 15);
            this.Annot2Index.TabIndex = 12;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(1030, 560);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(87, 23);
            this.ClearButton.TabIndex = 13;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(1132, 562);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(87, 23);
            this.ConfirmButton.TabIndex = 14;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // savePathDisplay
            // 
            this.savePathDisplay.AutoSize = true;
            this.savePathDisplay.Location = new System.Drawing.Point(1024, 590);
            this.savePathDisplay.Name = "savePathDisplay";
            this.savePathDisplay.Size = new System.Drawing.Size(55, 15);
            this.savePathDisplay.TabIndex = 15;
            this.savePathDisplay.Text = "label1";
            // 
            // Question1
            // 
            this.Question1.AutoSize = true;
            this.Question1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Question1.Location = new System.Drawing.Point(768, 235);
            this.Question1.Name = "Question1";
            this.Question1.Size = new System.Drawing.Size(176, 38);
            this.Question1.TabIndex = 16;
            this.Question1.Text = "Segmentaition quality \r\noverall";
            // 
            // Question2
            // 
            this.Question2.AutoSize = true;
            this.Question2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Question2.Location = new System.Drawing.Point(1035, 235);
            this.Question2.Name = "Question2";
            this.Question2.Size = new System.Drawing.Size(170, 38);
            this.Question2.TabIndex = 17;
            this.Question2.Text = "Segmentation quality \r\nintra-canal";
            // 
            // Question3
            // 
            this.Question3.AutoSize = true;
            this.Question3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Question3.Location = new System.Drawing.Point(768, 438);
            this.Question3.Name = "Question3";
            this.Question3.Size = new System.Drawing.Size(170, 38);
            this.Question3.TabIndex = 18;
            this.Question3.Text = "Segmentation quality \r\nextra-canal";
            // 
            // Q1R1
            // 
            this.Q1R1.AutoSize = true;
            this.Q1R1.Location = new System.Drawing.Point(6, 19);
            this.Q1R1.Name = "Q1R1";
            this.Q1R1.Size = new System.Drawing.Size(148, 19);
            this.Q1R1.TabIndex = 19;
            this.Q1R1.TabStop = true;
            this.Q1R1.Text = "1 better than 2";
            this.Q1R1.UseVisualStyleBackColor = true;
            // 
            // Q1Box
            // 
            this.Q1Box.Controls.Add(this.Q1R5);
            this.Q1Box.Controls.Add(this.Q1R4);
            this.Q1Box.Controls.Add(this.Q1R3);
            this.Q1Box.Controls.Add(this.Q1R2);
            this.Q1Box.Controls.Add(this.Q1R1);
            this.Q1Box.Location = new System.Drawing.Point(766, 276);
            this.Q1Box.Name = "Q1Box";
            this.Q1Box.Size = new System.Drawing.Size(225, 159);
            this.Q1Box.TabIndex = 20;
            this.Q1Box.TabStop = false;
            // 
            // Q1R5
            // 
            this.Q1R5.AutoSize = true;
            this.Q1R5.Location = new System.Drawing.Point(6, 121);
            this.Q1R5.Name = "Q1R5";
            this.Q1R5.Size = new System.Drawing.Size(140, 19);
            this.Q1R5.TabIndex = 23;
            this.Q1R5.TabStop = true;
            this.Q1R5.Text = "2 satisfactory";
            this.Q1R5.UseVisualStyleBackColor = true;
            // 
            // Q1R4
            // 
            this.Q1R4.AutoSize = true;
            this.Q1R4.Location = new System.Drawing.Point(6, 95);
            this.Q1R4.Name = "Q1R4";
            this.Q1R4.Size = new System.Drawing.Size(140, 19);
            this.Q1R4.TabIndex = 22;
            this.Q1R4.TabStop = true;
            this.Q1R4.Text = "1 satisfactory";
            this.Q1R4.UseVisualStyleBackColor = true;
            // 
            // Q1R3
            // 
            this.Q1R3.AutoSize = true;
            this.Q1R3.Location = new System.Drawing.Point(6, 69);
            this.Q1R3.Name = "Q1R3";
            this.Q1R3.Size = new System.Drawing.Size(172, 19);
            this.Q1R3.TabIndex = 21;
            this.Q1R3.TabStop = true;
            this.Q1R3.Text = "1 and 2 comparable";
            this.Q1R3.UseVisualStyleBackColor = true;
            // 
            // Q1R2
            // 
            this.Q1R2.AutoSize = true;
            this.Q1R2.Location = new System.Drawing.Point(6, 44);
            this.Q1R2.Name = "Q1R2";
            this.Q1R2.Size = new System.Drawing.Size(148, 19);
            this.Q1R2.TabIndex = 20;
            this.Q1R2.TabStop = true;
            this.Q1R2.Text = "2 better than 1";
            this.Q1R2.UseVisualStyleBackColor = true;
            // 
            // Q3Box
            // 
            this.Q3Box.Controls.Add(this.Q3R5);
            this.Q3Box.Controls.Add(this.Q3R4);
            this.Q3Box.Controls.Add(this.Q3R3);
            this.Q3Box.Controls.Add(this.Q3R2);
            this.Q3Box.Controls.Add(this.Q3R1);
            this.Q3Box.Location = new System.Drawing.Point(766, 479);
            this.Q3Box.Name = "Q3Box";
            this.Q3Box.Size = new System.Drawing.Size(225, 159);
            this.Q3Box.TabIndex = 21;
            this.Q3Box.TabStop = false;
            // 
            // Q3R5
            // 
            this.Q3R5.AutoSize = true;
            this.Q3R5.Location = new System.Drawing.Point(6, 121);
            this.Q3R5.Name = "Q3R5";
            this.Q3R5.Size = new System.Drawing.Size(140, 19);
            this.Q3R5.TabIndex = 23;
            this.Q3R5.TabStop = true;
            this.Q3R5.Text = "2 satisfactory";
            this.Q3R5.UseVisualStyleBackColor = true;
            // 
            // Q3R4
            // 
            this.Q3R4.AutoSize = true;
            this.Q3R4.Location = new System.Drawing.Point(6, 95);
            this.Q3R4.Name = "Q3R4";
            this.Q3R4.Size = new System.Drawing.Size(140, 19);
            this.Q3R4.TabIndex = 22;
            this.Q3R4.TabStop = true;
            this.Q3R4.Text = "1 satisfactory";
            this.Q3R4.UseVisualStyleBackColor = true;
            // 
            // Q3R3
            // 
            this.Q3R3.AutoSize = true;
            this.Q3R3.Location = new System.Drawing.Point(6, 69);
            this.Q3R3.Name = "Q3R3";
            this.Q3R3.Size = new System.Drawing.Size(172, 19);
            this.Q3R3.TabIndex = 21;
            this.Q3R3.TabStop = true;
            this.Q3R3.Text = "1 and 2 comparable";
            this.Q3R3.UseVisualStyleBackColor = true;
            // 
            // Q3R2
            // 
            this.Q3R2.AutoSize = true;
            this.Q3R2.Location = new System.Drawing.Point(6, 44);
            this.Q3R2.Name = "Q3R2";
            this.Q3R2.Size = new System.Drawing.Size(148, 19);
            this.Q3R2.TabIndex = 20;
            this.Q3R2.TabStop = true;
            this.Q3R2.Text = "2 better than 1";
            this.Q3R2.UseVisualStyleBackColor = true;
            // 
            // Q3R1
            // 
            this.Q3R1.AutoSize = true;
            this.Q3R1.Location = new System.Drawing.Point(6, 19);
            this.Q3R1.Name = "Q3R1";
            this.Q3R1.Size = new System.Drawing.Size(148, 19);
            this.Q3R1.TabIndex = 19;
            this.Q3R1.TabStop = true;
            this.Q3R1.Text = "1 better than 2";
            this.Q3R1.UseVisualStyleBackColor = true;
            // 
            // Q2Box
            // 
            this.Q2Box.Controls.Add(this.Q2R5);
            this.Q2Box.Controls.Add(this.Q2R4);
            this.Q2Box.Controls.Add(this.Q2R3);
            this.Q2Box.Controls.Add(this.Q2R2);
            this.Q2Box.Controls.Add(this.Q2R1);
            this.Q2Box.Location = new System.Drawing.Point(1021, 276);
            this.Q2Box.Name = "Q2Box";
            this.Q2Box.Size = new System.Drawing.Size(225, 159);
            this.Q2Box.TabIndex = 22;
            this.Q2Box.TabStop = false;
            // 
            // Q2R5
            // 
            this.Q2R5.AutoSize = true;
            this.Q2R5.Location = new System.Drawing.Point(6, 121);
            this.Q2R5.Name = "Q2R5";
            this.Q2R5.Size = new System.Drawing.Size(132, 19);
            this.Q2R5.TabIndex = 23;
            this.Q2R5.TabStop = true;
            this.Q2R5.Text = "2 satisfacory";
            this.Q2R5.UseVisualStyleBackColor = true;
            // 
            // Q2R4
            // 
            this.Q2R4.AutoSize = true;
            this.Q2R4.Location = new System.Drawing.Point(6, 95);
            this.Q2R4.Name = "Q2R4";
            this.Q2R4.Size = new System.Drawing.Size(140, 19);
            this.Q2R4.TabIndex = 22;
            this.Q2R4.TabStop = true;
            this.Q2R4.Text = "1 satisfactory";
            this.Q2R4.UseVisualStyleBackColor = true;
            // 
            // Q2R3
            // 
            this.Q2R3.AutoSize = true;
            this.Q2R3.Location = new System.Drawing.Point(6, 69);
            this.Q2R3.Name = "Q2R3";
            this.Q2R3.Size = new System.Drawing.Size(164, 19);
            this.Q2R3.TabIndex = 21;
            this.Q2R3.TabStop = true;
            this.Q2R3.Text = "1 and 2 coparable";
            this.Q2R3.UseVisualStyleBackColor = true;
            // 
            // Q2R2
            // 
            this.Q2R2.AutoSize = true;
            this.Q2R2.Location = new System.Drawing.Point(6, 44);
            this.Q2R2.Name = "Q2R2";
            this.Q2R2.Size = new System.Drawing.Size(148, 19);
            this.Q2R2.TabIndex = 20;
            this.Q2R2.TabStop = true;
            this.Q2R2.Text = "2 better than 1";
            this.Q2R2.UseVisualStyleBackColor = true;
            // 
            // Q2R1
            // 
            this.Q2R1.AutoSize = true;
            this.Q2R1.Location = new System.Drawing.Point(6, 19);
            this.Q2R1.Name = "Q2R1";
            this.Q2R1.Size = new System.Drawing.Size(148, 19);
            this.Q2R1.TabIndex = 19;
            this.Q2R1.TabStop = true;
            this.Q2R1.Text = "1 better than 2";
            this.Q2R1.UseVisualStyleBackColor = true;
            // 
            // PreviousButton
            // 
            this.PreviousButton.Location = new System.Drawing.Point(1030, 516);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(87, 23);
            this.PreviousButton.TabIndex = 23;
            this.PreviousButton.Text = "Previous";
            this.PreviousButton.UseVisualStyleBackColor = true;
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(1132, 516);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(87, 23);
            this.NextButton.TabIndex = 24;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            // 
            // ContrastReset
            // 
            this.ContrastReset.Location = new System.Drawing.Point(921, 99);
            this.ContrastReset.Name = "ContrastReset";
            this.ContrastReset.Size = new System.Drawing.Size(75, 23);
            this.ContrastReset.TabIndex = 25;
            this.ContrastReset.Text = "Reset";
            this.ContrastReset.UseVisualStyleBackColor = true;
            this.ContrastReset.Click += new System.EventHandler(this.ContrastReset_Click);
            // 
            // ContrastScrollbar
            // 
            this.ContrastScrollbar.Cursor = System.Windows.Forms.Cursors.Default;
            this.ContrastScrollbar.Location = new System.Drawing.Point(772, 68);
            this.ContrastScrollbar.Maximum = 108;
            this.ContrastScrollbar.Name = "ContrastScrollbar";
            this.ContrastScrollbar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ContrastScrollbar.Size = new System.Drawing.Size(224, 28);
            this.ContrastScrollbar.TabIndex = 26;
            this.ContrastScrollbar.Value = 50;
            this.ContrastScrollbar.ValueChanged += new System.EventHandler(this.Contrast_ValueChanged);
            // 
            // ContrastLabel
            // 
            this.ContrastLabel.AutoSize = true;
            this.ContrastLabel.Location = new System.Drawing.Point(769, 31);
            this.ContrastLabel.Name = "ContrastLabel";
            this.ContrastLabel.Size = new System.Drawing.Size(71, 15);
            this.ContrastLabel.TabIndex = 27;
            this.ContrastLabel.Text = "Contrast";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1049, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 28;
            this.label1.Text = "Brightness";
            // 
            // BrightnessScrollbar
            // 
            this.BrightnessScrollbar.Cursor = System.Windows.Forms.Cursors.Default;
            this.BrightnessScrollbar.Location = new System.Drawing.Point(1022, 68);
            this.BrightnessScrollbar.Maximum = 108;
            this.BrightnessScrollbar.Name = "BrightnessScrollbar";
            this.BrightnessScrollbar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BrightnessScrollbar.Size = new System.Drawing.Size(224, 28);
            this.BrightnessScrollbar.TabIndex = 29;
            this.BrightnessScrollbar.Value = 50;
            this.BrightnessScrollbar.ValueChanged += new System.EventHandler(this.Brightness_ValueChanged);
            // 
            // BrightnessReset
            // 
            this.BrightnessReset.Location = new System.Drawing.Point(1171, 99);
            this.BrightnessReset.Name = "BrightnessReset";
            this.BrightnessReset.Size = new System.Drawing.Size(75, 23);
            this.BrightnessReset.TabIndex = 30;
            this.BrightnessReset.Text = "Reset";
            this.BrightnessReset.UseVisualStyleBackColor = true;
            this.BrightnessReset.Click += new System.EventHandler(this.BrightnessReset_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(774, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 33;
            this.label2.Text = "Backup1";
            // 
            // hScrollBar2
            // 
            this.hScrollBar2.Cursor = System.Windows.Forms.Cursors.Default;
            this.hScrollBar2.Location = new System.Drawing.Point(772, 174);
            this.hScrollBar2.Name = "hScrollBar2";
            this.hScrollBar2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.hScrollBar2.Size = new System.Drawing.Size(224, 28);
            this.hScrollBar2.TabIndex = 32;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(921, 205);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 31;
            this.button3.Text = "Reset";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1024, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 36;
            this.label3.Text = "Backup2";
            // 
            // hScrollBar3
            // 
            this.hScrollBar3.Cursor = System.Windows.Forms.Cursors.Default;
            this.hScrollBar3.Location = new System.Drawing.Point(1022, 174);
            this.hScrollBar3.Name = "hScrollBar3";
            this.hScrollBar3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.hScrollBar3.Size = new System.Drawing.Size(224, 28);
            this.hScrollBar3.TabIndex = 35;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1171, 205);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 34;
            this.button4.Text = "Reset";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // ContrastMonitor
            // 
            this.ContrastMonitor.AutoSize = true;
            this.ContrastMonitor.Location = new System.Drawing.Point(944, 48);
            this.ContrastMonitor.Name = "ContrastMonitor";
            this.ContrastMonitor.Size = new System.Drawing.Size(23, 15);
            this.ContrastMonitor.TabIndex = 37;
            this.ContrastMonitor.Text = "50";
            // 
            // BrightnessMonitor
            // 
            this.BrightnessMonitor.AutoSize = true;
            this.BrightnessMonitor.Location = new System.Drawing.Point(1196, 48);
            this.BrightnessMonitor.Name = "BrightnessMonitor";
            this.BrightnessMonitor.Size = new System.Drawing.Size(23, 15);
            this.BrightnessMonitor.TabIndex = 38;
            this.BrightnessMonitor.Text = "50";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 652);
            this.Controls.Add(this.BrightnessMonitor);
            this.Controls.Add(this.ContrastMonitor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hScrollBar3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hScrollBar2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BrightnessReset);
            this.Controls.Add(this.BrightnessScrollbar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ContrastLabel);
            this.Controls.Add(this.ContrastScrollbar);
            this.Controls.Add(this.ContrastReset);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.PreviousButton);
            this.Controls.Add(this.Q2Box);
            this.Controls.Add(this.Q3Box);
            this.Controls.Add(this.Q1Box);
            this.Controls.Add(this.Question3);
            this.Controls.Add(this.Question2);
            this.Controls.Add(this.Question1);
            this.Controls.Add(this.savePathDisplay);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.Annot2Index);
            this.Controls.Add(this.Annot1Index);
            this.Controls.Add(this.T2Index);
            this.Controls.Add(this.T1Index);
            this.Controls.Add(this.OriT2);
            this.Controls.Add(this.Annotation2);
            this.Controls.Add(this.OriT1);
            this.Controls.Add(this.Annotation1);
            this.Controls.Add(this.T2ScrollBar);
            this.Controls.Add(this.T1ScrollBar);
            this.Controls.Add(this.Annot2ScrollBar);
            this.Controls.Add(this.Annot1ScrollBar);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "SegViewer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Annotation1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OriT1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Annotation2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OriT2)).EndInit();
            this.Q1Box.ResumeLayout(false);
            this.Q1Box.PerformLayout();
            this.Q3Box.ResumeLayout(false);
            this.Q3Box.PerformLayout();
            this.Q2Box.ResumeLayout(false);
            this.Q2Box.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar Annot1ScrollBar;
        private System.Windows.Forms.HScrollBar Annot2ScrollBar;
        private System.Windows.Forms.HScrollBar T1ScrollBar;
        private System.Windows.Forms.HScrollBar T2ScrollBar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem T1MRIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem T2MRIToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem annotation1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem annotation2ToolStripMenuItem;
        private System.Windows.Forms.PictureBox Annotation1;
        private System.Windows.Forms.PictureBox OriT1;
        private System.Windows.Forms.PictureBox Annotation2;
        private System.Windows.Forms.PictureBox OriT2;
        private System.Windows.Forms.Label T1Index;
        private System.Windows.Forms.Label T2Index;
        private System.Windows.Forms.Label Annot1Index;
        private System.Windows.Forms.Label Annot2Index;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Label savePathDisplay;
        private System.Windows.Forms.Label Question1;
        private System.Windows.Forms.Label Question2;
        private System.Windows.Forms.Label Question3;
        private System.Windows.Forms.RadioButton Q1R1;
        private System.Windows.Forms.GroupBox Q1Box;
        private System.Windows.Forms.RadioButton Q1R5;
        private System.Windows.Forms.RadioButton Q1R4;
        private System.Windows.Forms.RadioButton Q1R3;
        private System.Windows.Forms.RadioButton Q1R2;
        private System.Windows.Forms.GroupBox Q3Box;
        private System.Windows.Forms.RadioButton Q3R5;
        private System.Windows.Forms.RadioButton Q3R4;
        private System.Windows.Forms.RadioButton Q3R3;
        private System.Windows.Forms.RadioButton Q3R2;
        private System.Windows.Forms.RadioButton Q3R1;
        private System.Windows.Forms.GroupBox Q2Box;
        private System.Windows.Forms.RadioButton Q2R5;
        private System.Windows.Forms.RadioButton Q2R4;
        private System.Windows.Forms.RadioButton Q2R3;
        private System.Windows.Forms.RadioButton Q2R2;
        private System.Windows.Forms.RadioButton Q2R1;
        private System.Windows.Forms.Button PreviousButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button ContrastReset;
        private System.Windows.Forms.HScrollBar ContrastScrollbar;
        private System.Windows.Forms.Label ContrastLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.HScrollBar BrightnessScrollbar;
        private System.Windows.Forms.Button BrightnessReset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.HScrollBar hScrollBar2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.HScrollBar hScrollBar3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label ContrastMonitor;
        private System.Windows.Forms.Label BrightnessMonitor;
    }
}

