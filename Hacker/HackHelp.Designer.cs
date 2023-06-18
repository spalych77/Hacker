namespace Hacker
{
    partial class HackHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HackHelp));
            this.btnTakeHint = new System.Windows.Forms.Button();
            this.txtHints = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTakeHint
            // 
            this.btnTakeHint.Location = new System.Drawing.Point(573, 245);
            this.btnTakeHint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTakeHint.Name = "btnTakeHint";
            this.btnTakeHint.Size = new System.Drawing.Size(267, 74);
            this.btnTakeHint.TabIndex = 0;
            this.btnTakeHint.Text = "Купить подсказку за 50$\r\n";
            this.btnTakeHint.UseVisualStyleBackColor = true;
            this.btnTakeHint.Click += new System.EventHandler(this.btnTakeHint_Click);
            // 
            // txtHints
            // 
            this.txtHints.Enabled = false;
            this.txtHints.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtHints.Location = new System.Drawing.Point(11, 85);
            this.txtHints.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHints.Multiline = true;
            this.txtHints.Name = "txtHints";
            this.txtHints.ReadOnly = true;
            this.txtHints.Size = new System.Drawing.Size(828, 154);
            this.txtHints.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(687, 69);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ты находишься на сайте Hack.net - сайт сообщества хакеров.\r\nТы можешь взять подск" +
    "азку по взлому у \"заядлого хакера\" \r\nкаждые 50$ - новая подсказка.";
            // 
            // HackHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 327);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHints);
            this.Controls.Add(this.btnTakeHint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HackHelp";
            this.Text = "Хакерская сеть";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTakeHint;
        private System.Windows.Forms.TextBox txtHints;
        private System.Windows.Forms.Label label1;
    }
}