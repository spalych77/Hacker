namespace Hacker
{
    partial class Mining
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mining));
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnHackerCoin = new System.Windows.Forms.Button();
            this.btnKefirium = new System.Windows.Forms.Button();
            this.btnBitok = new System.Windows.Forms.Button();
            this.txtMining = new System.Windows.Forms.TextBox();
            this.btnMining = new System.Windows.Forms.Button();
            this.lblAttention = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(311, 352);
            this.progressBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(680, 31);
            this.progressBar.TabIndex = 0;
            // 
            // btnHackerCoin
            // 
            this.btnHackerCoin.Enabled = false;
            this.btnHackerCoin.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnHackerCoin.Location = new System.Drawing.Point(12, 129);
            this.btnHackerCoin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHackerCoin.Name = "btnHackerCoin";
            this.btnHackerCoin.Size = new System.Drawing.Size(267, 74);
            this.btnHackerCoin.TabIndex = 1;
            this.btnHackerCoin.Text = "HackerCoin\r\n";
            this.btnHackerCoin.UseVisualStyleBackColor = true;
            this.btnHackerCoin.Click += new System.EventHandler(this.btnHackerCoin_Click);
            // 
            // btnKefirium
            // 
            this.btnKefirium.Enabled = false;
            this.btnKefirium.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnKefirium.Location = new System.Drawing.Point(12, 260);
            this.btnKefirium.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKefirium.Name = "btnKefirium";
            this.btnKefirium.Size = new System.Drawing.Size(267, 74);
            this.btnKefirium.TabIndex = 2;
            this.btnKefirium.Text = "Kefirium";
            this.btnKefirium.UseVisualStyleBackColor = true;
            this.btnKefirium.Click += new System.EventHandler(this.btnKefirium_Click);
            // 
            // btnBitok
            // 
            this.btnBitok.Enabled = false;
            this.btnBitok.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBitok.Location = new System.Drawing.Point(12, 401);
            this.btnBitok.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBitok.Name = "btnBitok";
            this.btnBitok.Size = new System.Drawing.Size(267, 74);
            this.btnBitok.TabIndex = 3;
            this.btnBitok.Text = "Bitok";
            this.btnBitok.UseVisualStyleBackColor = true;
            this.btnBitok.Click += new System.EventHandler(this.btnBitok_Click);
            // 
            // txtMining
            // 
            this.txtMining.Enabled = false;
            this.txtMining.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtMining.Location = new System.Drawing.Point(311, 129);
            this.txtMining.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMining.Multiline = true;
            this.txtMining.Name = "txtMining";
            this.txtMining.ReadOnly = true;
            this.txtMining.Size = new System.Drawing.Size(679, 203);
            this.txtMining.TabIndex = 4;
            this.txtMining.TabStop = false;
            // 
            // btnMining
            // 
            this.btnMining.Enabled = false;
            this.btnMining.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMining.Location = new System.Drawing.Point(512, 401);
            this.btnMining.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMining.Name = "btnMining";
            this.btnMining.Size = new System.Drawing.Size(267, 74);
            this.btnMining.TabIndex = 5;
            this.btnMining.Text = "МАЙНИТЬ КРИПТУ";
            this.btnMining.UseVisualStyleBackColor = true;
            this.btnMining.Click += new System.EventHandler(this.btnMining_Click);
            // 
            // lblAttention
            // 
            this.lblAttention.AutoSize = true;
            this.lblAttention.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAttention.Location = new System.Drawing.Point(15, 11);
            this.lblAttention.Name = "lblAttention";
            this.lblAttention.Size = new System.Drawing.Size(907, 112);
            this.lblAttention.TabIndex = 6;
            this.lblAttention.Text = "Тут ты можешь иметь \"пассивный доход\", а именно добывать коины.\r\nДобыть 1 койн мо" +
    "жно каждый 7 день месяца.\r\nЭти коины можно перевести в деньги.\r\nДля этого нажми " +
    "на подходящую кнопку на главном экране.";
            // 
            // Mining
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 489);
            this.Controls.Add(this.lblAttention);
            this.Controls.Add(this.btnMining);
            this.Controls.Add(this.txtMining);
            this.Controls.Add(this.btnBitok);
            this.Controls.Add(this.btnKefirium);
            this.Controls.Add(this.btnHackerCoin);
            this.Controls.Add(this.progressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Mining";
            this.Text = "Майнинг";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button btnHackerCoin;
        private System.Windows.Forms.Button btnKefirium;
        private System.Windows.Forms.Button btnBitok;
        private System.Windows.Forms.TextBox txtMining;
        private System.Windows.Forms.Button btnMining;
        private System.Windows.Forms.Label lblAttention;
    }
}