namespace mSim
{
    partial class drawForm
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
            this.graphBox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckbHighQuality = new System.Windows.Forms.CheckBox();
            this.ckbSpeed = new System.Windows.Forms.CheckBox();
            this.ckbTrail = new System.Windows.Forms.CheckBox();
            this.ckbCoordinates = new System.Windows.Forms.CheckBox();
            this.ckbGid = new System.Windows.Forms.CheckBox();
            this.grb_Params0 = new System.Windows.Forms.GroupBox();
            this.txb_alpha0 = new System.Windows.Forms.TextBox();
            this.txb_v0y = new System.Windows.Forms.TextBox();
            this.txb_v0 = new System.Windows.Forms.TextBox();
            this.txb_ay = new System.Windows.Forms.TextBox();
            this.txb_y0 = new System.Windows.Forms.TextBox();
            this.txb_v0x = new System.Windows.Forms.TextBox();
            this.txb_ax = new System.Windows.Forms.TextBox();
            this.txb_x0 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rad_speedmode = new System.Windows.Forms.RadioButton();
            this.rtb_ay = new System.Windows.Forms.RichTextBox();
            this.rtb_alpha0 = new System.Windows.Forms.RichTextBox();
            this.rtb_ax = new System.Windows.Forms.RichTextBox();
            this.rtb_v0 = new System.Windows.Forms.RichTextBox();
            this.rtb_v0y = new System.Windows.Forms.RichTextBox();
            this.rtb_v0x = new System.Windows.Forms.RichTextBox();
            this.rtb_y0 = new System.Windows.Forms.RichTextBox();
            this.rtb_x0 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtb_yt = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rtb_xt = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.graphBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grb_Params0.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // graphBox
            // 
            this.graphBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.graphBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.graphBox.Location = new System.Drawing.Point(12, 12);
            this.graphBox.Name = "graphBox";
            this.graphBox.Size = new System.Drawing.Size(984, 530);
            this.graphBox.TabIndex = 0;
            this.graphBox.TabStop = false;
            this.graphBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.graphBox_MouseDown);
            this.graphBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.graphBox_MouseMove);
            this.graphBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.graphBox_MouseUp);
            this.graphBox.Resize += new System.EventHandler(this.graphBox_SizeChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ckbHighQuality);
            this.groupBox1.Controls.Add(this.ckbSpeed);
            this.groupBox1.Controls.Add(this.ckbTrail);
            this.groupBox1.Controls.Add(this.ckbCoordinates);
            this.groupBox1.Controls.Add(this.ckbGid);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(800, 606);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 111);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hiển thị:";
            // 
            // ckbHighQuality
            // 
            this.ckbHighQuality.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ckbHighQuality.AutoSize = true;
            this.ckbHighQuality.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbHighQuality.Location = new System.Drawing.Point(6, 76);
            this.ckbHighQuality.Name = "ckbHighQuality";
            this.ckbHighQuality.Size = new System.Drawing.Size(100, 17);
            this.ckbHighQuality.TabIndex = 1;
            this.ckbHighQuality.Text = "Khử \"răng cưa\"";
            this.ckbHighQuality.UseVisualStyleBackColor = true;
            this.ckbHighQuality.CheckedChanged += new System.EventHandler(this.ckbHighQuality_CheckedChanged);
            // 
            // ckbSpeed
            // 
            this.ckbSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ckbSpeed.AutoSize = true;
            this.ckbSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbSpeed.Location = new System.Drawing.Point(105, 49);
            this.ckbSpeed.Name = "ckbSpeed";
            this.ckbSpeed.Size = new System.Drawing.Size(63, 17);
            this.ckbSpeed.TabIndex = 0;
            this.ckbSpeed.Text = "Vận tốc";
            this.ckbSpeed.UseVisualStyleBackColor = true;
            this.ckbSpeed.CheckedChanged += new System.EventHandler(this.ckbSpeed_CheckedChanged);
            // 
            // ckbTrail
            // 
            this.ckbTrail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ckbTrail.AutoSize = true;
            this.ckbTrail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbTrail.Location = new System.Drawing.Point(105, 22);
            this.ckbTrail.Name = "ckbTrail";
            this.ckbTrail.Size = new System.Drawing.Size(85, 17);
            this.ckbTrail.TabIndex = 0;
            this.ckbTrail.Text = "Đường dóng";
            this.ckbTrail.UseVisualStyleBackColor = true;
            this.ckbTrail.CheckedChanged += new System.EventHandler(this.ckbTrail_CheckedChanged);
            // 
            // ckbCoordinates
            // 
            this.ckbCoordinates.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ckbCoordinates.AutoSize = true;
            this.ckbCoordinates.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbCoordinates.Location = new System.Drawing.Point(6, 49);
            this.ckbCoordinates.Name = "ckbCoordinates";
            this.ckbCoordinates.Size = new System.Drawing.Size(61, 17);
            this.ckbCoordinates.TabIndex = 0;
            this.ckbCoordinates.Text = "Tọa độ";
            this.ckbCoordinates.UseVisualStyleBackColor = true;
            this.ckbCoordinates.CheckedChanged += new System.EventHandler(this.ckbCoordinates_CheckedChanged);
            // 
            // ckbGid
            // 
            this.ckbGid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ckbGid.AutoSize = true;
            this.ckbGid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbGid.Location = new System.Drawing.Point(6, 22);
            this.ckbGid.Name = "ckbGid";
            this.ckbGid.Size = new System.Drawing.Size(46, 17);
            this.ckbGid.TabIndex = 0;
            this.ckbGid.Text = "Lưới";
            this.ckbGid.UseVisualStyleBackColor = true;
            this.ckbGid.CheckedChanged += new System.EventHandler(this.ckbGid_CheckedChanged);
            // 
            // grb_Params0
            // 
            this.grb_Params0.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grb_Params0.Controls.Add(this.txb_alpha0);
            this.grb_Params0.Controls.Add(this.txb_v0y);
            this.grb_Params0.Controls.Add(this.txb_v0);
            this.grb_Params0.Controls.Add(this.txb_ay);
            this.grb_Params0.Controls.Add(this.txb_y0);
            this.grb_Params0.Controls.Add(this.txb_v0x);
            this.grb_Params0.Controls.Add(this.txb_ax);
            this.grb_Params0.Controls.Add(this.txb_x0);
            this.grb_Params0.Controls.Add(this.radioButton1);
            this.grb_Params0.Controls.Add(this.rad_speedmode);
            this.grb_Params0.Controls.Add(this.rtb_ay);
            this.grb_Params0.Controls.Add(this.rtb_alpha0);
            this.grb_Params0.Controls.Add(this.rtb_ax);
            this.grb_Params0.Controls.Add(this.rtb_v0);
            this.grb_Params0.Controls.Add(this.rtb_v0y);
            this.grb_Params0.Controls.Add(this.rtb_v0x);
            this.grb_Params0.Controls.Add(this.rtb_y0);
            this.grb_Params0.Controls.Add(this.rtb_x0);
            this.grb_Params0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_Params0.ForeColor = System.Drawing.Color.DarkRed;
            this.grb_Params0.Location = new System.Drawing.Point(12, 548);
            this.grb_Params0.Name = "grb_Params0";
            this.grb_Params0.Size = new System.Drawing.Size(253, 169);
            this.grb_Params0.TabIndex = 2;
            this.grb_Params0.TabStop = false;
            this.grb_Params0.Text = "Tham số ban đầu (t=0)";
            // 
            // txb_alpha0
            // 
            this.txb_alpha0.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_alpha0.ForeColor = System.Drawing.Color.DarkRed;
            this.txb_alpha0.Location = new System.Drawing.Point(185, 136);
            this.txb_alpha0.MaxLength = 7;
            this.txb_alpha0.Name = "txb_alpha0";
            this.txb_alpha0.Size = new System.Drawing.Size(51, 22);
            this.txb_alpha0.TabIndex = 5;
            this.txb_alpha0.Text = "45";
            this.txb_alpha0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txb_alpha0.TextChanged += new System.EventHandler(this.txbs_TextChanged);
            // 
            // txb_v0y
            // 
            this.txb_v0y.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_v0y.ForeColor = System.Drawing.Color.DarkRed;
            this.txb_v0y.Location = new System.Drawing.Point(49, 136);
            this.txb_v0y.MaxLength = 7;
            this.txb_v0y.Name = "txb_v0y";
            this.txb_v0y.Size = new System.Drawing.Size(51, 22);
            this.txb_v0y.TabIndex = 3;
            this.txb_v0y.Text = "100";
            this.txb_v0y.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txb_v0y.TextChanged += new System.EventHandler(this.txbs_TextChanged);
            // 
            // txb_v0
            // 
            this.txb_v0.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_v0.ForeColor = System.Drawing.Color.DarkRed;
            this.txb_v0.Location = new System.Drawing.Point(185, 105);
            this.txb_v0.MaxLength = 7;
            this.txb_v0.Name = "txb_v0";
            this.txb_v0.Size = new System.Drawing.Size(51, 22);
            this.txb_v0.TabIndex = 4;
            this.txb_v0.Text = "10";
            this.txb_v0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txb_v0.TextChanged += new System.EventHandler(this.txbs_TextChanged);
            // 
            // txb_ay
            // 
            this.txb_ay.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_ay.ForeColor = System.Drawing.Color.DarkRed;
            this.txb_ay.Location = new System.Drawing.Point(185, 47);
            this.txb_ay.MaxLength = 7;
            this.txb_ay.Name = "txb_ay";
            this.txb_ay.Size = new System.Drawing.Size(51, 22);
            this.txb_ay.TabIndex = 7;
            this.txb_ay.Text = "0";
            this.txb_ay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txb_ay.TextChanged += new System.EventHandler(this.txbs_TextChanged);
            // 
            // txb_y0
            // 
            this.txb_y0.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_y0.ForeColor = System.Drawing.Color.DarkRed;
            this.txb_y0.Location = new System.Drawing.Point(49, 47);
            this.txb_y0.MaxLength = 7;
            this.txb_y0.Name = "txb_y0";
            this.txb_y0.Size = new System.Drawing.Size(51, 22);
            this.txb_y0.TabIndex = 1;
            this.txb_y0.Text = "0";
            this.txb_y0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txb_y0.TextChanged += new System.EventHandler(this.txbs_TextChanged);
            // 
            // txb_v0x
            // 
            this.txb_v0x.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_v0x.ForeColor = System.Drawing.Color.DarkRed;
            this.txb_v0x.Location = new System.Drawing.Point(49, 105);
            this.txb_v0x.MaxLength = 7;
            this.txb_v0x.Name = "txb_v0x";
            this.txb_v0x.Size = new System.Drawing.Size(51, 22);
            this.txb_v0x.TabIndex = 2;
            this.txb_v0x.Text = "100";
            this.txb_v0x.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txb_v0x.TextChanged += new System.EventHandler(this.txbs_TextChanged);
            // 
            // txb_ax
            // 
            this.txb_ax.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_ax.ForeColor = System.Drawing.Color.DarkRed;
            this.txb_ax.Location = new System.Drawing.Point(185, 18);
            this.txb_ax.MaxLength = 7;
            this.txb_ax.Name = "txb_ax";
            this.txb_ax.Size = new System.Drawing.Size(51, 22);
            this.txb_ax.TabIndex = 6;
            this.txb_ax.Text = "-9,80";
            this.txb_ax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txb_ax.TextChanged += new System.EventHandler(this.txbs_TextChanged);
            // 
            // txb_x0
            // 
            this.txb_x0.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_x0.ForeColor = System.Drawing.Color.DarkRed;
            this.txb_x0.Location = new System.Drawing.Point(49, 18);
            this.txb_x0.MaxLength = 7;
            this.txb_x0.Name = "txb_x0";
            this.txb_x0.Size = new System.Drawing.Size(51, 22);
            this.txb_x0.TabIndex = 0;
            this.txb_x0.Text = "0";
            this.txb_x0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txb_x0.TextChanged += new System.EventHandler(this.txbs_TextChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.DarkRed;
            this.radioButton1.Location = new System.Drawing.Point(152, 82);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(78, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "độ lớn/góc";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rad_speedmode
            // 
            this.rad_speedmode.AutoSize = true;
            this.rad_speedmode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_speedmode.ForeColor = System.Drawing.Color.DarkRed;
            this.rad_speedmode.Location = new System.Drawing.Point(7, 82);
            this.rad_speedmode.Name = "rad_speedmode";
            this.rad_speedmode.Size = new System.Drawing.Size(99, 17);
            this.rad_speedmode.TabIndex = 1;
            this.rad_speedmode.Text = "h.chiếu vận tốc";
            this.rad_speedmode.UseVisualStyleBackColor = true;
            this.rad_speedmode.CheckedChanged += new System.EventHandler(this.rad_speedmode_CheckedChanged);
            // 
            // rtb_ay
            // 
            this.rtb_ay.AutoSize = true;
            this.rtb_ay.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rtb_ay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_ay.DetectUrls = false;
            this.rtb_ay.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_ay.ForeColor = System.Drawing.Color.DarkRed;
            this.rtb_ay.Location = new System.Drawing.Point(151, 45);
            this.rtb_ay.Name = "rtb_ay";
            this.rtb_ay.ReadOnly = true;
            this.rtb_ay.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtb_ay.Size = new System.Drawing.Size(36, 20);
            this.rtb_ay.TabIndex = 0;
            this.rtb_ay.TabStop = false;
            this.rtb_ay.Text = "ay";
            this.rtb_ay.Enter += new System.EventHandler(this.rtb_ay_Enter);
            // 
            // rtb_alpha0
            // 
            this.rtb_alpha0.AutoSize = true;
            this.rtb_alpha0.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rtb_alpha0.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_alpha0.DetectUrls = false;
            this.rtb_alpha0.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_alpha0.ForeColor = System.Drawing.Color.DarkRed;
            this.rtb_alpha0.Location = new System.Drawing.Point(152, 136);
            this.rtb_alpha0.Name = "rtb_alpha0";
            this.rtb_alpha0.ReadOnly = true;
            this.rtb_alpha0.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtb_alpha0.Size = new System.Drawing.Size(36, 20);
            this.rtb_alpha0.TabIndex = 0;
            this.rtb_alpha0.TabStop = false;
            this.rtb_alpha0.Text = "Góc:";
            this.rtb_alpha0.Enter += new System.EventHandler(this.rtb_alpha0_Enter);
            // 
            // rtb_ax
            // 
            this.rtb_ax.AutoSize = true;
            this.rtb_ax.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rtb_ax.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_ax.DetectUrls = false;
            this.rtb_ax.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_ax.ForeColor = System.Drawing.Color.DarkRed;
            this.rtb_ax.Location = new System.Drawing.Point(151, 19);
            this.rtb_ax.Name = "rtb_ax";
            this.rtb_ax.ReadOnly = true;
            this.rtb_ax.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtb_ax.Size = new System.Drawing.Size(36, 20);
            this.rtb_ax.TabIndex = 0;
            this.rtb_ax.TabStop = false;
            this.rtb_ax.Text = "ax";
            this.rtb_ax.Enter += new System.EventHandler(this.rtb_ax_Enter);
            // 
            // rtb_v0
            // 
            this.rtb_v0.AutoSize = true;
            this.rtb_v0.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rtb_v0.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_v0.DetectUrls = false;
            this.rtb_v0.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_v0.ForeColor = System.Drawing.Color.DarkRed;
            this.rtb_v0.Location = new System.Drawing.Point(152, 105);
            this.rtb_v0.Name = "rtb_v0";
            this.rtb_v0.ReadOnly = true;
            this.rtb_v0.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtb_v0.Size = new System.Drawing.Size(36, 20);
            this.rtb_v0.TabIndex = 0;
            this.rtb_v0.TabStop = false;
            this.rtb_v0.Text = "v0";
            this.rtb_v0.Enter += new System.EventHandler(this.rtb_v0_Enter);
            // 
            // rtb_v0y
            // 
            this.rtb_v0y.AutoSize = true;
            this.rtb_v0y.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rtb_v0y.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_v0y.DetectUrls = false;
            this.rtb_v0y.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_v0y.ForeColor = System.Drawing.Color.DarkRed;
            this.rtb_v0y.Location = new System.Drawing.Point(7, 136);
            this.rtb_v0y.Name = "rtb_v0y";
            this.rtb_v0y.ReadOnly = true;
            this.rtb_v0y.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtb_v0y.Size = new System.Drawing.Size(36, 20);
            this.rtb_v0y.TabIndex = 0;
            this.rtb_v0y.TabStop = false;
            this.rtb_v0y.Text = "v0y";
            this.rtb_v0y.Enter += new System.EventHandler(this.rtb_v0y_Enter);
            // 
            // rtb_v0x
            // 
            this.rtb_v0x.AutoSize = true;
            this.rtb_v0x.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rtb_v0x.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_v0x.DetectUrls = false;
            this.rtb_v0x.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_v0x.ForeColor = System.Drawing.Color.DarkRed;
            this.rtb_v0x.Location = new System.Drawing.Point(7, 105);
            this.rtb_v0x.Name = "rtb_v0x";
            this.rtb_v0x.ReadOnly = true;
            this.rtb_v0x.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtb_v0x.Size = new System.Drawing.Size(36, 20);
            this.rtb_v0x.TabIndex = 0;
            this.rtb_v0x.TabStop = false;
            this.rtb_v0x.Text = "v0x";
            this.rtb_v0x.Enter += new System.EventHandler(this.rtb_v0x_Enter);
            // 
            // rtb_y0
            // 
            this.rtb_y0.AutoSize = true;
            this.rtb_y0.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rtb_y0.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_y0.DetectUrls = false;
            this.rtb_y0.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_y0.ForeColor = System.Drawing.Color.DarkRed;
            this.rtb_y0.Location = new System.Drawing.Point(6, 45);
            this.rtb_y0.Name = "rtb_y0";
            this.rtb_y0.ReadOnly = true;
            this.rtb_y0.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtb_y0.Size = new System.Drawing.Size(36, 20);
            this.rtb_y0.TabIndex = 0;
            this.rtb_y0.TabStop = false;
            this.rtb_y0.Text = "y0";
            this.rtb_y0.Enter += new System.EventHandler(this.rtb_y0_Enter);
            // 
            // rtb_x0
            // 
            this.rtb_x0.AutoSize = true;
            this.rtb_x0.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rtb_x0.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_x0.DetectUrls = false;
            this.rtb_x0.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_x0.ForeColor = System.Drawing.Color.DarkRed;
            this.rtb_x0.Location = new System.Drawing.Point(6, 19);
            this.rtb_x0.Name = "rtb_x0";
            this.rtb_x0.ReadOnly = true;
            this.rtb_x0.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtb_x0.Size = new System.Drawing.Size(36, 20);
            this.rtb_x0.TabIndex = 0;
            this.rtb_x0.TabStop = false;
            this.rtb_x0.Text = "x0";
            this.rtb_x0.Enter += new System.EventHandler(this.rtb_x0_Enter);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.richTextBox2);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.rtb_xt);
            this.panel1.Controls.Add(this.rtb_yt);
            this.panel1.Location = new System.Drawing.Point(271, 548);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 169);
            this.panel1.TabIndex = 3;
            // 
            // rtb_yt
            // 
            this.rtb_yt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rtb_yt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtb_yt.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Italic);
            this.rtb_yt.Location = new System.Drawing.Point(2, 49);
            this.rtb_yt.Name = "rtb_yt";
            this.rtb_yt.ReadOnly = true;
            this.rtb_yt.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtb_yt.Size = new System.Drawing.Size(327, 23);
            this.rtb_yt.TabIndex = 0;
            this.rtb_yt.Text = "y(t) = y0 + v0y.t + ay/2.t2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Phương trình chuyển động:";
            // 
            // rtb_xt
            // 
            this.rtb_xt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rtb_xt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtb_xt.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Italic);
            this.rtb_xt.Location = new System.Drawing.Point(2, 20);
            this.rtb_xt.Name = "rtb_xt";
            this.rtb_xt.ReadOnly = true;
            this.rtb_xt.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtb_xt.Size = new System.Drawing.Size(327, 23);
            this.rtb_xt.TabIndex = 0;
            this.rtb_xt.Text = "x(t) = x0 + v0x.t + ax/2.t2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Phương trình vận tốc:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Italic);
            this.richTextBox1.Location = new System.Drawing.Point(2, 130);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(327, 23);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "vy(t) = v0y + ay.t";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox2.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Italic);
            this.richTextBox2.Location = new System.Drawing.Point(2, 101);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox2.Size = new System.Drawing.Size(327, 23);
            this.richTextBox2.TabIndex = 0;
            this.richTextBox2.Text = "vx(t) = v0x + ax.t";
            // 
            // drawForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grb_Params0);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.graphBox);
            this.Name = "drawForm";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.drawForm_FormClosed);
            this.Shown += new System.EventHandler(this.drawForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.graphBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grb_Params0.ResumeLayout(false);
            this.grb_Params0.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox graphBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckbSpeed;
        private System.Windows.Forms.CheckBox ckbTrail;
        private System.Windows.Forms.CheckBox ckbCoordinates;
        private System.Windows.Forms.CheckBox ckbGid;
        private System.Windows.Forms.CheckBox ckbHighQuality;
        private System.Windows.Forms.GroupBox grb_Params0;
        private System.Windows.Forms.RichTextBox rtb_alpha0;
        private System.Windows.Forms.RichTextBox rtb_v0;
        private System.Windows.Forms.RichTextBox rtb_v0y;
        private System.Windows.Forms.RichTextBox rtb_v0x;
        private System.Windows.Forms.RichTextBox rtb_y0;
        private System.Windows.Forms.RichTextBox rtb_x0;
        private System.Windows.Forms.RichTextBox rtb_ay;
        private System.Windows.Forms.RichTextBox rtb_ax;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rad_speedmode;
        private System.Windows.Forms.TextBox txb_x0;
        private System.Windows.Forms.TextBox txb_y0;
        private System.Windows.Forms.TextBox txb_v0y;
        private System.Windows.Forms.TextBox txb_v0x;
        private System.Windows.Forms.TextBox txb_alpha0;
        private System.Windows.Forms.TextBox txb_v0;
        private System.Windows.Forms.TextBox txb_ay;
        private System.Windows.Forms.TextBox txb_ax;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox rtb_yt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtb_xt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

