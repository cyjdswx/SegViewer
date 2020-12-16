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
            this.saveInfoDisplay = new System.Windows.Forms.Label();
            this.Question1 = new System.Windows.Forms.Label();
            this.Question2 = new System.Windows.Forms.Label();
            this.Question3 = new System.Windows.Forms.Label();
            this.Q1R1 = new System.Windows.Forms.RadioButton();
            this.Q1Box = new System.Windows.Forms.GroupBox();
            this.Q1R2 = new System.Windows.Forms.RadioButton();
            this.Q1R3 = new System.Windows.Forms.RadioButton();
            this.Q1C1 = new System.Windows.Forms.CheckBox();
            this.Q1C2 = new System.Windows.Forms.CheckBox();
            this.Q3Box = new System.Windows.Forms.GroupBox();
            this.Q3R1 = new System.Windows.Forms.RadioButton();
            this.Q3R2 = new System.Windows.Forms.RadioButton();
            this.Q3R3 = new System.Windows.Forms.RadioButton();
            this.Q3C1 = new System.Windows.Forms.CheckBox();
            this.Q3C2 = new System.Windows.Forms.CheckBox();
            this.Q2Box = new System.Windows.Forms.GroupBox();
            this.Q2R1 = new System.Windows.Forms.RadioButton();
            this.Q2R2 = new System.Windows.Forms.RadioButton();
            this.Q2R3 = new System.Windows.Forms.RadioButton();
            this.Q2C1 = new System.Windows.Forms.CheckBox();
            this.Q2C2 = new System.Windows.Forms.CheckBox();
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
            this.synCheck = new System.Windows.Forms.CheckBox();
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
            this.Annot1ScrollBar.Location = new System.Drawing.Point(71, 313);
            this.Annot1ScrollBar.Name = "Annot1ScrollBar";
            this.Annot1ScrollBar.Size = new System.Drawing.Size(232, 28);
            this.Annot1ScrollBar.TabIndex = 0;
            this.Annot1ScrollBar.ValueChanged += new System.EventHandler(this.A1ScrollBar_ValueChanged);
            // 
            // Annot2ScrollBar
            // 
            this.Annot2ScrollBar.Location = new System.Drawing.Point(457, 313);
            this.Annot2ScrollBar.Name = "Annot2ScrollBar";
            this.Annot2ScrollBar.Size = new System.Drawing.Size(232, 28);
            this.Annot2ScrollBar.TabIndex = 1;
            this.Annot2ScrollBar.ValueChanged += new System.EventHandler(this.A2ScrollBar_ValueChanged);
            // 
            // T1ScrollBar
            // 
            this.T1ScrollBar.Location = new System.Drawing.Point(73, 655);
            this.T1ScrollBar.Name = "T1ScrollBar";
            this.T1ScrollBar.Size = new System.Drawing.Size(232, 28);
            this.T1ScrollBar.TabIndex = 2;
            this.T1ScrollBar.ValueChanged += new System.EventHandler(this.T1ScrollBar_ValueChanged);
            // 
            // T2ScrollBar
            // 
            this.T2ScrollBar.Location = new System.Drawing.Point(457, 655);
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1360, 30);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
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
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // T1MRIToolStripMenuItem
            // 
            this.T1MRIToolStripMenuItem.Name = "T1MRIToolStripMenuItem";
            this.T1MRIToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.T1MRIToolStripMenuItem.Text = "T1 MRI";
            this.T1MRIToolStripMenuItem.Click += new System.EventHandler(this.T1MRIToolStripMenuItem_Click);
            // 
            // T2MRIToolStripMenuItem1
            // 
            this.T2MRIToolStripMenuItem1.Name = "T2MRIToolStripMenuItem1";
            this.T2MRIToolStripMenuItem1.Size = new System.Drawing.Size(174, 26);
            this.T2MRIToolStripMenuItem1.Text = "T2 MRI";
            this.T2MRIToolStripMenuItem1.Click += new System.EventHandler(this.T2MRIToolStripMenuItem1_Click);
            // 
            // annotation1ToolStripMenuItem
            // 
            this.annotation1ToolStripMenuItem.Name = "annotation1ToolStripMenuItem";
            this.annotation1ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.annotation1ToolStripMenuItem.Text = "Annotation1";
            this.annotation1ToolStripMenuItem.Click += new System.EventHandler(this.annotation1ToolStripMenuItem_Click);
            // 
            // annotation2ToolStripMenuItem
            // 
            this.annotation2ToolStripMenuItem.Name = "annotation2ToolStripMenuItem";
            this.annotation2ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.annotation2ToolStripMenuItem.Text = "Annotation2";
            this.annotation2ToolStripMenuItem.Click += new System.EventHandler(this.annotation2ToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Annotation1
            // 
            this.Annotation1.BackColor = System.Drawing.Color.Black;
            this.Annotation1.Location = new System.Drawing.Point(24, 33);
            this.Annotation1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Annotation1.Name = "Annotation1";
            this.Annotation1.Size = new System.Drawing.Size(336, 276);
            this.Annotation1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Annotation1.TabIndex = 5;
            this.Annotation1.TabStop = false;
            // 
            // OriT1
            // 
            this.OriT1.BackColor = System.Drawing.Color.Black;
            this.OriT1.Location = new System.Drawing.Point(24, 375);
            this.OriT1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OriT1.Name = "OriT1";
            this.OriT1.Size = new System.Drawing.Size(336, 276);
            this.OriT1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OriT1.TabIndex = 6;
            this.OriT1.TabStop = false;
            // 
            // Annotation2
            // 
            this.Annotation2.BackColor = System.Drawing.Color.Black;
            this.Annotation2.Location = new System.Drawing.Point(405, 33);
            this.Annotation2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Annotation2.Name = "Annotation2";
            this.Annotation2.Size = new System.Drawing.Size(336, 276);
            this.Annotation2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Annotation2.TabIndex = 7;
            this.Annotation2.TabStop = false;
            // 
            // OriT2
            // 
            this.OriT2.BackColor = System.Drawing.Color.Black;
            this.OriT2.Location = new System.Drawing.Point(405, 375);
            this.OriT2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OriT2.Name = "OriT2";
            this.OriT2.Size = new System.Drawing.Size(336, 276);
            this.OriT2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OriT2.TabIndex = 8;
            this.OriT2.TabStop = false;
            // 
            // T1Index
            // 
            this.T1Index.AutoSize = true;
            this.T1Index.Location = new System.Drawing.Point(305, 663);
            this.T1Index.Name = "T1Index";
            this.T1Index.Size = new System.Drawing.Size(0, 17);
            this.T1Index.TabIndex = 9;
            // 
            // T2Index
            // 
            this.T2Index.AutoSize = true;
            this.T2Index.Location = new System.Drawing.Point(687, 663);
            this.T2Index.Name = "T2Index";
            this.T2Index.Size = new System.Drawing.Size(0, 17);
            this.T2Index.TabIndex = 10;
            // 
            // Annot1Index
            // 
            this.Annot1Index.AutoSize = true;
            this.Annot1Index.Location = new System.Drawing.Point(305, 321);
            this.Annot1Index.Name = "Annot1Index";
            this.Annot1Index.Size = new System.Drawing.Size(0, 17);
            this.Annot1Index.TabIndex = 11;
            // 
            // Annot2Index
            // 
            this.Annot2Index.AutoSize = true;
            this.Annot2Index.Location = new System.Drawing.Point(688, 321);
            this.Annot2Index.Name = "Annot2Index";
            this.Annot2Index.Size = new System.Drawing.Size(0, 17);
            this.Annot2Index.TabIndex = 12;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(1092, 606);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(87, 25);
            this.ClearButton.TabIndex = 13;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(1236, 606);
            this.ConfirmButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(87, 25);
            this.ConfirmButton.TabIndex = 14;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // saveInfoDisplay
            // 
            this.saveInfoDisplay.AutoSize = true;
            this.saveInfoDisplay.ForeColor = System.Drawing.Color.Green;
            this.saveInfoDisplay.Location = new System.Drawing.Point(1079, 635);
            this.saveInfoDisplay.MaximumSize = new System.Drawing.Size(267, 123);
            this.saveInfoDisplay.Name = "saveInfoDisplay";
            this.saveInfoDisplay.Size = new System.Drawing.Size(98, 17);
            this.saveInfoDisplay.TabIndex = 15;
            this.saveInfoDisplay.Text = "Ready to write";
            // 
            // Question1
            // 
            this.Question1.AutoSize = true;
            this.Question1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Question1.Location = new System.Drawing.Point(777, 262);
            this.Question1.Name = "Question1";
            this.Question1.Size = new System.Drawing.Size(176, 38);
            this.Question1.TabIndex = 16;
            this.Question1.Text = "Segmentaition quality \r\noverall";
            // 
            // Question2
            // 
            this.Question2.AutoSize = true;
            this.Question2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Question2.Location = new System.Drawing.Point(1068, 262);
            this.Question2.Name = "Question2";
            this.Question2.Size = new System.Drawing.Size(170, 38);
            this.Question2.TabIndex = 17;
            this.Question2.Text = "Segmentation quality \r\nintra-canal";
            // 
            // Question3
            // 
            this.Question3.AutoSize = true;
            this.Question3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Question3.Location = new System.Drawing.Point(777, 487);
            this.Question3.Name = "Question3";
            this.Question3.Size = new System.Drawing.Size(170, 38);
            this.Question3.TabIndex = 18;
            this.Question3.Text = "Segmentation quality \r\nextra-canal";
            // 
            // Q1R1
            // 
            this.Q1R1.AutoSize = true;
            this.Q1R1.Location = new System.Drawing.Point(5, 20);
            this.Q1R1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Q1R1.Name = "Q1R1";
            this.Q1R1.Size = new System.Drawing.Size(122, 21);
            this.Q1R1.TabIndex = 19;
            this.Q1R1.TabStop = true;
            this.Q1R1.Text = "1 better than 2";
            this.Q1R1.UseVisualStyleBackColor = true;
            // 
            // Q1Box
            // 
            this.Q1Box.Controls.Add(this.Q1R1);
            this.Q1Box.Controls.Add(this.Q1R2);
            this.Q1Box.Controls.Add(this.Q1R3);
            this.Q1Box.Controls.Add(this.Q1C1);
            this.Q1Box.Controls.Add(this.Q1C2);
            this.Q1Box.Location = new System.Drawing.Point(771, 313);
            this.Q1Box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Q1Box.Name = "Q1Box";
            this.Q1Box.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Q1Box.Size = new System.Drawing.Size(292, 145);
            this.Q1Box.TabIndex = 20;
            this.Q1Box.TabStop = false;
            // 
            // Q1R2
            // 
            this.Q1R2.AutoSize = true;
            this.Q1R2.Location = new System.Drawing.Point(5, 47);
            this.Q1R2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Q1R2.Name = "Q1R2";
            this.Q1R2.Size = new System.Drawing.Size(122, 21);
            this.Q1R2.TabIndex = 20;
            this.Q1R2.TabStop = true;
            this.Q1R2.Text = "2 better than 1";
            this.Q1R2.UseVisualStyleBackColor = true;
            // 
            // Q1R3
            // 
            this.Q1R3.AutoSize = true;
            this.Q1R3.Location = new System.Drawing.Point(5, 74);
            this.Q1R3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Q1R3.Name = "Q1R3";
            this.Q1R3.Size = new System.Drawing.Size(155, 21);
            this.Q1R3.TabIndex = 21;
            this.Q1R3.TabStop = true;
            this.Q1R3.Text = "1 and 2 comparable";
            this.Q1R3.UseVisualStyleBackColor = true;
            // 
            // Q1C1
            // 
            this.Q1C1.AutoSize = true;
            this.Q1C1.Location = new System.Drawing.Point(4, 113);
            this.Q1C1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Q1C1.Name = "Q1C1";
            this.Q1C1.Size = new System.Drawing.Size(114, 21);
            this.Q1C1.TabIndex = 39;
            this.Q1C1.Text = "1 satisfactory";
            this.Q1C1.UseVisualStyleBackColor = true;
            // 
            // Q1C2
            // 
            this.Q1C2.AutoSize = true;
            this.Q1C2.Location = new System.Drawing.Point(141, 113);
            this.Q1C2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Q1C2.Name = "Q1C2";
            this.Q1C2.Size = new System.Drawing.Size(114, 21);
            this.Q1C2.TabIndex = 40;
            this.Q1C2.Text = "2 satisfactory";
            this.Q1C2.UseVisualStyleBackColor = true;
            // 
            // Q3Box
            // 
            this.Q3Box.Controls.Add(this.Q3R1);
            this.Q3Box.Controls.Add(this.Q3R2);
            this.Q3Box.Controls.Add(this.Q3R3);
            this.Q3Box.Controls.Add(this.Q3C1);
            this.Q3Box.Controls.Add(this.Q3C2);
            this.Q3Box.Location = new System.Drawing.Point(771, 540);
            this.Q3Box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Q3Box.Name = "Q3Box";
            this.Q3Box.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Q3Box.Size = new System.Drawing.Size(292, 142);
            this.Q3Box.TabIndex = 21;
            this.Q3Box.TabStop = false;
            // 
            // Q3R1
            // 
            this.Q3R1.AutoSize = true;
            this.Q3R1.Location = new System.Drawing.Point(5, 20);
            this.Q3R1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Q3R1.Name = "Q3R1";
            this.Q3R1.Size = new System.Drawing.Size(122, 21);
            this.Q3R1.TabIndex = 19;
            this.Q3R1.TabStop = true;
            this.Q3R1.Text = "1 better than 2";
            this.Q3R1.UseVisualStyleBackColor = true;
            // 
            // Q3R2
            // 
            this.Q3R2.AutoSize = true;
            this.Q3R2.Location = new System.Drawing.Point(5, 47);
            this.Q3R2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Q3R2.Name = "Q3R2";
            this.Q3R2.Size = new System.Drawing.Size(122, 21);
            this.Q3R2.TabIndex = 20;
            this.Q3R2.TabStop = true;
            this.Q3R2.Text = "2 better than 1";
            this.Q3R2.UseVisualStyleBackColor = true;
            // 
            // Q3R3
            // 
            this.Q3R3.AutoSize = true;
            this.Q3R3.Location = new System.Drawing.Point(4, 78);
            this.Q3R3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Q3R3.Name = "Q3R3";
            this.Q3R3.Size = new System.Drawing.Size(155, 21);
            this.Q3R3.TabIndex = 21;
            this.Q3R3.TabStop = true;
            this.Q3R3.Text = "1 and 2 comparable";
            this.Q3R3.UseVisualStyleBackColor = true;
            // 
            // Q3C1
            // 
            this.Q3C1.AutoSize = true;
            this.Q3C1.Location = new System.Drawing.Point(4, 107);
            this.Q3C1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Q3C1.Name = "Q3C1";
            this.Q3C1.Size = new System.Drawing.Size(114, 21);
            this.Q3C1.TabIndex = 43;
            this.Q3C1.Text = "1 satisfactory";
            this.Q3C1.UseVisualStyleBackColor = true;
            // 
            // Q3C2
            // 
            this.Q3C2.AutoSize = true;
            this.Q3C2.Location = new System.Drawing.Point(141, 108);
            this.Q3C2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Q3C2.Name = "Q3C2";
            this.Q3C2.Size = new System.Drawing.Size(114, 21);
            this.Q3C2.TabIndex = 44;
            this.Q3C2.Text = "2 satisfactory";
            this.Q3C2.UseVisualStyleBackColor = true;
            // 
            // Q2Box
            // 
            this.Q2Box.Controls.Add(this.Q2R1);
            this.Q2Box.Controls.Add(this.Q2R2);
            this.Q2Box.Controls.Add(this.Q2R3);
            this.Q2Box.Controls.Add(this.Q2C1);
            this.Q2Box.Controls.Add(this.Q2C2);
            this.Q2Box.Location = new System.Drawing.Point(1068, 313);
            this.Q2Box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Q2Box.Name = "Q2Box";
            this.Q2Box.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Q2Box.Size = new System.Drawing.Size(277, 145);
            this.Q2Box.TabIndex = 22;
            this.Q2Box.TabStop = false;
            // 
            // Q2R1
            // 
            this.Q2R1.AutoSize = true;
            this.Q2R1.Location = new System.Drawing.Point(5, 20);
            this.Q2R1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Q2R1.Name = "Q2R1";
            this.Q2R1.Size = new System.Drawing.Size(122, 21);
            this.Q2R1.TabIndex = 19;
            this.Q2R1.TabStop = true;
            this.Q2R1.Text = "1 better than 2";
            this.Q2R1.UseVisualStyleBackColor = true;
            // 
            // Q2R2
            // 
            this.Q2R2.AutoSize = true;
            this.Q2R2.Location = new System.Drawing.Point(5, 47);
            this.Q2R2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Q2R2.Name = "Q2R2";
            this.Q2R2.Size = new System.Drawing.Size(122, 21);
            this.Q2R2.TabIndex = 20;
            this.Q2R2.TabStop = true;
            this.Q2R2.Text = "2 better than 1";
            this.Q2R2.UseVisualStyleBackColor = true;
            // 
            // Q2R3
            // 
            this.Q2R3.AutoSize = true;
            this.Q2R3.Location = new System.Drawing.Point(5, 74);
            this.Q2R3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Q2R3.Name = "Q2R3";
            this.Q2R3.Size = new System.Drawing.Size(144, 21);
            this.Q2R3.TabIndex = 21;
            this.Q2R3.TabStop = true;
            this.Q2R3.Text = "1 and 2 coparable";
            this.Q2R3.UseVisualStyleBackColor = true;
            // 
            // Q2C1
            // 
            this.Q2C1.AutoSize = true;
            this.Q2C1.Location = new System.Drawing.Point(1, 113);
            this.Q2C1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Q2C1.Name = "Q2C1";
            this.Q2C1.Size = new System.Drawing.Size(114, 21);
            this.Q2C1.TabIndex = 41;
            this.Q2C1.Text = "1 satisfactory";
            this.Q2C1.UseVisualStyleBackColor = true;
            // 
            // Q2C2
            // 
            this.Q2C2.AutoSize = true;
            this.Q2C2.Location = new System.Drawing.Point(139, 113);
            this.Q2C2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Q2C2.Name = "Q2C2";
            this.Q2C2.Size = new System.Drawing.Size(114, 21);
            this.Q2C2.TabIndex = 42;
            this.Q2C2.Text = "2 satisfactory";
            this.Q2C2.UseVisualStyleBackColor = true;
            // 
            // PreviousButton
            // 
            this.PreviousButton.Location = new System.Drawing.Point(1092, 559);
            this.PreviousButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(87, 25);
            this.PreviousButton.TabIndex = 23;
            this.PreviousButton.Text = "Previous";
            this.PreviousButton.UseVisualStyleBackColor = true;
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(1236, 559);
            this.NextButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(87, 25);
            this.NextButton.TabIndex = 24;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            // 
            // ContrastReset
            // 
            this.ContrastReset.Location = new System.Drawing.Point(969, 106);
            this.ContrastReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ContrastReset.Name = "ContrastReset";
            this.ContrastReset.Size = new System.Drawing.Size(75, 25);
            this.ContrastReset.TabIndex = 25;
            this.ContrastReset.Text = "Reset";
            this.ContrastReset.UseVisualStyleBackColor = true;
            this.ContrastReset.Click += new System.EventHandler(this.ContrastReset_Click);
            // 
            // ContrastScrollbar
            // 
            this.ContrastScrollbar.Cursor = System.Windows.Forms.Cursors.Default;
            this.ContrastScrollbar.Location = new System.Drawing.Point(771, 73);
            this.ContrastScrollbar.Maximum = 108;
            this.ContrastScrollbar.Name = "ContrastScrollbar";
            this.ContrastScrollbar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ContrastScrollbar.Size = new System.Drawing.Size(273, 24);
            this.ContrastScrollbar.TabIndex = 26;
            this.ContrastScrollbar.Value = 50;
            this.ContrastScrollbar.ValueChanged += new System.EventHandler(this.Contrast_ValueChanged);
            // 
            // ContrastLabel
            // 
            this.ContrastLabel.AutoSize = true;
            this.ContrastLabel.Location = new System.Drawing.Point(769, 33);
            this.ContrastLabel.Name = "ContrastLabel";
            this.ContrastLabel.Size = new System.Drawing.Size(61, 17);
            this.ContrastLabel.TabIndex = 27;
            this.ContrastLabel.Text = "Contrast";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1115, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Brightness";
            // 
            // BrightnessScrollbar
            // 
            this.BrightnessScrollbar.Cursor = System.Windows.Forms.Cursors.Default;
            this.BrightnessScrollbar.Location = new System.Drawing.Point(1075, 73);
            this.BrightnessScrollbar.Maximum = 108;
            this.BrightnessScrollbar.Name = "BrightnessScrollbar";
            this.BrightnessScrollbar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BrightnessScrollbar.Size = new System.Drawing.Size(273, 24);
            this.BrightnessScrollbar.TabIndex = 29;
            this.BrightnessScrollbar.Value = 50;
            this.BrightnessScrollbar.ValueChanged += new System.EventHandler(this.Brightness_ValueChanged);
            // 
            // BrightnessReset
            // 
            this.BrightnessReset.Location = new System.Drawing.Point(1276, 106);
            this.BrightnessReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BrightnessReset.Name = "BrightnessReset";
            this.BrightnessReset.Size = new System.Drawing.Size(75, 25);
            this.BrightnessReset.TabIndex = 30;
            this.BrightnessReset.Text = "Reset";
            this.BrightnessReset.UseVisualStyleBackColor = true;
            this.BrightnessReset.Click += new System.EventHandler(this.BrightnessReset_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(773, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 33;
            this.label2.Text = "Backup1";
            // 
            // hScrollBar2
            // 
            this.hScrollBar2.Cursor = System.Windows.Forms.Cursors.Default;
            this.hScrollBar2.Location = new System.Drawing.Point(753, 186);
            this.hScrollBar2.Name = "hScrollBar2";
            this.hScrollBar2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.hScrollBar2.Size = new System.Drawing.Size(291, 24);
            this.hScrollBar2.TabIndex = 32;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(969, 219);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 25);
            this.button3.TabIndex = 31;
            this.button3.Text = "Reset";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1089, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "Backup2";
            // 
            // hScrollBar3
            // 
            this.hScrollBar3.Cursor = System.Windows.Forms.Cursors.Default;
            this.hScrollBar3.Location = new System.Drawing.Point(1073, 186);
            this.hScrollBar3.Name = "hScrollBar3";
            this.hScrollBar3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.hScrollBar3.Size = new System.Drawing.Size(276, 24);
            this.hScrollBar3.TabIndex = 35;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1273, 224);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 25);
            this.button4.TabIndex = 34;
            this.button4.Text = "Reset";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // ContrastMonitor
            // 
            this.ContrastMonitor.AutoSize = true;
            this.ContrastMonitor.Location = new System.Drawing.Point(944, 52);
            this.ContrastMonitor.Name = "ContrastMonitor";
            this.ContrastMonitor.Size = new System.Drawing.Size(24, 17);
            this.ContrastMonitor.TabIndex = 37;
            this.ContrastMonitor.Text = "50";
            // 
            // BrightnessMonitor
            // 
            this.BrightnessMonitor.AutoSize = true;
            this.BrightnessMonitor.Location = new System.Drawing.Point(1261, 52);
            this.BrightnessMonitor.Name = "BrightnessMonitor";
            this.BrightnessMonitor.Size = new System.Drawing.Size(24, 17);
            this.BrightnessMonitor.TabIndex = 38;
            this.BrightnessMonitor.Text = "50";
            // 
            // synCheck
            // 
            this.synCheck.AutoSize = true;
            this.synCheck.Checked = true;
            this.synCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.synCheck.Location = new System.Drawing.Point(24, 696);
            this.synCheck.Name = "synCheck";
            this.synCheck.Size = new System.Drawing.Size(117, 21);
            this.synCheck.TabIndex = 39;
            this.synCheck.Text = "Sync scrolling";
            this.synCheck.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 729);
            this.Controls.Add(this.synCheck);
            this.Controls.Add(this.Q3Box);
            this.Controls.Add(this.Q2Box);
            this.Controls.Add(this.Q1Box);
            this.Controls.Add(this.BrightnessMonitor);
            this.Controls.Add(this.ContrastMonitor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hScrollBar3);
            this.Controls.Add(this.Question1);
            this.Controls.Add(this.Question2);
            this.Controls.Add(this.Question3);
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
            this.Controls.Add(this.saveInfoDisplay);
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
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
        private System.Windows.Forms.Label saveInfoDisplay;
        private System.Windows.Forms.Label Question1;
        private System.Windows.Forms.Label Question2;
        private System.Windows.Forms.Label Question3;
        private System.Windows.Forms.RadioButton Q1R1;
        private System.Windows.Forms.GroupBox Q1Box;
        private System.Windows.Forms.RadioButton Q1R3;
        private System.Windows.Forms.RadioButton Q1R2;
        private System.Windows.Forms.GroupBox Q3Box;
        private System.Windows.Forms.RadioButton Q3R3;
        private System.Windows.Forms.RadioButton Q3R2;
        private System.Windows.Forms.RadioButton Q3R1;
        private System.Windows.Forms.GroupBox Q2Box;
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
        private System.Windows.Forms.CheckBox Q1C1;
        private System.Windows.Forms.CheckBox Q1C2;
        private System.Windows.Forms.CheckBox Q2C1;
        private System.Windows.Forms.CheckBox Q2C2;
        private System.Windows.Forms.CheckBox Q3C1;
        private System.Windows.Forms.CheckBox Q3C2;
        private System.Windows.Forms.CheckBox synCheck;
    }
}

