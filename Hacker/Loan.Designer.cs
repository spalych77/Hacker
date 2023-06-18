namespace Hacker
{
    partial class Loan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loan));
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnTakePenkovv = new System.Windows.Forms.Button();
            this.btnTakeOmega = new System.Windows.Forms.Button();
            this.btnTakeTrata = new System.Windows.Forms.Button();
            this.btnTakeZakritie = new System.Windows.Forms.Button();
            this.btnTakeRosKolhoz = new System.Windows.Forms.Button();
            this.btnEndPenkovv = new System.Windows.Forms.Button();
            this.btnEndOmega = new System.Windows.Forms.Button();
            this.btnEndTrata = new System.Windows.Forms.Button();
            this.btnEndZakritie = new System.Windows.Forms.Button();
            this.btnEndRosKolhoz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInfo.Location = new System.Drawing.Point(63, 11);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(1139, 69);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = resources.GetString("lblInfo.Text");
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnTakePenkovv
            // 
            this.btnTakePenkovv.Enabled = false;
            this.btnTakePenkovv.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTakePenkovv.Location = new System.Drawing.Point(12, 87);
            this.btnTakePenkovv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTakePenkovv.Name = "btnTakePenkovv";
            this.btnTakePenkovv.Size = new System.Drawing.Size(267, 74);
            this.btnTakePenkovv.TabIndex = 1;
            this.btnTakePenkovv.Text = "Взять кредит \r\n\"Пеньковв\"";
            this.btnTakePenkovv.UseVisualStyleBackColor = true;
            this.btnTakePenkovv.Click += new System.EventHandler(this.btnTakeLoan_Click);
            // 
            // btnTakeOmega
            // 
            this.btnTakeOmega.Enabled = false;
            this.btnTakeOmega.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTakeOmega.Location = new System.Drawing.Point(284, 87);
            this.btnTakeOmega.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTakeOmega.Name = "btnTakeOmega";
            this.btnTakeOmega.Size = new System.Drawing.Size(267, 74);
            this.btnTakeOmega.TabIndex = 2;
            this.btnTakeOmega.Text = "Взять кредит \r\n\"ОмегаБанк\"";
            this.btnTakeOmega.UseVisualStyleBackColor = true;
            this.btnTakeOmega.Click += new System.EventHandler(this.btnTakeLoan_Click);
            // 
            // btnTakeTrata
            // 
            this.btnTakeTrata.Enabled = false;
            this.btnTakeTrata.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTakeTrata.Location = new System.Drawing.Point(556, 87);
            this.btnTakeTrata.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTakeTrata.Name = "btnTakeTrata";
            this.btnTakeTrata.Size = new System.Drawing.Size(267, 74);
            this.btnTakeTrata.TabIndex = 3;
            this.btnTakeTrata.Text = "Взять кредит \r\n\"ТратаБанк\"";
            this.btnTakeTrata.UseVisualStyleBackColor = true;
            this.btnTakeTrata.Click += new System.EventHandler(this.btnTakeLoan_Click);
            // 
            // btnTakeZakritie
            // 
            this.btnTakeZakritie.Enabled = false;
            this.btnTakeZakritie.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTakeZakritie.Location = new System.Drawing.Point(828, 87);
            this.btnTakeZakritie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTakeZakritie.Name = "btnTakeZakritie";
            this.btnTakeZakritie.Size = new System.Drawing.Size(267, 74);
            this.btnTakeZakritie.TabIndex = 4;
            this.btnTakeZakritie.Text = "Взять кредит \r\n\"БанкЗакрытие\"";
            this.btnTakeZakritie.UseVisualStyleBackColor = true;
            this.btnTakeZakritie.Click += new System.EventHandler(this.btnTakeLoan_Click);
            // 
            // btnTakeRosKolhoz
            // 
            this.btnTakeRosKolhoz.Enabled = false;
            this.btnTakeRosKolhoz.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTakeRosKolhoz.Location = new System.Drawing.Point(1100, 87);
            this.btnTakeRosKolhoz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTakeRosKolhoz.Name = "btnTakeRosKolhoz";
            this.btnTakeRosKolhoz.Size = new System.Drawing.Size(267, 74);
            this.btnTakeRosKolhoz.TabIndex = 5;
            this.btnTakeRosKolhoz.Text = "Взять кредит \r\n\"РосКолхозБанк\"";
            this.btnTakeRosKolhoz.UseVisualStyleBackColor = true;
            this.btnTakeRosKolhoz.Click += new System.EventHandler(this.btnTakeLoan_Click);
            // 
            // btnEndPenkovv
            // 
            this.btnEndPenkovv.Enabled = false;
            this.btnEndPenkovv.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEndPenkovv.Location = new System.Drawing.Point(12, 214);
            this.btnEndPenkovv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEndPenkovv.Name = "btnEndPenkovv";
            this.btnEndPenkovv.Size = new System.Drawing.Size(267, 74);
            this.btnEndPenkovv.TabIndex = 6;
            this.btnEndPenkovv.Text = "Погасить кредит\r\n\"Пеньковв\"";
            this.btnEndPenkovv.UseVisualStyleBackColor = true;
            this.btnEndPenkovv.Click += new System.EventHandler(this.btnEndLoan_Click);
            // 
            // btnEndOmega
            // 
            this.btnEndOmega.Enabled = false;
            this.btnEndOmega.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEndOmega.Location = new System.Drawing.Point(284, 214);
            this.btnEndOmega.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEndOmega.Name = "btnEndOmega";
            this.btnEndOmega.Size = new System.Drawing.Size(267, 74);
            this.btnEndOmega.TabIndex = 7;
            this.btnEndOmega.Text = "Погасить кредит\r\n\"ОмегаБанк\"";
            this.btnEndOmega.UseVisualStyleBackColor = true;
            this.btnEndOmega.Click += new System.EventHandler(this.btnEndLoan_Click);
            // 
            // btnEndTrata
            // 
            this.btnEndTrata.Enabled = false;
            this.btnEndTrata.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEndTrata.Location = new System.Drawing.Point(556, 214);
            this.btnEndTrata.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEndTrata.Name = "btnEndTrata";
            this.btnEndTrata.Size = new System.Drawing.Size(267, 74);
            this.btnEndTrata.TabIndex = 8;
            this.btnEndTrata.Text = "Погасить кредит\r\n\"ТратаБанк\"";
            this.btnEndTrata.UseVisualStyleBackColor = true;
            this.btnEndTrata.Click += new System.EventHandler(this.btnEndLoan_Click);
            // 
            // btnEndZakritie
            // 
            this.btnEndZakritie.Enabled = false;
            this.btnEndZakritie.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEndZakritie.Location = new System.Drawing.Point(828, 214);
            this.btnEndZakritie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEndZakritie.Name = "btnEndZakritie";
            this.btnEndZakritie.Size = new System.Drawing.Size(267, 74);
            this.btnEndZakritie.TabIndex = 9;
            this.btnEndZakritie.Text = "Погасить кредит\r\n\"БанкЗакрытие\"";
            this.btnEndZakritie.Click += new System.EventHandler(this.btnEndLoan_Click);
            // 
            // btnEndRosKolhoz
            // 
            this.btnEndRosKolhoz.Enabled = false;
            this.btnEndRosKolhoz.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEndRosKolhoz.Location = new System.Drawing.Point(1100, 214);
            this.btnEndRosKolhoz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEndRosKolhoz.Name = "btnEndRosKolhoz";
            this.btnEndRosKolhoz.Size = new System.Drawing.Size(267, 74);
            this.btnEndRosKolhoz.TabIndex = 10;
            this.btnEndRosKolhoz.Text = "Погасить кредит\r\n\"РосКолхозБанк\"";
            this.btnEndRosKolhoz.UseVisualStyleBackColor = true;
            this.btnEndRosKolhoz.Click += new System.EventHandler(this.btnEndLoan_Click);
            // 
            // Loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 299);
            this.Controls.Add(this.btnEndRosKolhoz);
            this.Controls.Add(this.btnEndZakritie);
            this.Controls.Add(this.btnEndTrata);
            this.Controls.Add(this.btnEndOmega);
            this.Controls.Add(this.btnEndPenkovv);
            this.Controls.Add(this.btnTakeRosKolhoz);
            this.Controls.Add(this.btnTakeZakritie);
            this.Controls.Add(this.btnTakeTrata);
            this.Controls.Add(this.btnTakeOmega);
            this.Controls.Add(this.btnTakePenkovv);
            this.Controls.Add(this.lblInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Loan";
            this.Text = "Кредиты";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnTakePenkovv;
        private System.Windows.Forms.Button btnTakeOmega;
        private System.Windows.Forms.Button btnTakeTrata;
        private System.Windows.Forms.Button btnTakeZakritie;
        private System.Windows.Forms.Button btnTakeRosKolhoz;
        private System.Windows.Forms.Button btnEndPenkovv;
        private System.Windows.Forms.Button btnEndOmega;
        private System.Windows.Forms.Button btnEndTrata;
        private System.Windows.Forms.Button btnEndZakritie;
        private System.Windows.Forms.Button btnEndRosKolhoz;
    }
}