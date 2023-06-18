namespace Hacker
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.picBoxFace = new System.Windows.Forms.PictureBox();
            this.txtMood = new System.Windows.Forms.TextBox();
            this.txtLoan = new System.Windows.Forms.TextBox();
            this.menuPanel = new System.Windows.Forms.MenuStrip();
            this.toolStripMusic = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDisconnect = new System.Windows.Forms.ToolStripMenuItem();
            this.lblMood = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.lblPenkovv = new System.Windows.Forms.Label();
            this.lblOmega = new System.Windows.Forms.Label();
            this.lblTrata = new System.Windows.Forms.Label();
            this.lblZakritie = new System.Windows.Forms.Label();
            this.lblRosKolhoz = new System.Windows.Forms.Label();
            this.txtPC = new System.Windows.Forms.TextBox();
            this.txtSoft = new System.Windows.Forms.TextBox();
            this.pictureBoxPC = new System.Windows.Forms.PictureBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblBody = new System.Windows.Forms.Label();
            this.lblDisk = new System.Windows.Forms.Label();
            this.lblGPU = new System.Windows.Forms.Label();
            this.lblRAM = new System.Windows.Forms.Label();
            this.lblCPU = new System.Windows.Forms.Label();
            this.lblMother = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblOS = new System.Windows.Forms.Label();
            this.lblPL = new System.Windows.Forms.Label();
            this.btnOpenShop = new System.Windows.Forms.Button();
            this.btnOpenSoft = new System.Windows.Forms.Button();
            this.btnOpenHack = new System.Windows.Forms.Button();
            this.btnOpenMining = new System.Windows.Forms.Button();
            this.btnOpenWork = new System.Windows.Forms.Button();
            this.btnOpenFun = new System.Windows.Forms.Button();
            this.btnOpenLoan = new System.Windows.Forms.Button();
            this.lblWork = new System.Windows.Forms.Label();
            this.statusStripMenu = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelMenu = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusMenu = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnConvertCoins = new System.Windows.Forms.Button();
            this.lblCrypto = new System.Windows.Forms.Label();
            this.lblAntivirus = new System.Windows.Forms.Label();
            this.lblBestDino = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFace)).BeginInit();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPC)).BeginInit();
            this.statusStripMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBoxFace
            // 
            this.picBoxFace.BackColor = System.Drawing.Color.Transparent;
            this.picBoxFace.Image = global::Hacker.Properties.Resources.NormalFace;
            this.picBoxFace.Location = new System.Drawing.Point(15, 38);
            this.picBoxFace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBoxFace.Name = "picBoxFace";
            this.picBoxFace.Size = new System.Drawing.Size(413, 369);
            this.picBoxFace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxFace.TabIndex = 0;
            this.picBoxFace.TabStop = false;
            this.picBoxFace.MouseLeave += new System.EventHandler(this.picBoxFace_MouseLeave);
            this.picBoxFace.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picBoxFace_MouseMove);
            // 
            // txtMood
            // 
            this.txtMood.BackColor = System.Drawing.SystemColors.Control;
            this.txtMood.Cursor = System.Windows.Forms.Cursors.No;
            this.txtMood.Enabled = false;
            this.txtMood.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtMood.Location = new System.Drawing.Point(15, 412);
            this.txtMood.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMood.Multiline = true;
            this.txtMood.Name = "txtMood";
            this.txtMood.ReadOnly = true;
            this.txtMood.ShortcutsEnabled = false;
            this.txtMood.Size = new System.Drawing.Size(412, 208);
            this.txtMood.TabIndex = 1;
            this.txtMood.TabStop = false;
            this.txtMood.Text = "  Состояние на сегодня:\r\nНастроение:\r\nБюджет:\r\n\r\n\r\nСтатус:\r\nСчёт:";
            // 
            // txtLoan
            // 
            this.txtLoan.Cursor = System.Windows.Forms.Cursors.No;
            this.txtLoan.Enabled = false;
            this.txtLoan.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLoan.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtLoan.Location = new System.Drawing.Point(15, 628);
            this.txtLoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLoan.Multiline = true;
            this.txtLoan.Name = "txtLoan";
            this.txtLoan.ReadOnly = true;
            this.txtLoan.ShortcutsEnabled = false;
            this.txtLoan.Size = new System.Drawing.Size(412, 184);
            this.txtLoan.TabIndex = 2;
            this.txtLoan.Text = "         Кредиты:\r\nПеньковв: \r\nОмегаБанк:\r\nТратаБанк:\r\nБанкЗакрытие:\r\nРосКолхозБа" +
    "нк:";
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuPanel.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuPanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMusic,
            this.toolStripDisconnect});
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuPanel.Size = new System.Drawing.Size(1466, 31);
            this.menuPanel.TabIndex = 3;
            this.menuPanel.Text = "menuStrip1";
            // 
            // toolStripMusic
            // 
            this.toolStripMusic.Checked = true;
            this.toolStripMusic.CheckOnClick = true;
            this.toolStripMusic.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMusic.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripMusic.Image = global::Hacker.Properties.Resources.sound;
            this.toolStripMusic.Name = "toolStripMusic";
            this.toolStripMusic.Size = new System.Drawing.Size(124, 27);
            this.toolStripMusic.Text = "Музыка";
            this.toolStripMusic.Click += new System.EventHandler(this.toolStripMusic_Click);
            this.toolStripMusic.MouseLeave += new System.EventHandler(this.toolStripMusic_MouseLeave);
            this.toolStripMusic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.toolStripMusic_MouseMove);
            // 
            // toolStripDisconnect
            // 
            this.toolStripDisconnect.Name = "toolStripDisconnect";
            this.toolStripDisconnect.Size = new System.Drawing.Size(14, 27);
            // 
            // lblMood
            // 
            this.lblMood.AutoSize = true;
            this.lblMood.BackColor = System.Drawing.SystemColors.Control;
            this.lblMood.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMood.Location = new System.Drawing.Point(201, 447);
            this.lblMood.Name = "lblMood";
            this.lblMood.Size = new System.Drawing.Size(144, 23);
            this.lblMood.TabIndex = 4;
            this.lblMood.Text = "Нормальное";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.SystemColors.Control;
            this.lblStatus.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStatus.Location = new System.Drawing.Point(129, 561);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(90, 23);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Чайник";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.SystemColors.Control;
            this.lblScore.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblScore.Location = new System.Drawing.Point(101, 590);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(24, 23);
            this.lblScore.TabIndex = 9;
            this.lblScore.Text = "0";
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.BackColor = System.Drawing.SystemColors.Control;
            this.lblMoney.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMoney.Location = new System.Drawing.Point(144, 476);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(66, 23);
            this.lblMoney.TabIndex = 10;
            this.lblMoney.Text = "100$";
            // 
            // lblPenkovv
            // 
            this.lblPenkovv.AutoSize = true;
            this.lblPenkovv.BackColor = System.Drawing.SystemColors.Control;
            this.lblPenkovv.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPenkovv.Location = new System.Drawing.Point(167, 662);
            this.lblPenkovv.Name = "lblPenkovv";
            this.lblPenkovv.Size = new System.Drawing.Size(141, 23);
            this.lblPenkovv.TabIndex = 11;
            this.lblPenkovv.Text = "Отсутствует";
            // 
            // lblOmega
            // 
            this.lblOmega.AutoSize = true;
            this.lblOmega.BackColor = System.Drawing.SystemColors.Control;
            this.lblOmega.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOmega.Location = new System.Drawing.Point(189, 692);
            this.lblOmega.Name = "lblOmega";
            this.lblOmega.Size = new System.Drawing.Size(141, 23);
            this.lblOmega.TabIndex = 12;
            this.lblOmega.Text = "Отсутствует";
            // 
            // lblTrata
            // 
            this.lblTrata.AutoSize = true;
            this.lblTrata.BackColor = System.Drawing.SystemColors.Control;
            this.lblTrata.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTrata.Location = new System.Drawing.Point(183, 720);
            this.lblTrata.Name = "lblTrata";
            this.lblTrata.Size = new System.Drawing.Size(141, 23);
            this.lblTrata.TabIndex = 13;
            this.lblTrata.Text = "Отсутствует";
            // 
            // lblZakritie
            // 
            this.lblZakritie.AutoSize = true;
            this.lblZakritie.BackColor = System.Drawing.SystemColors.Control;
            this.lblZakritie.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblZakritie.Location = new System.Drawing.Point(232, 747);
            this.lblZakritie.Name = "lblZakritie";
            this.lblZakritie.Size = new System.Drawing.Size(141, 23);
            this.lblZakritie.TabIndex = 14;
            this.lblZakritie.Text = "Отсутствует\r\n";
            // 
            // lblRosKolhoz
            // 
            this.lblRosKolhoz.AutoSize = true;
            this.lblRosKolhoz.BackColor = System.Drawing.SystemColors.Control;
            this.lblRosKolhoz.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRosKolhoz.Location = new System.Drawing.Point(248, 775);
            this.lblRosKolhoz.Name = "lblRosKolhoz";
            this.lblRosKolhoz.Size = new System.Drawing.Size(141, 23);
            this.lblRosKolhoz.TabIndex = 15;
            this.lblRosKolhoz.Text = "Отсутствует\r\n";
            // 
            // txtPC
            // 
            this.txtPC.Cursor = System.Windows.Forms.Cursors.No;
            this.txtPC.Enabled = false;
            this.txtPC.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPC.Location = new System.Drawing.Point(1005, 431);
            this.txtPC.Margin = new System.Windows.Forms.Padding(4);
            this.txtPC.Multiline = true;
            this.txtPC.Name = "txtPC";
            this.txtPC.ReadOnly = true;
            this.txtPC.Size = new System.Drawing.Size(448, 212);
            this.txtPC.TabIndex = 16;
            this.txtPC.Text = "   Твой компьютер:\r\nКорпус:\r\nМатеринка:\r\nПроц:\r\nОперативка:\r\nВидюха:\r\nДиск:";
            // 
            // txtSoft
            // 
            this.txtSoft.Cursor = System.Windows.Forms.Cursors.No;
            this.txtSoft.Enabled = false;
            this.txtSoft.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSoft.Location = new System.Drawing.Point(1005, 651);
            this.txtSoft.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoft.Multiline = true;
            this.txtSoft.Name = "txtSoft";
            this.txtSoft.ReadOnly = true;
            this.txtSoft.Size = new System.Drawing.Size(448, 184);
            this.txtSoft.TabIndex = 17;
            this.txtSoft.Text = "         Софт и прочее:\r\nСистема:\r\nЯзык:\r\nАнтивирус:\r\n\r\nЛучший счёт в дино:";
            // 
            // pictureBoxPC
            // 
            this.pictureBoxPC.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPC.Location = new System.Drawing.Point(1005, 38);
            this.pictureBoxPC.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxPC.Name = "pictureBoxPC";
            this.pictureBoxPC.Size = new System.Drawing.Size(448, 387);
            this.pictureBoxPC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPC.TabIndex = 18;
            this.pictureBoxPC.TabStop = false;
            this.pictureBoxPC.MouseLeave += new System.EventHandler(this.pictureBoxPC_MouseLeave);
            this.pictureBoxPC.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxPC_MouseMove);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.SystemColors.Control;
            this.lblTime.Font = new System.Drawing.Font("Lucida Sans Unicode", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTime.Location = new System.Drawing.Point(453, 92);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(488, 37);
            this.lblTime.TabIndex = 21;
            this.lblTime.Text = "Время 23:00 Дата 31.12.2022\r\n";
            // 
            // lblBody
            // 
            this.lblBody.AutoSize = true;
            this.lblBody.BackColor = System.Drawing.SystemColors.Control;
            this.lblBody.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBody.Location = new System.Drawing.Point(1119, 463);
            this.lblBody.Name = "lblBody";
            this.lblBody.Size = new System.Drawing.Size(141, 23);
            this.lblBody.TabIndex = 22;
            this.lblBody.Text = "Отсутствует";
            // 
            // lblDisk
            // 
            this.lblDisk.AutoSize = true;
            this.lblDisk.BackColor = System.Drawing.SystemColors.Control;
            this.lblDisk.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDisk.Location = new System.Drawing.Point(1093, 609);
            this.lblDisk.Name = "lblDisk";
            this.lblDisk.Size = new System.Drawing.Size(141, 23);
            this.lblDisk.TabIndex = 23;
            this.lblDisk.Text = "Отсутствует";
            // 
            // lblGPU
            // 
            this.lblGPU.AutoSize = true;
            this.lblGPU.BackColor = System.Drawing.SystemColors.Control;
            this.lblGPU.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGPU.Location = new System.Drawing.Point(1130, 575);
            this.lblGPU.Name = "lblGPU";
            this.lblGPU.Size = new System.Drawing.Size(141, 23);
            this.lblGPU.TabIndex = 24;
            this.lblGPU.Text = "Отсутствует";
            // 
            // lblRAM
            // 
            this.lblRAM.AutoSize = true;
            this.lblRAM.BackColor = System.Drawing.SystemColors.Control;
            this.lblRAM.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRAM.Location = new System.Drawing.Point(1181, 549);
            this.lblRAM.Name = "lblRAM";
            this.lblRAM.Size = new System.Drawing.Size(141, 23);
            this.lblRAM.TabIndex = 25;
            this.lblRAM.Text = "Отсутствует";
            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.BackColor = System.Drawing.SystemColors.Control;
            this.lblCPU.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCPU.Location = new System.Drawing.Point(1093, 523);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(141, 23);
            this.lblCPU.TabIndex = 26;
            this.lblCPU.Text = "Отсутствует";
            // 
            // lblMother
            // 
            this.lblMother.AutoSize = true;
            this.lblMother.BackColor = System.Drawing.SystemColors.Control;
            this.lblMother.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMother.Location = new System.Drawing.Point(1173, 500);
            this.lblMother.Name = "lblMother";
            this.lblMother.Size = new System.Drawing.Size(141, 23);
            this.lblMother.TabIndex = 27;
            this.lblMother.Text = "Отсутствует";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(432, 159);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(563, 94);
            this.textBox1.TabIndex = 29;
            this.textBox1.Text = "Работа:\r\n\r\nКрипта:";
            // 
            // lblOS
            // 
            this.lblOS.AutoSize = true;
            this.lblOS.BackColor = System.Drawing.SystemColors.Control;
            this.lblOS.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOS.Location = new System.Drawing.Point(1130, 688);
            this.lblOS.Name = "lblOS";
            this.lblOS.Size = new System.Drawing.Size(141, 23);
            this.lblOS.TabIndex = 31;
            this.lblOS.Text = "Отсутствует";
            // 
            // lblPL
            // 
            this.lblPL.AutoSize = true;
            this.lblPL.BackColor = System.Drawing.SystemColors.Control;
            this.lblPL.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPL.Location = new System.Drawing.Point(1093, 711);
            this.lblPL.Name = "lblPL";
            this.lblPL.Size = new System.Drawing.Size(141, 23);
            this.lblPL.TabIndex = 32;
            this.lblPL.Text = "Отсутствует";
            // 
            // btnOpenShop
            // 
            this.btnOpenShop.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOpenShop.Location = new System.Drawing.Point(731, 412);
            this.btnOpenShop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOpenShop.Name = "btnOpenShop";
            this.btnOpenShop.Size = new System.Drawing.Size(267, 74);
            this.btnOpenShop.TabIndex = 2;
            this.btnOpenShop.Text = "Магаз";
            this.btnOpenShop.UseVisualStyleBackColor = true;
            this.btnOpenShop.Click += new System.EventHandler(this.btnOpenShop_Click);
            // 
            // btnOpenSoft
            // 
            this.btnOpenSoft.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOpenSoft.Location = new System.Drawing.Point(731, 738);
            this.btnOpenSoft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOpenSoft.Name = "btnOpenSoft";
            this.btnOpenSoft.Size = new System.Drawing.Size(267, 74);
            this.btnOpenSoft.TabIndex = 3;
            this.btnOpenSoft.Text = "Установка софта";
            this.btnOpenSoft.UseVisualStyleBackColor = true;
            this.btnOpenSoft.Click += new System.EventHandler(this.btnOpenSoft_Click);
            // 
            // btnOpenHack
            // 
            this.btnOpenHack.Enabled = false;
            this.btnOpenHack.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOpenHack.Location = new System.Drawing.Point(731, 628);
            this.btnOpenHack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOpenHack.Name = "btnOpenHack";
            this.btnOpenHack.Size = new System.Drawing.Size(267, 74);
            this.btnOpenHack.TabIndex = 35;
            this.btnOpenHack.Text = "Хакерство";
            this.btnOpenHack.UseVisualStyleBackColor = true;
            this.btnOpenHack.Click += new System.EventHandler(this.btnOpenHack_Click);
            this.btnOpenHack.MouseLeave += new System.EventHandler(this.btnOpenHack_MouseLeave);
            this.btnOpenHack.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnOpenHack_MouseMove);
            // 
            // btnOpenMining
            // 
            this.btnOpenMining.Enabled = false;
            this.btnOpenMining.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOpenMining.Location = new System.Drawing.Point(731, 549);
            this.btnOpenMining.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOpenMining.Name = "btnOpenMining";
            this.btnOpenMining.Size = new System.Drawing.Size(267, 74);
            this.btnOpenMining.TabIndex = 36;
            this.btnOpenMining.Text = "Майнинг крипты";
            this.btnOpenMining.UseVisualStyleBackColor = true;
            this.btnOpenMining.Click += new System.EventHandler(this.btnOpenMining_Click);
            this.btnOpenMining.MouseLeave += new System.EventHandler(this.btnOpenMining_MouseLeave);
            this.btnOpenMining.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnOpenMining_MouseMove);
            // 
            // btnOpenWork
            // 
            this.btnOpenWork.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOpenWork.Location = new System.Drawing.Point(432, 258);
            this.btnOpenWork.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOpenWork.Name = "btnOpenWork";
            this.btnOpenWork.Size = new System.Drawing.Size(267, 74);
            this.btnOpenWork.TabIndex = 1;
            this.btnOpenWork.Text = "Работа";
            this.btnOpenWork.UseVisualStyleBackColor = true;
            this.btnOpenWork.Click += new System.EventHandler(this.btnOpenWork_Click);
            // 
            // btnOpenFun
            // 
            this.btnOpenFun.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOpenFun.Location = new System.Drawing.Point(432, 486);
            this.btnOpenFun.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOpenFun.Name = "btnOpenFun";
            this.btnOpenFun.Size = new System.Drawing.Size(267, 74);
            this.btnOpenFun.TabIndex = 6;
            this.btnOpenFun.Text = "Развлекуха";
            this.btnOpenFun.UseVisualStyleBackColor = true;
            this.btnOpenFun.Click += new System.EventHandler(this.btnOpenFun_Click);
            // 
            // btnOpenLoan
            // 
            this.btnOpenLoan.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOpenLoan.Location = new System.Drawing.Point(433, 671);
            this.btnOpenLoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOpenLoan.Name = "btnOpenLoan";
            this.btnOpenLoan.Size = new System.Drawing.Size(267, 74);
            this.btnOpenLoan.TabIndex = 39;
            this.btnOpenLoan.Text = "Кредиты";
            this.btnOpenLoan.UseVisualStyleBackColor = true;
            this.btnOpenLoan.Click += new System.EventHandler(this.btnOpenLoan_Click);
            // 
            // lblWork
            // 
            this.lblWork.AutoSize = true;
            this.lblWork.BackColor = System.Drawing.SystemColors.Control;
            this.lblWork.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWork.Location = new System.Drawing.Point(560, 165);
            this.lblWork.Name = "lblWork";
            this.lblWork.Size = new System.Drawing.Size(256, 23);
            this.lblWork.TabIndex = 40;
            this.lblWork.Text = "Безработный. 0$/день";
            // 
            // statusStripMenu
            // 
            this.statusStripMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelMenu,
            this.toolStripStatusMenu});
            this.statusStripMenu.Location = new System.Drawing.Point(0, 844);
            this.statusStripMenu.Name = "statusStripMenu";
            this.statusStripMenu.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStripMenu.Size = new System.Drawing.Size(1466, 22);
            this.statusStripMenu.TabIndex = 42;
            this.statusStripMenu.Text = "вывод";
            // 
            // toolStripStatusLabelMenu
            // 
            this.toolStripStatusLabelMenu.Name = "toolStripStatusLabelMenu";
            this.toolStripStatusLabelMenu.Size = new System.Drawing.Size(0, 16);
            // 
            // toolStripStatusMenu
            // 
            this.toolStripStatusMenu.Name = "toolStripStatusMenu";
            this.toolStripStatusMenu.Size = new System.Drawing.Size(0, 16);
            // 
            // btnConvertCoins
            // 
            this.btnConvertCoins.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnConvertCoins.Location = new System.Drawing.Point(731, 258);
            this.btnConvertCoins.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConvertCoins.Name = "btnConvertCoins";
            this.btnConvertCoins.Size = new System.Drawing.Size(267, 74);
            this.btnConvertCoins.TabIndex = 43;
            this.btnConvertCoins.Text = "Перевести крипту\r\n";
            this.btnConvertCoins.UseVisualStyleBackColor = true;
            this.btnConvertCoins.Click += new System.EventHandler(this.btnConvertCoins_Click);
            // 
            // lblCrypto
            // 
            this.lblCrypto.AutoSize = true;
            this.lblCrypto.BackColor = System.Drawing.SystemColors.Control;
            this.lblCrypto.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCrypto.Location = new System.Drawing.Point(560, 222);
            this.lblCrypto.Name = "lblCrypto";
            this.lblCrypto.Size = new System.Drawing.Size(387, 23);
            this.lblCrypto.TabIndex = 44;
            this.lblCrypto.Text = "HackerCoin: 0  Kefirium: 0  Bitok: 0";
            // 
            // lblAntivirus
            // 
            this.lblAntivirus.AutoSize = true;
            this.lblAntivirus.BackColor = System.Drawing.SystemColors.Control;
            this.lblAntivirus.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAntivirus.Location = new System.Drawing.Point(1161, 738);
            this.lblAntivirus.Name = "lblAntivirus";
            this.lblAntivirus.Size = new System.Drawing.Size(141, 23);
            this.lblAntivirus.TabIndex = 45;
            this.lblAntivirus.Text = "Отсутствует";
            // 
            // lblBestDino
            // 
            this.lblBestDino.AutoSize = true;
            this.lblBestDino.BackColor = System.Drawing.SystemColors.Control;
            this.lblBestDino.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBestDino.Location = new System.Drawing.Point(1290, 801);
            this.lblBestDino.Name = "lblBestDino";
            this.lblBestDino.Size = new System.Drawing.Size(24, 23);
            this.lblBestDino.TabIndex = 46;
            this.lblBestDino.Text = "0";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1466, 866);
            this.Controls.Add(this.lblBestDino);
            this.Controls.Add(this.lblAntivirus);
            this.Controls.Add(this.lblCrypto);
            this.Controls.Add(this.btnConvertCoins);
            this.Controls.Add(this.statusStripMenu);
            this.Controls.Add(this.lblWork);
            this.Controls.Add(this.btnOpenLoan);
            this.Controls.Add(this.btnOpenFun);
            this.Controls.Add(this.btnOpenWork);
            this.Controls.Add(this.btnOpenMining);
            this.Controls.Add(this.btnOpenHack);
            this.Controls.Add(this.btnOpenSoft);
            this.Controls.Add(this.btnOpenShop);
            this.Controls.Add(this.lblPL);
            this.Controls.Add(this.lblOS);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblMother);
            this.Controls.Add(this.lblCPU);
            this.Controls.Add(this.lblRAM);
            this.Controls.Add(this.lblGPU);
            this.Controls.Add(this.lblDisk);
            this.Controls.Add(this.lblBody);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.pictureBoxPC);
            this.Controls.Add(this.txtSoft);
            this.Controls.Add(this.txtPC);
            this.Controls.Add(this.lblRosKolhoz);
            this.Controls.Add(this.lblZakritie);
            this.Controls.Add(this.lblTrata);
            this.Controls.Add(this.lblOmega);
            this.Controls.Add(this.lblPenkovv);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblMood);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.txtLoan);
            this.Controls.Add(this.txtMood);
            this.Controls.Add(this.picBoxFace);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Хакер";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Game_Closed);
            this.Load += new System.EventHandler(this.Game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFace)).EndInit();
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPC)).EndInit();
            this.statusStripMenu.ResumeLayout(false);
            this.statusStripMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxFace;
        private System.Windows.Forms.TextBox txtMood;
        private System.Windows.Forms.TextBox txtLoan;
        private System.Windows.Forms.MenuStrip menuPanel;
        private System.Windows.Forms.ToolStripMenuItem toolStripMusic;
        private System.Windows.Forms.Label lblMood;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label lblPenkovv;
        private System.Windows.Forms.Label lblOmega;
        private System.Windows.Forms.Label lblTrata;
        private System.Windows.Forms.Label lblZakritie;
        private System.Windows.Forms.Label lblRosKolhoz;
        private System.Windows.Forms.TextBox txtPC;
        private System.Windows.Forms.TextBox txtSoft;
        private System.Windows.Forms.PictureBox pictureBoxPC;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblBody;
        private System.Windows.Forms.Label lblDisk;
        private System.Windows.Forms.Label lblGPU;
        private System.Windows.Forms.Label lblRAM;
        private System.Windows.Forms.Label lblCPU;
        private System.Windows.Forms.Label lblMother;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem toolStripDisconnect;
        private System.Windows.Forms.Label lblOS;
        private System.Windows.Forms.Label lblPL;
        private System.Windows.Forms.Button btnOpenShop;
        private System.Windows.Forms.Button btnOpenSoft;
        private System.Windows.Forms.Button btnOpenHack;
        private System.Windows.Forms.Button btnOpenMining;
        private System.Windows.Forms.Button btnOpenWork;
        private System.Windows.Forms.Button btnOpenFun;
        private System.Windows.Forms.Button btnOpenLoan;
        private System.Windows.Forms.Label lblWork;
        private System.Windows.Forms.StatusStrip statusStripMenu;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelMenu;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusMenu;
        private System.Windows.Forms.Button btnConvertCoins;
        private System.Windows.Forms.Label lblCrypto;
        private System.Windows.Forms.Label lblAntivirus;
        private System.Windows.Forms.Label lblBestDino;
    }
}