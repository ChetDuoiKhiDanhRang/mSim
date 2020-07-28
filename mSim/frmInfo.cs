using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mSim
{
    public partial class frmInfo : Form
    {
        public frmInfo(string lang="")
        {
            InitializeComponent();
            if (lang == "en")
            {
                label9.Text = "Author:";
                lblPlayPaused.Text = "Play/Pause";
                lblCapture.Text = "Save Image";
                lblReSet.Text = "Reset";
                lblExportVideo.Text = "Export videos";
                lblNextFrame.Text = "Next value (when paused only)";
                lblPreviousFrame.Text = "Previous value (when paused only)";
                label6.Text = "Hot keys:";
            }
            else if (lang == "vi")
            {
                label9.Text = "Tác giả:";
                lblPlayPaused.Text = "Chạy/tạm dừng mô phỏng";
                lblCapture.Text = "Lưu ảnh";
                lblReSet.Text = "Vè trạng thái ban đầu";
                lblExportVideo.Text = "Xuất video";
                lblNextFrame.Text = "Vị trí liền sau (chỉ hiệu lực khi đang tạm dừng)";
                lblPreviousFrame.Text = "vị trí liền trước (chỉ hiệu lực khi đang tạm dừng)";
                label6.Text = "Các phím tắt:";
            }
        }

        private void frmInfo_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            p.StartInfo = new ProcessStartInfo("https://github.com/ChetDuoiKhiDanhRang/mSim");
            p.Start();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Cursor = Cursors.Hand;

        }
    }
}
