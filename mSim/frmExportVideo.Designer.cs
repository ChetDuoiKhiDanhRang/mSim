namespace mSim
{
    partial class FormExportVideo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExportVideo));
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.nudStartTime = new System.Windows.Forms.NumericUpDown();
            this.nudDuration = new System.Windows.Forms.NumericUpDown();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblFPS = new System.Windows.Forms.Label();
            this.cmbFPS = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.Location = new System.Drawing.Point(13, 55);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(61, 13);
            this.lblDuration.TabIndex = 0;
            this.lblDuration.Text = "Duration:";
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartTime.Location = new System.Drawing.Point(13, 21);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(73, 13);
            this.lblStartTime.TabIndex = 0;
            this.lblStartTime.Text = "Start time:";
            // 
            // nudStartTime
            // 
            this.nudStartTime.DecimalPlaces = 2;
            this.nudStartTime.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudStartTime.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudStartTime.Location = new System.Drawing.Point(153, 19);
            this.nudStartTime.Name = "nudStartTime";
            this.nudStartTime.Size = new System.Drawing.Size(62, 20);
            this.nudStartTime.TabIndex = 0;
            this.nudStartTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudStartTime.ThousandsSeparator = true;
            this.nudStartTime.ValueChanged += new System.EventHandler(this.nudStartTime_ValueChanged);
            // 
            // nudDuration
            // 
            this.nudDuration.DecimalPlaces = 2;
            this.nudDuration.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDuration.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudDuration.Location = new System.Drawing.Point(153, 53);
            this.nudDuration.Name = "nudDuration";
            this.nudDuration.Size = new System.Drawing.Size(62, 20);
            this.nudDuration.TabIndex = 1;
            this.nudDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudDuration.ThousandsSeparator = true;
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(16, 108);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(131, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblFPS
            // 
            this.lblFPS.AutoSize = true;
            this.lblFPS.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFPS.Location = new System.Drawing.Point(13, 84);
            this.lblFPS.Name = "lblFPS";
            this.lblFPS.Size = new System.Drawing.Size(31, 13);
            this.lblFPS.TabIndex = 0;
            this.lblFPS.Text = "FPS:";
            // 
            // cmbFPS
            // 
            this.cmbFPS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFPS.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFPS.FormatString = "%-3d";
            this.cmbFPS.FormattingEnabled = true;
            this.cmbFPS.Items.AddRange(new object[] {
            "25",
            "30",
            "50"});
            this.cmbFPS.Location = new System.Drawing.Point(153, 81);
            this.cmbFPS.Name = "cmbFPS";
            this.cmbFPS.Size = new System.Drawing.Size(62, 21);
            this.cmbFPS.TabIndex = 2;
            this.cmbFPS.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(153, 108);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(62, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(221, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "(s)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(221, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "(s)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "(fps)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(263, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FormExportVideo
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(403, 139);
            this.Controls.Add(this.cmbFPS);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.nudDuration);
            this.Controls.Add(this.nudStartTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblStartTime);
            this.Controls.Add(this.lblFPS);
            this.Controls.Add(this.lblDuration);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(419, 178);
            this.MinimumSize = new System.Drawing.Size(419, 178);
            this.Name = "FormExportVideo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Export video...";
            ((System.ComponentModel.ISupportInitialize)(this.nudStartTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.NumericUpDown nudStartTime;
        private System.Windows.Forms.NumericUpDown nudDuration;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblFPS;
        private System.Windows.Forms.ComboBox cmbFPS;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}