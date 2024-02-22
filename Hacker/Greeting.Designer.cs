namespace Hacker
{
    partial class Greeting
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Greeting));
            this.menuPanel = new System.Windows.Forms.MenuStrip();
            this.toolStripMusic = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDescription = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblEnterUrName = new System.Windows.Forms.Label();
            this.txtNickName = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.statusStripMenu = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelMenu = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusMenu = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStripMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuPanel.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuPanel.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuPanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMusic,
            this.toolStripHelp});
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuPanel.Size = new System.Drawing.Size(605, 28);
            this.menuPanel.TabIndex = 1;
            this.menuPanel.Text = "menuStrip1";
            // 
            // toolStripMusic
            // 
            this.toolStripMusic.Checked = true;
            this.toolStripMusic.CheckOnClick = true;
            this.toolStripMusic.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMusic.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripMusic.Name = "toolStripMusic";
            this.toolStripMusic.Size = new System.Drawing.Size(87, 24);
            this.toolStripMusic.Text = "Музыка";
            this.toolStripMusic.Click += new System.EventHandler(this.toolStripMusic_Click);
            // 
            // toolStripHelp
            // 
            this.toolStripHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDescription,
            this.toolStripAbout});
            this.toolStripHelp.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripHelp.Name = "toolStripHelp";
            this.toolStripHelp.Size = new System.Drawing.Size(94, 24);
            this.toolStripHelp.Text = "Справка";
            this.toolStripHelp.MouseLeave += new System.EventHandler(this.toolStripHelp_MouseLeave);
            this.toolStripHelp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.toolStripHelp_MouseMove);
            // 
            // toolStripDescription
            // 
            this.toolStripDescription.Name = "toolStripDescription";
            this.toolStripDescription.Size = new System.Drawing.Size(197, 24);
            this.toolStripDescription.Text = "Описание";
            this.toolStripDescription.Click += new System.EventHandler(this.toolStripDescription_Click);
            // 
            // toolStripAbout
            // 
            this.toolStripAbout.Name = "toolStripAbout";
            this.toolStripAbout.Size = new System.Drawing.Size(197, 24);
            this.toolStripAbout.Text = "О программе";
            this.toolStripAbout.Click += new System.EventHandler(this.toolStripAbout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 29);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(605, 360);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblEnterUrName
            // 
            this.lblEnterUrName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEnterUrName.AutoSize = true;
            this.lblEnterUrName.BackColor = System.Drawing.Color.Black;
            this.lblEnterUrName.Font = new System.Drawing.Font("Lucida Sans Unicode", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEnterUrName.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.lblEnterUrName.Location = new System.Drawing.Point(9, 183);
            this.lblEnterUrName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEnterUrName.Name = "lblEnterUrName";
            this.lblEnterUrName.Size = new System.Drawing.Size(304, 37);
            this.lblEnterUrName.TabIndex = 3;
            this.lblEnterUrName.Text = "Введите свой ник:";
            // 
            // txtNickName
            // 
            this.txtNickName.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.txtNickName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNickName.Font = new System.Drawing.Font("Ink Free", 19.8F, System.Drawing.FontStyle.Bold);
            this.txtNickName.Location = new System.Drawing.Point(317, 187);
            this.txtNickName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNickName.MaxLength = 16;
            this.txtNickName.Name = "txtNickName";
            this.txtNickName.Size = new System.Drawing.Size(253, 33);
            this.txtNickName.TabIndex = 4;
            this.txtNickName.UseSystemPasswordChar = true;
            this.txtNickName.TextChanged += new System.EventHandler(this.txtNickName_TextChanged);
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnEnter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEnter.Font = new System.Drawing.Font("Lucida Sans Unicode", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEnter.Location = new System.Drawing.Point(192, 264);
            this.btnEnter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(225, 73);
            this.btnEnter.TabIndex = 5;
            this.btnEnter.Text = "Войти в \"ИГРУ\"";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // statusStripMenu
            // 
            this.statusStripMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelMenu,
            this.toolStripStatusMenu});
            this.statusStripMenu.Location = new System.Drawing.Point(0, 366);
            this.statusStripMenu.Name = "statusStripMenu";
            this.statusStripMenu.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStripMenu.Size = new System.Drawing.Size(605, 22);
            this.statusStripMenu.TabIndex = 7;
            this.statusStripMenu.Text = "вывод";
            // 
            // toolStripStatusLabelMenu
            // 
            this.toolStripStatusLabelMenu.Name = "toolStripStatusLabelMenu";
            this.toolStripStatusLabelMenu.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusMenu
            // 
            this.toolStripStatusMenu.Name = "toolStripStatusMenu";
            this.toolStripStatusMenu.Size = new System.Drawing.Size(0, 17);
            // 
            // Greeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(605, 388);
            this.Controls.Add(this.statusStripMenu);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtNickName);
            this.Controls.Add(this.lblEnterUrName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuPanel;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Greeting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Хакер";
            this.Load += new System.EventHandler(this.FrmHello_Load);
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStripMenu.ResumeLayout(false);
            this.statusStripMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPanel;
        private System.Windows.Forms.ToolStripMenuItem toolStripMusic;
        private System.Windows.Forms.ToolStripMenuItem toolStripHelp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblEnterUrName;
        private System.Windows.Forms.TextBox txtNickName;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.StatusStrip statusStripMenu;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelMenu;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripDescription;
        private System.Windows.Forms.ToolStripMenuItem toolStripAbout;
    }
}

