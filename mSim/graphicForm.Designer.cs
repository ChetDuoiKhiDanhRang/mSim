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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmb_timeUnit = new System.Windows.Forms.ComboBox();
            this.cmb_angleUnit = new System.Windows.Forms.ComboBox();
            this.cmb_distanceUnit = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.graphBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grb_Params0.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.ckbHighQuality.Size = new System.Drawing.Size(90, 17);
            this.ckbHighQuality.TabIndex = 1;
            this.ckbHighQuality.Text = "Khử răng cưa";
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
            this.grb_Params0.Location = new System.Drawing.Point(12, 548);
            this.grb_Params0.Name = "grb_Params0";
            this.grb_Params0.Size = new System.Drawing.Size(306, 169);
            this.grb_Params0.TabIndex = 2;
            this.grb_Params0.TabStop = false;
            this.grb_Params0.Text = "Tham số ban đầu (t=0)";
            // 
            // txb_alpha0
            // 
            this.txb_alpha0.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_alpha0.Location = new System.Drawing.Point(164, 133);
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
            this.txb_v0y.Location = new System.Drawing.Point(49, 133);
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
            this.txb_v0.Location = new System.Drawing.Point(164, 102);
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
            this.txb_ay.Location = new System.Drawing.Point(164, 47);
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
            this.txb_v0x.Location = new System.Drawing.Point(49, 102);
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
            this.txb_ax.Location = new System.Drawing.Point(164, 18);
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
            this.radioButton1.Location = new System.Drawing.Point(131, 81);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(88, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "độ lớn/góc";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rad_speedmode
            // 
            this.rad_speedmode.AutoSize = true;
            this.rad_speedmode.Location = new System.Drawing.Point(7, 79);
            this.rad_speedmode.Name = "rad_speedmode";
            this.rad_speedmode.Size = new System.Drawing.Size(114, 17);
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
            this.rtb_ay.Location = new System.Drawing.Point(130, 45);
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
            this.rtb_alpha0.Location = new System.Drawing.Point(131, 133);
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
            this.rtb_ax.Location = new System.Drawing.Point(130, 19);
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
            this.rtb_v0.Location = new System.Drawing.Point(131, 102);
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
            this.rtb_v0y.Location = new System.Drawing.Point(7, 133);
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
            this.rtb_v0x.Location = new System.Drawing.Point(7, 102);
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
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.cmb_timeUnit);
            this.groupBox3.Controls.Add(this.cmb_angleUnit);
            this.groupBox3.Controls.Add(this.cmb_distanceUnit);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(598, 606);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(196, 111);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Đơn vị:";
            // 
            // cmb_timeUnit
            // 
            this.cmb_timeUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_timeUnit.FormattingEnabled = true;
            this.cmb_timeUnit.Items.AddRange(new object[] {
            "giây (s)",
            "giờ (h)"});
            this.cmb_timeUnit.Location = new System.Drawing.Point(101, 20);
            this.cmb_timeUnit.Name = "cmb_timeUnit";
            this.cmb_timeUnit.Size = new System.Drawing.Size(72, 21);
            this.cmb_timeUnit.TabIndex = 1;
            // 
            // cmb_angleUnit
            // 
            this.cmb_angleUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_angleUnit.FormattingEnabled = true;
            this.cmb_angleUnit.Items.AddRange(new object[] {
            "độ (deg)",
            "radian (rad)"});
            this.cmb_angleUnit.Location = new System.Drawing.Point(101, 74);
            this.cmb_angleUnit.Name = "cmb_angleUnit";
            this.cmb_angleUnit.Size = new System.Drawing.Size(72, 21);
            this.cmb_angleUnit.TabIndex = 1;
            // 
            // cmb_distanceUnit
            // 
            this.cmb_distanceUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_distanceUnit.FormattingEnabled = true;
            this.cmb_distanceUnit.Items.AddRange(new object[] {
            "met (m)",
            "kilomet (km)"});
            this.cmb_distanceUnit.Location = new System.Drawing.Point(101, 47);
            this.cmb_distanceUnit.Name = "cmb_distanceUnit";
            this.cmb_distanceUnit.Size = new System.Drawing.Size(72, 21);
            this.cmb_distanceUnit.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Góc";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Khoảng cách:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thời gian:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // drawForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.grb_Params0);
            this.Controls.Add(this.groupBox3);
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
            this.groupBox3.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_timeUnit;
        private System.Windows.Forms.ComboBox cmb_angleUnit;
        private System.Windows.Forms.ComboBox cmb_distanceUnit;
        private System.Windows.Forms.Label label3;
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
    }
}

