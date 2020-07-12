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
            backGround = new Bitmap(graphBox.Width, graphBox.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
        }

        private void LoadSettings()
        {
           
        }

        private Bitmap DrawAxis(int imageWidth, int imageHeight, int ox=0, int oy = 0, string xlabel = "x", string ylabel = "y")
        {


            return null;
        }
    }
}
