namespace Hacker
{
    partial class Work
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Work));
            this.btnJanitor = new System.Windows.Forms.Button();
            this.btnLoader = new System.Windows.Forms.Button();
            this.btnSeller = new System.Windows.Forms.Button();
            this.btnJunior = new System.Windows.Forms.Button();
            this.btnMiddle = new System.Windows.Forms.Button();
            this.btnSenior = new System.Windows.Forms.Button();
            this.txtWork = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnJanitor
            // 
            this.btnJanitor.Enabled = false;
            this.btnJanitor.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnJanitor.Location = new System.Drawing.Point(15, 14);
            this.btnJanitor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnJanitor.Name = "btnJanitor";
            this.btnJanitor.Size = new System.Drawing.Size(267, 74);
            this.btnJanitor.TabIndex = 0;
            this.btnJanitor.Text = "Дворник";
            this.btnJanitor.UseVisualStyleBackColor = true;
            this.btnJanitor.Click += new System.EventHandler(this.btnJanitor_Click);
            // 
            // btnLoader
            // 
            this.btnLoader.Enabled = false;
            this.btnLoader.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLoader.Location = new System.Drawing.Point(15, 100);
            this.btnLoader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoader.Name = "btnLoader";
            this.btnLoader.Size = new System.Drawing.Size(267, 74);
            this.btnLoader.TabIndex = 1;
            this.btnLoader.Text = "Грузчик";
            this.btnLoader.UseVisualStyleBackColor = true;
            this.btnLoader.Click += new System.EventHandler(this.btnLoader_Click);
            // 
            // btnSeller
            // 
            this.btnSeller.Enabled = false;
            this.btnSeller.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSeller.Location = new System.Drawing.Point(15, 186);
            this.btnSeller.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSeller.Name = "btnSeller";
            this.btnSeller.Size = new System.Drawing.Size(267, 74);
            this.btnSeller.TabIndex = 2;
            this.btnSeller.Text = "Кассир";
            this.btnSeller.UseVisualStyleBackColor = true;
            this.btnSeller.Click += new System.EventHandler(this.btnSeller_Click);
            // 
            // btnJunior
            // 
            this.btnJunior.Enabled = false;
            this.btnJunior.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnJunior.Location = new System.Drawing.Point(15, 271);
            this.btnJunior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnJunior.Name = "btnJunior";
            this.btnJunior.Size = new System.Drawing.Size(267, 74);
            this.btnJunior.TabIndex = 3;
            this.btnJunior.Text = "Программист(Джун)";
            this.btnJunior.UseVisualStyleBackColor = true;
            this.btnJunior.Click += new System.EventHandler(this.btnJunior_Click);
            // 
            // btnMiddle
            // 
            this.btnMiddle.Enabled = false;
            this.btnMiddle.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMiddle.Location = new System.Drawing.Point(15, 357);
            this.btnMiddle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMiddle.Name = "btnMiddle";
            this.btnMiddle.Size = new System.Drawing.Size(267, 74);
            this.btnMiddle.TabIndex = 4;
            this.btnMiddle.Text = "Программист(Мидл)";
            this.btnMiddle.UseVisualStyleBackColor = true;
            this.btnMiddle.Click += new System.EventHandler(this.btnMiddle_Click);
            // 
            // btnSenior
            // 
            this.btnSenior.Enabled = false;
            this.btnSenior.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSenior.Location = new System.Drawing.Point(15, 436);
            this.btnSenior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSenior.Name = "btnSenior";
            this.btnSenior.Size = new System.Drawing.Size(267, 74);
            this.btnSenior.TabIndex = 5;
            this.btnSenior.Text = "Программист(Сеньор)";
            this.btnSenior.UseVisualStyleBackColor = true;
            this.btnSenior.Click += new System.EventHandler(this.btnSenior_Click);
            // 
            // txtWork
            // 
            this.txtWork.Enabled = false;
            this.txtWork.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtWork.Location = new System.Drawing.Point(287, 133);
            this.txtWork.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWork.Multiline = true;
            this.txtWork.Name = "txtWork";
            this.txtWork.ReadOnly = true;
            this.txtWork.Size = new System.Drawing.Size(628, 272);
            this.txtWork.TabIndex = 10;
            this.txtWork.Text = "Ты можешь устроиться на любую работу\r\n\r\nЕсли конечно же твой статус это позволяет" +
    "\r\n\r\n\r\n\r\nНа данный момент ты - БЕЗРАБОТНЫЙ\r\n\r\nТвоя зарпалата составляет: 0$/день." +
    "";
            // 
            // Work
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 526);
            this.Controls.Add(this.txtWork);
            this.Controls.Add(this.btnSenior);
            this.Controls.Add(this.btnMiddle);
            this.Controls.Add(this.btnJunior);
            this.Controls.Add(this.btnSeller);
            this.Controls.Add(this.btnLoader);
            this.Controls.Add(this.btnJanitor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Work";
            this.Text = "Трудоустройство";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnJanitor;
        private System.Windows.Forms.Button btnLoader;
        private System.Windows.Forms.Button btnSeller;
        private System.Windows.Forms.Button btnJunior;
        private System.Windows.Forms.Button btnMiddle;
        private System.Windows.Forms.Button btnSenior;
        private System.Windows.Forms.TextBox txtWork;
    }
}