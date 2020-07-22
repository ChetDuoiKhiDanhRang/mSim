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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(drawForm));
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
            this.panel1 = new System.Windows.Forms.GroupBox();
            this.rtb_vx = new System.Windows.Forms.RichTextBox();
            this.rtb_vy = new System.Windows.Forms.RichTextBox();
            this.rtb_xt = new System.Windows.Forms.RichTextBox();
            this.rtb_yt = new System.Windows.Forms.RichTextBox();
            this.grbStatus = new System.Windows.Forms.GroupBox();
            this.rtb_cur_vy = new System.Windows.Forms.RichTextBox();
            this.rtb_cur_vx = new System.Windows.Forms.RichTextBox();
            this.rtb_cur_y = new System.Windows.Forms.RichTextBox();
            this.rtb_cur_x = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picInfo = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.picCapture = new System.Windows.Forms.PictureBox();
            this.picReset = new System.Windows.Forms.PictureBox();
            this.picPlay = new System.Windows.Forms.PictureBox();
            this.trb = new System.Windows.Forms.TrackBar();
            this.btnLanguage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.graphBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grb_Params0.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grbStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCapture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb)).BeginInit();
            this.SuspendLayout();
            // 
            // graphBox
            // 
            this.graphBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.graphBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.graphBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.graphBox.Location = new System.Drawing.Point(12, 12);
            this.graphBox.Name = "graphBox";
            this.graphBox.Size = new System.Drawing.Size(760, 361);
            this.graphBox.TabIndex = 0;
            this.graphBox.TabStop = false;
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
            this.groupBox1.Location = new System.Drawing.Point(519, 473);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 78);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hiển thị:";
            // 
            // ckbHighQuality
            // 
            this.ckbHighQuality.AutoSize = true;
            this.ckbHighQuality.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbHighQuality.Location = new System.Drawing.Point(6, 56);
            this.ckbHighQuality.Name = "ckbHighQuality";
            this.ckbHighQuality.Size = new System.Drawing.Size(100, 17);
            this.ckbHighQuality.TabIndex = 1;
            this.ckbHighQuality.Text = "Khử \"răng cưa\"";
            this.ckbHighQuality.UseVisualStyleBackColor = true;
            // 
            // ckbSpeed
            // 
            this.ckbSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ckbSpeed.AutoSize = true;
            this.ckbSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbSpeed.Location = new System.Drawing.Point(161, 39);
            this.ckbSpeed.Name = "ckbSpeed";
            this.ckbSpeed.Size = new System.Drawing.Size(63, 17);
            this.ckbSpeed.TabIndex = 0;
            this.ckbSpeed.Text = "Vận tốc";
            this.ckbSpeed.UseVisualStyleBackColor = true;
            // 
            // ckbTrail
            // 
            this.ckbTrail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ckbTrail.AutoSize = true;
            this.ckbTrail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbTrail.Location = new System.Drawing.Point(161, 22);
            this.ckbTrail.Name = "ckbTrail";
            this.ckbTrail.Size = new System.Drawing.Size(85, 17);
            this.ckbTrail.TabIndex = 0;
            this.ckbTrail.Text = "Đường dóng";
            this.ckbTrail.UseVisualStyleBackColor = true;
            // 
            // ckbCoordinates
            // 
            this.ckbCoordinates.AutoSize = true;
            this.ckbCoordinates.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbCoordinates.Location = new System.Drawing.Point(6, 39);
            this.ckbCoordinates.Name = "ckbCoordinates";
            this.ckbCoordinates.Size = new System.Drawing.Size(61, 17);
            this.ckbCoordinates.TabIndex = 0;
            this.ckbCoordinates.Text = "Tọa độ";
            this.ckbCoordinates.UseVisualStyleBackColor = true;
            // 
            // ckbGid
            // 
            this.ckbGid.AutoSize = true;
            this.ckbGid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbGid.Location = new System.Drawing.Point(6, 22);
            this.ckbGid.Name = "ckbGid";
            this.ckbGid.Size = new System.Drawing.Size(46, 17);
            this.ckbGid.TabIndex = 0;
            this.ckbGid.Text = "Lưới";
            this.ckbGid.UseVisualStyleBackColor = true;
            // 
            // grb_Params0
            // 
            this.grb_Params0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.grb_Params0.ForeColor = System.Drawing.Color.Black;
            this.grb_Params0.Location = new System.Drawing.Point(12, 380);
            this.grb_Params0.Name = "grb_Params0";
            this.grb_Params0.Size = new System.Drawing.Size(253, 171);
            this.grb_Params0.TabIndex = 2;
            this.grb_Params0.TabStop = false;
            this.grb_Params0.Text = "Tham số ban đầu (t=0)";
            this.grb_Params0.EnabledChanged += new System.EventHandler(this.grb_Params0_EnabledChanged);
            // 
            // txb_alpha0
            // 
            this.txb_alpha0.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_alpha0.Location = new System.Drawing.Point(185, 136);
            this.txb_alpha0.MaxLength = 7;
            this.txb_alpha0.Name = "txb_alpha0";
            this.txb_alpha0.Size = new System.Drawing.Size(51, 22);
            this.txb_alpha0.TabIndex = 5;
            this.txb_alpha0.Text = "45";
            this.txb_alpha0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txb_v0y
            // 
            this.txb_v0y.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_v0y.Location = new System.Drawing.Point(49, 136);
            this.txb_v0y.MaxLength = 7;
            this.txb_v0y.Name = "txb_v0y";
            this.txb_v0y.Size = new System.Drawing.Size(51, 22);
            this.txb_v0y.TabIndex = 3;
            this.txb_v0y.Text = "100";
            this.txb_v0y.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txb_v0
            // 
            this.txb_v0.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_v0.Location = new System.Drawing.Point(185, 105);
            this.txb_v0.MaxLength = 7;
            this.txb_v0.Name = "txb_v0";
            this.txb_v0.Size = new System.Drawing.Size(51, 22);
            this.txb_v0.TabIndex = 4;
            this.txb_v0.Text = "10";
            this.txb_v0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txb_ay
            // 
            this.txb_ay.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_ay.Location = new System.Drawing.Point(185, 47);
            this.txb_ay.MaxLength = 7;
            this.txb_ay.Name = "txb_ay";
            this.txb_ay.Size = new System.Drawing.Size(51, 22);
            this.txb_ay.TabIndex = 7;
            this.txb_ay.Text = "0";
            this.txb_ay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            // 
            // txb_v0x
            // 
            this.txb_v0x.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_v0x.Location = new System.Drawing.Point(49, 105);
            this.txb_v0x.MaxLength = 7;
            this.txb_v0x.Name = "txb_v0x";
            this.txb_v0x.Size = new System.Drawing.Size(51, 22);
            this.txb_v0x.TabIndex = 2;
            this.txb_v0x.Text = "100";
            this.txb_v0x.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txb_ax
            // 
            this.txb_ax.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_ax.Location = new System.Drawing.Point(185, 18);
            this.txb_ax.MaxLength = 7;
            this.txb_ax.Name = "txb_ax";
            this.txb_ax.Size = new System.Drawing.Size(51, 22);
            this.txb_ax.TabIndex = 6;
            this.txb_ax.Text = "-9,80";
            this.txb_ax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.rtb_vx);
            this.panel1.Controls.Add(this.rtb_vy);
            this.panel1.Controls.Add(this.rtb_xt);
            this.panel1.Controls.Add(this.rtb_yt);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(271, 446);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 105);
            this.panel1.TabIndex = 3;
            this.panel1.TabStop = false;
            this.panel1.Text = "Các phương trình:";
            // 
            // rtb_vx
            // 
            this.rtb_vx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_vx.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rtb_vx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_vx.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Italic);
            this.rtb_vx.Location = new System.Drawing.Point(14, 60);
            this.rtb_vx.Multiline = false;
            this.rtb_vx.Name = "rtb_vx";
            this.rtb_vx.ReadOnly = true;
            this.rtb_vx.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtb_vx.Size = new System.Drawing.Size(217, 20);
            this.rtb_vx.TabIndex = 0;
            this.rtb_vx.Text = "...";
            // 
            // rtb_vy
            // 
            this.rtb_vy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_vy.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rtb_vy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_vy.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Italic);
            this.rtb_vy.Location = new System.Drawing.Point(14, 80);
            this.rtb_vy.Multiline = false;
            this.rtb_vy.Name = "rtb_vy";
            this.rtb_vy.ReadOnly = true;
            this.rtb_vy.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtb_vy.Size = new System.Drawing.Size(217, 20);
            this.rtb_vy.TabIndex = 0;
            this.rtb_vy.Text = "abcd";
            // 
            // rtb_xt
            // 
            this.rtb_xt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_xt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rtb_xt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_xt.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Italic);
            this.rtb_xt.Location = new System.Drawing.Point(14, 20);
            this.rtb_xt.Multiline = false;
            this.rtb_xt.Name = "rtb_xt";
            this.rtb_xt.ReadOnly = true;
            this.rtb_xt.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtb_xt.Size = new System.Drawing.Size(217, 20);
            this.rtb_xt.TabIndex = 0;
            this.rtb_xt.Text = "...";
            // 
            // rtb_yt
            // 
            this.rtb_yt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_yt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rtb_yt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_yt.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Italic);
            this.rtb_yt.Location = new System.Drawing.Point(14, 40);
            this.rtb_yt.Multiline = false;
            this.rtb_yt.Name = "rtb_yt";
            this.rtb_yt.ReadOnly = true;
            this.rtb_yt.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtb_yt.Size = new System.Drawing.Size(217, 20);
            this.rtb_yt.TabIndex = 0;
            this.rtb_yt.Text = "...";
            // 
            // grbStatus
            // 
            this.grbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbStatus.Controls.Add(this.rtb_cur_vy);
            this.grbStatus.Controls.Add(this.rtb_cur_vx);
            this.grbStatus.Controls.Add(this.rtb_cur_y);
            this.grbStatus.Controls.Add(this.rtb_cur_x);
            this.grbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbStatus.Location = new System.Drawing.Point(271, 380);
            this.grbStatus.Name = "grbStatus";
            this.grbStatus.Size = new System.Drawing.Size(242, 60);
            this.grbStatus.TabIndex = 3;
            this.grbStatus.TabStop = false;
            this.grbStatus.Text = "t = ...";
            // 
            // rtb_cur_vy
            // 
            this.rtb_cur_vy.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rtb_cur_vy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_cur_vy.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Italic);
            this.rtb_cur_vy.Location = new System.Drawing.Point(127, 37);
            this.rtb_cur_vy.Multiline = false;
            this.rtb_cur_vy.Name = "rtb_cur_vy";
            this.rtb_cur_vy.ReadOnly = true;
            this.rtb_cur_vy.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtb_cur_vy.Size = new System.Drawing.Size(107, 20);
            this.rtb_cur_vy.TabIndex = 0;
            this.rtb_cur_vy.Text = "...";
            // 
            // rtb_cur_vx
            // 
            this.rtb_cur_vx.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rtb_cur_vx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_cur_vx.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Italic);
            this.rtb_cur_vx.Location = new System.Drawing.Point(127, 17);
            this.rtb_cur_vx.Multiline = false;
            this.rtb_cur_vx.Name = "rtb_cur_vx";
            this.rtb_cur_vx.ReadOnly = true;
            this.rtb_cur_vx.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtb_cur_vx.Size = new System.Drawing.Size(107, 20);
            this.rtb_cur_vx.TabIndex = 0;
            this.rtb_cur_vx.Text = "...";
            // 
            // rtb_cur_y
            // 
            this.rtb_cur_y.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rtb_cur_y.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_cur_y.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Italic);
            this.rtb_cur_y.Location = new System.Drawing.Point(14, 37);
            this.rtb_cur_y.Multiline = false;
            this.rtb_cur_y.Name = "rtb_cur_y";
            this.rtb_cur_y.ReadOnly = true;
            this.rtb_cur_y.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtb_cur_y.Size = new System.Drawing.Size(107, 20);
            this.rtb_cur_y.TabIndex = 0;
            this.rtb_cur_y.Text = "...";
            // 
            // rtb_cur_x
            // 
            this.rtb_cur_x.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rtb_cur_x.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_cur_x.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Italic);
            this.rtb_cur_x.Location = new System.Drawing.Point(14, 17);
            this.rtb_cur_x.Multiline = false;
            this.rtb_cur_x.Name = "rtb_cur_x";
            this.rtb_cur_x.ReadOnly = true;
            this.rtb_cur_x.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtb_cur_x.Size = new System.Drawing.Size(107, 20);
            this.rtb_cur_x.TabIndex = 0;
            this.rtb_cur_x.Text = "...";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picInfo
            // 
            this.picInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picInfo.Location = new System.Drawing.Point(660, 391);
            this.picInfo.Name = "picInfo";
            this.picInfo.Size = new System.Drawing.Size(28, 28);
            this.picInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picInfo.TabIndex = 4;
            this.picInfo.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "capture.png");
            this.imageList1.Images.SetKeyName(1, "pause.png");
            this.imageList1.Images.SetKeyName(2, "play.png");
            this.imageList1.Images.SetKeyName(3, "reset.png");
            this.imageList1.Images.SetKeyName(4, "about.png");
            // 
            // picCapture
            // 
            this.picCapture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picCapture.Location = new System.Drawing.Point(615, 391);
            this.picCapture.Name = "picCapture";
            this.picCapture.Size = new System.Drawing.Size(28, 28);
            this.picCapture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picCapture.TabIndex = 4;
            this.picCapture.TabStop = false;
            this.picCapture.Click += new System.EventHandler(this.picCapture_Click);
            // 
            // picReset
            // 
            this.picReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picReset.Location = new System.Drawing.Point(570, 391);
            this.picReset.Name = "picReset";
            this.picReset.Size = new System.Drawing.Size(28, 28);
            this.picReset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picReset.TabIndex = 4;
            this.picReset.TabStop = false;
            this.picReset.Click += new System.EventHandler(this.picReset_Click);
            // 
            // picPlay
            // 
            this.picPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picPlay.Location = new System.Drawing.Point(525, 391);
            this.picPlay.Name = "picPlay";
            this.picPlay.Size = new System.Drawing.Size(28, 28);
            this.picPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picPlay.TabIndex = 4;
            this.picPlay.TabStop = false;
            this.picPlay.Click += new System.EventHandler(this.picPlay_Click);
            // 
            // trb
            // 
            this.trb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.trb.LargeChange = 100;
            this.trb.Location = new System.Drawing.Point(519, 427);
            this.trb.Maximum = 510;
            this.trb.Minimum = 10;
            this.trb.Name = "trb";
            this.trb.Size = new System.Drawing.Size(253, 45);
            this.trb.SmallChange = 5;
            this.trb.TabIndex = 5;
            this.trb.TickFrequency = 20;
            this.trb.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trb.Value = 10;
            this.trb.ValueChanged += new System.EventHandler(this.trb_ValueChanged);
            // 
            // btnLanguage
            // 
            this.btnLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLanguage.Location = new System.Drawing.Point(708, 391);
            this.btnLanguage.Name = "btnLanguage";
            this.btnLanguage.Size = new System.Drawing.Size(64, 28);
            this.btnLanguage.TabIndex = 6;
            this.btnLanguage.Text = "VI ↔ EN";
            this.btnLanguage.UseVisualStyleBackColor = true;
            // 
            // drawForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnLanguage);
            this.Controls.Add(this.trb);
            this.Controls.Add(this.picPlay);
            this.Controls.Add(this.picReset);
            this.Controls.Add(this.picCapture);
            this.Controls.Add(this.picInfo);
            this.Controls.Add(this.grbStatus);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grb_Params0);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.graphBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "drawForm";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.drawForm_FormClosed);
            this.Shown += new System.EventHandler(this.drawForm_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.drawForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.graphBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grb_Params0.ResumeLayout(false);
            this.grb_Params0.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.grbStatus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCapture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.GroupBox panel1;
        private System.Windows.Forms.RichTextBox rtb_yt;
        private System.Windows.Forms.RichTextBox rtb_xt;
        private System.Windows.Forms.RichTextBox rtb_vx;
        private System.Windows.Forms.RichTextBox rtb_vy;
        private System.Windows.Forms.GroupBox grbStatus;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picInfo;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox picCapture;
        private System.Windows.Forms.PictureBox picReset;
        private System.Windows.Forms.PictureBox picPlay;
        private System.Windows.Forms.RichTextBox rtb_cur_x;
        private System.Windows.Forms.RichTextBox rtb_cur_vy;
        private System.Windows.Forms.RichTextBox rtb_cur_vx;
        private System.Windows.Forms.RichTextBox rtb_cur_y;
        private System.Windows.Forms.TrackBar trb;
        private System.Windows.Forms.Button btnLanguage;
    }
}

