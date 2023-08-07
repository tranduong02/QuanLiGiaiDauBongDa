namespace QuanLyGiaiDauBongDa
{
    partial class FrmLichThiDauChoClub
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbClub = new System.Windows.Forms.Label();
            this.pbClub = new System.Windows.Forms.PictureBox();
            this.flpSchedule = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbClub)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(33, 12);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(265, 35);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Lịch Thi Đấu của CLB:";
            // 
            // lbClub
            // 
            this.lbClub.AutoSize = true;
            this.lbClub.BackColor = System.Drawing.Color.Transparent;
            this.lbClub.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbClub.ForeColor = System.Drawing.Color.White;
            this.lbClub.Location = new System.Drawing.Point(355, 12);
            this.lbClub.Name = "lbClub";
            this.lbClub.Size = new System.Drawing.Size(69, 35);
            this.lbClub.TabIndex = 1;
            this.lbClub.Text = "Club";
            // 
            // pbClub
            // 
            this.pbClub.BackColor = System.Drawing.Color.Transparent;
            this.pbClub.Location = new System.Drawing.Point(289, 2);
            this.pbClub.Name = "pbClub";
            this.pbClub.Size = new System.Drawing.Size(60, 60);
            this.pbClub.TabIndex = 2;
            this.pbClub.TabStop = false;
            // 
            // flpSchedule
            // 
            this.flpSchedule.BackColor = System.Drawing.Color.Transparent;
            this.flpSchedule.Location = new System.Drawing.Point(33, 115);
            this.flpSchedule.Name = "flpSchedule";
            this.flpSchedule.Size = new System.Drawing.Size(834, 372);
            this.flpSchedule.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(698, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Danh sach cau thu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmLichThiDauChoClub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyGiaiDauBongDa.Properties.Resources.arsenal_football_club_stadium_211427551515995098;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(899, 511);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flpSchedule);
            this.Controls.Add(this.pbClub);
            this.Controls.Add(this.lbClub);
            this.Controls.Add(this.lbTitle);
            this.Name = "FrmLichThiDauChoClub";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lịch Thi Đấu";
            this.Load += new System.EventHandler(this.FrmLichThiDauChoClub_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbClub)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbClub;
        private System.Windows.Forms.PictureBox pbClub;
        private System.Windows.Forms.FlowLayoutPanel flpSchedule;
        private System.Windows.Forms.Button button1;
    }
}