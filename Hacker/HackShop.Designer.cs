namespace Hacker
{
    partial class HackShop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HackShop));
            this.txtShop = new System.Windows.Forms.TextBox();
            this.btnBuy = new System.Windows.Forms.Button();
            this.lblLightNet = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtShop
            // 
            this.txtShop.Enabled = false;
            this.txtShop.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtShop.Location = new System.Drawing.Point(16, 113);
            this.txtShop.Margin = new System.Windows.Forms.Padding(4);
            this.txtShop.Multiline = true;
            this.txtShop.Name = "txtShop";
            this.txtShop.ReadOnly = true;
            this.txtShop.Size = new System.Drawing.Size(872, 130);
            this.txtShop.TabIndex = 0;
            // 
            // btnBuy
            // 
            this.btnBuy.Enabled = false;
            this.btnBuy.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBuy.Location = new System.Drawing.Point(319, 251);
            this.btnBuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(267, 74);
            this.btnBuy.TabIndex = 1;
            this.btnBuy.Text = "Купить за ";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // lblLightNet
            // 
            this.lblLightNet.AutoSize = true;
            this.lblLightNet.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLightNet.Location = new System.Drawing.Point(16, 11);
            this.lblLightNet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLightNet.Name = "lblLightNet";
            this.lblLightNet.Size = new System.Drawing.Size(801, 92);
            this.lblLightNet.TabIndex = 2;
            this.lblLightNet.Text = resources.GetString("lblLightNet.Text");
            // 
            // HackShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 335);
            this.Controls.Add(this.lblLightNet);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.txtShop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HackShop";
            this.Text = "Светлая сеть";
            this.Load += new System.EventHandler(this.HackShop_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtShop;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Label lblLightNet;
    }
}