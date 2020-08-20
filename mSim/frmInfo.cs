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
                this.Text = "THANKS FOR USING MSIM! :))";
                lblDonate.Text = "Donate:";
                lblPlayPaused.Text = "Play/Pause";
                lblCapture.Text = "Save Image";
                lblReSet.Text = "Reset";
                lblExportVideo.Text = "Export video";
                lblNextFrame.Text = "Next (when paused only)";
                lblPreviousFrame.Text = "Previous (when paused only)";
                label6.Text = "Hot keys:";
                txbInfo.Text = "Motion Simulator - a program that simulates arbitrary motions with constant acceleration in the Oxy coordinate system of a material point such as Free fall motion, projectile motion etc";
            }
            else if (lang == "vi")
            {
                this.Text = "THÔNG TIN";
                lblDonate.Text = "Ủng hộ tác giả:";
                lblPlayPaused.Text = "Chạy/tạm dừng mô phỏng";
                lblCapture.Text = "Lưu ảnh";
                lblReSet.Text = "Về trạng thái ban đầu";
                lblExportVideo.Text = "Xuất video";
                lblNextFrame.Text = "Vị trí liền sau (chỉ hiệu lực khi đang tạm dừng)";
                lblPreviousFrame.Text = "vị trí liền trước (chỉ hiệu lực khi đang tạm dừng)";
                label6.Text = "Các phím tắt:";
                txbInfo.Text = "Motion simulator - chương trình giả lập chuyển động bất kì với gia tốc không đổi của chất điểm trong mặt phẳng tọa độ Oxy (chuyển động rơi tự do, chuyển động ném xiên,…)";
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
            var c = (Control)sender;
            string ctn = "mailto:nguyenngoccuongls@gmail.com";
            if (c.Name == pic_Author.Name)
            {
                ctn = "mailto:nguyenngoccuongls@gmail.com";
            }
            else if (c.Name == pic_Author2.Name)
            {
                ctn = "mailto:qingxiangruc@gmail.com";
            }
            Process p = new Process();
            p.StartInfo = new ProcessStartInfo(ctn);
            p.Start();
        }

        int donate = 2;
        private void radUSD_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdb = (RadioButton)sender;
            if (rdb.Name == rad2USD.Name)
            {
                donate = 2;
            }
            else if (rdb.Name == rad3USD.Name)
            {
                donate = 3;
            }
            else if (rdb.Name == rad5USD.Name)
            {
                donate = 5;
            }
        }

        private void pic_PayPal_Click(object sender, EventArgs e)
        {
            string link = "https://paypal.me/nguyenngoccuongls/";
            string donateValue = donate + "USD";
            string donateLink = link + donateValue;
            Process p = new Process();
            p.StartInfo = new ProcessStartInfo(donateLink);
            p.Start();
        }
    }
}
