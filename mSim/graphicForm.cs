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
        string fontname = "consolas";
        float fontsize = 9F;
        Font myFont;
        float scaleF = 1F;
        float xO = 15F;
        float yO = 15F;
        Image backGround;

        public drawForm()
        {
            InitializeComponent();
            //backGround = new Bitmap(graphBox.Width, graphBox.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            LoadSettings();
        }

        private void LoadSettings()
        {
            myFont = new Font(fontname, fontsize, FontStyle.Bold);
        }

        private Image DrawAxis(int width, int height, float xO=0, float yO = 0, string xlabel = "x", string ylabel = "y")
        {
            Image img = new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);

            Graphics g = Graphics.FromImage(img);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            //g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            
            Pen p = new Pen(Brushes.Black, 1F);
            
            g.FillRectangle(Brushes.LightGray, 0, 0, width, height);

            g.DrawLine(p, 0, height - yO, width, height- yO);
            g.DrawLine(p, width-1, height - yO, width - 10, height - yO - 5);
            g.DrawLine(p, width-1, height - yO, width - 10, height - yO + 5);

            g.DrawLine(p, xO, height, xO, 0);
            g.DrawLine(p, xO, 0, xO + 5, 11);
            g.DrawLine(p, xO, 0, xO - 5, 11);

            Font f = new Font(fontname, fontsize);
            g.DrawString(xlabel, myFont, Brushes.Black, width - 20, height -15);
            g.DrawString(ylabel, myFont, Brushes.Black, xO-15, 10);
            return img;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            backGround?.Dispose();
            backGround = DrawAxis(graphBox.Width, graphBox.Height, xO, yO);
            graphBox.Image = backGround;
            GC.Collect();
        }

        bool drag = false;
        int mX = 0;
        int mY = 0;
        private void graphBox_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            mX = e.X;
            mY = e.Y;
        }

        private void graphBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                int dX = e.X;// - mX;
                int dY = e.Y;// - mY;
                xO = xO + dX;
                yO = yO + dY;

                label1.Text = "mX: " + mX + "| mY: " + mY + "| eX: " + dX + "| eY: " + dY;

                //backGround?.Dispose();
                //backGround = DrawAxis(graphBox.Width, graphBox.Height, xO, yO);
                //graphBox.Image = backGround;
                //GC.Collect();
            }
        }

        private void graphBox_MouseUp(object sender, MouseEventArgs e)
        {
            xO = 15;
            yO = 15;
            drag = false;
        }
    }
}
