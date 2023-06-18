namespace Hacker
{
    partial class Description
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Description));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.linkLbl2 = new System.Windows.Forms.LinkLabel();
            this.linkLbl1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(804, 550);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // linkLbl2
            // 
            this.linkLbl2.AutoSize = true;
            this.linkLbl2.BackColor = System.Drawing.SystemColors.Control;
            this.linkLbl2.DisabledLinkColor = System.Drawing.Color.Black;
            this.linkLbl2.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLbl2.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.linkLbl2.Location = new System.Drawing.Point(408, 384);
            this.linkLbl2.Name = "linkLbl2";
            this.linkLbl2.Size = new System.Drawing.Size(146, 23);
            this.linkLbl2.TabIndex = 1;
            this.linkLbl2.TabStop = true;
            this.linkLbl2.Text = "Яндекс.Диск";
            this.linkLbl2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLbl_LinkClicked);
            // 
            // linkLbl1
            // 
            this.linkLbl1.AutoSize = true;
            this.linkLbl1.BackColor = System.Drawing.SystemColors.Control;
            this.linkLbl1.DisabledLinkColor = System.Drawing.Color.Black;
            this.linkLbl1.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLbl1.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.linkLbl1.Location = new System.Drawing.Point(289, 311);
            this.linkLbl1.Name = "linkLbl1";
            this.linkLbl1.Size = new System.Drawing.Size(146, 23);
            this.linkLbl1.TabIndex = 2;
            this.linkLbl1.TabStop = true;
            this.linkLbl1.Text = "Яндекс.Диск";
            this.linkLbl1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLbl_LinkClicked);
            // 
            // Description
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 575);
            this.Controls.Add(this.linkLbl1);
            this.Controls.Add(this.linkLbl2);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Description";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Описание";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.LinkLabel linkLbl2;
        private System.Windows.Forms.LinkLabel linkLbl1;
    }
}