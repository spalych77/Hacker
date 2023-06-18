namespace Hacker
{
    partial class DNS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DNS));
            this.btnBuyCase = new System.Windows.Forms.Button();
            this.btnBuyMother = new System.Windows.Forms.Button();
            this.btnBuyCPU = new System.Windows.Forms.Button();
            this.btnBuyRAM = new System.Windows.Forms.Button();
            this.btnBuyGPU = new System.Windows.Forms.Button();
            this.btnBuyDisk = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBuyCase
            // 
            this.btnBuyCase.Location = new System.Drawing.Point(12, 14);
            this.btnBuyCase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuyCase.Name = "btnBuyCase";
            this.btnBuyCase.Size = new System.Drawing.Size(267, 74);
            this.btnBuyCase.TabIndex = 10;
            this.btnBuyCase.Text = "Купить корпус";
            this.btnBuyCase.UseVisualStyleBackColor = true;
            this.btnBuyCase.Click += new System.EventHandler(this.btnBuyCase_Click);
            // 
            // btnBuyMother
            // 
            this.btnBuyMother.Location = new System.Drawing.Point(12, 92);
            this.btnBuyMother.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuyMother.Name = "btnBuyMother";
            this.btnBuyMother.Size = new System.Drawing.Size(267, 74);
            this.btnBuyMother.TabIndex = 11;
            this.btnBuyMother.Text = "Купить материнку";
            this.btnBuyMother.UseVisualStyleBackColor = true;
            this.btnBuyMother.Click += new System.EventHandler(this.btnBuyMother_Click);
            // 
            // btnBuyCPU
            // 
            this.btnBuyCPU.Location = new System.Drawing.Point(12, 171);
            this.btnBuyCPU.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuyCPU.Name = "btnBuyCPU";
            this.btnBuyCPU.Size = new System.Drawing.Size(267, 74);
            this.btnBuyCPU.TabIndex = 12;
            this.btnBuyCPU.Text = "Купить проц";
            this.btnBuyCPU.UseVisualStyleBackColor = true;
            this.btnBuyCPU.Click += new System.EventHandler(this.btnBuyCPU_Click);
            // 
            // btnBuyRAM
            // 
            this.btnBuyRAM.Location = new System.Drawing.Point(12, 272);
            this.btnBuyRAM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuyRAM.Name = "btnBuyRAM";
            this.btnBuyRAM.Size = new System.Drawing.Size(267, 74);
            this.btnBuyRAM.TabIndex = 13;
            this.btnBuyRAM.Text = "Купить оперативу";
            this.btnBuyRAM.UseVisualStyleBackColor = true;
            this.btnBuyRAM.Click += new System.EventHandler(this.btnBuyRAM_Click);
            // 
            // btnBuyGPU
            // 
            this.btnBuyGPU.Location = new System.Drawing.Point(15, 351);
            this.btnBuyGPU.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuyGPU.Name = "btnBuyGPU";
            this.btnBuyGPU.Size = new System.Drawing.Size(267, 74);
            this.btnBuyGPU.TabIndex = 14;
            this.btnBuyGPU.Text = "Купить видюху";
            this.btnBuyGPU.UseVisualStyleBackColor = true;
            this.btnBuyGPU.Click += new System.EventHandler(this.btnBuyGPU_Click);
            // 
            // btnBuyDisk
            // 
            this.btnBuyDisk.Location = new System.Drawing.Point(12, 430);
            this.btnBuyDisk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuyDisk.Name = "btnBuyDisk";
            this.btnBuyDisk.Size = new System.Drawing.Size(267, 74);
            this.btnBuyDisk.TabIndex = 15;
            this.btnBuyDisk.Text = "Купить диск";
            this.btnBuyDisk.UseVisualStyleBackColor = true;
            this.btnBuyDisk.Click += new System.EventHandler(this.btnDisk_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(285, 14);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(519, 489);
            this.textBox1.TabIndex = 16;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // DNS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 517);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnBuyDisk);
            this.Controls.Add(this.btnBuyGPU);
            this.Controls.Add(this.btnBuyRAM);
            this.Controls.Add(this.btnBuyCPU);
            this.Controls.Add(this.btnBuyMother);
            this.Controls.Add(this.btnBuyCase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DNS";
            this.Text = "Магаз";
            this.Load += new System.EventHandler(this.DNS_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBuyCase;
        private System.Windows.Forms.Button btnBuyMother;
        private System.Windows.Forms.Button btnBuyCPU;
        private System.Windows.Forms.Button btnBuyRAM;
        private System.Windows.Forms.Button btnBuyGPU;
        private System.Windows.Forms.Button btnBuyDisk;
        private System.Windows.Forms.TextBox textBox1;
    }
}