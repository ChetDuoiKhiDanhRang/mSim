using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mSim
{
    public partial class drawForm : Form
    {
        public event EventHandler<bool> SpeedModeChanged;
        public event EventHandler<bool> IsRunningChanged;
        public event EventHandler<float> Obj_x0Changed;
        public event EventHandler<float> Obj_y0Changed;
        public event EventHandler<float> Obj_v0xChanged;
        public event EventHandler<float> Obj_v0yChanged;
        public event EventHandler<float> Obj_axChanged;
        public event EventHandler<float> Obj_ayChanged;
        public event EventHandler<string> Lang_Changed;

        string axis_fontname = "Consolas";
        float axis_fontsize = 8F;

        string interval_fontname = "consolas";
        float interval_fontsize = 8F;

        string object_fontname = "consolas";
        float object_fontsize = 8F;


        Font myFont_script;
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

        Color Obj_Color { get; set; }
        Color MovingLine_Color { get; set; }
        Color Velocity_Color { get; set; }
        int Obj_Size { get; set; }

        bool showGrid;
        bool showCoordinates;
        bool showTrails;
        bool showSpeeds;
        bool highQuality;
        bool autoScaleVelocityVector;

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
        public bool IsRunning { get => isRunning; set { isRunning = value; IsRunningChanged?.Invoke(this, value); } }


        float obj_vx;
        float obj_vy;
        float obj_x;
        float obj_y;
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
        public float Obj_v0x { get => obj_v0x; set { obj_v0x = value; Obj_v0xChanged?.Invoke(this, value); } }
        public float Obj_v0y { get => obj_v0y; set { obj_v0y = value; Obj_v0yChanged?.Invoke(this, value); } }
        public float Obj_ax { get => obj_ax; set { obj_ax = value; Obj_axChanged?.Invoke(this, value); } }
        public float Obj_ay { get => obj_ay; set { obj_ay = value; Obj_ayChanged?.Invoke(this, value); } }
        public float Obj_alpha0 { get => obj_alpha0; set { obj_alpha0 = value; } }
        public float Obj_v0 { get => obj_v0; set => obj_v0 = value; }
        public float Obj_x { get => obj_x; set => obj_x = value; }
        public float Obj_y { get => obj_y; set => obj_y = value; }
        public float Obj_vx { get => obj_vx; set => obj_vx = value; }
        public float Obj_vy { get => obj_vy; set => obj_vy = value; }

        string lang;
        public string Lang { get => lang; set { lang = value; Lang_Changed?.Invoke(this, lang); } }

        public drawForm()
        {
            InitializeComponent();
            Lang_Changed += DrawForm_Lang_Changed;
            SpeedModeChanged += DrawForm_SpeedModeChanged;

            myFont_script = new Font(rtb_x0.Font.Name, (rtb_x0.Font.Size * 0.7F));

            rtb_x0.Text = "x0:";
            rtb_x0.Select(1, rtb_x0.Text.Length - 2);
            rtb_x0.SelectionFont = myFont_script;
            rtb_x0.SelectionCharOffset = -5;

            rtb_y0.Text = "y0:";
            rtb_y0.Select(1, rtb_y0.Text.Length - 2);
            rtb_y0.SelectionFont = myFont_script;
            rtb_y0.SelectionCharOffset = -5;

            rtb_ax.Text = "ax:";
            rtb_ax.Select(1, rtb_ax.Text.Length - 2);
            rtb_ax.SelectionFont = myFont_script;
            rtb_ax.SelectionCharOffset = -5;

            rtb_ay.Text = "ay:";
            rtb_ay.Select(1, rtb_ay.Text.Length - 2);
            rtb_ay.SelectionFont = myFont_script;
            rtb_ay.SelectionCharOffset = -5;

            rtb_v0x.Text = "v0x:";
            rtb_v0x.Select(1, rtb_v0x.Text.Length - 2);
            rtb_v0x.SelectionFont = myFont_script;
            rtb_v0x.SelectionCharOffset = -5;

            rtb_v0y.Text = "v0y:";
            rtb_v0y.Select(1, rtb_v0y.Text.Length - 2);
            rtb_v0y.SelectionFont = myFont_script;
            rtb_v0y.SelectionCharOffset = -5;

            rtb_v0.Text = "v0:";
            rtb_v0.Select(1, rtb_v0.Text.Length - 2);
            rtb_v0.SelectionFont = myFont_script;
            rtb_v0.SelectionCharOffset = -5;

            rtb_alpha0.Text = "α0:";
            rtb_alpha0.Select(1, rtb_alpha0.Text.Length - 2);
            rtb_alpha0.SelectionFont = myFont_script;
            rtb_alpha0.SelectionCharOffset = -5;


            stepX = baseStepX;
            stepY = baseStepY;

            myFont_axis = new Font(axis_fontname, axis_fontsize, FontStyle.Bold | FontStyle.Italic);
            myFont_Intervals = new Font(interval_fontname, interval_fontsize, FontStyle.Regular);
            myFont_Object = new Font(object_fontname, object_fontsize, FontStyle.Regular);

        }

        int callInfo = 0;
        int callExportVideo = 0;

        private void LoadSettings()
        {
            var x = Properties.Settings.Default;

            callInfo = x.callInfo;
            callExportVideo = x.callExportVideo;

            nud_timeOffset.Value = timeOffset = x.timeOffset;
            lbl_trbSpeed.Text = (1000F / timer1.Interval).ToString("#0.00");
            showGrid = ckbGid.Checked = x.showGrid;
            showCoordinates = ckbCoordinates.Checked = x.showCoodinates;
            showTrails = ckbTrail.Checked = x.showTrails;
            showSpeeds = ckbSpeed.Checked = x.showSpeeds;
            highQuality = ckbHighQuality.Checked = x.highQuality;
            autoScaleVelocityVector = ckbAutoScaleVelocityVector.Checked = x.autoScaleVelocityVector;

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

            stepX = x.last_stepX;
            stepY = x.last_stepY;
            stepValueX = x.last_stepValueX;
            stepValueY = x.last_stepValueY;

            txb_v0.Text = Obj_v0.ToString();
            txb_alpha0.Text = Obj_alpha0.ToString();
            txb_v0x.Text = Obj_v0x.ToString();
            txb_v0y.Text = Obj_v0y.ToString();

            Obj_Color = x.Obj_Color;
            Obj_Size = x.Obj_Size;
            MovingLine_Color = x.MovingLine_Color;
            Velocity_Color = x.Velocity_color;
            Lang = x.last_Lang;
        }
        private void SaveSettings()
        {
            var x = Properties.Settings.Default;
            x.showGrid = showGrid;
            x.showCoodinates = showCoordinates;
            x.showTrails = showTrails;
            x.showSpeeds = showSpeeds;
            x.highQuality = highQuality;
            x.autoScaleVelocityVector = autoScaleVelocityVector;

            x.XYSpeedMode = XYSpeedMode;

            x.last_ax = Obj_ax;
            x.last_ay = Obj_ay;
            x.last_x0 = Obj_x0;
            x.last_y0 = Obj_y0;

            x.last_v0 = Obj_v0;
            x.last_alpha0 = Obj_alpha0;
            x.last_v0x = Obj_v0x;
            x.last_v0y = Obj_v0y;


            x.last_stepX = stepX;
            x.last_stepY = stepY;
            x.last_stepValueX = stepValueX;
            x.last_stepValueY = stepValueY;
            x.timeOffset = timeOffset;

            x.Obj_Color = Obj_Color;
            x.Obj_Size = Obj_Size;
            x.MovingLine_Color = MovingLine_Color;
            x.Velocity_color = Velocity_Color;
            x.last_Lang = Lang;

            if (callExportVideo > 3)
            {
                callExportVideo = 3;
            }
            if (callInfo > 7)
            {
                callInfo = 7;
            }

            x.callInfo = callInfo;
            x.callExportVideo = callExportVideo;

            x.Save();
        }

        private void drawForm_Shown(object sender, EventArgs e)
        {
            x0 = BASE_X0;
            y0 = BASE_Y0;

            LoadSettings();

            picPlay.Image = imageList1.Images[2];
            picCapture.Image = imageList1.Images[0];
            picReset.Image = imageList1.Images[3];
            picInfo.Image = imageList1.Images[4];

            Obj_vx = Obj_v0x;
            Obj_vy = Obj_v0y;
            Obj_x = Obj_x0;
            Obj_y = Obj_y0;

            GenCoordinatesEquation();
            GenVelocityEquation();
            Gen_VLength();

            BackgroundLayer = new Bitmap(graphBox.Width, graphBox.Height, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
            Graphics g = Graphics.FromImage(BackgroundLayer);
            g.Clear(Color.WhiteSmoke);
            g.Dispose();


            IntervalsLayer = BackgroundLayer.Clone() as Bitmap;
            DrawIntervals(IntervalsLayer, x0, y0, stepX, stepY, stepValueX, stepValueY, showGrid, showCoordinates);

            AxisLayer = IntervalsLayer.Clone() as Bitmap;
            DrawAxis(AxisLayer, x0, y0);


            MovingLineLayer = AxisLayer.Clone() as Bitmap;
            DrawMovingLine(MovingLineLayer);

            MovingObjectLayer = MovingLineLayer.Clone() as Bitmap;
            DrawObject(MovingObjectLayer, Obj_x0, Obj_y0, x0, y0, showSpeeds, showTrails, Obj_v0x, Obj_v0y);

            graphBox.BackgroundImage = MovingObjectLayer;


            ckbCoordinates.CheckedChanged += ckbCoordinates_CheckedChanged;
            ckbGid.CheckedChanged += ckbGid_CheckedChanged;
            ckbHighQuality.CheckedChanged += ckbHighQuality_CheckedChanged;
            ckbTrail.CheckedChanged += ckbTrail_CheckedChanged;
            ckbSpeed.CheckedChanged += ckbSpeed_CheckedChanged;
            ckbAutoScaleVelocityVector.CheckedChanged += CkbAutoScaleVelocityVector_CheckedChanged;

            this.Obj_x0Changed += DrawForm_Obj_x0Changed;
            this.Obj_y0Changed += DrawForm_Obj_y0Changed;
            this.Obj_v0xChanged += DrawForm_Obj_v0xChanged;
            this.Obj_v0yChanged += DrawForm_Obj_v0yChanged;
            this.Obj_axChanged += DrawForm_Obj_axChanged;
            this.Obj_ayChanged += DrawForm_Obj_ayChanged;
            this.IsRunningChanged += DrawForm_IsRunningChanged;

            txb_x0.TextChanged += txbs_TextChanged;
            txb_y0.TextChanged += txbs_TextChanged;
            txb_v0x.TextChanged += txbs_TextChanged;
            txb_v0y.TextChanged += txbs_TextChanged;
            txb_ax.TextChanged += txbs_TextChanged;
            txb_ay.TextChanged += txbs_TextChanged;
            txb_v0.TextChanged += txbs_TextChanged;
            txb_alpha0.TextChanged += txbs_TextChanged;

            graphBox.MouseWheel += GraphBox_MouseWheel;
            graphBox.MouseDown += graphBox_MouseDown;
            graphBox.MouseMove += graphBox_MouseMove;
            graphBox.MouseUp += graphBox_MouseUp;
            graphBox.SizeChanged += graphBox_SizeChanged;

            nud_timeOffset.ValueChanged += nud_timeOffset_ValueChanged;
            ctm_objsize_values.SelectedIndexChanged += Ctm_objsize_values_SelectedIndexChanged;
        }

        private void CkbAutoScaleVelocityVector_CheckedChanged(object sender, EventArgs e)
        {
            autoScaleVelocityVector = ckbAutoScaleVelocityVector.Checked;
        }

        private void DrawForm_Lang_Changed(object sender, string e)
        {
            if (Lang == "en")
            {
                grb_Params0.Text = "First parameters (t=0)";
                rad_speedmode.Text = "Vx/Vy";
                radioButton1.Text = "Value/Angle";
                panel1.Text = "Equations:";
                label1.Text = "Number of sampling:";
                label2.Text = "Play speed:";
                groupBox1.Text = "View:";
                ctm_ObjColor.Text = "Object color";
                ctm_ObjSize.Text = "Object size";
                ctm_MovingLineColor.Text = "Trajectory color";
                ctm_VelocityColor.Text = "Velocity color";
                ckbGid.Text = "Grid lines";
                ckbCoordinates.Text = "Coordinates";
                ckbHighQuality.Text = "Smooth graphic";
                ckbTrail.Text = "Trail lines";
                ckbSpeed.Text = "Velocity vector";
                ckbAutoScaleVelocityVector.Text = "Auto scale velocity vector";
            }
            else
            {
                grb_Params0.Text = "Tham số ban đầu (t=0)";
                rad_speedmode.Text = "H.chiếu vận tốc";
                radioButton1.Text = "Độ lớn/góc";
                panel1.Text = "Các phương trình:";
                label1.Text = "\"Số lần lấy mẫu\":";
                label2.Text = "Tốc độ:";
                groupBox1.Text = "Hiển thị:";
                ctm_ObjColor.Text = "Màu vật thể";
                ctm_ObjSize.Text = "Kích thước vật thể";
                ctm_MovingLineColor.Text = "Màu quỹ đạo";
                ctm_VelocityColor.Text = "Màu véc-tơ vận tốc";
                ckbGid.Text = "Lưới";
                ckbCoordinates.Text = "Tọa độ";
                ckbHighQuality.Text = "Khử \"răng cưa\"";
                ckbTrail.Text = "Đường dóng";
                ckbSpeed.Text = "Véc-tơ vận tốc";
                ckbAutoScaleVelocityVector.Text = "Tự động điều chỉnh véc-tơ";
            }
        }

        private void DrawForm_Obj_ayChanged(object sender, float e)
        {
            GenCoordinatesEquation();
            GenVelocityEquation();
            Redraw_MovingLine_Layer();
            MovingObjectLayer?.Dispose();
            MovingObjectLayer = MovingLineLayer.Clone() as Bitmap;
            DrawObject(MovingObjectLayer, Obj_x0, Obj_y0, x0, y0, showSpeeds, showTrails, Obj_v0x, Obj_v0y);
            graphBox.BackgroundImage = MovingObjectLayer;
        }

        private void DrawForm_Obj_axChanged(object sender, float e)
        {
            GenCoordinatesEquation();
            GenVelocityEquation();
            Redraw_MovingLine_Layer();
            MovingObjectLayer?.Dispose();
            MovingObjectLayer = MovingLineLayer.Clone() as Bitmap;
            DrawObject(MovingObjectLayer, Obj_x0, Obj_y0, x0, y0, showSpeeds, showTrails, Obj_v0x, Obj_v0y);
            graphBox.BackgroundImage = MovingObjectLayer;
        }

        private void DrawForm_Obj_v0yChanged(object sender, float e)
        {
            Obj_vy = e;
            GenCoordinatesEquation();
            GenVelocityEquation();
            Gen_VLength();

            Redraw_MovingLine_Layer();
            MovingObjectLayer?.Dispose();
            MovingObjectLayer = MovingLineLayer.Clone() as Bitmap;
            DrawObject(MovingObjectLayer, Obj_x0, Obj_y0, x0, y0, showSpeeds, showTrails, Obj_v0x, Obj_v0y);
            graphBox.BackgroundImage = MovingObjectLayer;
        }

        private void DrawForm_Obj_v0xChanged(object sender, float e)
        {
            Obj_vx = e;
            GenCoordinatesEquation();
            GenVelocityEquation();
            Gen_VLength();

            Redraw_MovingLine_Layer();
            MovingObjectLayer?.Dispose();
            MovingObjectLayer = MovingLineLayer.Clone() as Bitmap;
            DrawObject(MovingObjectLayer, Obj_x0, Obj_y0, x0, y0, showSpeeds, showTrails, Obj_v0x, Obj_v0y);
            graphBox.BackgroundImage = MovingObjectLayer;
        }

        private void DrawForm_Obj_x0Changed(object sender, float e)
        {
            Obj_x = Obj_x0;
            ReZoomX(e);
            GenCoordinatesEquation();
            Redraw_MovingLine_Layer();
            MovingObjectLayer?.Dispose();
            MovingObjectLayer = MovingLineLayer.Clone() as Bitmap;
            DrawObject(MovingObjectLayer, Obj_x0, Obj_y0, x0, y0, showSpeeds, showTrails, Obj_v0x, Obj_v0y);
            graphBox.BackgroundImage = MovingObjectLayer;
        }

        private void DrawForm_Obj_y0Changed(object sender, float e)
        {
            Obj_y = Obj_y0;
            ReZoomY(e);
            GenCoordinatesEquation();
            Redraw_MovingLine_Layer();
            MovingObjectLayer?.Dispose();
            MovingObjectLayer = MovingLineLayer.Clone() as Bitmap;
            DrawObject(MovingObjectLayer, Obj_x0, Obj_y0, x0, y0, showSpeeds, showTrails, Obj_v0x, Obj_v0y);
            graphBox.BackgroundImage = MovingObjectLayer;
        }

        private void DrawForm_IsRunningChanged(object sender, bool e)
        {
            picPlay.Image = e ? imageList1.Images[1] : imageList1.Images[2];
            if (e)
            {
                grb_Params0.Enabled = false;
                timer1.Start();
            }
            else
            {
                timer1.Stop();
            }
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

        private void drawForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.P))
            {
                picPlay_Click(null, null);
                e.Handled = true;

            }
            else if (e.KeyData == (Keys.Control | Keys.R))
            {
                picReset_Click(null, null);
                e.Handled = true;

            }
            else if (e.KeyData == (Keys.Control | Keys.S))
            {
                picCapture_Click(null, null);
                e.Handled = true;

            }
            else if (isPaused && !IsRunning && e.KeyData == (Keys.Control | Keys.Left))
            {
                if ((frameindex + timeOffset) > 0)
                {
                    frameindex--;
                    float t = tmin + (frameindex + timeOffset) * timeStep;
                    Obj_x = obj_xy[frameindex + timeOffset].X;
                    Obj_y = obj_xy[frameindex + timeOffset].Y;
                    Obj_vx = obj_vx_values[frameindex + timeOffset];
                    Obj_vy = obj_vy_values[frameindex + timeOffset];

                    lbl_time.Text = "t = " + t.ToString("0.000");
                    rtb_cur_x.Text = "x = " + Obj_x.ToString("0.000");
                    rtb_cur_y.Text = "y = " + Obj_y.ToString("0.000");

                    rtb_cur_vx.Invoke((Action)(() =>
                    {
                        rtb_cur_vx.Text = "vx = " + Obj_vx.ToString("0.000");
                        rtb_cur_vx.Select(1, 1);
                        rtb_cur_vx.SelectionFont = myFont_script;
                        rtb_cur_vx.SelectionCharOffset = -5;
                    }));

                    rtb_cur_vy.Invoke((Action)(() =>
                    {
                        rtb_cur_vy.Text = "vy = " + Obj_vy.ToString("0.000");
                        rtb_cur_vy.Select(1, 1);
                        rtb_cur_vy.SelectionFont = myFont_script;
                        rtb_cur_vy.SelectionCharOffset = -5;
                    }));

                    Redraw_Object();
                    graphBox.BackgroundImage = MovingObjectLayer;
                    e.Handled = true;

                }
            }
            else if (isPaused && !IsRunning && e.KeyData == (Keys.Control | Keys.Right))
            {
                if (frameindex < timeOffset)
                {
                    frameindex++;
                    float t = tmin + (frameindex + timeOffset) * timeStep;
                    Obj_x = obj_xy[frameindex + timeOffset].X;
                    Obj_y = obj_xy[frameindex + timeOffset].Y;
                    Obj_vx = obj_vx_values[frameindex + timeOffset];
                    Obj_vy = obj_vy_values[frameindex + timeOffset];

                    lbl_time.Text = "t = " + t.ToString("0.000");
                    rtb_cur_x.Text = "x = " + Obj_x.ToString("0.000");
                    rtb_cur_y.Text = "y = " + Obj_y.ToString("0.000");

                    rtb_cur_vx.Invoke((Action)(() =>
                    {
                        rtb_cur_vx.Text = "vx = " + Obj_vx.ToString("0.000");
                        rtb_cur_vx.Select(1, 1);
                        rtb_cur_vx.SelectionFont = myFont_script;
                        rtb_cur_vx.SelectionCharOffset = -5;
                    }));

                    rtb_cur_vy.Invoke((Action)(() =>
                    {
                        rtb_cur_vy.Text = "vy = " + Obj_vy.ToString("0.000");
                        rtb_cur_vy.Select(1, 1);
                        rtb_cur_vy.SelectionFont = myFont_script;
                        rtb_cur_vy.SelectionCharOffset = -5;
                    }));

                    Redraw_Object();
                    graphBox.BackgroundImage = MovingObjectLayer;
                    e.Handled = true;
                }
            }
            else if (e.KeyData == (Keys.Control | Keys.I))
            {
                picInfo_Click(null, null);
                e.Handled = true;
            }
            else if (e.KeyData == (Keys.Control | Keys.E))
            {
                if (callExportVideo < 3)
                {
                    callExportVideo++;
                    return;
                }
                if (timeOffset > 100)
                {
                    if (graphBox.Height % 2 > 0)
                    {
                        this.WindowState = FormWindowState.Normal;
                        graphBox.Size = new Size(graphBox.Size.Width, graphBox.Size.Height + 1);
                    }
                    ExportVideo();
                }
                //callExportVideo = 0;
                e.Handled = true;
            }
        }

        FormExportVideo formExportVideo;
        private void ExportVideo()
        {
            string tmpPath = Application.StartupPath + "\\tmp";
            string baseName = "tmpvid_";

            if (!File.Exists(Application.StartupPath + "\\ffmpeg.exe"))
            {
                string content;
                if (Lang == "vi")
                {
                    content = "Không tìm thấy tập tin \"ffmpeg.exe\"!\nTải và giải nén tập tin \"ffmpeg.exe\" vào thư mục chương trình.\nĐến trang tải về?";
                }
                else
                {
                    content = "Cannot find \"ffmpeg.exe\" file!\nDownload and extract \"ffmpeg.exe\" file to application folder plz.\nGo to download site?";
                }

                if (MessageBox.Show(content, "ERROR!", MessageBoxButtons.YesNo, MessageBoxIcon.None) == DialogResult.Yes)
                {
                    Process p = new Process()
                    {
                        StartInfo = new ProcessStartInfo("https://ffmpeg.zeranoe.com/builds/")
                    };
                    p.Start();
                }
                return;
            }

            if (!Directory.Exists(tmpPath))
            {
                Directory.CreateDirectory(tmpPath);
            }

            formExportVideo?.Dispose();
            formExportVideo = new FormExportVideo(Lang, timeOffset);
            if (formExportVideo.ShowDialog() == DialogResult.OK)
            {
                int startIndex = (int)(formExportVideo.StartTime / 0.01M) + timeOffset;
                int endIndex = (int)(startIndex + formExportVideo.Duration / 0.01M);
                int FPS = formExportVideo.FPS;
                int step = 100 / FPS;
                int suffix = 1;
                for (int index = startIndex; index <= endIndex; index += step)
                {
                    Bitmap bmp = MovingLineLayer.Clone() as Bitmap;
                    DrawObject(bmp, obj_xy[index].X, obj_xy[index].Y, x0, y0, showSpeeds, showTrails, obj_vx_values[index], obj_vy_values[index],
                        ("t=" + ((index - timeOffset) * 0.01F).ToString("0.000")));
                    bmp.Save(tmpPath + "\\" + baseName + suffix.ToString("0000000") + ".png", ImageFormat.Png);
                    bmp.Dispose();
                    suffix++;
                }

                string mmpeg = Application.StartupPath + "\\ffmpeg.exe";
                string frameRate = "-framerate " + FPS.ToString();
                string fileindex = "-i " + tmpPath + "\\" + baseName + "%07d.png";
                string libx264 = "-c:v libx264";
                string vsync = "-vsync vfr";
                string videoFormat = "-pix_fmt yuv420p";
                string outputPath = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos) + "\\mSim";
                if (!Directory.Exists(outputPath))
                {
                    Directory.CreateDirectory(outputPath);
                }
                string outputFile = outputPath + "\\mSim_" + DateTime.Now.ToString("yy.MM.dd_HH.mm.ss") + ".mp4";

                string pars = /*mmpeg + " " +*/ frameRate + " " + fileindex + " " + libx264 + " " + vsync + " " + videoFormat + " " + outputFile;

                Process p = new Process();
                p.StartInfo = new ProcessStartInfo(mmpeg, pars);
                p.Start();
                p.WaitForExit();

                Directory.Delete(tmpPath, true);

                Process exp = new Process();
                exp.StartInfo = new ProcessStartInfo(outputPath);
                exp.Start();
            }
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
            ReDraw_Intervals_Axis();
            Redraw_MovingLine_Layer();
            Redraw_Object();
            graphBox.BackgroundImage = MovingObjectLayer;
        }


        bool drag = false;
        int mouseDownX = 0;
        int mouseDownY = 0;
        int offsetX = 0;
        int offsetY = 0;
        private void graphBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                drag = true;
                mouseDownX = e.Location.X;
                mouseDownY = e.Location.Y;
                graphBox.Cursor = Cursors.SizeAll;
            }
            if (e.Button == MouseButtons.Right)
            {
                ctm.Show(graphBox, e.Location);

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

                if (!IsRunning)
                {
                    ReDraw_Intervals_Axis();
                    Redraw_MovingLine_Layer();
                    graphBox.BackgroundImage = MovingLineLayer;
                }
            }

        }

        private void graphBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                //ReDraw_Intervals_Axis();
                //Redraw_MovingLine_Layer();
                BASE_X0 = BASE_X0 + offsetX;
                BASE_Y0 = BASE_Y0 - offsetY;
                drag = false;

                Redraw_MovingLine_Layer();
                Redraw_Object();
                graphBox.BackgroundImage = MovingObjectLayer;

                offsetX = 0;
                offsetY = 0;

                graphBox.Cursor = Cursors.Default;
                //GC.Collect();
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
                ReDraw_Intervals_Axis();
                Redraw_MovingLine_Layer();
                Redraw_Object();
                graphBox.BackgroundImage = MovingObjectLayer;
            }
        }

        //---------------------------------------------------------------------------
        private void nud_timeOffset_ValueChanged(object sender, EventArgs e)
        {
            timeOffset = (int)nud_timeOffset.Value;
            Redraw_MovingLine_Layer();
            Redraw_Object();
            graphBox.BackgroundImage = MovingObjectLayer;
        }

        //---------------------------------------------------------------------------
        private void btnLanguage_Click(object sender, EventArgs e)
        {
            if (Lang == "vi")
            {
                Lang = "en";
            }
            else
            {
                Lang = "vi";
            }
        }


        //---------------------------------------------------------------------------
        private void ckbGid_CheckedChanged(object sender, EventArgs e)
        {
            showGrid = ckbGid.Checked;
            //if (!IsRunning)
            {
                ReDraw_Intervals_Axis();
                Redraw_MovingLine_Layer();
                Redraw_Object();
                graphBox.BackgroundImage = MovingObjectLayer;
            }
        }

        private void ckbCoordinates_CheckedChanged(object sender, EventArgs e)
        {
            showCoordinates = ckbCoordinates.Checked;
            //if (!IsRunning)
            {
                ReDraw_Intervals_Axis();
                Redraw_MovingLine_Layer();
                Redraw_Object();
                graphBox.BackgroundImage = MovingObjectLayer;
            }
        }

        private void ckbHighQuality_CheckedChanged(object sender, EventArgs e)
        {
            highQuality = ckbHighQuality.Checked;
            //if (!IsRunning)
            {
                ReDraw_Intervals_Axis();
                Redraw_MovingLine_Layer();
                Redraw_Object();
                graphBox.BackgroundImage = MovingObjectLayer;
            }
        }

        private void ckbTrail_CheckedChanged(object sender, EventArgs e)
        {
            showTrails = ckbTrail.Checked;
            if (!IsRunning)
            {
                //ReDraw_Background_Intervals_Axis();
                Redraw_Object();
                graphBox.BackgroundImage = MovingObjectLayer;
            }
        }

        private void ckbSpeed_CheckedChanged(object sender, EventArgs e)
        {
            showSpeeds = ckbSpeed.Checked;
            if (!IsRunning)
            {
                Redraw_Object();
                graphBox.BackgroundImage = MovingObjectLayer;
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
                    txb.SelectAll();
                    //return;
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
                            Obj_ax = value;

                            break;
                        case "txb_ay":
                            Obj_ay = value;

                            break;

                        default:
                            break;
                    }
                }
                else
                {
                    txb.ForeColor = Color.Red;
                }
            }
        }

        //---------------------------------------------------------------------------
        private void Ctm_objsize_values_SelectedIndexChanged(object sender, EventArgs e)
        {
            Obj_Size = (ctm_objsize_values.SelectedIndex + 1) * 4;
            if (!IsRunning || isPaused)
            {
                Redraw_Object();
                graphBox.BackgroundImage = MovingObjectLayer;
            }
        }

        private void ctm_ObjColor_Click(object sender, EventArgs e)
        {
            var c = (ToolStripMenuItem)sender;
            ColorDialog cd = new ColorDialog()
            {
                FullOpen = true,
                AnyColor = true,
                AllowFullOpen = true
            };
            if (c.Name == ctm_ObjColor.Name)
            {
                cd.Color = Obj_Color;
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    Obj_Color = cd.Color;
                }
            }
            else if (c.Name == ctm_MovingLineColor.Name)
            {
                cd.Color = MovingLine_Color;
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    MovingLine_Color = cd.Color;
                }
            }
            else if (c.Name == ctm_VelocityColor.Name)
            {
                cd.Color = Velocity_Color;
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    Velocity_Color = cd.Color;
                }
            }
            if (!IsRunning || isPaused)
            {
                Redraw_MovingLine_Layer();
                Redraw_Object();
                graphBox.BackgroundImage = MovingObjectLayer;
            }
        }

        private void ctm_Opened(object sender, EventArgs e)
        {
            ctm_objsize_values.SelectedIndex = Obj_Size / 4 - 1;
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

        //---------------------------------------------------------------------------
        int frameindex = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (frameindex + timeOffset >= obj_xy.Length - 1)
            {
                picPlay_Click(null, null);
                return;
            }

            float t = tmin + (frameindex + timeOffset) * timeStep;
            Obj_x = obj_xy[frameindex + timeOffset].X;
            Obj_y = obj_xy[frameindex + timeOffset].Y;
            Obj_vx = obj_vx_values[frameindex + timeOffset];
            Obj_vy = obj_vy_values[frameindex + timeOffset];

            lbl_time.Invoke((Action)(() => { lbl_time.Text = "t = " + t.ToString("0.000"); }));
            rtb_cur_x.Invoke((Action)(() => rtb_cur_x.Text = "x = " + Obj_x.ToString("0.000").PadLeft(7)));
            rtb_cur_y.Invoke((Action)(() => rtb_cur_y.Text = "y = " + Obj_y.ToString("0.000").PadLeft(7)));

            rtb_cur_vx.Invoke((Action)(() =>
            {
                rtb_cur_vx.Text = "vx = " + Obj_vx.ToString("0.000").PadLeft(7);
                rtb_cur_vx.Select(1, 1);
                rtb_cur_vx.SelectionFont = myFont_script;
                rtb_cur_vx.SelectionCharOffset = -5;
            }));

            rtb_cur_vy.Invoke((Action)(() =>
            {
                rtb_cur_vy.Text = "vy = " + Obj_vy.ToString("0.000").PadLeft(7);
                rtb_cur_vy.Select(1, 1);
                rtb_cur_vy.SelectionFont = myFont_script;
                rtb_cur_vy.SelectionCharOffset = -5;
            }));

            Redraw_Object();
            graphBox.BackgroundImage = MovingObjectLayer;
            frameindex += 1;
            //if (frameindex + timeOffset >= obj_xy.Length - 1)
            //{
            //    timer1.Stop();
            //}
        }

        bool isPaused = false;
        private void picPlay_Click(object sender, EventArgs e)
        {
            if (IsRunning)
            {
                isPaused = true;
            }
            IsRunning = !IsRunning;
            nud_timeOffset.Enabled = !(IsRunning && !isPaused);
        }

        private void picReset_Click(object sender, EventArgs e)
        {
            grb_Params0.Enabled = true;
            IsRunning = false;
            isPaused = false;
            frameindex = 0;
            Obj_x = Obj_x0;
            Obj_y = Obj_y0;
            Obj_vx = Obj_v0x;
            Obj_vy = Obj_v0y;
            Redraw_Object();
            graphBox.BackgroundImage = MovingObjectLayer;
            nud_timeOffset.Enabled = !(IsRunning && !isPaused);

        }

        private void picCapture_Click(object sender, EventArgs e)
        {
            IsRunning = false;
            SaveFileDialog sfd = new SaveFileDialog()
            {
                AddExtension = true,
                SupportMultiDottedExtensions = true,
                ValidateNames = true,
                Title = "Save Image",
                OverwritePrompt = true,
                RestoreDirectory = true,
                Filter = "PNG image (*.png)|*.png|JPEG image (*.jpg, *.jpeg)|*.jpeg, *.jpg|Bitmap image (*.bmp)|*.bmp",
                FilterIndex = 2,
                DefaultExt = ".jpg",
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                switch (sfd.FilterIndex)
                {
                    case 1:
                        MovingObjectLayer.Save(sfd.FileName, ImageFormat.Png);
                        break;
                    case 2:
                        MovingObjectLayer.Save(sfd.FileName, ImageFormat.Jpeg);
                        break;
                    case 3:
                        MovingObjectLayer.Save(sfd.FileName, ImageFormat.Bmp);
                        break;
                    default:
                        break;
                }
            }
        }

        //---------------------------------------------------------------------------
        FormInfo frmInfo;
        private void picInfo_Click(object sender, EventArgs e)
        {
            callInfo++;
            if (callInfo >= 7)
            {
                frmInfo?.Dispose();
                frmInfo = new FormInfo(Lang);
                frmInfo.Show();
            }
        }

        private void grb_Params0_EnabledChanged(object sender, EventArgs e)
        {
            //ckbGid.Enabled = ckbHighQuality.Enabled = ckbCoordinates.Enabled = grb_Params0.Enabled;
        }

        private void trb_ValueChanged(object sender, EventArgs e)
        {
            this.Invoke((Action)(() => { timer1.Interval = (trb.Maximum - trb.Value) + 10; }));
            lbl_trbSpeed.Invoke((Action)(() =>
            {
                lbl_trbSpeed.Text = (1000F / timer1.Interval).ToString("#0.00");
            }));
        }

        //METHODS====================================================================================================================
        private void GenCoordinatesEquation()
        {
            string x_0 = Obj_x0 == 0 ? "" : Obj_x0.ToString();
            string x_1 = Obj_v0x == 0 ? "" : ((Obj_v0x < 0 ? "" : "+") + Obj_v0x.ToString() + "t");
            string x_2 = Obj_ax == 0 ? "" : ((Obj_ax < 0 ? "" : "+") + (Obj_ax / 2).ToString() + "t2");

            rtb_xt.Invoke((Action)(() =>
            {
                rtb_xt.Text = "x(t) = " + x_0 + x_1 + x_2;
                if (x_2.Length > 0)
                {
                    rtb_xt.Select(rtb_xt.Text.Length - 1, 1);
                    rtb_xt.SelectionFont = myFont_script;
                    rtb_xt.SelectionCharOffset = 5;
                    rtb_xt.Select(0, 0);
                }
            }));

            string y_0 = Obj_y0 == 0 ? "" : Obj_y0.ToString();
            string y_1 = Obj_v0y == 0 ? "" : ((Obj_v0y < 0 ? "" : "+") + Obj_v0y.ToString() + "t");
            string y_2 = Obj_ay == 0 ? "" : ((Obj_ay < 0 ? "" : "+") + (Obj_ay / 2).ToString() + "t2");

            rtb_yt.Invoke((Action)(() =>
            {
                rtb_yt.Text = "y(t) = " + y_0 + y_1 + y_2;
                if (y_2.Length > 0)
                {
                    rtb_yt.Select(rtb_yt.Text.Length - 1, 1);
                    rtb_yt.SelectionFont = myFont_script;
                    rtb_yt.SelectionCharOffset = 5;
                    rtb_yt.Select(0, 0);
                }
            }));
        }

        private void GenVelocityEquation()
        {
            string vx_0 = Obj_v0x == 0 ? "" : (Obj_v0x.ToString());
            string vx_1 = Obj_ax == 0 ? "" : ((Obj_ax < 0 ? "" : "+") + Obj_ax.ToString() + "t");
            rtb_vx.Invoke((Action)(() =>
            {
                rtb_vx.Text = "vx(t) = " + vx_0 + vx_1;
                rtb_vx.Select(1, 1);
                rtb_vx.SelectionFont = myFont_script;
                rtb_vx.SelectionCharOffset = -5;
                rtb_vx.Select(0, 0);
            }));

            string vy_0 = Obj_v0y == 0 ? "" : (Obj_v0y.ToString());
            string vy_1 = Obj_ay == 0 ? "" : ((Obj_ay < 0 ? "" : "+") + Obj_ay.ToString() + "t");
            rtb_vy.Invoke((Action)(() =>
            {
                rtb_vy.Text = "vy(t) = " + vy_0 + vy_1;
                rtb_vy.Select(1, 1);
                rtb_vy.SelectionFont = myFont_script;
                rtb_vy.SelectionCharOffset = -5;
                rtb_vy.Select(0, 0);
            }));
        }

        private void ReDraw_Intervals_Axis()
        {
            IntervalsLayer?.Dispose();
            AxisLayer?.Dispose();
            IntervalsLayer = BackgroundLayer.Clone() as Bitmap;
            DrawIntervals(IntervalsLayer, x0, y0, stepX, stepY, stepValueX, stepValueY, showGrid, showCoordinates);
            AxisLayer = IntervalsLayer.Clone() as Bitmap;
            DrawAxis(AxisLayer, x0, y0);
        }

        private void Redraw_MovingLine_Layer()
        {
            MovingLineLayer?.Dispose();
            MovingLineLayer = AxisLayer.Clone() as Bitmap;
            DrawMovingLine(MovingLineLayer);
        }

        private void Redraw_Object()
        {
            MovingObjectLayer?.Dispose();
            MovingObjectLayer = MovingLineLayer.Clone() as Bitmap;
            DrawObject(MovingObjectLayer, Obj_x, Obj_y, x0, y0, showSpeeds, showTrails, Obj_vx, Obj_vy);
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
            Pen p2 = new Pen(Brushes.DarkSlateGray, 1F);
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

            p.Width = 1F;

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

            //draw y arrow
            g.DrawLine(p, _x0, 0, _x0 + 4, 12);
            g.DrawLine(p, _x0, 0, _x0 - 4, 12);

            //draw x arrow
            g.DrawLine(p, width - 2, height - _y0, width - 13, height - _y0 - 4);
            g.DrawLine(p, width - 2, height - _y0, width - 13, height - _y0 + 4);

            //draw axis label
            g.DrawString(xlabel, myFont_axis, Brushes.DarkRed, width - 15, height - _y0 + 6);
            g.DrawString(ylabel, myFont_axis, Brushes.DarkRed, _x0 - 20, 5);

            g.FillEllipse(Brushes.DarkGray, _x0 - 4, height - y0 - 4, 8, 8);
            p.Width = 2F;
            p.Color = Color.Black;
            g.DrawEllipse(p, _x0 - 4, height - y0 - 4, 8, 8);

            p.Dispose();
            g.Dispose();
        }

        Point Convert_XY2Point(int heigth, float obj_x, float obj_y, int x0, int y0)
        {
            int point_x = x0 + (int)(Math.Round(obj_x, 2) * stepX / stepValueX);
            int point_y = heigth - ((int)(Math.Round(obj_y, 2) * stepY / stepValueY) + y0);
            Point p = new Point(point_x, point_y);
            return p;
        }
        PointF Convert_Point2XY(int px, int py, int x0, int y0)
        {
            float x = ((float)(px - x0)) / stepX * stepValueX;
            float y = ((float)(y0 - py)) / stepY * stepValueY;
            return new PointF(x, y);
        }
        float tmin;
        float timeStep = 0.01F;
        float tmax;
        PointF[] obj_xy;
        Point[] xy;
        float[] obj_vx_values;
        float[] obj_vy_values;
        int timeOffset;
        void Gen_tRange()
        {
            float t = 0;
            tmin = t - timeOffset * timeStep;
            tmax = t + timeOffset * timeStep;
        }
        void Gen_XYCoordinates_VelocityValues()
        {
            Gen_tRange();
            int count = (int)((tmax - tmin) / timeStep) + 1;
            PointF[] xy_range = new PointF[count];
            obj_vx_values = new float[count];
            obj_vy_values = new float[count];

            for (int i = 0; i < count; i++)
            {
                float t = tmin + i * timeStep;
                float x = Obj_x0 + Obj_v0x * t + Obj_ax * t * t / 2;
                float y = Obj_y0 + Obj_v0y * t + Obj_ay * t * t / 2;
                xy_range[i] = new PointF(x, y);

                float vx = Obj_v0x + Obj_ax * t;
                float vy = Obj_v0y + Obj_ay * t;
                obj_vx_values[i] = vx;
                obj_vy_values[i] = vy;

            }
            obj_xy = xy_range;
        }
        void Gen_MovingLine()
        {
            Gen_XYCoordinates_VelocityValues();

            List<Point> points = new List<Point>();
            for (int i = 0; i <= obj_xy.Count() - 1; i++)
            {
                Point p = Convert_XY2Point(graphBox.Height, obj_xy[i].X, obj_xy[i].Y, x0, y0);
                if (i == 0)
                {
                    points.Add(p);
                }
                else
                {
                    if (points[points.Count - 1].X != p.X && points[points.Count - 1].Y != p.Y)
                    {
                        points.Add(p);
                    }
                }
            }

            xy = points.ToArray();
        }

        private void DrawMovingLine(Bitmap bitmap)
        {
            Gen_MovingLine();
            Graphics g = Graphics.FromImage(bitmap);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Low;
            g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.None;
            g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighSpeed;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixel;

            if (highQuality)
            {
                g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            }

            Pen p = new Pen(MovingLine_Color, 2F);
            p.DashStyle = DashStyle.Dash;
            p.LineJoin = LineJoin.Miter;
            p.DashCap = DashCap.Triangle;
            p.StartCap = LineCap.Round;
            p.Alignment = PenAlignment.Center;

            if (xy.Length > 2)
            {
                g.DrawLines(p, xy);
            }

            p.Dispose();
            g.Dispose();
        }

        int baseLengthV = 40;
        float baseValueV = 40;
        void Gen_VLength()
        {
            baseValueV = Math.Max(Math.Abs(Obj_v0x), Math.Abs(Obj_v0y));
            if (baseValueV == 0)
            {
                baseValueV = 5;
            }
            baseLengthV = Math.Max(stepX, stepY);
        }
        private void DrawObject(Bitmap bitmap, float obj_x, float obj_y, int x0, int y0, bool showSpeeds, bool showTrails, float vx, float vy, string timelabel = "")
        {
            if (drag)
            {
                ReDraw_Intervals_Axis();
                Redraw_MovingLine_Layer();
            }
            Point p = Convert_XY2Point(bitmap.Height, obj_x, obj_y, x0, y0);

            Graphics g = Graphics.FromImage(bitmap);
            g.SmoothingMode = SmoothingMode.None;
            g.InterpolationMode = InterpolationMode.Low;
            g.PixelOffsetMode = PixelOffsetMode.None;
            g.CompositingQuality = CompositingQuality.HighSpeed;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixel;
            if (highQuality)
            {
                g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            }

            Pen obj_p = new Pen(Brushes.Black, 1F);
            if (timelabel != "")
            {
                g.DrawString(timelabel, myFont_Object, Brushes.Black, 0, 0);
            }
            if (showTrails)
            {
                obj_p.DashStyle = DashStyle.DashDot;
                g.DrawLine(obj_p, p.X, p.Y, x0, p.Y);
                g.DrawLine(obj_p, p.X, p.Y, p.X, bitmap.Height - y0);
            }

            if (showSpeeds)
            {
                obj_p.Color = Velocity_Color;
                obj_p.DashStyle = DashStyle.Solid;
                obj_p.Width = 2F;
                obj_p.EndCap = LineCap.Round;

                if (autoScaleVelocityVector)
                {
                    int value = (int)Math.Max(Math.Abs(vx), Math.Abs(vy));

                    if ((value / baseValueV * baseLengthV) > graphBox.Height / 3)
                    {
                        baseLengthV /= 2;
                    }

                }

                int length_vx = (int)(vx / baseValueV * baseLengthV);
                g.DrawLine(obj_p, p.X, p.Y, p.X + length_vx, p.Y);
                string _vx = vx.ToString("0.00");
                string _vy = vy.ToString("0.00");
                if (vx > 0)
                {
                    g.DrawLine(obj_p, p.X + length_vx - 1, p.Y, p.X + length_vx - 8, p.Y - 4);
                    g.DrawLine(obj_p, p.X + length_vx - 1, p.Y, p.X + length_vx - 8, p.Y + 4);
                    int _vxLength = (int)(g.MeasureString(_vx, myFont_Object).Width);
                    g.DrawString(_vx, myFont_Object, obj_p.Brush, p.X + length_vx - _vxLength, p.Y + 4);
                }
                else if (vx < 0)
                {
                    g.DrawLine(obj_p, p.X + length_vx + 1, p.Y, p.X + length_vx + 8, p.Y - 4);
                    g.DrawLine(obj_p, p.X + length_vx + 1, p.Y, p.X + length_vx + 8, p.Y + 4);

                    g.DrawString(_vx, myFont_Object, obj_p.Brush, p.X + length_vx, p.Y + 4);

                }

                int length_vy = (int)(vy / baseValueV * baseLengthV);
                g.DrawLine(obj_p, p.X, p.Y, p.X, p.Y - length_vy);
                int _vyLength = (int)g.MeasureString(_vy, myFont_Object).Width;
                int _vyWidth = (int)g.MeasureString(_vy, myFont_Object).Height;
                if (vy > 0)
                {
                    g.DrawLine(obj_p, p.X, p.Y - length_vy + 1, p.X - 4, p.Y - length_vy + 8);
                    g.DrawLine(obj_p, p.X, p.Y - length_vy + 1, p.X + 4, p.Y - length_vy + 8);

                    g.RotateTransform(-90);
                    g.TranslateTransform(p.X - 4 - _vyWidth, p.Y - length_vy + _vyLength, MatrixOrder.Append);
                    g.DrawString(_vy, myFont_Object, obj_p.Brush, 0, 0);
                    g.ResetTransform();
                }
                else if (vy < 0)
                {
                    g.DrawLine(obj_p, p.X, p.Y - length_vy - 1, p.X - 4, p.Y - length_vy - 8);
                    g.DrawLine(obj_p, p.X, p.Y - length_vy - 1, p.X + 4, p.Y - length_vy - 8);

                    g.RotateTransform(-90);
                    g.TranslateTransform(p.X - 4 - _vyWidth, p.Y - length_vy, MatrixOrder.Append);
                    g.DrawString(_vy, myFont_Object, obj_p.Brush, 0, 0);
                    g.ResetTransform();
                }


            }

            obj_p.Color = Color.Black;
            obj_p.Width = 2F;
            obj_p.DashStyle = DashStyle.Solid;
            SolidBrush b = new SolidBrush(Obj_Color);

            g.FillEllipse(b, p.X - Obj_Size / 2, p.Y - Obj_Size / 2, Obj_Size, Obj_Size);
            g.DrawEllipse(obj_p, p.X - Obj_Size / 2, p.Y - Obj_Size / 2, Obj_Size, Obj_Size);

            obj_p.Dispose();
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

        private void ReZoomY(float value)
        {
            if (value != 0)
            {
                while (Math.Abs(value) < stepValueY)
                {
                    stepValueY = stepValueY / 2;
                };

                while (Math.Abs(value) / 2 > stepValueY)
                {
                    stepValueY *= 2;
                }
            }

            ReDraw_Intervals_Axis();
            Redraw_MovingLine_Layer();
            graphBox.BackgroundImage = MovingLineLayer;
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
            }
            ReDraw_Intervals_Axis();
            Redraw_MovingLine_Layer();
            graphBox.BackgroundImage = MovingLineLayer;
        }

        private void rtb_status_Enter(object sender, EventArgs e)
        {
            picPlay.Focus();
        }
    }
}
