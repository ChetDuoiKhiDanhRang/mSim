using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace mSim
{
    public partial class drawForm : Form
    {
        string axis_fontname = "Consolas";
        float axis_fontsize = 10F;

        string interval_fontname = "consolas";
        float interval_fontsize = 8F;

        string object_fontname = "Cambria";
        float object_fontsize = 10F;

        Font myFont_axis;
        Font myFont_Intervals;
        Font myFont_Object;

        int BASE_X0 = 90;
        int BASE_Y0 = 90;
        int x0;
        int y0;

        int baseStepX = 50;
        int baseStepY = 50;
        int stepX;
        int stepY;

        int MAX_STEP_X = 120;
        int MIN_STEP_X = 30;
        int MAX_STEP_Y = 120;
        int MIN_STEP_Y = 30;

        //int MAX_COUNT_X = 30;
        //int MAX_COUNT_Y = 30;
        //int MIN_COUNT_X = 8;
        //int MIN_COUNT_Y = 8;

        float stepValueX = 5F;
        float stepValueY = 5F;

        Bitmap background;
        public Bitmap BackgroundLayer { get => background; set => background = value; }

        Bitmap axisLayer;
        public Bitmap AxisLayer
        {
            get => axisLayer;
            set
            {
                axisLayer = value;
                //if (value != null)
                //{
                //    Intervals?.Dispose();
                //    Intervals = background.Clone() as Bitmap; 
                //}
            }
        }

        Bitmap intervalsLayer;
        public Bitmap IntervalsLayer
        {
            get => intervalsLayer;
            set
            {
                intervalsLayer = value;
                //if (value != null)
                //{
                //    movingLine?.Dispose();
                //    movingLine = intervals.Clone() as Bitmap; 
                //}
            }
        }


        Bitmap movingLine;
        public Bitmap MovingLine { get => movingLine; set => movingLine = value; }

        Bitmap movingObject;
        public Bitmap MovingObject { get => movingObject; set => movingObject = value; }



        Point[] points_ox;
        Point[] points_oy;

        bool showGrid;
        bool showCoordinates;
        bool showTrails;
        bool showSpeeds;

        bool isRunning = false;
        public drawForm()
        {
            InitializeComponent();


            stepX = baseStepX;
            stepY = baseStepY;

            myFont_axis = new Font(axis_fontname, axis_fontsize, FontStyle.Bold | FontStyle.Italic);
            myFont_Intervals = new Font(interval_fontname, interval_fontsize, FontStyle.Regular);
            myFont_Object = new Font(object_fontname, object_fontsize, FontStyle.Regular);

        }

        private void LoadSettings()
        {
            var x = Properties.Settings.Default;
            showGrid = ckbGid.Checked = x.showGrid;
            showCoordinates = ckbCoordinates.Checked = x.showCoodinates;

        }

        private void SaveSettings()
        {
            var x = Properties.Settings.Default;
            x.showGrid = showGrid;
            x.showCoodinates = showCoordinates;
            x.Save();
        }


        bool drag = false;
        int mouseDownX = 0;
        int mouseDownY = 0;
        int offsetX = 0;
        int offsetY = 0;

        private void drawForm_Shown(object sender, EventArgs e)
        {
            x0 = BASE_X0;
            y0 = BASE_Y0;


            BackgroundLayer = new Bitmap(graphBox.Width, graphBox.Height, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
            Graphics g = Graphics.FromImage(BackgroundLayer);
            g.Clear(Color.WhiteSmoke);
            g.Dispose();
            IntervalsLayer = BackgroundLayer.Clone() as Bitmap;
            DrawIntervals(IntervalsLayer, x0, y0, stepX, stepY, stepValueX, stepValueY, showGrid, showCoordinates);
            AxisLayer = IntervalsLayer.Clone() as Bitmap;
            DrawAxis(AxisLayer, x0, y0);
            graphBox.BackgroundImage = AxisLayer;

            graphBox.MouseWheel += GraphBox_MouseWheel;
            LoadSettings();
        }


        private void drawForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveSettings();
        }


        //Controls events--------------------------------------------------------------------------------------------------------------------
        private void GraphBox_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                ZoomOut();
            }
            else
            {
                ZoomIn();
            }
            ReDraw_Background_Intervals_Axis();
            graphBox.BackgroundImage = AxisLayer;
        }

        private void graphBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                drag = true;
                mouseDownX = e.Location.X;
                mouseDownY = e.Location.Y;
                graphBox.Cursor = Cursors.NoMove2D;
            }
        }

        private void graphBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                offsetX = (e.Location.X - mouseDownX)/4;
                offsetY = (e.Location.Y - mouseDownY)/4;

                x0 = BASE_X0 + offsetX;
                y0 = BASE_Y0 - offsetY;


                ReDraw_Background_Intervals_Axis();
                graphBox.BackgroundImage = AxisLayer;
                //graphBox.Refresh();
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
                GC.Collect();
            }
        }

        private void graphBox_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                BackgroundLayer.Dispose();
                BackgroundLayer = new Bitmap(graphBox.Width, graphBox.Height, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
                Graphics g = Graphics.FromImage(BackgroundLayer);
                g.Clear(Color.WhiteSmoke);
                g.Dispose();
                ReDraw_Background_Intervals_Axis();
                graphBox.BackgroundImage = AxisLayer;
            }
        }

        private void ckbGid_CheckedChanged(object sender, EventArgs e)
        {
            showGrid = ckbGid.Checked;
            if (!isRunning)
            {
                ReDraw_Background_Intervals_Axis();
                graphBox.BackgroundImage = AxisLayer;
            }
        }

        private void ckbCoordinates_CheckedChanged(object sender, EventArgs e)
        {
            showCoordinates = ckbCoordinates.Checked;
            if (!isRunning)
            {
                ReDraw_Background_Intervals_Axis();
                graphBox.BackgroundImage = AxisLayer;
            }
        }


        //METHODS-----------------------------------------------------------------------------------------------------------------------------
        private void ReDraw_Background_Intervals_Axis()
        {
            IntervalsLayer.Dispose();
            AxisLayer.Dispose();
            IntervalsLayer = BackgroundLayer.Clone() as Bitmap;
            DrawIntervals(IntervalsLayer, x0, y0, stepX, stepY, stepValueX, stepValueY, showGrid, showCoordinates);
            AxisLayer = IntervalsLayer.Clone() as Bitmap;
            DrawAxis(AxisLayer, x0, y0);
            //graphBox.Refresh();

        }

        private void DrawAxis(Bitmap bitmap, int _x0 = 0, int _y0 = 0, string xlabel = "x", string ylabel = "y")
        {
            //Image img = new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            int width = bitmap.Width;
            int height = bitmap.Height;

            Graphics g = Graphics.FromImage(bitmap);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Low;
            g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.None;
            g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighSpeed;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixel;

            Pen p = new Pen(Brushes.Black, 1F);

            //g.FillRectangle(Brushes.WhiteSmoke, 0, 0, width, height);

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            //draw x axis
            g.DrawLine(p, 0, height - _y0, width, height - _y0);
            g.DrawLine(p, width - 2, height - _y0, width - 11, height - _y0 - 5);
            g.DrawLine(p, width - 2, height - _y0, width - 11, height - _y0 + 5);

            //draw y axis
            g.DrawLine(p, _x0, height, _x0, 0);
            g.DrawLine(p, _x0, 0, _x0 + 5, 11);
            g.DrawLine(p, _x0, 0, _x0 - 5, 11);

            //draw axis label
            g.DrawString(xlabel, myFont_axis, Brushes.DarkRed, width - 15, height - _y0 + 6);
            g.DrawString(ylabel, myFont_axis, Brushes.DarkRed, _x0 - 20, 5);
            //g.DrawString("0", myFont, Brushes.Black, _x0 - 12, height - _y0 +4);

            p.Dispose();
            g.Dispose();
        }

        private void DrawIntervals(Bitmap bitmap, int _x0, int _y0, int _stepX, int _stepY, float _stepValueX, float _stepValueY, bool _showGrid, bool _showCoordinates)
        {

            int subStepX = _stepX / 5;
            int startX = (_x0 % subStepX);
            int endX = bitmap.Width - (bitmap.Width - _x0) % subStepX - (showGrid ? 0 : (2 * subStepX));

            int subStepY = _stepY / 5;
            int startY = bitmap.Height - (_y0 % subStepY);
            int endY = (bitmap.Height - _y0) % subStepY + (showGrid ? 0 : (2 * subStepY));

            Graphics g = Graphics.FromImage(bitmap);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Low;
            g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.None;
            g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighSpeed;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixel;

            Pen p1 = new Pen(Brushes.Black, 1F);
            Pen p2 = new Pen(Brushes.Gray, 1F);
            Pen p1g = new Pen(Brushes.Gray, 1F); //for grid lines
            Pen p2g = new Pen(Brushes.LightGray, 1F); //for grid lines

            if (_showGrid)
            {
                for (int i = startX; i <= endX; i += subStepX)
                {
                    g.DrawLine(p2g, i, 0, i, bitmap.Height);
                }
            }
            else
            {
                for (int i = startX; i <= endX; i += subStepX)
                {
                    g.DrawLine(p2, i, (bitmap.Height - _y0 - 2), i, (bitmap.Height - _y0 + 2));
                }
            }

            for (int i = startY; i >= endY; i -= subStepY)
            {
                g.DrawLine(_showGrid ? p2g : p2, _showGrid ? 0 : (_x0 - 2), i, _showGrid ? bitmap.Width : (_x0 + 2), i);
                if ((i - (bitmap.Height - _y0)) % _stepY == 0)
                {
                    g.DrawLine(_showGrid ? p1g : p1, _showGrid ? 0 : (_x0 - 4), i, _showGrid ? bitmap.Width : (_x0 + 4), i);
                    if (i != (bitmap.Height - _y0) && _showCoordinates)
                    {
                        string va;
                        va = ((float)(((bitmap.Height - _y0) - i) / _stepY) * _stepValueY).ToString();
                        //g.DrawString(va, myFont_Intervals, Brushes.Black, i - 9, bitmap.Height - _y0 + 4);
                        g.DrawString(va, myFont_Intervals, Brushes.DarkBlue, _x0 - (int)(g.MeasureString(va, myFont_Intervals).Width) - 4,
                            i - (int)(g.MeasureString(va, myFont_Intervals).Height / 2));
                    }
                }
            }

            for (int i = (_x0 % _stepX); i <= endX; i += _stepX)
            {
                if ((i != _x0))
                {

                    if (!_showGrid)
                    {
                        g.DrawLine(p1, i, (bitmap.Height - _y0 - 4), i, (bitmap.Height - _y0 + 4));
                    }
                    else
                    {
                        g.DrawLine(p1g, i, 0, i, bitmap.Height);
                    }

                    if (_showCoordinates)
                    {
                        string va;
                        va = ((float)((i - _x0) / _stepX) * _stepValueX).ToString();
                        g.DrawString(va, myFont_Intervals, Brushes.DarkBlue, i - (int)((g.MeasureString(va, myFont_Intervals).Width) / 2),
                            bitmap.Height - _y0 + (int)(g.MeasureString(va, myFont_Intervals).Height * 0.3F));
                    }
                }
            }

            p1.Dispose();
            p2.Dispose();
            p1g.Dispose();
            p2g.Dispose();
            g.Dispose();
        }



        private void ZoomIn()
        {
            stepX -= 10;
            stepY -= 10;
            if (stepX < MIN_STEP_X)
            {
                stepX = MAX_STEP_X;
                stepValueX = stepValueX * 2;
            }
            if (stepY < MIN_STEP_Y)
            {
                stepY = MAX_STEP_Y;
                stepValueY = stepValueY * 2;
            }
        }

        private void ZoomOut()
        {
            stepX += 10;
            stepY += 10;
            if (stepX > MAX_STEP_X)
            {
                stepX = MIN_STEP_X;
                stepValueX = stepValueX / 2;
            }
            if (stepY > MAX_STEP_Y)
            {
                stepY = MIN_STEP_Y;
                stepValueY = stepValueY / 2;
            }
        }


    }
}
