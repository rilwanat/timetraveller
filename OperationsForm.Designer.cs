namespace TimeTraveller
{
    partial class OperationsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OperationsForm));
            this.labelAlert = new System.Windows.Forms.Label();
            this.btnClock = new System.Windows.Forms.Button();
            this.btnKey = new System.Windows.Forms.Button();
            this.btnPc = new System.Windows.Forms.Button();
            this.btn_Go = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.bk4 = new System.Windows.Forms.Button();
            this.bk3 = new System.Windows.Forms.Button();
            this.bk2 = new System.Windows.Forms.Button();
            this.bk1 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb6 = new System.Windows.Forms.PictureBox();
            this.pb5 = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnContact = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pc = new System.Windows.Forms.PictureBox();
            this.txt_info = new System.Windows.Forms.TextBox();
            this.b9 = new System.Windows.Forms.PictureBox();
            this.b8 = new System.Windows.Forms.PictureBox();
            this.b7 = new System.Windows.Forms.PictureBox();
            this.b6 = new System.Windows.Forms.PictureBox();
            this.b5 = new System.Windows.Forms.PictureBox();
            this.b4 = new System.Windows.Forms.PictureBox();
            this.b3 = new System.Windows.Forms.PictureBox();
            this.b2 = new System.Windows.Forms.PictureBox();
            this.b1 = new System.Windows.Forms.PictureBox();
            this.b0 = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timerFloat = new System.Windows.Forms.Timer(this.components);
            this.timerSpace = new System.Windows.Forms.Timer(this.components);
            this.timerNext = new System.Windows.Forms.Timer(this.components);
            this.timerKey = new System.Windows.Forms.Timer(this.components);
            this.tKo = new System.Windows.Forms.Timer(this.components);
            this.timerCountdown = new System.Windows.Forms.Timer(this.components);
            this.timerInitialize = new System.Windows.Forms.Timer(this.components);
            this.timerOP = new System.Windows.Forms.Timer(this.components);
            this.selecter = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b0)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAlert
            // 
            this.labelAlert.AutoSize = true;
            this.labelAlert.BackColor = System.Drawing.Color.Transparent;
            this.labelAlert.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(197)))), ((int)(((byte)(0)))));
            this.labelAlert.Location = new System.Drawing.Point(354, 12);
            this.labelAlert.Name = "labelAlert";
            this.labelAlert.Size = new System.Drawing.Size(563, 29);
            this.labelAlert.TabIndex = 1;
            this.labelAlert.Text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            // 
            // btnClock
            // 
            this.btnClock.BackColor = System.Drawing.Color.Orange;
            this.btnClock.BackgroundImage = global::TimeTraveller.Properties.Resources.palien;
            this.btnClock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClock.Location = new System.Drawing.Point(105, 12);
            this.btnClock.Name = "btnClock";
            this.btnClock.Size = new System.Drawing.Size(25, 25);
            this.btnClock.TabIndex = 10;
            this.btnClock.UseVisualStyleBackColor = false;
            this.btnClock.Click += new System.EventHandler(this.btnClock_Click);
            this.btnClock.MouseEnter += new System.EventHandler(this.btnClock_MouseEnter);
            this.btnClock.MouseLeave += new System.EventHandler(this.btnClock_MouseLeave);
            // 
            // btnKey
            // 
            this.btnKey.BackColor = System.Drawing.Color.SpringGreen;
            this.btnKey.BackgroundImage = global::TimeTraveller.Properties.Resources.pkey;
            this.btnKey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnKey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKey.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKey.Location = new System.Drawing.Point(74, 12);
            this.btnKey.Name = "btnKey";
            this.btnKey.Size = new System.Drawing.Size(25, 25);
            this.btnKey.TabIndex = 9;
            this.btnKey.UseVisualStyleBackColor = false;
            this.btnKey.Click += new System.EventHandler(this.btnKey_Click);
            this.btnKey.MouseEnter += new System.EventHandler(this.btnKey_MouseEnter);
            this.btnKey.MouseLeave += new System.EventHandler(this.btnKey_MouseLeave);
            // 
            // btnPc
            // 
            this.btnPc.BackColor = System.Drawing.Color.DarkViolet;
            this.btnPc.BackgroundImage = global::TimeTraveller.Properties.Resources.pclock;
            this.btnPc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPc.Enabled = false;
            this.btnPc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPc.Location = new System.Drawing.Point(43, 12);
            this.btnPc.Name = "btnPc";
            this.btnPc.Size = new System.Drawing.Size(25, 25);
            this.btnPc.TabIndex = 8;
            this.btnPc.UseVisualStyleBackColor = false;
            this.btnPc.Click += new System.EventHandler(this.btnPc_Click);
            this.btnPc.MouseEnter += new System.EventHandler(this.btnPc_MouseEnter);
            this.btnPc.MouseLeave += new System.EventHandler(this.btnPc_MouseLeave);
            // 
            // btn_Go
            // 
            this.btn_Go.BackColor = System.Drawing.Color.Black;
            this.btn_Go.BackgroundImage = global::TimeTraveller.Properties.Resources.go;
            this.btn_Go.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Go.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Go.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Go.Location = new System.Drawing.Point(777, 508);
            this.btn_Go.Name = "btn_Go";
            this.btn_Go.Size = new System.Drawing.Size(165, 90);
            this.btn_Go.TabIndex = 154;
            this.btn_Go.UseVisualStyleBackColor = false;
            this.btn_Go.Click += new System.EventHandler(this.btn_Go_Click);
            this.btn_Go.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Go_MouseDown);
            this.btn_Go.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Go_MouseUp);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Location = new System.Drawing.Point(901, 657);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(27, 27);
            this.btnReset.TabIndex = 153;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtScore
            // 
            this.txtScore.BackColor = System.Drawing.Color.Black;
            this.txtScore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtScore.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtScore.ForeColor = System.Drawing.Color.White;
            this.txtScore.Location = new System.Drawing.Point(558, 422);
            this.txtScore.Name = "txtScore";
            this.txtScore.ReadOnly = true;
            this.txtScore.Size = new System.Drawing.Size(155, 13);
            this.txtScore.TabIndex = 152;
            this.txtScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(558, 445);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(155, 12);
            this.progressBar1.TabIndex = 151;
            // 
            // bk4
            // 
            this.bk4.BackColor = System.Drawing.Color.Transparent;
            this.bk4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bk4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bk4.Location = new System.Drawing.Point(429, 552);
            this.bk4.Name = "bk4";
            this.bk4.Size = new System.Drawing.Size(40, 40);
            this.bk4.TabIndex = 150;
            this.bk4.UseVisualStyleBackColor = false;
            this.bk4.Click += new System.EventHandler(this.bk4_Click);
            // 
            // bk3
            // 
            this.bk3.BackColor = System.Drawing.Color.Transparent;
            this.bk3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bk3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bk3.Location = new System.Drawing.Point(383, 552);
            this.bk3.Name = "bk3";
            this.bk3.Size = new System.Drawing.Size(40, 40);
            this.bk3.TabIndex = 149;
            this.bk3.UseVisualStyleBackColor = false;
            this.bk3.Click += new System.EventHandler(this.bk3_Click);
            // 
            // bk2
            // 
            this.bk2.BackColor = System.Drawing.Color.Transparent;
            this.bk2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bk2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bk2.Location = new System.Drawing.Point(429, 508);
            this.bk2.Name = "bk2";
            this.bk2.Size = new System.Drawing.Size(40, 40);
            this.bk2.TabIndex = 148;
            this.bk2.UseVisualStyleBackColor = false;
            this.bk2.Click += new System.EventHandler(this.bk2_Click);
            // 
            // bk1
            // 
            this.bk1.BackColor = System.Drawing.Color.Transparent;
            this.bk1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bk1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bk1.Location = new System.Drawing.Point(383, 508);
            this.bk1.Name = "bk1";
            this.bk1.Size = new System.Drawing.Size(40, 40);
            this.bk1.TabIndex = 147;
            this.bk1.UseVisualStyleBackColor = false;
            this.bk1.Click += new System.EventHandler(this.bk1_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.Black;
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar1.Enabled = false;
            this.trackBar1.Location = new System.Drawing.Point(332, 508);
            this.trackBar1.Maximum = 6;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 135);
            this.trackBar1.TabIndex = 146;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // txtLevel
            // 
            this.txtLevel.BackColor = System.Drawing.Color.Black;
            this.txtLevel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLevel.ForeColor = System.Drawing.Color.LightGray;
            this.txtLevel.Location = new System.Drawing.Point(304, 623);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.ReadOnly = true;
            this.txtLevel.Size = new System.Drawing.Size(25, 13);
            this.txtLevel.TabIndex = 0;
            this.txtLevel.TabStop = false;
            this.txtLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtQuestion
            // 
            this.txtQuestion.BackColor = System.Drawing.Color.Black;
            this.txtQuestion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuestion.ForeColor = System.Drawing.Color.LightGray;
            this.txtQuestion.Location = new System.Drawing.Point(530, 445);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.ReadOnly = true;
            this.txtQuestion.Size = new System.Drawing.Size(25, 13);
            this.txtQuestion.TabIndex = 0;
            this.txtQuestion.TabStop = false;
            this.txtQuestion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pb1
            // 
            this.pb1.BackColor = System.Drawing.Color.Transparent;
            this.pb1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb1.Image = ((System.Drawing.Image)(resources.GetObject("pb1.Image")));
            this.pb1.Location = new System.Drawing.Point(540, 558);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(40, 70);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb1.TabIndex = 140;
            this.pb1.TabStop = false;
            this.pb1.Click += new System.EventHandler(this.pb1_Click);
            this.pb1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb1_MouseDown);
            this.pb1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pb1_MouseUp);
            // 
            // pb2
            // 
            this.pb2.BackColor = System.Drawing.Color.Transparent;
            this.pb2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb2.Image = ((System.Drawing.Image)(resources.GetObject("pb2.Image")));
            this.pb2.Location = new System.Drawing.Point(586, 558);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(40, 70);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb2.TabIndex = 141;
            this.pb2.TabStop = false;
            this.pb2.Click += new System.EventHandler(this.pb2_Click);
            this.pb2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb2_MouseDown);
            this.pb2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pb2_MouseUp);
            // 
            // pb6
            // 
            this.pb6.Location = new System.Drawing.Point(632, 609);
            this.pb6.Name = "pb6";
            this.pb6.Size = new System.Drawing.Size(6, 6);
            this.pb6.TabIndex = 145;
            this.pb6.TabStop = false;
            // 
            // pb5
            // 
            this.pb5.Location = new System.Drawing.Point(632, 574);
            this.pb5.Name = "pb5";
            this.pb5.Size = new System.Drawing.Size(6, 6);
            this.pb5.TabIndex = 142;
            this.pb5.TabStop = false;
            // 
            // pb4
            // 
            this.pb4.BackColor = System.Drawing.Color.Transparent;
            this.pb4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb4.Image = ((System.Drawing.Image)(resources.GetObject("pb4.Image")));
            this.pb4.Location = new System.Drawing.Point(690, 558);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(40, 70);
            this.pb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb4.TabIndex = 144;
            this.pb4.TabStop = false;
            this.pb4.Click += new System.EventHandler(this.pb4_Click);
            this.pb4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb4_MouseDown);
            this.pb4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pb4_MouseUp);
            // 
            // pb3
            // 
            this.pb3.BackColor = System.Drawing.Color.Transparent;
            this.pb3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb3.Image = ((System.Drawing.Image)(resources.GetObject("pb3.Image")));
            this.pb3.Location = new System.Drawing.Point(644, 558);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(40, 70);
            this.pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb3.TabIndex = 143;
            this.pb3.TabStop = false;
            this.pb3.Click += new System.EventHandler(this.pb3_Click);
            this.pb3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb3_MouseDown);
            this.pb3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pb3_MouseUp);
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.YellowGreen;
            this.btnProfile.BackgroundImage = global::TimeTraveller.Properties.Resources.pprofile;
            this.btnProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProfile.Location = new System.Drawing.Point(198, 12);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(25, 25);
            this.btnProfile.TabIndex = 13;
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            this.btnProfile.MouseEnter += new System.EventHandler(this.btnProfile_MouseEnter);
            this.btnProfile.MouseLeave += new System.EventHandler(this.btnProfile_MouseLeave);
            // 
            // btnContact
            // 
            this.btnContact.BackColor = System.Drawing.Color.White;
            this.btnContact.BackgroundImage = global::TimeTraveller.Properties.Resources.pcontact;
            this.btnContact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnContact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContact.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnContact.Location = new System.Drawing.Point(167, 12);
            this.btnContact.Name = "btnContact";
            this.btnContact.Size = new System.Drawing.Size(25, 25);
            this.btnContact.TabIndex = 12;
            this.btnContact.UseVisualStyleBackColor = false;
            this.btnContact.Click += new System.EventHandler(this.btnContact_Click);
            this.btnContact.MouseEnter += new System.EventHandler(this.btnContact_MouseEnter);
            this.btnContact.MouseLeave += new System.EventHandler(this.btnContact_MouseLeave);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.SkyBlue;
            this.btnHelp.BackgroundImage = global::TimeTraveller.Properties.Resources.phelp;
            this.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHelp.Location = new System.Drawing.Point(136, 12);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(25, 25);
            this.btnHelp.TabIndex = 11;
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            this.btnHelp.MouseEnter += new System.EventHandler(this.btnHelp_MouseEnter);
            this.btnHelp.MouseLeave += new System.EventHandler(this.btnHelp_MouseLeave);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Maroon;
            this.btnClose.BackgroundImage = global::TimeTraveller.Properties.Resources.pclose;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Location = new System.Drawing.Point(12, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 7;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            // 
            // pc
            // 
            this.pc.BackColor = System.Drawing.Color.Transparent;
            this.pc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pc.Location = new System.Drawing.Point(485, 63);
            this.pc.Name = "pc";
            this.pc.Size = new System.Drawing.Size(300, 300);
            this.pc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pc.TabIndex = 0;
            this.pc.TabStop = false;
            // 
            // txt_info
            // 
            this.txt_info.BackColor = System.Drawing.Color.Black;
            this.txt_info.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_info.Location = new System.Drawing.Point(11, 658);
            this.txt_info.MaxLength = 1;
            this.txt_info.Name = "txt_info";
            this.txt_info.Size = new System.Drawing.Size(26, 13);
            this.txt_info.TabIndex = 157;
            this.txt_info.TabStop = false;
            this.txt_info.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // b9
            // 
            this.b9.BackColor = System.Drawing.Color.Transparent;
            this.b9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.b9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b9.Location = new System.Drawing.Point(883, 434);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(44, 44);
            this.b9.TabIndex = 167;
            this.b9.TabStop = false;
            this.b9.Visible = false;
            this.b9.Click += new System.EventHandler(this.b9_Click);
            // 
            // b8
            // 
            this.b8.BackColor = System.Drawing.Color.Transparent;
            this.b8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.b8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b8.Location = new System.Drawing.Point(823, 404);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(44, 44);
            this.b8.TabIndex = 166;
            this.b8.TabStop = false;
            this.b8.Visible = false;
            this.b8.Click += new System.EventHandler(this.b8_Click);
            // 
            // b7
            // 
            this.b7.BackColor = System.Drawing.Color.Transparent;
            this.b7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.b7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b7.Location = new System.Drawing.Point(763, 389);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(44, 44);
            this.b7.TabIndex = 165;
            this.b7.TabStop = false;
            this.b7.Visible = false;
            this.b7.Click += new System.EventHandler(this.b7_Click);
            // 
            // b6
            // 
            this.b6.BackColor = System.Drawing.Color.Transparent;
            this.b6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.b6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b6.Location = new System.Drawing.Point(703, 379);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(44, 44);
            this.b6.TabIndex = 164;
            this.b6.TabStop = false;
            this.b6.Visible = false;
            this.b6.Click += new System.EventHandler(this.b6_Click);
            // 
            // b5
            // 
            this.b5.BackColor = System.Drawing.Color.Transparent;
            this.b5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.b5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b5.Location = new System.Drawing.Point(643, 374);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(44, 44);
            this.b5.TabIndex = 163;
            this.b5.TabStop = false;
            this.b5.Visible = false;
            this.b5.Click += new System.EventHandler(this.b5_Click);
            // 
            // b4
            // 
            this.b4.BackColor = System.Drawing.Color.Transparent;
            this.b4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.b4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b4.Location = new System.Drawing.Point(583, 374);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(44, 44);
            this.b4.TabIndex = 162;
            this.b4.TabStop = false;
            this.b4.Visible = false;
            this.b4.Click += new System.EventHandler(this.b4_Click);
            // 
            // b3
            // 
            this.b3.BackColor = System.Drawing.Color.Transparent;
            this.b3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.b3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b3.Location = new System.Drawing.Point(523, 379);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(44, 44);
            this.b3.TabIndex = 161;
            this.b3.TabStop = false;
            this.b3.Visible = false;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // b2
            // 
            this.b2.BackColor = System.Drawing.Color.Transparent;
            this.b2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.b2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b2.Location = new System.Drawing.Point(463, 389);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(44, 44);
            this.b2.TabIndex = 160;
            this.b2.TabStop = false;
            this.b2.Visible = false;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.Color.Transparent;
            this.b1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.b1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b1.Location = new System.Drawing.Point(403, 404);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(44, 44);
            this.b1.TabIndex = 159;
            this.b1.TabStop = false;
            this.b1.Visible = false;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // b0
            // 
            this.b0.BackColor = System.Drawing.Color.Transparent;
            this.b0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.b0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b0.Location = new System.Drawing.Point(343, 434);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(44, 44);
            this.b0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.b0.TabIndex = 158;
            this.b0.TabStop = false;
            this.b0.Visible = false;
            this.b0.Click += new System.EventHandler(this.b0_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timerFloat
            // 
            this.timerFloat.Interval = 250;
            this.timerFloat.Tick += new System.EventHandler(this.timerFloat_Tick);
            // 
            // timerSpace
            // 
            this.timerSpace.Interval = 1;
            this.timerSpace.Tick += new System.EventHandler(this.timerSpace_Tick);
            // 
            // timerNext
            // 
            this.timerNext.Interval = 2000;
            this.timerNext.Tick += new System.EventHandler(this.timerNext_Tick);
            // 
            // timerKey
            // 
            this.timerKey.Interval = 1000;
            this.timerKey.Tick += new System.EventHandler(this.timerKey_Tick);
            // 
            // tKo
            // 
            this.tKo.Interval = 800;
            this.tKo.Tick += new System.EventHandler(this.tKo_Tick);
            // 
            // timerCountdown
            // 
            this.timerCountdown.Interval = 1000;
            this.timerCountdown.Tick += new System.EventHandler(this.timerCountdown_Tick);
            // 
            // timerInitialize
            // 
            this.timerInitialize.Interval = 4000;
            this.timerInitialize.Tick += new System.EventHandler(this.timerInitialize_Tick);
            // 
            // timerOP
            // 
            this.timerOP.Interval = 10;
            this.timerOP.Tick += new System.EventHandler(this.timerOP_Tick);
            // 
            // selecter
            // 
            this.selecter.Interval = 200;
            this.selecter.Tick += new System.EventHandler(this.selecter_Tick);
            // 
            // OperationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TimeTraveller.Properties.Resources.ttb0;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1270, 700);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.txt_info);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.txtLevel);
            this.Controls.Add(this.btn_Go);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.bk4);
            this.Controls.Add(this.bk3);
            this.Controls.Add(this.bk2);
            this.Controls.Add(this.bk1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb6);
            this.Controls.Add(this.pb5);
            this.Controls.Add(this.pb4);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.btnContact);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnClock);
            this.Controls.Add(this.btnKey);
            this.Controls.Add(this.btnPc);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.labelAlert);
            this.Controls.Add(this.pc);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OperationsForm";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.OperationsForm_Load);
            this.Click += new System.EventHandler(this.OperationsForm_Click);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b0)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pc;
        private System.Windows.Forms.Label labelAlert;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnContact;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnClock;
        private System.Windows.Forms.Button btnKey;
        public System.Windows.Forms.Button btnPc;
        private System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.Button btn_Go;
        public System.Windows.Forms.Button btnReset;
        public System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button bk4;
        private System.Windows.Forms.Button bk3;
        private System.Windows.Forms.Button bk2;
        private System.Windows.Forms.Button bk1;
        public System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb6;
        private System.Windows.Forms.PictureBox pb5;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.TextBox txt_info;
        private System.Windows.Forms.PictureBox b9;
        private System.Windows.Forms.PictureBox b8;
        private System.Windows.Forms.PictureBox b7;
        private System.Windows.Forms.PictureBox b6;
        private System.Windows.Forms.PictureBox b5;
        private System.Windows.Forms.PictureBox b4;
        private System.Windows.Forms.PictureBox b3;
        private System.Windows.Forms.PictureBox b2;
        private System.Windows.Forms.PictureBox b1;
        private System.Windows.Forms.PictureBox b0;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timerFloat;
        private System.Windows.Forms.Timer timerSpace;
        private System.Windows.Forms.Timer timerNext;
        private System.Windows.Forms.Timer timerKey;
        private System.Windows.Forms.Timer tKo;
        private System.Windows.Forms.Timer timerCountdown;
        private System.Windows.Forms.Timer timerInitialize;
        private System.Windows.Forms.Timer timerOP;
        public System.Windows.Forms.TextBox txtLevel;
        private System.Windows.Forms.Timer selecter;
    }
}