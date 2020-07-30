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
    public partial class FormInfo : Form
    {
        public FormInfo(string lang="")
        {
            InitializeComponent();
            if (lang == "en")
            {
                this.Text = "THANK YOU VERY MUCH FOR GO HERE! :))";
                lblDonate.Text = "Donate:";
                lblPlayPaused.Text = "Play/Pause";
                lblCapture.Text = "Save Image";
                lblReSet.Text = "Reset";
                lblExportVideo.Text = "Export video (It's hidden feature, active after 3 times)";
                lblNextFrame.Text = "Next situation (when paused only)";
                lblPreviousFrame.Text = "Previous situation (when paused only)";
                label6.Text = "Hot keys:";
            }
            else if (lang == "vi")
            {
                this.Text = "THÔNG TIN";
                lblDonate.Text = "Ủng hộ tác giả:";
                lblPlayPaused.Text = "Chạy/tạm dừng mô phỏng";
                lblCapture.Text = "Lưu ảnh";
                lblReSet.Text = "Về trạng thái ban đầu";
                lblExportVideo.Text = "Xuất video (Đã ẩn khỏi UI, kích hoạt sau 3 lần ấn)";
                lblNextFrame.Text = "Vị trí liền sau (chỉ hiệu lực khi đang tạm dừng)";
                lblPreviousFrame.Text = "vị trí liền trước (chỉ hiệu lực khi đang tạm dừng)";
                label6.Text = "Các phím tắt:";
            }
        }

        private void frmInfo_Load(object sender, EventArgs e)
        {

        }

        private void ptb_Github_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            p.StartInfo = new ProcessStartInfo("https://github.com/ChetDuoiKhiDanhRang/mSim");
            p.Start();
        }

        private void pictureBoxes_MouseEnter(object sender, EventArgs e)
        {
            Control p = (Control)sender;
            p.Cursor = Cursors.Hand;

        }

        private void pic_Author_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            Process p = new Process();
            p.StartInfo = new ProcessStartInfo("mailto:nguyenngoccuongls@gmail.com");
            p.Start();
        }
    }
}
