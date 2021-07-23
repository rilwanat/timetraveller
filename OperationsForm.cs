using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Security.Cryptography;

using System.Drawing.Drawing2D;

using System.Media;

using System.Runtime.InteropServices;
using System.Drawing.Text;

using System.Diagnostics;


namespace TimeTraveller
{
    public partial class OperationsForm : Form
    {
        string appName = "TimeTravellerv1.1";
        public string fPath = "C://Users/Public/TTR/tbl.txt";


        int a, b, c, d;
        int ra, rb, rc, rd;
        Boolean secticb;

        Pen pen_s, pen_ss;
        Pen pen_m, pen_mm;
        Pen pen_h, pen_hh;
        Point pt1;
        Point pt2;
        int x, y;
        //Random rand;
        //Random rand1, rand2, rand3;
        Graphics formGraphics;

        int widths, widthm, widthh;
        double lengths, lengthm, lengthh;
        double angles, anglem, angleh;
        double x1s, x1m, x1h;
        double y1s, y1m, y1h;
        double x2s, x2m, x2h;
        double y2s, y2m, y2h;
        double x22s, x22m, x22h;
        double y22s, y22m, y22h;

        int h;

        Boolean ca, cb, cc, cd;
        Form formb;
        Boolean ap, bq;
        int mh, mm, ms;

        int ans1, ans2, ans3, ans4;

        Image[] im_r1, im_r2;
        Image[] im_r3, im_r4;
        Image[] im_r5, im_r6;
        Image img, imgcor;
        Image[] im_r0, im_r7;

        Color colors, colorm, colorh;

        SoundPlayer snd = new SoundPlayer();
        public int score = 0;

        int ix1h;
        int iy1h;
        int ix2h;
        int iy2h;
        int ix22h;
        int iy22h;

        int ix1m;
        int iy1m;
        int ix2m;
        int iy2m;
        int ix22m;
        int iy22m;

        int ix1;
        int iy1;
        int ix2;
        int iy2;
        int ix22;
        int iy22;

        int kr = 0;
        int k;

        int tm6 = 0;

        string now;
        string nowh, nowm, nows;

        string s_hr = "";
        string s_mi = "";
        string s_se = "";

        string th = "";
        string tm = "";
        string ts = "";


        int rdm1;
        int rdm2;

        int rdmp1;
        int rdmp2;

        int ssize = 2;

        //
        Brush result = Brushes.Transparent;
        Type brushesType = typeof(Brushes);
        System.Reflection.PropertyInfo[] properties;


        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbfont, uint cbfont, IntPtr pdv, [In] ref uint pcFonts);
        FontFamily ff;
        Font font;

        public static OperationsForm miOPrref = null;
        SummaryForm formSummary = new SummaryForm();
        ProfileForm formProfile = new ProfileForm();

        HelpForm helpform = new HelpForm();
        public string helpmode = "";

        Boolean repeatMemory = true;
        int memoryLevel;

        int pcounter = 0;
        string key;
        string u_key;

        int ikey = 0;
        string[] ik = new string[4] { "1", "2", "3", "4" };

        int questions = 0;
        int questionsCorrect = 0;
        public Boolean adVance = false;

        Boolean flip = false;


        public OperationsForm()
        {
            InitializeComponent();

            VisiF();

            txt_info.KeyPress += new KeyPressEventHandler(txt_info_KeyPress);

            pb1.MouseDown += new MouseEventHandler(pb1_MouseDown);
            pb1.MouseUp += new MouseEventHandler(pb1_MouseUp);
            pb2.MouseDown += new MouseEventHandler(pb2_MouseDown);
            pb2.MouseUp += new MouseEventHandler(pb2_MouseUp);
            pb3.MouseDown += new MouseEventHandler(pb3_MouseDown);
            pb3.MouseUp += new MouseEventHandler(pb3_MouseUp);
            pb4.MouseDown += new MouseEventHandler(pb4_MouseDown);
            pb4.MouseUp += new MouseEventHandler(pb4_MouseUp);

            loadFont();
            AllocFont(font, this.txtScore, 10.00F);
            AllocFont(font, this.txtQuestion, 10.00F);
            AllocFont(font, this.txtLevel, 10.00F);
            AllocFont(font, this.labelAlert, 16.00F);
        }

        private void VisiF()
        {
            pb1.Visible = false;
            pb2.Visible = false;
            pb3.Visible = false;
            pb4.Visible = false;
        }

        private void AllocFont(Font f, Control c, float size)
        {
            FontStyle fontStyle = FontStyle.Regular;
            c.Font = new Font(ff, size, fontStyle);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPc_Click(object sender, EventArgs e)
        {
            if (trackBar1.Value == 0)
            {
                pcounter++;

                switch (pcounter)
                {
                    case (1):
                        pc.BackgroundImage = TimeTraveller.Properties.Resources.p1;
                        break;
                    case (2):
                        pc.BackgroundImage = TimeTraveller.Properties.Resources.p2;
                        break;
                    case (3):
                        pc.BackgroundImage = TimeTraveller.Properties.Resources.p3;
                        break;
                    case (4):
                        pc.BackgroundImage = TimeTraveller.Properties.Resources.p4;
                        break;
                    case (5):
                        pc.BackgroundImage = TimeTraveller.Properties.Resources.p5;
                        break;
                    case (6):
                        pc.BackgroundImage = TimeTraveller.Properties.Resources.p6;
                        pcounter = 0;
                        break;
                }
            }
        }

        private void DoTrack()
        {
            switch (trackBar1.Value)
            {
                case (0): memoryLevel = 4; break;
                case (1): memoryLevel = 5; break;
                case (2): memoryLevel = 6; break;
                case (3): memoryLevel = 7; break;
                case (4): memoryLevel = 8; break;
                case (5): memoryLevel = 9; break;
                case (6): memoryLevel = 10; break;
            }
        }
        private void btnKey_Click(object sender, EventArgs e)
        {
            DoTrack();

            labelAlert.Text = "Repeat the pattern shown to start the Time Engine";
            txtScore.Text = "< - - - -";
            labelAlert.TextAlign = ContentAlignment.MiddleCenter;
            u_key = "";
            ikey = 0;
            timerKey.Start();
            //break;
        }

        private void btnClock_Click(object sender, EventArgs e)
        {
            labelAlert.Text = "";
            txtScore.Text = "SCORE: " + score.ToString();

            if (repeatMemory)
            {
                //init all
                timerSpace.Stop();
                pc.BackgroundImage = null;
                pc.Refresh();

                this.Refresh();

                questions = 0;
                txtQuestion.Text = questions.ToString();

                progressBar1.Value = 0;
                timerCountdown.Stop();

            }
            else
            {
                timerSpace.Stop();

                pb1.Visible = true;
                pb2.Visible = true;
                pb3.Visible = true;
                pb4.Visible = true;


                switch (trackBar1.Value)
                {
                    case (0):
                        pc.BackgroundImage = TimeTraveller.Properties.Resources.p0;
                        break;
                    case (1):
                        pc.BackgroundImage = TimeTraveller.Properties.Resources.p1;
                        break;
                    case (2):
                        pc.BackgroundImage = TimeTraveller.Properties.Resources.p2;
                        break;
                    case (3):
                        pc.BackgroundImage = TimeTraveller.Properties.Resources.p3;
                        break;
                    case (4):
                        pc.BackgroundImage = TimeTraveller.Properties.Resources.p4;
                        break;
                    case (5):
                        pc.BackgroundImage = TimeTraveller.Properties.Resources.p5;
                        break;
                    case (6):
                        pc.BackgroundImage = TimeTraveller.Properties.Resources.p6;
                        break;
                }



                pc.Refresh();
                this.Refresh();


                //no white
                colors = (Color.FromArgb(GetNextInt32Limit(0, 236), GetNextInt32Limit(0, 236), GetNextInt32Limit(0, 236)));
                colorm = (Color.FromArgb(GetNextInt32Limit(0, 236), GetNextInt32Limit(0, 236), GetNextInt32Limit(0, 236)));
                colorh = (Color.FromArgb(GetNextInt32Limit(0, 236), GetNextInt32Limit(0, 236), GetNextInt32Limit(0, 236)));

                questions++;
                txtQuestion.Text = questions.ToString();
                qrand();

                rand_digital();

                progressBar1.Value = 100;
                timerCountdown.Start();

                btn_Go.Enabled = true;
            }
        }

        private void rand_digital()
        {
            ra = GetNextInt32Limit(0, 10);
            rb = GetNextInt32Limit(0, 10);
            rc = GetNextInt32Limit(0, 10);
            rd = GetNextInt32Limit(0, 10);

            switch (ra)
            {
                case (0):
                    pb1.Image = TimeTraveller.Properties.Resources.dgc0;
                    break;
                case (1):
                    pb1.Image = TimeTraveller.Properties.Resources.dgc1;
                    break;
                case (2):
                    pb1.Image = TimeTraveller.Properties.Resources.dgc2;
                    break;
                case (3):
                    pb1.Image = TimeTraveller.Properties.Resources.dgc3;
                    break;
                case (4):
                    pb1.Image = TimeTraveller.Properties.Resources.dgc4;
                    break;
                case (5):
                    pb1.Image = TimeTraveller.Properties.Resources.dgc5;
                    break;
                case (6):
                    pb1.Image = TimeTraveller.Properties.Resources.dgc6;
                    break;
                case (7):
                    pb1.Image = TimeTraveller.Properties.Resources.dgc7;
                    break;
                case (8):
                    pb1.Image = TimeTraveller.Properties.Resources.dgc8;
                    break;
                case (9):
                    pb1.Image = TimeTraveller.Properties.Resources.dgc9;
                    break;
            }
            switch (rb)
            {
                case (0):
                    pb2.Image = TimeTraveller.Properties.Resources.dgc0;
                    break;
                case (1):
                    pb2.Image = TimeTraveller.Properties.Resources.dgc1;
                    break;
                case (2):
                    pb2.Image = TimeTraveller.Properties.Resources.dgc2;
                    break;
                case (3):
                    pb2.Image = TimeTraveller.Properties.Resources.dgc3;
                    break;
                case (4):
                    pb2.Image = TimeTraveller.Properties.Resources.dgc4;
                    break;
                case (5):
                    pb2.Image = TimeTraveller.Properties.Resources.dgc5;
                    break;
                case (6):
                    pb2.Image = TimeTraveller.Properties.Resources.dgc6;
                    break;
                case (7):
                    pb2.Image = TimeTraveller.Properties.Resources.dgc7;
                    break;
                case (8):
                    pb2.Image = TimeTraveller.Properties.Resources.dgc8;
                    break;
                case (9):
                    pb2.Image = TimeTraveller.Properties.Resources.dgc9;
                    break;

            }
            switch (rc)
            {
                case (0):
                    pb3.Image = TimeTraveller.Properties.Resources.dgc0;
                    break;
                case (1):
                    pb3.Image = TimeTraveller.Properties.Resources.dgc1;
                    break;
                case (2):
                    pb3.Image = TimeTraveller.Properties.Resources.dgc2;
                    break;
                case (3):
                    pb3.Image = TimeTraveller.Properties.Resources.dgc3;
                    break;
                case (4):
                    pb3.Image = TimeTraveller.Properties.Resources.dgc4;
                    break;
                case (5):
                    pb3.Image = TimeTraveller.Properties.Resources.dgc5;
                    break;
                case (6):
                    pb3.Image = TimeTraveller.Properties.Resources.dgc6;
                    break;
                case (7):
                    pb3.Image = TimeTraveller.Properties.Resources.dgc7;
                    break;
                case (8):
                    pb3.Image = TimeTraveller.Properties.Resources.dgc8;
                    break;
                case (9):
                    pb3.Image = TimeTraveller.Properties.Resources.dgc9;
                    break;

            }
            switch (rd)
            {
                case (0):
                    pb4.Image = TimeTraveller.Properties.Resources.dgc0;
                    break;
                case (1):
                    pb4.Image = TimeTraveller.Properties.Resources.dgc1;
                    break;
                case (2):
                    pb4.Image = TimeTraveller.Properties.Resources.dgc2;
                    break;
                case (3):
                    pb4.Image = TimeTraveller.Properties.Resources.dgc3;
                    break;
                case (4):
                    pb4.Image = TimeTraveller.Properties.Resources.dgc4;
                    break;
                case (5):
                    pb4.Image = TimeTraveller.Properties.Resources.dgc5;
                    break;
                case (6):
                    pb4.Image = TimeTraveller.Properties.Resources.dgc6;
                    break;
                case (7):
                    pb4.Image = TimeTraveller.Properties.Resources.dgc7;
                    break;
                case (8):
                    pb4.Image = TimeTraveller.Properties.Resources.dgc8;
                    break;
                case (9):
                    pb4.Image = TimeTraveller.Properties.Resources.dgc9;
                    break;
            }

            ans1 = ra;
            ans2 = rb;
            ans3 = rc;
            ans4 = rd;
        }

        private void qrand()
        {
            h = GetNextInt32Limit(0, 12);

            switch (h)
            {
                case (0):
                    angleh = 270;
                    break;
                case (1):
                    angleh = 300;
                    break;
                case (2):
                    angleh = 330;
                    break;
                case (3):
                    angleh = 0;
                    break;
                case (4):
                    angleh = 30;
                    break;
                case (5):
                    angleh = 60;
                    break;
                case (6):
                    angleh = 90;
                    break;
                case (7):
                    angleh = 120;
                    break;
                case (8):
                    angleh = 150;
                    break;
                case (9):
                    angleh = 180;
                    break;
                case (10):
                    angleh = 210;
                    break;
                case (11):
                    angleh = 240;
                    break;

            }

            int[] i = new int[12] { 270, 0, 90, 180, 300, 330, 30, 60, 120, 150, 210, 240 };
            int[] i1 = new int[2] { 270, 90 };
            ///////////////////////////////
            if (trackBar1.Value == 0)
            {
                anglem = i[GetNextInt32Limit(0, 1)];
                angles = 6 * GetNextInt32Limit(45, 56);
            }
            else if (trackBar1.Value == 1)
            {
                anglem = i1[GetNextInt32Limit(0, 2)];
                angles = 6 * GetNextInt32Limit(45, 56);
            }
            else if (trackBar1.Value == 2)
            {
                anglem = i[GetNextInt32Limit(0, 4)];
                if (anglem == 270)
                {
                    angles = 6 * GetNextInt32Limit(45, 56);
                }
                else
                {
                    angles = 6 * GetNextInt32Limit(0, 40);
                }
            }
            else if (trackBar1.Value == 3)
            {
                anglem = i[GetNextInt32Limit(0, 12)];
                if (anglem == 270)
                {
                    angles = 6 * GetNextInt32Limit(45, 56);
                }
                else
                {
                    angles = 6 * GetNextInt32Limit(0, 40);
                }
            }
            else if (trackBar1.Value == 4)
            {
                anglem = 6 * GetNextInt32Limit(1, 61);
            }
            else if (trackBar1.Value == 5)
            {
                anglem = 6 * GetNextInt32Limit(1, 61);
            }
            else if (trackBar1.Value == 6)
            {
                anglem = 6 * GetNextInt32Limit(1, 61);
            }
            ////////////////////////////////////

            if ((anglem >= 270) && (anglem < 342))
            {
                angleh += 0;
            }
            else if ((anglem >= 342) || (anglem < 54))
            {
                angleh += 6;
            }
            else if ((anglem >= 54) && (anglem < 126))
            {
                angleh += 12;
            }
            else if ((anglem >= 126) && (anglem < 198))
            {
                angleh += 18;
            }
            else if ((anglem >= 198) && (anglem < 270))
            {
                angleh += 24;
            }


            draws();
            whatrad();
        }

        private void draws()
        {
            pc.Refresh();
            angles += 6 * GetNextInt32Limit(1, 61);

            lengths = 130;

            if (angles == 360)
            {
                angles = 0;
            }

            if (angles == 270)
            {
                //# dc();
                anglem += 6;

                if (anglem == 360)
                {
                    anglem = 0;
                }

                if ((anglem == 270) || (anglem == 342) || (anglem == 54) || (anglem == 126) || (anglem == 198))
                {
                    angleh += 6;
                    if (angleh == 360)
                    {
                        angleh = 0;
                    }

                    if (angleh == 270)
                    {
                        //anglem = 270;                        
                    }
                }

            }

            widths = 1;

            x1s = 150;
            y1s = 150;
            x2s = x1s + Math.Cos((Math.PI / 180) * angles) * lengths;
            y2s = y1s + Math.Sin((Math.PI / 180) * angles) * lengths;

            x22s = x1s + Math.Cos((Math.PI / 180) * (angles - 180)) * (lengths - 90);
            y22s = y1s + Math.Sin((Math.PI / 180) * (angles - 180)) * (lengths - 90);

            ix1 = Convert.ToInt32(x1s);
            iy1 = Convert.ToInt32(y1s);
            ix2 = Convert.ToInt32(x2s);
            iy2 = Convert.ToInt32(y2s);

            ix22 = Convert.ToInt32(x22s);
            iy22 = Convert.ToInt32(y22s);

            drawh();
            drawm();

            pen_s = new Pen(colors, widths);

            formGraphics = pc.CreateGraphics();
            formGraphics.DrawLine(pen_s, ix2, iy2, ix1, iy1);
            pen_s.Dispose();
            formGraphics.Dispose();

            pen_ss = new Pen(colors, widths);
            formGraphics = pc.CreateGraphics();
            formGraphics.DrawLine(pen_ss, ix22, iy22, ix1, iy1);
            pen_ss.Dispose();
            formGraphics.Dispose();

            whatrad();
            whattime();
        }

        private void drawm()
        {
            lengthm = 125;
            widthm = 7;

            x1m = 150;
            y1m = 150;
            x2m = x1m + Math.Cos((Math.PI / 180) * anglem) * lengthm;
            y2m = y1m + Math.Sin((Math.PI / 180) * anglem) * lengthm;

            x22m = x1m + Math.Cos((Math.PI / 180) * (anglem - 180)) * (lengthm - 95);
            y22m = y1m + Math.Sin((Math.PI / 180) * (anglem - 180)) * (lengthm - 95);

            ix1m = Convert.ToInt32(x1m);
            iy1m = Convert.ToInt32(y1m);
            ix2m = Convert.ToInt32(x2m);
            iy2m = Convert.ToInt32(y2m);

            ix22m = Convert.ToInt32(x22m);
            iy22m = Convert.ToInt32(y22m);

            pen_m = new Pen(colorm, widthm);
            formGraphics = pc.CreateGraphics();
            formGraphics.DrawLine(pen_m, ix2m, iy2m, ix1m, iy1m);
            pen_m.Dispose();
            formGraphics.Dispose();

            pen_mm = new Pen(colorm, widthm);
            formGraphics = pc.CreateGraphics();
            formGraphics.DrawLine(pen_mm, ix22m, iy22m, ix1m, iy1m);
            pen_mm.Dispose();
            formGraphics.Dispose();
        }

        private void drawh()
        {
            lengthh = 80;
            widthh = 9;

            x1h = 150;
            y1h = 150;
            x2h = x1h + Math.Cos((Math.PI / 180) * angleh) * lengthh;
            y2h = y1h + Math.Sin((Math.PI / 180) * angleh) * lengthh;

            x22h = x1h + Math.Cos((Math.PI / 180) * (angleh - 180)) * (lengthh - 60);
            y22h = y1h + Math.Sin((Math.PI / 180) * (angleh - 180)) * (lengthh - 60);

            ix1h = Convert.ToInt32(x1h);
            iy1h = Convert.ToInt32(y1h);
            ix2h = Convert.ToInt32(x2h);
            iy2h = Convert.ToInt32(y2h);

            ix22h = Convert.ToInt32(x22h);
            iy22h = Convert.ToInt32(y22h);

            pen_h = new Pen(colorh, widthh);
            formGraphics = pc.CreateGraphics();
            formGraphics.DrawLine(pen_h, ix2h, iy2h, ix1h, iy1h);
            pen_h.Dispose();
            formGraphics.Dispose();

            pen_hh = new Pen(colorh, widthh);
            formGraphics = pc.CreateGraphics();
            formGraphics.DrawLine(pen_hh, ix22h, iy22h, ix1h, iy1h);
            pen_hh.Dispose();
            formGraphics.Dispose();
        }

        private void whatrad()
        {
            s_hr = Convert.ToString(angleh);
            s_mi = Convert.ToString(anglem);
            s_se = Convert.ToString(angles);
        }

        private void whattime()
        {
            switch (s_hr)
            {
                //
                case ("360"):
                    th = "03";
                    break;
                //
                case ("270"):
                    th = "12";
                    break;
                case ("300"):
                    th = "01";
                    break;
                case ("330"):
                    th = "02";
                    break;
                case ("0"):
                    th = "03";
                    break;
                case ("30"):
                    th = "04";
                    break;
                case ("60"):
                    th = "05";
                    break;
                case ("90"):
                    th = "06";
                    break;
                case ("120"):
                    th = "07";
                    break;
                case ("150"):
                    th = "08";
                    break;
                case ("180"):
                    th = "09";
                    break;
                case ("210"):
                    th = "10";
                    break;
                case ("240"):
                    th = "11";
                    break;

                case ("276"):
                    th = "12";
                    break;
                case ("306"):
                    th = "01";
                    break;
                case ("336"):
                    th = "02";
                    break;
                case ("6"):
                    th = "03";
                    break;
                case ("36"):
                    th = "04";
                    break;
                case ("66"):
                    th = "05";
                    break;
                case ("96"):
                    th = "06";
                    break;
                case ("126"):
                    th = "07";
                    break;
                case ("156"):
                    th = "08";
                    break;
                case ("186"):
                    th = "09";
                    break;
                case ("216"):
                    th = "10";
                    break;
                case ("246"):
                    th = "11";
                    break;

                case ("282"):
                    th = "12";
                    break;
                case ("312"):
                    th = "01";
                    break;
                case ("342"):
                    th = "02";
                    break;
                case ("12"):
                    th = "03";
                    break;
                case ("42"):
                    th = "04";
                    break;
                case ("72"):
                    th = "05";
                    break;
                case ("102"):
                    th = "06";
                    break;
                case ("132"):
                    th = "07";
                    break;
                case ("162"):
                    th = "08";
                    break;
                case ("192"):
                    th = "09";
                    break;
                case ("222"):
                    th = "10";
                    break;
                case ("252"):
                    th = "11";
                    break;

                case ("288"):
                    th = "12";
                    break;
                case ("318"):
                    th = "01";
                    break;
                case ("348"):
                    th = "02";
                    break;
                case ("18"):
                    th = "03";
                    break;
                case ("48"):
                    th = "04";
                    break;
                case ("78"):
                    th = "05";
                    break;
                case ("108"):
                    th = "06";
                    break;
                case ("138"):
                    th = "07";
                    break;
                case ("168"):
                    th = "08";
                    break;
                case ("198"):
                    th = "09";
                    break;
                case ("228"):
                    th = "10";
                    break;
                case ("258"):
                    th = "11";
                    break;

                case ("294"):
                    th = "12";
                    break;
                case ("324"):
                    th = "01";
                    break;
                case ("354"):
                    th = "02";
                    break;
                case ("24"):
                    th = "03";
                    break;
                case ("54"):
                    th = "04";
                    break;
                case ("84"):
                    th = "05";
                    break;
                case ("114"):
                    th = "06";
                    break;
                case ("144"):
                    th = "07";
                    break;
                case ("174"):
                    th = "08";
                    break;
                case ("204"):
                    th = "09";
                    break;
                case ("234"):
                    th = "10";
                    break;
                case ("264"):
                    th = "11";
                    break;
            }
            switch (s_mi)
            {
                //
                case ("360"):
                    tm = "15";
                    break;
                //
                case ("270"):
                    tm = "00";
                    break;
                case ("300"):
                    tm = "05";
                    break;
                case ("330"):
                    tm = "10";
                    break;
                case ("0"):
                    tm = "15";
                    break;
                case ("30"):
                    tm = "20";
                    break;
                case ("60"):
                    tm = "25";
                    break;
                case ("90"):
                    tm = "30";
                    break;
                case ("120"):
                    tm = "35";
                    break;
                case ("150"):
                    tm = "40";
                    break;
                case ("180"):
                    tm = "45";
                    break;
                case ("210"):
                    tm = "50";
                    break;
                case ("240"):
                    tm = "55";
                    break;

                case ("276"):
                    tm = "01";
                    break;
                case ("306"):
                    tm = "06";
                    break;
                case ("336"):
                    tm = "11";
                    break;
                case ("6"):
                    tm = "16";
                    break;
                case ("36"):
                    tm = "21";
                    break;
                case ("66"):
                    tm = "26";
                    break;
                case ("96"):
                    tm = "31";
                    break;
                case ("126"):
                    tm = "36";
                    break;
                case ("156"):
                    tm = "41";
                    break;
                case ("186"):
                    tm = "46";
                    break;
                case ("216"):
                    tm = "51";
                    break;
                case ("246"):
                    tm = "56";
                    break;

                case ("282"):
                    tm = "02";
                    break;
                case ("312"):
                    tm = "07";
                    break;
                case ("342"):
                    tm = "12";
                    break;
                case ("12"):
                    tm = "17";
                    break;
                case ("42"):
                    tm = "22";
                    break;
                case ("72"):
                    tm = "27";
                    break;
                case ("102"):
                    tm = "32";
                    break;
                case ("132"):
                    tm = "37";
                    break;
                case ("162"):
                    tm = "42";
                    break;
                case ("192"):
                    tm = "47";
                    break;
                case ("222"):
                    tm = "52";
                    break;
                case ("252"):
                    tm = "57";
                    break;

                case ("288"):
                    tm = "03";
                    break;
                case ("318"):
                    tm = "08";
                    break;
                case ("348"):
                    tm = "13";
                    break;
                case ("18"):
                    tm = "18";
                    break;
                case ("48"):
                    tm = "23";
                    break;
                case ("78"):
                    tm = "28";
                    break;
                case ("108"):
                    tm = "33";
                    break;
                case ("138"):
                    tm = "38";
                    break;
                case ("168"):
                    tm = "43";
                    break;
                case ("198"):
                    tm = "48";
                    break;
                case ("228"):
                    tm = "53";
                    break;
                case ("258"):
                    tm = "58";
                    break;

                case ("294"):
                    tm = "04";
                    break;
                case ("324"):
                    tm = "09";
                    break;
                case ("354"):
                    tm = "14";
                    break;
                case ("24"):
                    tm = "19";
                    break;
                case ("54"):
                    tm = "24";
                    break;
                case ("84"):
                    tm = "29";
                    break;
                case ("114"):
                    tm = "34";
                    break;
                case ("144"):
                    tm = "39";
                    break;
                case ("174"):
                    tm = "44";
                    break;
                case ("204"):
                    tm = "49";
                    break;
                case ("234"):
                    tm = "54";
                    break;
                case ("264"):
                    tm = "59";
                    break;
            }
            switch (s_se)
            {
                //
                case ("360"):
                    ts = "15";
                    break;
                //
                case ("270"):
                    ts = "00";
                    break;
                case ("300"):
                    ts = "05";
                    break;
                case ("330"):
                    ts = "10";
                    break;
                case ("0"):
                    ts = "15";
                    break;
                case ("30"):
                    ts = "20";
                    break;
                case ("60"):
                    ts = "25";
                    break;
                case ("90"):
                    ts = "30";
                    break;
                case ("120"):
                    ts = "35";
                    break;
                case ("150"):
                    ts = "40";
                    break;
                case ("180"):
                    ts = "45";
                    break;
                case ("210"):
                    ts = "50";
                    break;
                case ("240"):
                    ts = "55";
                    break;

                case ("276"):
                    ts = "01";
                    break;
                case ("306"):
                    ts = "06";
                    break;
                case ("336"):
                    ts = "11";
                    break;
                case ("6"):
                    ts = "16";
                    break;
                case ("36"):
                    ts = "21";
                    break;
                case ("66"):
                    ts = "26";
                    break;
                case ("96"):
                    ts = "31";
                    break;
                case ("126"):
                    ts = "36";
                    break;
                case ("156"):
                    ts = "41";
                    break;
                case ("186"):
                    ts = "46";
                    break;
                case ("216"):
                    ts = "51";
                    break;
                case ("246"):
                    ts = "56";
                    break;

                case ("282"):
                    ts = "02";
                    break;
                case ("312"):
                    ts = "07";
                    break;
                case ("342"):
                    ts = "12";
                    break;
                case ("12"):
                    ts = "17";
                    break;
                case ("42"):
                    ts = "22";
                    break;
                case ("72"):
                    ts = "27";
                    break;
                case ("102"):
                    ts = "32";
                    break;
                case ("132"):
                    ts = "37";
                    break;
                case ("162"):
                    ts = "42";
                    break;
                case ("192"):
                    ts = "47";
                    break;
                case ("222"):
                    ts = "52";
                    break;
                case ("252"):
                    ts = "57";
                    break;

                case ("288"):
                    ts = "03";
                    break;
                case ("318"):
                    ts = "08";
                    break;
                case ("348"):
                    ts = "13";
                    break;
                case ("18"):
                    ts = "18";
                    break;
                case ("48"):
                    ts = "23";
                    break;
                case ("78"):
                    ts = "28";
                    break;
                case ("108"):
                    ts = "33";
                    break;
                case ("138"):
                    ts = "38";
                    break;
                case ("168"):
                    ts = "43";
                    break;
                case ("198"):
                    ts = "48";
                    break;
                case ("228"):
                    ts = "53";
                    break;
                case ("258"):
                    ts = "58";
                    break;

                case ("294"):
                    ts = "04";
                    break;
                case ("324"):
                    ts = "09";
                    break;
                case ("354"):
                    ts = "14";
                    break;
                case ("24"):
                    ts = "19";
                    break;
                case ("54"):
                    ts = "24";
                    break;
                case ("84"):
                    ts = "29";
                    break;
                case ("114"):
                    ts = "34";
                    break;
                case ("144"):
                    ts = "39";
                    break;
                case ("174"):
                    ts = "44";
                    break;
                case ("204"):
                    ts = "49";
                    break;
                case ("234"):
                    ts = "54";
                    break;
                case ("264"):
                    ts = "59";
                    break;
            }
        }

        private static int GetNextInt32Limit(int min, int max)
        {
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] buffer = new byte[4];

            rng.GetBytes(buffer);
            int result = BitConverter.ToInt32(buffer, 0);

            return new Random(result).Next(min, max);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            helpmode = "about";
            try
            {
                if (helpform.Visible != true)
                {
                    helpform = new HelpForm();
                    helpform.Show();
                }
                else
                {
                    helpform.Close();
                    helpform = new HelpForm();
                    helpform.Show();
                }
            }
            catch
            {
                helpform = new HelpForm();
                helpform.Show();
            }
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            helpmode = "contact";
            try
            {
                if (helpform.Visible != true)
                {
                    helpform = new HelpForm();
                    helpform.Show();
                }
                else
                {
                    helpform.Close();
                    helpform = new HelpForm();
                    helpform.Show();
                }
            }
            catch
            {
                helpform = new HelpForm();
                helpform.Show();
            }
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            try
            {
                if (formProfile.Visible != true)
                {
                    formProfile = new ProfileForm();
                    formProfile.Show();
                }
                else
                {
                    formProfile.Close();
                    formProfile = new ProfileForm();
                    formProfile.Show();
                }
            }
            catch
            {
                formProfile = new ProfileForm();
                formProfile.Show();
            }
        }

        private void checkAchievedLevel()
        {
            //if file exists then read trackbar value from 
            //trackBarLocation.txt file in C:\Users\Public\TTR\tbl.txt

            if (File.Exists(@fPath))
            {
                string im = File.ReadAllText(@fPath);

                //  //  //
                //parse im if not a number then rewrite as im 0
                try
                {
                    int imi = int.Parse(im);
                    if (imi > 7)
                    {
                        //MessageBox.Show("error catch");
                        File.WriteAllText(@fPath, "0");
                        im = "0";
                    }
                }
                catch
                {
                    //MessageBox.Show("error catch");
                    File.WriteAllText(@fPath, "0");
                    im = "0";
                }

                //parse im if length not 1 then rewrite as im 0
                if (im.Length != 1)
                {
                    //MessageBox.Show("error catch");
                    File.WriteAllText(@fPath, "0");
                    im = "0";
                }
                //  //  //



                if (im != "7") { trackBar1.Value = int.Parse(im); }
                else { trackBar1.Enabled = true; }

                //MessageBox.Show("You are currently on Level-" + im, appName);
            }
            else
            {
                File.WriteAllText(@fPath, "0");
                trackBar1.Value = 0;

                //MessageBox.Show("You are currently on Level-0", appName);
            }


        }

        private void OperationsForm_Load(object sender, EventArgs e)
        {
            checkAchievedLevel();

            miOPrref = this;

            snd = new SoundPlayer(TimeTraveller.Properties.Resources.scommence);
            snd.Play();

            btnClock.Enabled = false;

            //memoryLevel = 4;
            ULevel();
            GetNewKey();

            txtQuestion.Text = questions.ToString();

            timerOP.Enabled = true;

            score = 0;

            bq = true;
            ca = cb = cc = cd = false;

            txt_info.Focus();
        }

        public void GetNewKey()
        {

            DoTrack();
            //MessageBox.Show(memoryLevel.ToString());

            key = "";
            for (int i = 0; i < memoryLevel; i++)
            {
                key += ik[GetNextInt32Limit(0, 4)];
            }

            txtQuestion.Text = "0";
            progressBar1.Value = 0;
            //MessageBox.Show(key);
        }

        public void ULevel()
        {
            //upon finishing a level create/update tbl.txt -> 1,2,3,4,5,6,7 at 7 trackBar1.enabled = true

            txtLevel.Text = "L-" + trackBar1.Value.ToString();
            repeatMemory = true;

            questions = 0;
        }

        private void loadFont()
        {
            byte[] fontArray = TimeTraveller.Properties.Resources.scorefont;
            int datalength = TimeTraveller.Properties.Resources.scorefont.Length;
            IntPtr ptrData = Marshal.AllocCoTaskMem(datalength);
            Marshal.Copy(fontArray, 0, ptrData, datalength);
            uint cFonts = 0;
            AddFontMemResourceEx(ptrData, (uint)fontArray.Length, IntPtr.Zero, ref cFonts);
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddMemoryFont(ptrData, datalength);
            Marshal.FreeCoTaskMem(ptrData);
            ff = pfc.Families[0];


            font = new Font(ff, 10f, FontStyle.Regular);
        }

        private void pb1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void pb1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void pb2_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void pb2_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void pb3_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void pb3_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void pb4_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void pb4_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void btn_Go_MouseDown(object sender, MouseEventArgs e)
        {
            txtScore.Text = "Please wait . .";

            btn_Go.BackgroundImage = TimeTraveller.Properties.Resources.go2;
            btn_Go.Refresh();
        }

        private void btn_Go_MouseUp(object sender, MouseEventArgs e)
        {
            btn_Go.BackgroundImage = TimeTraveller.Properties.Resources.go;
            btn_Go.Refresh();
        }

        private void btn_Go_Click(object sender, EventArgs e)
        {
            selecter.Stop();
            pb1.Visible = true;
            pb2.Visible = true;
            pb3.Visible = true;
            pb4.Visible = true;

            btn_Go.Enabled = false;
            if (repeatMemory)
            {
                timerSpace.Stop();


                pc.Refresh();
                this.Refresh();

                questions = 0;
                questionsCorrect = 0;
                txtQuestion.Text = questions.ToString();

                progressBar1.Value = 0;


                btnKey.PerformClick();
            }
            else
            {
                repeatMemory = false;

                int r_s = GetNextInt32Limit(0, 8);
                switch (r_s)
                {
                    case (0):
                        snd = new SoundPlayer(TimeTraveller.Properties.Resources.scorr1);
                        break;
                    case (1):
                        snd = new SoundPlayer(TimeTraveller.Properties.Resources.scorr2);
                        break;
                    case (2):
                        snd = new SoundPlayer(TimeTraveller.Properties.Resources.scorr3);
                        break;
                    case (3):
                        snd = new SoundPlayer(TimeTraveller.Properties.Resources.scorr4);
                        break;
                    case (4):
                        snd = new SoundPlayer(TimeTraveller.Properties.Resources.scorr5);
                        break;
                    case (5):
                        snd = new SoundPlayer(TimeTraveller.Properties.Resources.scorr6);
                        break;
                    case (6):
                        snd = new SoundPlayer(TimeTraveller.Properties.Resources.scorr7);
                        break;
                    case (7):
                        snd = new SoundPlayer(TimeTraveller.Properties.Resources.scorr8);
                        break;
                }

                snd.Play();

                string enteredAnswer =
                    ans1.ToString() + ans2.ToString() + ":" + ans3.ToString() + ans4.ToString();

                string correctAnswer =
                    th + ":" + tm + ":" + ts;


                timerCountdown.Stop();

                if (correctAnswer != "::")
                {
                    if (questions == 5)
                    {
                        //Mark
                        //enteredAnswer = correctAnswer.Substring(0, 5);
                        if (enteredAnswer == correctAnswer.Substring(0, 5))
                        {
                            {
                                int lv = int.Parse(txtLevel.Text.Replace("L-", "")) + 1;
                                System.IO.File.WriteAllText(@OperationsForm.miOPrref.fPath, lv.ToString());
                                //btnDismiss.Visible = false;
                                //btnSaveScore.Visible = false;
                            }

                            //all questions complete
                            questionsCorrect++;
                            score += (progressBar1.Value / 10) + (questionsCorrect * Convert.ToInt32(Math.Pow(10, trackBar1.Value)));


                            timerSpace.Start();


                            r_s = trackBar1.Value;
                            switch (r_s)
                            {
                                case (0):
                                    snd = new SoundPlayer(TimeTraveller.Properties.Resources.swarp1);
                                    break;
                                case (1):
                                    snd = new SoundPlayer(TimeTraveller.Properties.Resources.swarp2);
                                    break;
                                case (2):
                                    snd = new SoundPlayer(TimeTraveller.Properties.Resources.swarp3);
                                    break;
                                case (3):
                                    snd = new SoundPlayer(TimeTraveller.Properties.Resources.swarp3);
                                    break;
                                case (4):
                                    snd = new SoundPlayer(TimeTraveller.Properties.Resources.swarp3);
                                    break;
                                case (5):
                                    snd = new SoundPlayer(TimeTraveller.Properties.Resources.swarp3);
                                    break;

                            }

                            snd.Play();

                            pb1.Image = null;
                            pb2.Image = null;
                            pb3.Image = null;
                            pb4.Image = null;

                            th = "00";
                            tm = "00";
                            ts = "00";
                        }
                        else
                        {
                            if (!adVance)
                            {
                                snd = new SoundPlayer(TimeTraveller.Properties.Resources.swrong);
                                snd.Play();
                            }

                            DisplayAnswerWait();

                        }


                        //Show summary
                        try
                        {


                            if (formSummary.Visible == false) { formSummary = new SummaryForm(); formSummary.Show(); }
                            else { this.SendToBack(); }

                            btn_Go.Enabled = false;
                            btnReset.Enabled = false;
                            btnPc.Enabled = false;
                        }
                        catch { formSummary = new SummaryForm(); formSummary.Show(); }
                        //
                    }
                    else
                    {
                        //Mark
                        //enteredAnswer = correctAnswer.Substring(0, 5);
                        if (enteredAnswer == correctAnswer.Substring(0, 5))
                        {
                            questionsCorrect++;
                            score += (progressBar1.Value / 10) + (questionsCorrect * Convert.ToInt32(Math.Pow(10, trackBar1.Value)));

                            timerSpace.Start();

                            pb1.Image = null;
                            pb2.Image = null;
                            pb3.Image = null;
                            pb4.Image = null;

                            th = "00";
                            tm = "00";
                            ts = "00";
                        }
                        else
                        {
                            if (!adVance)
                            {
                                snd = new SoundPlayer(TimeTraveller.Properties.Resources.swrong);
                                snd.Play();
                            }

                            DisplayAnswerWait();

                        }
                    }

                }




                if (questions == 5)
                {
                    if (questionsCorrect == 5)
                    {
                        //wait Advanced
                        questions = 0;
                        questionsCorrect = 0;

                        adVance = true;


                        //timerSpace.Start();


                        //pb1.Image = null;
                        //pb2.Image = null;
                        //pb3.Image = null;
                        //pb4.Image = null;

                        //th = "00";
                        //tm = "00";
                        //ts = "00";
                    }
                    else
                    {
                        DisplayAnswerWait();

                        questions = 0;
                        questionsCorrect = 0;
                        score = 0;
                    }
                }
                else
                {
                    if (adVance)
                    {
                        if (trackBar1.Value != 6)
                        {
                            adVance = false;
                            trackBar1.Value = trackBar1.Value + 1;
                            ULevel();
                            GetNewKey();
                            btn_Go.Enabled = true;
                        }
                        else
                        {
                            //congratulations!! you have finished the game
                        }
                    }

                    timerNext.Start();
                }

            }

            txt_info.Focus();
        }


        private void DisplayAnswerWait()
        {
            txtScore.Text = th + ":" + tm;
            System.Threading.Thread.Sleep(2000);
        }

        void txt_info_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8)
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (ca == true)
                {
                    if (e.KeyChar == 48)
                    {
                        b0_Click(sender, e);
                    }
                    else if (e.KeyChar == 49)
                    {
                        b1_Click(sender, e);
                    }
                    else if (e.KeyChar == 50)
                    {
                        b2_Click(sender, e);
                    }
                    else if (e.KeyChar == 51)
                    {
                        b3_Click(sender, e);
                    }
                    else if (e.KeyChar == 52)
                    {
                        b4_Click(sender, e);
                    }
                    else if (e.KeyChar == 53)
                    {
                        b5_Click(sender, e);
                    }
                    else if (e.KeyChar == 54)
                    {
                        b6_Click(sender, e);
                    }
                    else if (e.KeyChar == 55)
                    {
                        b7_Click(sender, e);
                    }
                    else if (e.KeyChar == 56)
                    {
                        b8_Click(sender, e);
                    }
                    else if (e.KeyChar == 57)
                    {
                        b9_Click(sender, e);
                    }
                }
                else if (cb == true)
                {
                    if (e.KeyChar == 48)
                    {
                        b0_Click(sender, e);
                    }
                    else if (e.KeyChar == 49)
                    {
                        b1_Click(sender, e);
                    }
                    else if (e.KeyChar == 50)
                    {
                        b2_Click(sender, e);
                    }
                    else if (e.KeyChar == 51)
                    {
                        b3_Click(sender, e);
                    }
                    else if (e.KeyChar == 52)
                    {
                        b4_Click(sender, e);
                    }
                    else if (e.KeyChar == 53)
                    {
                        b5_Click(sender, e);
                    }
                    else if (e.KeyChar == 54)
                    {
                        b6_Click(sender, e);
                    }
                    else if (e.KeyChar == 55)
                    {
                        b7_Click(sender, e);
                    }
                    else if (e.KeyChar == 56)
                    {
                        b8_Click(sender, e);
                    }
                    else if (e.KeyChar == 57)
                    {
                        b9_Click(sender, e);
                    }
                }
                else if (cc == true)
                {
                    if (e.KeyChar == 48)
                    {
                        b0_Click(sender, e);
                    }
                    else if (e.KeyChar == 49)
                    {
                        b1_Click(sender, e);
                    }
                    else if (e.KeyChar == 50)
                    {
                        b2_Click(sender, e);
                    }
                    else if (e.KeyChar == 51)
                    {
                        b3_Click(sender, e);
                    }
                    else if (e.KeyChar == 52)
                    {
                        b4_Click(sender, e);
                    }
                    else if (e.KeyChar == 53)
                    {
                        b5_Click(sender, e);
                    }
                    else if (e.KeyChar == 54)
                    {
                        b6_Click(sender, e);
                    }
                    else if (e.KeyChar == 55)
                    {
                        b7_Click(sender, e);
                    }
                    else if (e.KeyChar == 56)
                    {
                        b8_Click(sender, e);
                    }
                    else if (e.KeyChar == 57)
                    {
                        b9_Click(sender, e);
                    }
                }
                else if (cd == true)
                {
                    if (e.KeyChar == 48)
                    {
                        b0_Click(sender, e);
                    }
                    else if (e.KeyChar == 49)
                    {
                        b1_Click(sender, e);
                    }
                    else if (e.KeyChar == 50)
                    {
                        b2_Click(sender, e);
                    }
                    else if (e.KeyChar == 51)
                    {
                        b3_Click(sender, e);
                    }
                    else if (e.KeyChar == 52)
                    {
                        b4_Click(sender, e);
                    }
                    else if (e.KeyChar == 53)
                    {
                        b5_Click(sender, e);
                    }
                    else if (e.KeyChar == 54)
                    {
                        b6_Click(sender, e);
                    }
                    else if (e.KeyChar == 55)
                    {
                        b7_Click(sender, e);
                    }
                    else if (e.KeyChar == 56)
                    {
                        b8_Click(sender, e);
                    }
                    else if (e.KeyChar == 57)
                    {
                        b9_Click(sender, e);
                    }
                }
            }
        }

        private void b0_Click(object sender, EventArgs e)
        {
            snd = new SoundPlayer(TimeTraveller.Properties.Resources.s_col_2);
            snd.Play();

            if (ca == true)
            {
                pb1.Image = TimeTraveller.Properties.Resources.dgc0;
                ans1 = 0;
            }
            else if (cb == true)
            {
                pb2.Image = TimeTraveller.Properties.Resources.dgc0;
                ans2 = 0;
            }
            else if (cc == true)
            {
                pb3.Image = TimeTraveller.Properties.Resources.dgc0;
                ans3 = 0;
            }
            else if (cd == true)
            {
                pb4.Image = TimeTraveller.Properties.Resources.dgc0;
                ans4 = 0;
            }
        }

        private void b1_Click(object sender, EventArgs e)
        {
            snd = new SoundPlayer(TimeTraveller.Properties.Resources.s_col_1);
            snd.Play();

            if (ca == true)
            {
                pb1.Image = TimeTraveller.Properties.Resources.dgc1;
                ans1 = 1;
            }
            else if (cb == true)
            {
                pb2.Image = TimeTraveller.Properties.Resources.dgc1;
                ans2 = 1;
            }
            else if (cc == true)
            {
                pb3.Image = TimeTraveller.Properties.Resources.dgc1;
                ans3 = 1;
            }
            else if (cd == true)
            {
                pb4.Image = TimeTraveller.Properties.Resources.dgc1;
                ans4 = 1;
            }
        }

        private void b2_Click(object sender, EventArgs e)
        {
            snd = new SoundPlayer(TimeTraveller.Properties.Resources.s_col_1);
            snd.Play();

            if (ca == true)
            {
                pb1.Image = TimeTraveller.Properties.Resources.dgc2;
                ans1 = 2;
            }
            else if (cb == true)
            {
                pb2.Image = TimeTraveller.Properties.Resources.dgc2;
                ans2 = 2;
            }
            else if (cc == true)
            {
                pb3.Image = TimeTraveller.Properties.Resources.dgc2;
                ans3 = 2;
            }
            else if (cd == true)
            {
                pb4.Image = TimeTraveller.Properties.Resources.dgc2;
                ans4 = 2;
            }
        }

        private void b3_Click(object sender, EventArgs e)
        {
            snd = new SoundPlayer(TimeTraveller.Properties.Resources.s_col_1);
            snd.Play();

            if (ca == true)
            {
                pb1.Image = TimeTraveller.Properties.Resources.dgc3;
                ans1 = 3;
            }
            else if (cb == true)
            {
                pb2.Image = TimeTraveller.Properties.Resources.dgc3;
                ans2 = 3;
            }
            else if (cc == true)
            {
                pb3.Image = TimeTraveller.Properties.Resources.dgc3;
                ans3 = 3;
            }
            else if (cd == true)
            {
                pb4.Image = TimeTraveller.Properties.Resources.dgc3;
                ans4 = 3;
            }
        }

        private void b4_Click(object sender, EventArgs e)
        {
            snd = new SoundPlayer(TimeTraveller.Properties.Resources.s_col_1);
            snd.Play();

            if (ca == true)
            {
                pb1.Image = TimeTraveller.Properties.Resources.dgc4;
                ans1 = 4;
            }
            else if (cb == true)
            {
                pb2.Image = TimeTraveller.Properties.Resources.dgc4;
                ans2 = 4;
            }
            else if (cc == true)
            {
                pb3.Image = TimeTraveller.Properties.Resources.dgc4;
                ans3 = 4;
            }
            else if (cd == true)
            {
                pb4.Image = TimeTraveller.Properties.Resources.dgc4;
                ans4 = 4;
            }
        }

        private void b5_Click(object sender, EventArgs e)
        {
            snd = new SoundPlayer(TimeTraveller.Properties.Resources.s_col_1);
            snd.Play();

            if (ca == true)
            {
                pb1.Image = TimeTraveller.Properties.Resources.dgc5;
                ans1 = 5;
            }
            else if (cb == true)
            {
                pb2.Image = TimeTraveller.Properties.Resources.dgc5;
                ans2 = 5;
            }
            else if (cc == true)
            {
                pb3.Image = TimeTraveller.Properties.Resources.dgc5;
                ans3 = 5;
            }
            else if (cd == true)
            {
                pb4.Image = TimeTraveller.Properties.Resources.dgc5;
                ans4 = 5;
            }
        }

        private void b6_Click(object sender, EventArgs e)
        {
            snd = new SoundPlayer(TimeTraveller.Properties.Resources.s_col_1);
            snd.Play();

            if (ca == true)
            {
                pb1.Image = TimeTraveller.Properties.Resources.dgc6;
                ans1 = 6;
            }
            else if (cb == true)
            {
                pb2.Image = TimeTraveller.Properties.Resources.dgc6;
                ans2 = 6;
            }
            else if (cc == true)
            {
                pb3.Image = TimeTraveller.Properties.Resources.dgc6;
                ans3 = 6;
            }
            else if (cd == true)
            {
                pb4.Image = TimeTraveller.Properties.Resources.dgc6;
                ans4 = 6;
            }
        }

        private void b7_Click(object sender, EventArgs e)
        {
            snd = new SoundPlayer(TimeTraveller.Properties.Resources.s_col_1);
            snd.Play();

            if (ca == true)
            {
                pb1.Image = TimeTraveller.Properties.Resources.dgc7;
                ans1 = 7;
            }
            else if (cb == true)
            {
                pb2.Image = TimeTraveller.Properties.Resources.dgc7;
                ans2 = 7;
            }
            else if (cc == true)
            {
                pb3.Image = TimeTraveller.Properties.Resources.dgc7;
                ans3 = 7;
            }
            else if (cd == true)
            {
                pb4.Image = TimeTraveller.Properties.Resources.dgc7;
                ans4 = 7;
            }
        }

        private void b8_Click(object sender, EventArgs e)
        {
            snd = new SoundPlayer(TimeTraveller.Properties.Resources.s_col_1);
            snd.Play();

            if (ca == true)
            {
                pb1.Image = TimeTraveller.Properties.Resources.dgc8;
                ans1 = 8;
            }
            else if (cb == true)
            {
                pb2.Image = TimeTraveller.Properties.Resources.dgc8;
                ans2 = 8;
            }
            else if (cc == true)
            {
                pb3.Image = TimeTraveller.Properties.Resources.dgc8;
                ans3 = 8;
            }
            else if (cd == true)
            {
                pb4.Image = TimeTraveller.Properties.Resources.dgc8;
                ans4 = 8;
            }
        }

        private void b9_Click(object sender, EventArgs e)
        {
            snd = new SoundPlayer(TimeTraveller.Properties.Resources.s_col_3);
            snd.Play();

            if (ca == true)
            {
                pb1.Image = TimeTraveller.Properties.Resources.dgc9;
                ans1 = 9;
            }
            else if (cb == true)
            {
                pb2.Image = TimeTraveller.Properties.Resources.dgc9;
                ans2 = 9;
            }
            else if (cc == true)
            {
                pb3.Image = TimeTraveller.Properties.Resources.dgc9;
                ans3 = 9;
            }
            else if (cd == true)
            {
                pb4.Image = TimeTraveller.Properties.Resources.dgc9;
                ans4 = 9;
            }
        }

        private void sectic()
        {
            if (secticb == false)
            {
                pb5.BackColor = Color.Black;
                pb6.BackColor = Color.Black;
                secticb = true;
            }
            else
            {
                //pb5.Image = TimeTraveller.Properties.Resources.dgcl;
                //pb6.Image = TimeTraveller.Properties.Resources.dgcl;
                pb5.BackColor = Color.White;
                pb6.BackColor = Color.White;
                secticb = false;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            sectic();
        }

        private void timerFloat_Tick(object sender, EventArgs e)
        {
            if (flip)
            {
                b0.Location = new Point(b0.Location.X - 1, b0.Location.Y - 1);
                flip = false;
            }
            else
            {
                b0.Location = new Point(b0.Location.X + 1, b0.Location.Y + 1);
                flip = true;
            }
        }

        private void timerSpace_Tick(object sender, EventArgs e)
        {
            properties = brushesType.GetProperties();

            //while (true)
            {
                for (int i = 0; i < 10; i++)
                {
                    rdm1 = GetNextInt32Limit(0, this.Width);
                    rdm2 = GetNextInt32Limit(0, this.Height);

                    rdmp1 = GetNextInt32Limit(0, pc.Width);
                    rdmp2 = GetNextInt32Limit(0, pc.Height);

                    //int random = 
                    result = (Brush)properties[GetNextInt32Limit(0, properties.Length)].GetValue(null, null);

                    if ((rdm1 > pc.Location.X) && (rdm1 < pc.Location.X + pc.Width)
                        &&
                    (rdm2 > pc.Location.Y) && (rdm2 < pc.Location.Y + pc.Height))
                    {
                        pc.CreateGraphics().DrawEllipse(new Pen((Brush)result, ssize), new Rectangle(rdmp1, rdmp2, ssize, ssize));
                    }
                    else
                    {
                        this.CreateGraphics().DrawEllipse(new Pen((Brush)result, ssize), new Rectangle(rdm1, rdm2, ssize, ssize));
                    }
                }
                //System.Threading.Thread.Sleep(1);
                //}

            }


        }

        private void timerNext_Tick(object sender, EventArgs e)
        {
            timerNext.Stop();
            btnClock.PerformClick();
        }

        private void timerKey_Tick(object sender, EventArgs e)
        {
            try
            {
                tKo.Start();

                switch (key.Substring(ikey, 1))
                {
                    case ("1"):
                        bk1.BackColor = Color.Red;
                        bk2.BackColor = Color.Transparent;
                        bk3.BackColor = Color.Transparent;
                        bk4.BackColor = Color.Transparent;
                        break;
                    case ("2"):
                        bk2.BackColor = Color.Red;
                        bk1.BackColor = Color.Transparent;
                        bk3.BackColor = Color.Transparent;
                        bk4.BackColor = Color.Transparent;
                        break;
                    case ("3"):
                        bk3.BackColor = Color.Red;
                        bk1.BackColor = Color.Transparent;
                        bk2.BackColor = Color.Transparent;
                        bk4.BackColor = Color.Transparent;
                        break;
                    case ("4"):
                        bk4.BackColor = Color.Red;
                        bk1.BackColor = Color.Transparent;
                        bk2.BackColor = Color.Transparent;
                        bk3.BackColor = Color.Transparent;
                        break;
                }
                ikey++;
            }
            catch
            {
                ikey = 0;
                bk1.BackColor = Color.Transparent;
                bk2.BackColor = Color.Transparent;
                bk3.BackColor = Color.Transparent;
                bk4.BackColor = Color.Transparent;
                timerKey.Stop();
            }
        }

        private void tKo_Tick(object sender, EventArgs e)
        {
            bk1.BackColor = Color.Transparent;
            bk2.BackColor = Color.Transparent;
            bk3.BackColor = Color.Transparent;
            bk4.BackColor = Color.Transparent;
            tKo.Stop();
        }

        private void timerCountdown_Tick(object sender, EventArgs e)
        {
            progressBar1.Value -= 1;
            if (progressBar1.Value == 0)
            {
                timerCountdown.Stop();
                //progressBar1.Value = 100;
                btn_Go.PerformClick();
            }
        }

        private void timerInitialize_Tick(object sender, EventArgs e)
        {
            timerInitialize.Stop();
            btnKey.PerformClick();
        }

        private void timerOP_Tick(object sender, EventArgs e)
        {
            this.Opacity += .005;
            if (this.Opacity == 1)
            {
                timerOP.Stop();
                this.Cursor = Cursors.Default;
                //btn_0init.Enabled = true;
                labelAlert.Text = "    * * *  HIT THE 'GO' BUTTON TO BEGIN   * * *";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            questions = 0;
            questionsCorrect = 0;
            score = 0;

            timerNext.Start();
        }

        private void bk1_Click(object sender, EventArgs e)
        {
            u_key += "1";

            if (u_key == key)
            {
                repeatMemory = false;
                timerInitialize.Enabled = false;
                timerKey.Enabled = false;

                labelAlert.Text = "";

                snd = new SoundPlayer(TimeTraveller.Properties.Resources.sstart);
                snd.Play();

                btnClock.Enabled = true;
                btnClock.PerformClick();
            }

            if ((u_key.Length == memoryLevel) && (u_key != key))
            {
                repeatMemory = true;
                questions = 0;
                labelAlert.Text = "                        Loading . .  Please wait . .";
                labelAlert.TextAlign = ContentAlignment.MiddleCenter;
                txtScore.Text = "Not Correct";

                timerInitialize.Start();
            }

            try
            {
                if (u_key.Length == memoryLevel)
                { u_key = ""; }
                else
                {
                    txtScore.Text = (memoryLevel - u_key.Length).ToString() + " to go . .";
                }
            }
            catch { }
        }

        private void bk2_Click(object sender, EventArgs e)
        {
            u_key += "2";

            if (u_key == key)
            {
                repeatMemory = false;
                timerInitialize.Enabled = false;
                timerKey.Enabled = false;

                labelAlert.Text = "";

                snd = new SoundPlayer(TimeTraveller.Properties.Resources.sstart);
                snd.Play();

                btnClock.Enabled = true;
                btnClock.PerformClick();
            }

            if ((u_key.Length == memoryLevel) && (u_key != key))
            {
                repeatMemory = true;
                questions = 0;
                labelAlert.Text = "                        Loading . .  Please wait . .";
                labelAlert.TextAlign = ContentAlignment.MiddleCenter;
                txtScore.Text = "Not Correct";

                timerInitialize.Start();
            }

            try
            {
                if (u_key.Length == memoryLevel)
                { u_key = ""; }
                else
                {
                    txtScore.Text = (memoryLevel - u_key.Length).ToString() + " to go . .";
                }
            }
            catch { }
        }

        private void bk3_Click(object sender, EventArgs e)
        {

            u_key += "3";

            if (u_key == key)
            {
                repeatMemory = false;
                timerInitialize.Enabled = false;
                timerKey.Enabled = false;

                labelAlert.Text = "";

                snd = new SoundPlayer(TimeTraveller.Properties.Resources.sstart);
                snd.Play();

                btnClock.Enabled = true;
                btnClock.PerformClick();
            }

            if ((u_key.Length == memoryLevel) && (u_key != key))
            {
                repeatMemory = true;
                questions = 0;
                labelAlert.Text = "                        Loading . .  Please wait . .";
                labelAlert.TextAlign = ContentAlignment.MiddleCenter;
                txtScore.Text = "Not Correct";

                timerInitialize.Start();
            }

            try
            {
                if (u_key.Length == memoryLevel)
                { u_key = ""; }
                else
                {
                    txtScore.Text = (memoryLevel - u_key.Length).ToString() + " to go . .";
                }
            }
            catch { }
        }

        private void bk4_Click(object sender, EventArgs e)
        {
            u_key += "4";

            if (u_key == key)
            {
                repeatMemory = false;
                timerInitialize.Enabled = false;
                timerKey.Enabled = false;

                labelAlert.Text = "";

                snd = new SoundPlayer(TimeTraveller.Properties.Resources.sstart);
                snd.Play();

                btnClock.Enabled = true;
                btnClock.PerformClick();
            }

            if ((u_key.Length == memoryLevel) && (u_key != key))
            {
                repeatMemory = true;
                questions = 0;
                labelAlert.Text = "                        Loading . .  Please wait . .";
                labelAlert.TextAlign = ContentAlignment.MiddleCenter;
                txtScore.Text = "Not Correct";

                timerInitialize.Start();
            }

            try
            {
                if (u_key.Length == memoryLevel)
                { u_key = ""; }
                else
                {
                    txtScore.Text = (memoryLevel - u_key.Length).ToString() + " to go . .";
                }
            }
            catch { }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            timerCountdown.Enabled = false;
            timerKey.Enabled = false;


            questions = 0;
            questionsCorrect = 0;
            repeatMemory = true;


            ULevel();

            GetNewKey();

            pc.BackgroundImage = null;
            pc.Refresh();

            pb1.Image = pb2.Image = pb3.Image = pb4.Image = null;
        }

        private void pb1_Click(object sender, EventArgs e)
        {
            selecter.Stop();
            selecter.Start();

            if (bq == true)
            {
                snd = new SoundPlayer(TimeTraveller.Properties.Resources.s_las);
                snd.Play();

                //if (ca == false)
                {
                    ca = true;
                    cb = false;
                    cc = false;
                    cd = false;

                    //pb2.Visible = false;
                    //pb3.Visible = false;
                    //pb4.Visible = false;
                }
                //else if (ca == true)
                //{
                //    ca = false;
                //    cb = false;
                //    cc = false;
                //    cd = false;

                pb2.Visible = true;
                pb3.Visible = true;
                pb4.Visible = true;
                //}
            }

            txt_info.Focus();
        }

        private void pb2_Click(object sender, EventArgs e)
        {
            selecter.Stop();
            selecter.Start();

            if (bq == true)
            {
                snd = new SoundPlayer(TimeTraveller.Properties.Resources.s_las);
                snd.Play();

                //if (cb == false)
                {
                    cb = true;
                    ca = false;
                    cc = false;
                    cd = false;

                    //pb1.Visible = false;
                    //pb3.Visible = false;
                    //pb4.Visible = false;
                }
                //else if (cb == true)
                //{
                //    ca = false;
                //    cb = false;
                //    cc = false;
                //    cd = false;

                pb1.Visible = true;
                pb3.Visible = true;
                pb4.Visible = true;
                //}
            }

            txt_info.Focus();
        }

        private void pb3_Click(object sender, EventArgs e)
        {
            selecter.Stop();
            selecter.Start();

            if (bq == true)
            {
                snd = new SoundPlayer(TimeTraveller.Properties.Resources.s_las);
                snd.Play();

                //if (cc == false)
                {
                    cc = true;
                    cb = false;
                    ca = false;
                    cd = false;

                    //pb2.Visible = false;
                    //pb1.Visible = false;
                    //pb4.Visible = false;
                }
                //else if (cc == true)
                //{
                //    ca = false;
                //    cb = false;
                //    cc = false;
                //    cd = false;

                pb2.Visible = true;
                pb1.Visible = true;
                pb4.Visible = true;
                //}
            }

            txt_info.Focus();
        }

        private void pb4_Click(object sender, EventArgs e)
        {
            selecter.Stop();
            selecter.Start();

            if (bq == true)
            {
                snd = new SoundPlayer(TimeTraveller.Properties.Resources.s_las);
                snd.Play();

                //if (cd == false)
                {
                    cd = true;
                    cb = false;
                    cc = false;
                    ca = false;

                    //pb2.Visible = false;
                    //pb3.Visible = false;
                    //pb1.Visible = false;
                }
                //else if (cd == true)
                //{
                //    ca = false;
                //    cb = false;
                //    cc = false;
                //    cd = false;

                pb2.Visible = true;
                pb3.Visible = true;
                pb1.Visible = true;
                //}
            }

            txt_info.Focus();
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            labelAlert.Text = "Exit TimeTraveller";
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            labelAlert.Text = "";
        }

        private void btnKey_MouseEnter(object sender, EventArgs e)
        {
            labelAlert.Text = "Show Memory Pattern";
        }

        private void btnKey_MouseLeave(object sender, EventArgs e)
        {
            labelAlert.Text = "";
        }

        private void btnPc_MouseEnter(object sender, EventArgs e)
        {
            labelAlert.Text = "Disabled";
        }

        private void btnPc_MouseLeave(object sender, EventArgs e)
        {
            labelAlert.Text = "";
        }

        private void btnClock_MouseEnter(object sender, EventArgs e)
        {
            labelAlert.Text = "Disabled";
        }

        private void btnClock_MouseLeave(object sender, EventArgs e)
        {
            labelAlert.Text = "";
        }

        private void btnHelp_MouseEnter(object sender, EventArgs e)
        {
            labelAlert.Text = "Help";
        }

        private void btnHelp_MouseLeave(object sender, EventArgs e)
        {
            labelAlert.Text = "";
        }

        private void btnContact_MouseEnter(object sender, EventArgs e)
        {
            labelAlert.Text = "Developer Contact";
        }

        private void btnContact_MouseLeave(object sender, EventArgs e)
        {
            labelAlert.Text = "";
        }

        private void btnProfile_MouseEnter(object sender, EventArgs e)
        {
            labelAlert.Text = "Your Profile";
        }

        private void btnProfile_MouseLeave(object sender, EventArgs e)
        {
            labelAlert.Text = "";
        }

        private void OperationsForm_Click(object sender, EventArgs e)
        {
            if (formSummary.Visible == true)
            {
                //MessageBox.Show("V");
                formSummary.BringToFront();

            }
            else
            {
                //MessageBox.Show("NV");
            }
        }

        Boolean o_o = false;
        private void selecter_Tick(object sender, EventArgs e)
        {
            //
            switch (ca)
            {
                case (true):
                    if (o_o)
                    {
                        o_o = false;
                        pb1.Visible = false;
                    }
                    else
                    {
                        o_o = true;
                        pb1.Visible = true;
                    }
                    break;
            }

            //
            switch (cb)
            {
                case (true):
                    if (o_o)
                    {
                        o_o = false;
                        pb2.Visible = false;
                    }
                    else
                    {
                        o_o = true;
                        pb2.Visible = true;
                    }
                    break;
            }

            //
            switch (cc)
            {
                case (true):
                    if (o_o)
                    {
                        o_o = false;
                        pb3.Visible = false;
                    }
                    else
                    {
                        o_o = true;
                        pb3.Visible = true;
                    }
                    break;
            }

            //
            switch (cd)
            {
                case (true):
                    if (o_o)
                    {
                        o_o = false;
                        pb4.Visible = false;
                    }
                    else
                    {
                        o_o = true;
                        pb4.Visible = true;
                    }
                    break;
            }
        }




    }
}
