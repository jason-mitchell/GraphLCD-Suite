namespace GraphLCD
{
    partial class Form2
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
            this.AcceptBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FontSizePreview = new System.Windows.Forms.PictureBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.VerticalByteMarker4 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.VerticalByteMarker3 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.VerticalByteMarker2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.HorByteMarker4 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.HorByteMarker3 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.HorByteMarker2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.HorByteMarker1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.VerticalByteMarker1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.label3 = new System.Windows.Forms.Label();
            this.ByteA = new System.Windows.Forms.Label();
            this.OriginX = new System.Windows.Forms.Label();
            this.Byte1 = new System.Windows.Forms.Label();
            this.ByteB = new System.Windows.Forms.Label();
            this.ByteC = new System.Windows.Forms.Label();
            this.ByteD = new System.Windows.Forms.Label();
            this.Byte2 = new System.Windows.Forms.Label();
            this.Byte3 = new System.Windows.Forms.Label();
            this.Byte4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SynchCheckBox = new System.Windows.Forms.CheckBox();
            this.StatusLabel2 = new System.Windows.Forms.Label();
            this.StatusLabel1 = new System.Windows.Forms.Label();
            this.StatusIcon2 = new System.Windows.Forms.PictureBox();
            this.StatusIcon1 = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NumOfCharacters = new System.Windows.Forms.NumericUpDown();
            this.UnicodeRb = new System.Windows.Forms.RadioButton();
            this.AnsiRb = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LCDVertical = new System.Windows.Forms.RadioButton();
            this.LCDHorizontal = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Baseline = new System.Windows.Forms.ComboBox();
            this.KerningEdge = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.YDimension = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.XDimension = new System.Windows.Forms.ComboBox();
            this.WarningIconImage = new System.Windows.Forms.PictureBox();
            this.WarningLabel = new System.Windows.Forms.Label();
            this.BaselineWarningIcon = new System.Windows.Forms.PictureBox();
            this.KerningWarningIcon = new System.Windows.Forms.PictureBox();
            this.FileIdent = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.FontSizeLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FontSizePreview)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StatusIcon2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusIcon1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumOfCharacters)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WarningIconImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaselineWarningIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KerningWarningIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // AcceptBtn
            // 
            this.AcceptBtn.Location = new System.Drawing.Point(649, 643);
            this.AcceptBtn.Name = "AcceptBtn";
            this.AcceptBtn.Size = new System.Drawing.Size(89, 29);
            this.AcceptBtn.TabIndex = 0;
            this.AcceptBtn.Text = "Accept";
            this.AcceptBtn.UseVisualStyleBackColor = true;
            this.AcceptBtn.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(744, 643);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(89, 29);
            this.CancelBtn.TabIndex = 1;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FontSizePreview);
            this.groupBox1.Controls.Add(this.shapeContainer1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ByteA);
            this.groupBox1.Controls.Add(this.OriginX);
            this.groupBox1.Controls.Add(this.Byte1);
            this.groupBox1.Controls.Add(this.ByteB);
            this.groupBox1.Controls.Add(this.ByteC);
            this.groupBox1.Controls.Add(this.ByteD);
            this.groupBox1.Controls.Add(this.Byte2);
            this.groupBox1.Controls.Add(this.Byte3);
            this.groupBox1.Controls.Add(this.Byte4);
            this.groupBox1.Location = new System.Drawing.Point(228, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(608, 625);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Preview";
            // 
            // FontSizePreview
            // 
            this.FontSizePreview.Location = new System.Drawing.Point(37, 40);
            this.FontSizePreview.Name = "FontSizePreview";
            this.FontSizePreview.Size = new System.Drawing.Size(565, 567);
            this.FontSizePreview.TabIndex = 0;
            this.FontSizePreview.TabStop = false;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(3, 18);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.VerticalByteMarker4,
            this.VerticalByteMarker3,
            this.VerticalByteMarker2,
            this.HorByteMarker4,
            this.HorByteMarker3,
            this.HorByteMarker2,
            this.HorByteMarker1,
            this.VerticalByteMarker1});
            this.shapeContainer1.Size = new System.Drawing.Size(602, 604);
            this.shapeContainer1.TabIndex = 4;
            this.shapeContainer1.TabStop = false;
            // 
            // VerticalByteMarker4
            // 
            this.VerticalByteMarker4.BorderColor = System.Drawing.Color.Tan;
            this.VerticalByteMarker4.FillColor = System.Drawing.Color.Tan;
            this.VerticalByteMarker4.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.VerticalByteMarker4.Location = new System.Drawing.Point(8, 442);
            this.VerticalByteMarker4.Name = "VerticalByteMarker4";
            this.VerticalByteMarker4.Size = new System.Drawing.Size(8, 121);
            // 
            // VerticalByteMarker3
            // 
            this.VerticalByteMarker3.BorderColor = System.Drawing.Color.Tan;
            this.VerticalByteMarker3.FillColor = System.Drawing.Color.Tan;
            this.VerticalByteMarker3.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.VerticalByteMarker3.Location = new System.Drawing.Point(8, 306);
            this.VerticalByteMarker3.Name = "VerticalByteMarker3";
            this.VerticalByteMarker3.Size = new System.Drawing.Size(8, 121);
            // 
            // VerticalByteMarker2
            // 
            this.VerticalByteMarker2.BorderColor = System.Drawing.Color.Tan;
            this.VerticalByteMarker2.FillColor = System.Drawing.Color.Tan;
            this.VerticalByteMarker2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.VerticalByteMarker2.Location = new System.Drawing.Point(8, 169);
            this.VerticalByteMarker2.Name = "VerticalByteMarker2";
            this.VerticalByteMarker2.Size = new System.Drawing.Size(8, 121);
            // 
            // HorByteMarker4
            // 
            this.HorByteMarker4.BorderColor = System.Drawing.Color.Tan;
            this.HorByteMarker4.FillColor = System.Drawing.Color.Tan;
            this.HorByteMarker4.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.HorByteMarker4.Location = new System.Drawing.Point(454, 1);
            this.HorByteMarker4.Name = "HorByteMarker4";
            this.HorByteMarker4.Size = new System.Drawing.Size(121, 8);
            // 
            // HorByteMarker3
            // 
            this.HorByteMarker3.BorderColor = System.Drawing.Color.Tan;
            this.HorByteMarker3.FillColor = System.Drawing.Color.Tan;
            this.HorByteMarker3.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.HorByteMarker3.Location = new System.Drawing.Point(318, 1);
            this.HorByteMarker3.Name = "HorByteMarker3";
            this.HorByteMarker3.Size = new System.Drawing.Size(121, 8);
            // 
            // HorByteMarker2
            // 
            this.HorByteMarker2.BorderColor = System.Drawing.Color.Tan;
            this.HorByteMarker2.FillColor = System.Drawing.Color.Tan;
            this.HorByteMarker2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.HorByteMarker2.Location = new System.Drawing.Point(181, 1);
            this.HorByteMarker2.Name = "HorByteMarker2";
            this.HorByteMarker2.Size = new System.Drawing.Size(121, 8);
            // 
            // HorByteMarker1
            // 
            this.HorByteMarker1.BorderColor = System.Drawing.Color.Tan;
            this.HorByteMarker1.FillColor = System.Drawing.Color.Tan;
            this.HorByteMarker1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.HorByteMarker1.Location = new System.Drawing.Point(47, 1);
            this.HorByteMarker1.Name = "HorByteMarker1";
            this.HorByteMarker1.Size = new System.Drawing.Size(121, 8);
            // 
            // VerticalByteMarker1
            // 
            this.VerticalByteMarker1.BorderColor = System.Drawing.Color.Tan;
            this.VerticalByteMarker1.FillColor = System.Drawing.Color.Tan;
            this.VerticalByteMarker1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.VerticalByteMarker1.Location = new System.Drawing.Point(8, 31);
            this.VerticalByteMarker1.Name = "VerticalByteMarker1";
            this.VerticalByteMarker1.Size = new System.Drawing.Size(8, 121);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Webdings", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label3.Location = new System.Drawing.Point(34, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "";
            // 
            // ByteA
            // 
            this.ByteA.AutoSize = true;
            this.ByteA.Font = new System.Drawing.Font("Webdings", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.ByteA.Location = new System.Drawing.Point(156, 23);
            this.ByteA.Name = "ByteA";
            this.ByteA.Size = new System.Drawing.Size(27, 22);
            this.ByteA.TabIndex = 5;
            this.ByteA.Text = "";
            // 
            // OriginX
            // 
            this.OriginX.AutoSize = true;
            this.OriginX.Font = new System.Drawing.Font("Webdings", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.OriginX.Location = new System.Drawing.Point(17, 40);
            this.OriginX.Name = "OriginX";
            this.OriginX.Size = new System.Drawing.Size(27, 22);
            this.OriginX.TabIndex = 1;
            this.OriginX.Text = "";
            // 
            // Byte1
            // 
            this.Byte1.AutoSize = true;
            this.Byte1.Font = new System.Drawing.Font("Webdings", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.Byte1.Location = new System.Drawing.Point(17, 156);
            this.Byte1.Name = "Byte1";
            this.Byte1.Size = new System.Drawing.Size(27, 22);
            this.Byte1.TabIndex = 2;
            this.Byte1.Text = "";
            // 
            // ByteB
            // 
            this.ByteB.AutoSize = true;
            this.ByteB.Font = new System.Drawing.Font("Webdings", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.ByteB.Location = new System.Drawing.Point(288, 23);
            this.ByteB.Name = "ByteB";
            this.ByteB.Size = new System.Drawing.Size(27, 22);
            this.ByteB.TabIndex = 6;
            this.ByteB.Text = "";
            // 
            // ByteC
            // 
            this.ByteC.AutoSize = true;
            this.ByteC.Font = new System.Drawing.Font("Webdings", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.ByteC.Location = new System.Drawing.Point(427, 23);
            this.ByteC.Name = "ByteC";
            this.ByteC.Size = new System.Drawing.Size(27, 22);
            this.ByteC.TabIndex = 7;
            this.ByteC.Text = "";
            // 
            // ByteD
            // 
            this.ByteD.AutoSize = true;
            this.ByteD.Font = new System.Drawing.Font("Webdings", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.ByteD.Location = new System.Drawing.Point(564, 23);
            this.ByteD.Name = "ByteD";
            this.ByteD.Size = new System.Drawing.Size(27, 22);
            this.ByteD.TabIndex = 8;
            this.ByteD.Text = "";
            // 
            // Byte2
            // 
            this.Byte2.AutoSize = true;
            this.Byte2.Font = new System.Drawing.Font("Webdings", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.Byte2.Location = new System.Drawing.Point(17, 294);
            this.Byte2.Name = "Byte2";
            this.Byte2.Size = new System.Drawing.Size(27, 22);
            this.Byte2.TabIndex = 9;
            this.Byte2.Text = "";
            // 
            // Byte3
            // 
            this.Byte3.AutoSize = true;
            this.Byte3.Font = new System.Drawing.Font("Webdings", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.Byte3.Location = new System.Drawing.Point(17, 429);
            this.Byte3.Name = "Byte3";
            this.Byte3.Size = new System.Drawing.Size(27, 22);
            this.Byte3.TabIndex = 10;
            this.Byte3.Text = "";
            // 
            // Byte4
            // 
            this.Byte4.AutoSize = true;
            this.Byte4.Font = new System.Drawing.Font("Webdings", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.Byte4.Location = new System.Drawing.Point(17, 565);
            this.Byte4.Name = "Byte4";
            this.Byte4.Size = new System.Drawing.Size(27, 22);
            this.Byte4.TabIndex = 11;
            this.Byte4.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.FontSizeLabel);
            this.groupBox2.Controls.Add(this.SynchCheckBox);
            this.groupBox2.Controls.Add(this.StatusLabel2);
            this.groupBox2.Controls.Add(this.StatusLabel1);
            this.groupBox2.Controls.Add(this.StatusIcon2);
            this.groupBox2.Controls.Add(this.StatusIcon1);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.Baseline);
            this.groupBox2.Controls.Add(this.KerningEdge);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.YDimension);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.XDimension);
            this.groupBox2.Location = new System.Drawing.Point(24, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(198, 625);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parameters";
            // 
            // SynchCheckBox
            // 
            this.SynchCheckBox.AutoSize = true;
            this.SynchCheckBox.Location = new System.Drawing.Point(6, 109);
            this.SynchCheckBox.Name = "SynchCheckBox";
            this.SynchCheckBox.Size = new System.Drawing.Size(94, 21);
            this.SynchCheckBox.TabIndex = 21;
            this.SynchCheckBox.Text = "Auto-Kern";
            this.SynchCheckBox.UseVisualStyleBackColor = true;
            this.SynchCheckBox.CheckedChanged += new System.EventHandler(this.SynchCheckBox_CheckedChanged);
            // 
            // StatusLabel2
            // 
            this.StatusLabel2.AutoSize = true;
            this.StatusLabel2.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel2.Location = new System.Drawing.Point(42, 590);
            this.StatusLabel2.Name = "StatusLabel2";
            this.StatusLabel2.Size = new System.Drawing.Size(70, 17);
            this.StatusLabel2.TabIndex = 20;
            this.StatusLabel2.Text = "StatusLabel2";
            // 
            // StatusLabel1
            // 
            this.StatusLabel1.AutoSize = true;
            this.StatusLabel1.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel1.Location = new System.Drawing.Point(44, 549);
            this.StatusLabel1.Name = "StatusLabel1";
            this.StatusLabel1.Size = new System.Drawing.Size(70, 17);
            this.StatusLabel1.TabIndex = 19;
            this.StatusLabel1.Text = "StatusLabel1";
            // 
            // StatusIcon2
            // 
            this.StatusIcon2.Location = new System.Drawing.Point(9, 582);
            this.StatusIcon2.Name = "StatusIcon2";
            this.StatusIcon2.Size = new System.Drawing.Size(32, 32);
            this.StatusIcon2.TabIndex = 18;
            this.StatusIcon2.TabStop = false;
            // 
            // StatusIcon1
            // 
            this.StatusIcon1.Location = new System.Drawing.Point(9, 540);
            this.StatusIcon1.Name = "StatusIcon1";
            this.StatusIcon1.Size = new System.Drawing.Size(32, 32);
            this.StatusIcon1.TabIndex = 17;
            this.StatusIcon1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.NumOfCharacters);
            this.groupBox4.Controls.Add(this.UnicodeRb);
            this.groupBox4.Controls.Add(this.AnsiRb);
            this.groupBox4.Location = new System.Drawing.Point(9, 397);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(174, 137);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Encoding";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Chars in font";
            // 
            // NumOfCharacters
            // 
            this.NumOfCharacters.Enabled = false;
            this.NumOfCharacters.Location = new System.Drawing.Point(7, 98);
            this.NumOfCharacters.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.NumOfCharacters.Minimum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NumOfCharacters.Name = "NumOfCharacters";
            this.NumOfCharacters.Size = new System.Drawing.Size(102, 22);
            this.NumOfCharacters.TabIndex = 2;
            this.NumOfCharacters.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // UnicodeRb
            // 
            this.UnicodeRb.AutoSize = true;
            this.UnicodeRb.Location = new System.Drawing.Point(7, 51);
            this.UnicodeRb.Name = "UnicodeRb";
            this.UnicodeRb.Size = new System.Drawing.Size(91, 21);
            this.UnicodeRb.TabIndex = 1;
            this.UnicodeRb.TabStop = true;
            this.UnicodeRb.Text = "UNICODE";
            this.UnicodeRb.UseVisualStyleBackColor = true;
            this.UnicodeRb.CheckedChanged += new System.EventHandler(this.UnicodeRb_CheckedChanged);
            // 
            // AnsiRb
            // 
            this.AnsiRb.AutoSize = true;
            this.AnsiRb.Location = new System.Drawing.Point(7, 24);
            this.AnsiRb.Name = "AnsiRb";
            this.AnsiRb.Size = new System.Drawing.Size(60, 21);
            this.AnsiRb.TabIndex = 0;
            this.AnsiRb.TabStop = true;
            this.AnsiRb.Text = "ANSI";
            this.AnsiRb.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LCDVertical);
            this.groupBox3.Controls.Add(this.LCDHorizontal);
            this.groupBox3.Location = new System.Drawing.Point(9, 294);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(175, 97);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "LCD ORG (Preview)";
            // 
            // LCDVertical
            // 
            this.LCDVertical.AutoSize = true;
            this.LCDVertical.Location = new System.Drawing.Point(7, 48);
            this.LCDVertical.Name = "LCDVertical";
            this.LCDVertical.Size = new System.Drawing.Size(76, 21);
            this.LCDVertical.TabIndex = 1;
            this.LCDVertical.TabStop = true;
            this.LCDVertical.Text = "Vertical";
            this.LCDVertical.UseVisualStyleBackColor = true;
            // 
            // LCDHorizontal
            // 
            this.LCDHorizontal.AutoSize = true;
            this.LCDHorizontal.Location = new System.Drawing.Point(7, 21);
            this.LCDHorizontal.Name = "LCDHorizontal";
            this.LCDHorizontal.Size = new System.Drawing.Size(93, 21);
            this.LCDHorizontal.TabIndex = 0;
            this.LCDHorizontal.TabStop = true;
            this.LCDHorizontal.Text = "Horizontal";
            this.LCDHorizontal.UseVisualStyleBackColor = true;
            this.LCDHorizontal.CheckedChanged += new System.EventHandler(this.LCDHorizontal_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.LimeGreen;
            this.label8.Location = new System.Drawing.Point(93, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Baseline";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(93, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Kerning Edge";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Character Properties";
            // 
            // Baseline
            // 
            this.Baseline.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Baseline.FormattingEnabled = true;
            this.Baseline.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32"});
            this.Baseline.Location = new System.Drawing.Point(6, 230);
            this.Baseline.Name = "Baseline";
            this.Baseline.Size = new System.Drawing.Size(81, 24);
            this.Baseline.TabIndex = 11;
            this.Baseline.TextChanged += new System.EventHandler(this.Baseline_TextChanged);
            // 
            // KerningEdge
            // 
            this.KerningEdge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.KerningEdge.FormattingEnabled = true;
            this.KerningEdge.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32"});
            this.KerningEdge.Location = new System.Drawing.Point(6, 187);
            this.KerningEdge.Name = "KerningEdge";
            this.KerningEdge.Size = new System.Drawing.Size(81, 24);
            this.KerningEdge.TabIndex = 10;
            this.KerningEdge.TextChanged += new System.EventHandler(this.KerningEdge_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Character Cell Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Y-DIM";
            // 
            // YDimension
            // 
            this.YDimension.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.YDimension.FormattingEnabled = true;
            this.YDimension.Items.AddRange(new object[] {
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32"});
            this.YDimension.Location = new System.Drawing.Point(6, 79);
            this.YDimension.Name = "YDimension";
            this.YDimension.Size = new System.Drawing.Size(81, 24);
            this.YDimension.TabIndex = 4;
            this.YDimension.TextChanged += new System.EventHandler(this.YDimension_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "X-DIM";
            // 
            // XDimension
            // 
            this.XDimension.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.XDimension.FormattingEnabled = true;
            this.XDimension.Items.AddRange(new object[] {
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32"});
            this.XDimension.Location = new System.Drawing.Point(6, 49);
            this.XDimension.Name = "XDimension";
            this.XDimension.Size = new System.Drawing.Size(81, 24);
            this.XDimension.TabIndex = 2;
            this.XDimension.TextChanged += new System.EventHandler(this.XDimension_TextChanged);
            // 
            // WarningIconImage
            // 
            this.WarningIconImage.Location = new System.Drawing.Point(24, 640);
            this.WarningIconImage.Name = "WarningIconImage";
            this.WarningIconImage.Size = new System.Drawing.Size(38, 41);
            this.WarningIconImage.TabIndex = 4;
            this.WarningIconImage.TabStop = false;
            // 
            // WarningLabel
            // 
            this.WarningLabel.AutoSize = true;
            this.WarningLabel.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WarningLabel.Location = new System.Drawing.Point(68, 649);
            this.WarningLabel.Name = "WarningLabel";
            this.WarningLabel.Size = new System.Drawing.Size(26, 17);
            this.WarningLabel.TabIndex = 5;
            this.WarningLabel.Text = "abc";
            // 
            // BaselineWarningIcon
            // 
            this.BaselineWarningIcon.Location = new System.Drawing.Point(1, 245);
            this.BaselineWarningIcon.Name = "BaselineWarningIcon";
            this.BaselineWarningIcon.Size = new System.Drawing.Size(20, 20);
            this.BaselineWarningIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BaselineWarningIcon.TabIndex = 6;
            this.BaselineWarningIcon.TabStop = false;
            // 
            // KerningWarningIcon
            // 
            this.KerningWarningIcon.Location = new System.Drawing.Point(1, 199);
            this.KerningWarningIcon.Name = "KerningWarningIcon";
            this.KerningWarningIcon.Size = new System.Drawing.Size(20, 20);
            this.KerningWarningIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.KerningWarningIcon.TabIndex = 7;
            this.KerningWarningIcon.TabStop = false;
            // 
            // FileIdent
            // 
            this.FileIdent.Location = new System.Drawing.Point(439, 690);
            this.FileIdent.Name = "FileIdent";
            this.FileIdent.Size = new System.Drawing.Size(394, 22);
            this.FileIdent.TabIndex = 8;
            this.FileIdent.Text = "NewFont Ver1.0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(320, 693);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "Internal Identifier";
            // 
            // FontSizeLabel
            // 
            this.FontSizeLabel.AutoSize = true;
            this.FontSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FontSizeLabel.Location = new System.Drawing.Point(6, 133);
            this.FontSizeLabel.Name = "FontSizeLabel";
            this.FontSizeLabel.Size = new System.Drawing.Size(0, 17);
            this.FontSizeLabel.TabIndex = 22;
            // 
            // Form2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(848, 733);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.FileIdent);
            this.Controls.Add(this.KerningWarningIcon);
            this.Controls.Add(this.BaselineWarningIcon);
            this.Controls.Add(this.WarningLabel);
            this.Controls.Add(this.WarningIconImage);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.AcceptBtn);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.Text = "Font Creation Options";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FontSizePreview)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StatusIcon2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusIcon1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumOfCharacters)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WarningIconImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaselineWarningIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KerningWarningIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AcceptBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox XDimension;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox YDimension;
        private System.Windows.Forms.PictureBox FontSizePreview;
        private System.Windows.Forms.Label OriginX;
        private System.Windows.Forms.Label Byte1;
        private System.Windows.Forms.Label label3;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape VerticalByteMarker1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape HorByteMarker1;
        private System.Windows.Forms.Label ByteA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Baseline;
        private System.Windows.Forms.ComboBox KerningEdge;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton LCDVertical;
        private System.Windows.Forms.RadioButton LCDHorizontal;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape HorByteMarker2;
        private System.Windows.Forms.Label ByteB;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape HorByteMarker3;
        private System.Windows.Forms.Label ByteC;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape HorByteMarker4;
        private System.Windows.Forms.Label ByteD;
        private System.Windows.Forms.Label Byte2;
        private System.Windows.Forms.Label Byte3;
        private System.Windows.Forms.Label Byte4;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape VerticalByteMarker2;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape VerticalByteMarker3;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape VerticalByteMarker4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton UnicodeRb;
        private System.Windows.Forms.RadioButton AnsiRb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown NumOfCharacters;
        private System.Windows.Forms.PictureBox WarningIconImage;
        private System.Windows.Forms.Label WarningLabel;
        private System.Windows.Forms.PictureBox StatusIcon1;
        private System.Windows.Forms.PictureBox BaselineWarningIcon;
        private System.Windows.Forms.PictureBox KerningWarningIcon;
        private System.Windows.Forms.PictureBox StatusIcon2;
        private System.Windows.Forms.Label StatusLabel1;
        private System.Windows.Forms.Label StatusLabel2;
        private System.Windows.Forms.CheckBox SynchCheckBox;
        private System.Windows.Forms.TextBox FileIdent;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label FontSizeLabel;
    }
}