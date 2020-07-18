using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace mSim
{
    public partial class drawForm : Form
    {
        public event EventHandler<bool> SpeedModeChanged;
        public event EventHandler<float> Obj_x0Changed;
        public event EventHandler<float> Obj_y0Changed;

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
        int MIN_STEP_X = 40;
        int MAX_STEP_Y = 120;
        int MIN_STEP_Y = 40;

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


        Bitmap movingLineLayer;
        public Bitmap MovingLineLayer { get => movingLineLayer; set => movingLineLayer = value; }

        Bitmap movingObjectLayer;
        public Bitmap MovingObjectLayer { get => movingObjectLayer; set => movingObjectLayer = value; }

        bool showGrid;
        bool showCoordinates;
        bool showTrails;
        bool showSpeeds;
        bool highQuality;

        bool xYSpeedMode;
        public bool XYSpeedMode
        {
            get => xYSpeedMode;
            set
            {
                xYSpeedMode = value;
                SpeedModeChanged?.Invoke(this, xYSpeedMode);
            }
        }

        bool isRunning = false;
        public bool IsRunning { get => isRunning; set => isRunning = value; }

        float obj_x0;
        float obj_y0;
        float obj_v0x;
        float obj_v0y;
        float obj_ax;
        float obj_ay;
        float obj_alpha0;
        float obj_v0;
        public float Obj_x0 { get => obj_x0; set { obj_x0 = value; Obj_x0Changed?.Invoke(this, value); } }
        public float Obj_y0 { get => obj_y0; set { obj_y0 = value; Obj_y0Changed?.Invoke(this, value); } }
        public float Obj_v0x { get => obj_v0x; set => obj_v0x = value; }
        public float Obj_v0y { get => obj_v0y; set => obj_v0y = value; }
        public float Obj_ax { get => obj_ax; set => obj_ax = value; }
        public float Obj_ay { get => obj_ay; set => obj_ay = value; }
        public float Obj_alpha0 { get => obj_alpha0; set => obj_alpha0 = value; }
        public float Obj_v0 { get => obj_v0; set => obj_v0 = value; }

        public drawForm()
        {
            InitializeComponent();

            SpeedModeChanged += DrawForm_SpeedModeChanged;

            Font labelFont = new Font(rtb_x0.Font.Name, (rtb_x0.Font.Size * 0.8F));

            rtb_x0.Text = "x0:";
            rtb_x0.Select(1, rtb_x0.Text.Length - 2);
            rtb_x0.SelectionFont = labelFont;
            rtb_x0.SelectionCharOffset = -5;

            rtb_y0.Text = "y0:";
            rtb_y0.Select(1, rtb_y0.Text.Length - 2);
            rtb_y0.SelectionFont = labelFont;
            rtb_y0.SelectionCharOffset = -5;

            rtb_ax.Text = "ax:";
            rtb_ax.Select(1, rtb_ax.Text.Length - 2);
            rtb_ax.SelectionFont = labelFont;
            rtb_ax.SelectionCharOffset = -5;

            rtb_ay.Text = "ay:";
            rtb_ay.Select(1, rtb_ay.Text.Length - 2);
            rtb_ay.SelectionFont = labelFont;
            rtb_ay.SelectionCharOffset = -5;

            rtb_v0x.Text = "v0x:";
            rtb_v0x.Select(1, rtb_v0x.Text.Length - 2);
            rtb_v0x.SelectionFont = labelFont;
            rtb_v0x.SelectionCharOffset = -5;

            rtb_v0y.Text = "v0y:";
            rtb_v0y.Select(1, rtb_v0y.Text.Length - 2);
            rtb_v0y.SelectionFont = labelFont;
            rtb_v0y.SelectionCharOffset = -5;

            rtb_v0.Text = "v0:";
            rtb_v0.Select(1, rtb_v0.Text.Length - 2);
            rtb_v0.SelectionFont = labelFont;
            rtb_v0.SelectionCharOffset = -5;

            rtb_alpha0.Text = "α0:";
            rtb_alpha0.Select(1, rtb_alpha0.Text.Length - 2);
            rtb_alpha0.SelectionFont = labelFont;
            rtb_alpha0.SelectionCharOffset = -5;


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
            showTrails = ckbTrail.Checked = x.showTrails;
            showSpeeds = ckbSpeed.Checked = x.showSpeeds;
            highQuality = ckbHighQuality.Checked = x.highQuality;
            XYSpeedMode = rad_speedmode.Checked = x.XYSpeedMode;

            Obj_ax = x.last_ax;
            Obj_ay = x.last_ay;
            Obj_x0 = x.last_x0;
            Obj_y0 = x.last_y0;

            txb_ax.Text = Obj_ax.ToString();
            txb_ay.Text = Obj_ay.ToString();
            txb_x0.Text = Obj_x0.ToString();
            txb_y0.Text = Obj_y0.ToString();

            Obj_v0 = x.last_v0;
            Obj_alpha0 = x.last_alpha0;
            Obj_v0x = x.last_v0x;
            Obj_v0y = x.last_v0y;

            txb_v0.Text = Obj_v0.ToString();
            txb_alpha0.Text = Obj_alpha0.ToString();
            txb_v0x.Text = Obj_v0x.ToString();
            txb_v0y.Text = Obj_v0y.ToString();
        }
        private void SaveSettings()
        {
            var x = Properties.Settings.Default;
            x.showGrid = showGrid;
            x.showCoodinates = showCoordinates;
            x.showTrails = showTrails;
            x.showSpeeds = showSpeeds;
            x.highQuality = highQuality;
            x.XYSpeedMode = XYSpeedMode;

            x.last_ax = Obj_ax;
            x.last_ay = Obj_ay;
            x.last_x0 = Obj_x0;
            x.last_y0 = Obj_y0;

            x.last_v0 = Obj_v0;
            x.last_alpha0 = Obj_alpha0;
            x.last_v0x = Obj_v0x;
            x.last_v0y = Obj_v0y;

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
            MovingLineLayer = AxisLayer.Clone() as Bitmap;
            MovingObjectLayer = AxisLayer.Clone() as Bitmap;

            graphBox.BackgroundImage = AxisLayer;

            LoadSettings();
            this.Obj_x0Changed += DrawForm_Obj_x0Changed;
            this.Obj_y0Changed += DrawForm_Obj_y0Changed;
            graphBox.MouseWheel += GraphBox_MouseWheel;

        }

        private void DrawForm_Obj_y0Changed(object sender, float e)
        {
            ReZoomY(e);
        }

        private void DrawForm_Obj_x0Changed(object sender, float e)
        {
            ReZoomX(e);
        }

        private void drawForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveSettings();
        }
        private void DrawForm_SpeedModeChanged(object sender, bool e)
        {
            rtb_v0x.Enabled = rtb_v0y.Enabled = txb_v0x.Enabled = txb_v0y.Enabled = XYSpeedMode;
            rtb_v0.Enabled = rtb_alpha0.Enabled = txb_v0.Enabled = txb_alpha0.Enabled = !XYSpeedMode;
        }


        //CONTROLS EVENTS====================================================================================================================
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
                offsetX = (e.Location.X - mouseDownX);
                offsetY = (e.Location.Y - mouseDownY);

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

        //---------------------------------------------------------------------------

        private void ckbGid_CheckedChanged(object sender, EventArgs e)
        {
            showGrid = ckbGid.Checked;
            if (!IsRunning)
            {
                ReDraw_Background_Intervals_Axis();
                graphBox.BackgroundImage = AxisLayer;
            }
        }

        private void ckbCoordinates_CheckedChanged(object sender, EventArgs e)
        {
            showCoordinates = ckbCoordinates.Checked;
            if (!IsRunning)
            {
                ReDraw_Background_Intervals_Axis();
                graphBox.BackgroundImage = AxisLayer;
            }
        }

        private void ckbHighQuality_CheckedChanged(object sender, EventArgs e)
        {
            highQuality = ckbHighQuality.Checked;
            if (!IsRunning)
            {
                ReDraw_Background_Intervals_Axis();
                graphBox.BackgroundImage = AxisLayer;
            }
        }

        private void ckbTrail_CheckedChanged(object sender, EventArgs e)
        {
            showTrails = ckbTrail.Checked;
            if (!IsRunning)
            {
                ReDraw_Background_Intervals_Axis();
                graphBox.BackgroundImage = AxisLayer;
            }
        }

        private void ckbSpeed_CheckedChanged(object sender, EventArgs e)
        {
            showSpeeds = ckbSpeed.Checked;
            if (!IsRunning)
            {
                ReDraw_Background_Intervals_Axis();
                graphBox.BackgroundImage = AxisLayer;
            }
        }

        //---------------------------------------------------------------------------

        private void txbs_TextChanged(object sender, EventArgs e)
        {
            TextBox txb = (TextBox)sender;
            if (txb.Enabled)
            {
                if (txb.Text.Length == 0)
                {
                    txb.Text = "0";
                    return;
                }
                string txt;
                string decimalChar = System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator;
                if (decimalChar == ",")
                {
                    txt = txb.Text.Replace(".", decimalChar);
                }
                else
                {
                    txt = txb.Text.Replace(",", decimalChar);
                }

                if (float.TryParse(txt, out float value))
                {
                    txb.ForeColor = Color.Black;
                    switch (txb.Name)
                    {
                        case "txb_x0":
                            Obj_x0 = value;
                            break;
                        case "txb_y0":
                            Obj_y0 = value;
                            break;
                        case "txb_v0x":
                            Obj_v0x = value;
                            Obj_v0 = (float)Math.Sqrt((double)(Obj_v0x * Obj_v0x + Obj_v0y * Obj_v0y));
                            Obj_alpha0 = (float)(Math.Atan2((double)Obj_v0y, (double)Obj_v0x) * 180 / Math.PI);
                            txb_v0.Text = Obj_v0.ToString();
                            txb_alpha0.Text = Obj_alpha0.ToString();
                            break;
                        case "txb_v0y":
                            Obj_v0y = value;
                            Obj_v0 = (float)Math.Sqrt((double)(Obj_v0x * Obj_v0x + Obj_v0y * Obj_v0y));
                            Obj_alpha0 = (float)(Math.Atan2((double)Obj_v0y, (double)Obj_v0x) * 180 / Math.PI);
                            txb_v0.Text = Obj_v0.ToString();
                            txb_alpha0.Text = Obj_alpha0.ToString();
                            break;
                        case "txb_v0":
                            Obj_v0 = value;
                            Obj_v0x = Obj_v0 * (float)Math.Cos(Obj_alpha0 * Math.PI / 180);
                            Obj_v0y = Obj_v0 * (float)Math.Sin(Obj_alpha0 * Math.PI / 180);
                            txb_v0x.Text = Obj_v0x.ToString();
                            txb_v0y.Text = Obj_v0y.ToString();

                            break;
                        case "txb_alpha0":
                            Obj_alpha0 = value;
                            Obj_v0x = Obj_v0 * (float)Math.Cos(Obj_alpha0 * Math.PI / 180);
                            Obj_v0y = Obj_v0 * (float)Math.Sin(Obj_alpha0 * Math.PI / 180);
                            txb_v0x.Text = Obj_v0x.ToString();
                            txb_v0y.Text = Obj_v0y.ToString();
                            break;
                        case "txb_ax":
                            break;
                        case "txb_ay":
                            break;

                        default:
                            break;
                    }
                }
                else
                {
                    txb.ForeColor = Color.Red;
                    txb.Undo();
                }
            }
        }



        private void ReZoomY(float value)
        {
            if (value != 0)
            {
                while (Math.Abs(value) < stepValueY)
                {
                    stepValueY = stepValueY / 2;
                };

                //if (Obj_y0 > 0) y0 = (int)(Obj_y0 / stepValueY * stepY * 1.1);
                //else y0 = (int)(graphBox.Height - Obj_y0 / stepValueY * stepY * 1.1);
                while (Math.Abs(value) / 2 > stepValueY)
                {
                    stepValueY *= 2;
                }

                ReDraw_Background_Intervals_Axis();
                graphBox.BackgroundImage = AxisLayer;
            }
        }

        private void ReZoomX(float value)
        {
            if (value != 0)
            {
                while (Math.Abs(value) < stepValueX)
                {
                    stepValueX = stepValueX / 2;
                };

                //if (Obj_y0 > 0) y0 = (int)(Obj_y0 / stepValueY * stepY * 1.1);
                //else y0 = (int)(graphBox.Height - Obj_y0 / stepValueY * stepY * 1.1);
                while (Math.Abs(value) / 2 > stepValueX)
                {
                    stepValueX *= 2;
                }

                ReDraw_Background_Intervals_Axis();
                graphBox.BackgroundImage = AxisLayer;
            }
        }

        //---------------------------------------------------------------------------

        private void rtb_x0_Enter(object sender, EventArgs e)
        {
            txb_x0.Focus();
        }

        private void rtb_y0_Enter(object sender, EventArgs e)
        {
            txb_y0.Focus();
        }

        private void rtb_ax_Enter(object sender, EventArgs e)
        {
            txb_ax.Focus();
        }

        private void rtb_ay_Enter(object sender, EventArgs e)
        {
            txb_ay.Focus();
        }

        private void rtb_v0x_Enter(object sender, EventArgs e)
        {
            txb_v0x.Focus();
        }

        private void rtb_v0y_Enter(object sender, EventArgs e)
        {
            txb_v0y.Focus();
        }

        private void rtb_v0_Enter(object sender, EventArgs e)
        {
            txb_v0.Focus();
        }

        private void rtb_alpha0_Enter(object sender, EventArgs e)
        {
            txb_alpha0.Focus();
        }

        //---------------------------------------------------------------------------

        private void rad_speedmode_CheckedChanged(object sender, EventArgs e)
        {
            XYSpeedMode = ((RadioButton)sender).Checked;
        }

        //METHODS====================================================================================================================
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

            Pen p = new Pen(Brushes.DarkBlue, 1F);
            Graphics g = Graphics.FromImage(bitmap);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Low;
            g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.None;
            g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighSpeed;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixel;

            //draw x axis
            g.DrawLine(p, 0, height - _y0, width, height - _y0);

            //draw y axis
            g.DrawLine(p, _x0, height, _x0, 0);

            if (highQuality)
            {
                g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            }

            p.Width = 1F;
            //draw y narrow
            g.DrawLine(p, _x0, 0, _x0 + 4, 12);
            g.DrawLine(p, _x0, 0, _x0 - 4, 12);

            //draw x narrow
            g.DrawLine(p, width - 2, height - _y0, width - 13, height - _y0 - 4);
            g.DrawLine(p, width - 2, height - _y0, width - 13, height - _y0 + 4);

            //draw axis label
            g.DrawString(xlabel, myFont_axis, Brushes.DarkRed, width - 15, height - _y0 + 6);
            g.DrawString(ylabel, myFont_axis, Brushes.DarkRed, _x0 - 20, 5);

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

            Pen p1 = new Pen(Brushes.Black, 1F);
            Pen p2 = new Pen(Brushes.Gray, 1F);
            Pen p1g = new Pen(Brushes.Gray, 1F); //for grid lines
            Pen p2g = new Pen(Brushes.LightGray, 1F); //for grid lines
            //p1.DashStyle = p2.DashStyle = p1g.DashStyle = p2g.DashStyle = DashStyle.Dash;

            Graphics g = Graphics.FromImage(bitmap);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Low;
            g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.None;
            g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighSpeed;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixel;


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
                        if (highQuality)
                        {
                            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
                        }
                        string va;
                        va = ((float)(((bitmap.Height - _y0) - i) / _stepY) * _stepValueY).ToString();
                        //g.DrawString(va, myFont_Intervals, Brushes.Black, i - 9, bitmap.Height - _y0 + 4);
                        g.DrawString(va, myFont_Intervals, Brushes.DarkBlue, _x0 - (int)(g.MeasureString(va, myFont_Intervals).Width) - 4,
                            i - (int)(g.MeasureString(va, myFont_Intervals).Height / 2));
                        g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixel;
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

                        if (highQuality)
                        {
                            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
                        }
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
            stepX -= 5;
            stepY -= 5;
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
            stepX += 5;
            stepY += 5;
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
