using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mSim
{
    public partial class FormExportVideo : Form
    {
        public int minStep { get; set; }
        public int maxStep { get; set; }

        public decimal StartTime { get; set; }
        public decimal Duration { get; set; }
        public int FPS { get; set; }

        public FormExportVideo(string lang, int timeOffset)
        {
            InitializeComponent();
            nudStartTime.Minimum = (-timeOffset * 0.01M);
            nudStartTime.Maximum = (timeOffset * 0.01M);
            nudDuration.Minimum = 1M;
            nudDuration.Maximum = nudStartTime.Maximum - nudStartTime.Value;
            cmbFPS.SelectedIndex = 0;
            nudStartTime.Value = 0;
            nudDuration.Value = nudDuration.Maximum;
            if (lang == "vi")
            {

            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            StartTime = nudStartTime.Value;
            Duration = nudDuration.Value;
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnOK.Enabled = cmbFPS.SelectedIndex >= 0;
            if (btnOK.Enabled)
            {
                FPS = int.Parse((string)cmbFPS.SelectedItem);
            }
        }

        private void nudStartTime_ValueChanged(object sender, EventArgs e)
        {
            nudDuration.Maximum = nudStartTime.Maximum - nudStartTime.Value;
        }
    }
}
