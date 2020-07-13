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

        float BASE_X0 = 25F;
        float BASE_Y0 = 25F;
        float x0;
        float y0;


        Bitmap background;
        Bitmap intervals;
        Bitmap moveingLine;
        int Delta_X;
        int Delta_Y;

        Point[] points_ox;
        Point[] points_oy;

        public drawForm()
        {
            InitializeComponent();
            LoadSettings();

            myFont = new Font(fontname, fontsize, FontStyle.Bold);
            background = new Bitmap(graphBox.Width, graphBox.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
        }

        private void LoadSettings()
        {
        }

        private void DrawAxis(Bitmap bitmap, float _x0 = 0, float _y0 = 0, string xlabel = "x", string ylabel = "y")
        {
            //Image img = new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            int width = bitmap.Width;
            int height = bitmap.Height;

            Graphics g = Graphics.FromImage(bitmap);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            //g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;

            Pen p = new Pen(Brushes.Black, 1F);

            g.FillRectangle(Brushes.LightGray, 0, 0, width, height);

            g.DrawLine(p, 0, height - _y0, width, height - _y0);
            g.DrawLine(p, width - 2, height - _y0, width - 11, height - _y0 - 5);
            g.DrawLine(p, width - 2, height - _y0, width - 11, height - _y0 + 5);

            g.DrawLine(p, _x0, height, _x0, 0);
            g.DrawLine(p, _x0, 0, _x0 + 5, 11);
            g.DrawLine(p, _x0, 0, _x0 - 5, 11);

            g.DrawString(xlabel, myFont, Brushes.Black, width - 20, height - _y0);
            g.DrawString(ylabel, myFont, Brushes.Black, _x0 - 15, 8);
            g.DrawString("0", myFont, Brushes.Black, _x0 - 10, height - _y0);
        }

        bool drag = false;
        int mX = 0;
        int mY = 0;
        int offsetX = 0;
        int offsetY = 0;
        private void graphBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                drag = true;
                mX = e.Location.X;
                mY = e.Location.Y;
                graphBox.Cursor = Cursors.NoMove2D;
            }
        }

        private void graphBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                offsetX = e.Location.X - mX;
                offsetY = e.Location.Y - mY;

                x0 = BASE_X0 + offsetX;
                y0 = BASE_Y0 - offsetY;

                DrawAxis(background, x0, y0);
                graphBox.Refresh();
            }
        }

        private void graphBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                BASE_X0 = BASE_X0 + offsetX;
                BASE_Y0 = BASE_Y0 - offsetY;
                drag = false;
                graphBox.Cursor = Cursors.Default;
            }
        }

        private void drawForm_Shown(object sender, EventArgs e)
        {
            DrawAxis(background, BASE_X0, BASE_Y0);
            x0 = BASE_X0;
            y0 = BASE_Y0;
            CalculateIntervals(graphBox, Delta_X, Delta_Y);
            graphBox.BackgroundImage = background;
        }

        private void CalculateIntervals(PictureBox graphBox, int delta_X, int delta_Y)
        {

        }

        private void graphBox_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                background = new Bitmap(graphBox.Width, graphBox.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                DrawAxis(background, x0, y0);
                graphBox.BackgroundImage = background;
                graphBox.Refresh();
                GC.Collect();
            }
        }
    }
}
