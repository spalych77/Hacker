namespace Hacker
{
    partial class Missions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Missions));
            this.txtMission = new System.Windows.Forms.TextBox();
            this.btnToolHack = new System.Windows.Forms.Button();
            this.btnNextTool = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMission
            // 
            this.txtMission.Enabled = false;
            this.txtMission.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtMission.Location = new System.Drawing.Point(16, 15);
            this.txtMission.Margin = new System.Windows.Forms.Padding(4);
            this.txtMission.Multiline = true;
            this.txtMission.Name = "txtMission";
            this.txtMission.ReadOnly = true;
            this.txtMission.Size = new System.Drawing.Size(1471, 299);
            this.txtMission.TabIndex = 0;
            // 
            // btnToolHack
            // 
            this.btnToolHack.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnToolHack.Location = new System.Drawing.Point(348, 322);
            this.btnToolHack.Margin = new System.Windows.Forms.Padding(4);
            this.btnToolHack.Name = "btnToolHack";
            this.btnToolHack.Size = new System.Drawing.Size(533, 74);
            this.btnToolHack.TabIndex = 1;
            this.btnToolHack.Text = "Выбери инструмент для взлома!";
            this.btnToolHack.UseVisualStyleBackColor = true;
            this.btnToolHack.Click += new System.EventHandler(this.btnToolHack_Click);
            // 
            // btnNextTool
            // 
            this.btnNextTool.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNextTool.Location = new System.Drawing.Point(889, 322);
            this.btnNextTool.Margin = new System.Windows.Forms.Padding(4);
            this.btnNextTool.Name = "btnNextTool";
            this.btnNextTool.Size = new System.Drawing.Size(240, 74);
            this.btnNextTool.TabIndex = 3;
            this.btnNextTool.Text = ">>";
            this.btnNextTool.UseVisualStyleBackColor = true;
            this.btnNextTool.Click += new System.EventHandler(this.btnNextTool_Click);
            // 
            // Missions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1505, 409);
            this.Controls.Add(this.btnNextTool);
            this.Controls.Add(this.btnToolHack);
            this.Controls.Add(this.txtMission);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Missions";
            this.Text = "Хакерское задание №";
            this.Load += new System.EventHandler(this.Mission_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMission;
        private System.Windows.Forms.Button btnToolHack;
        private System.Windows.Forms.Button btnNextTool;
    }
}