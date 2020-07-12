using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mSim
{
    public partial class drawForm : Form
    {
        Image backGround;
        public drawForm()
        {
            InitializeComponent();
            backGround = new Image();
        }

        private void LoadSettings()
        {
           
        }

        private void DrawAxis(PictureBox pictureBox, int ox=0, int oy = 0)
        {

        }
    }
}
