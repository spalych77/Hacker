namespace Hacker
{
    partial class Fun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fun));
            this.btnFriends = new System.Windows.Forms.Button();
            this.btnInDaClub = new System.Windows.Forms.Button();
            this.btnDino = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnFriends
            // 
            this.btnFriends.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFriends.Location = new System.Drawing.Point(12, 20);
            this.btnFriends.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFriends.Name = "btnFriends";
            this.btnFriends.Size = new System.Drawing.Size(267, 74);
            this.btnFriends.TabIndex = 0;
            this.btnFriends.Text = "Сходить к друзьям\r\n10$";
            this.btnFriends.UseVisualStyleBackColor = true;
            this.btnFriends.Click += new System.EventHandler(this.btnFriends_Click);
            // 
            // btnInDaClub
            // 
            this.btnInDaClub.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnInDaClub.Location = new System.Drawing.Point(12, 98);
            this.btnInDaClub.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInDaClub.Name = "btnInDaClub";
            this.btnInDaClub.Size = new System.Drawing.Size(267, 74);
            this.btnInDaClub.TabIndex = 1;
            this.btnInDaClub.Text = "Потусить в клубе\r\n50$";
            this.btnInDaClub.UseVisualStyleBackColor = true;
            this.btnInDaClub.Click += new System.EventHandler(this.btnInDaClub_Click);
            // 
            // btnDino
            // 
            this.btnDino.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDino.Location = new System.Drawing.Point(12, 177);
            this.btnDino.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDino.Name = "btnDino";
            this.btnDino.Size = new System.Drawing.Size(267, 74);
            this.btnDino.TabIndex = 2;
            this.btnDino.Text = "Сыграть в \"Дино\"\r\n125$";
            this.btnDino.UseVisualStyleBackColor = true;
            this.btnDino.Click += new System.EventHandler(this.btnDino_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(284, 20);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(576, 230);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Тут вы можете развлечься и поднять себе настроение!\r\n\r\nСходить в гости к друзьям." +
    "\r\nПотусить в клубешнике.\r\nА также сыграть в \"Гугл-динозаврика\".\r\n\r\nРазвлекитесь " +
    "от души!";
            // 
            // Fun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 262);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnDino);
            this.Controls.Add(this.btnInDaClub);
            this.Controls.Add(this.btnFriends);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Fun";
            this.Text = "Fun";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFriends;
        private System.Windows.Forms.Button btnInDaClub;
        private System.Windows.Forms.Button btnDino;
        private System.Windows.Forms.TextBox textBox1;
    }
}