
namespace QuanLyGiaiDauBongDa
{
    partial class FrmXemDoiHinhThiDau
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
            this.dgvDoiHinh = new System.Windows.Forms.DataGridView();
            this.lbDoiHinh = new System.Windows.Forms.Label();
            this.cbClub = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoiHinh)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDoiHinh
            // 
            this.dgvDoiHinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoiHinh.Location = new System.Drawing.Point(51, 149);
            this.dgvDoiHinh.Name = "dgvDoiHinh";
            this.dgvDoiHinh.RowHeadersWidth = 51;
            this.dgvDoiHinh.RowTemplate.Height = 29;
            this.dgvDoiHinh.Size = new System.Drawing.Size(660, 400);
            this.dgvDoiHinh.TabIndex = 0;
            // 
            // lbDoiHinh
            // 
            this.lbDoiHinh.AutoSize = true;
            this.lbDoiHinh.BackColor = System.Drawing.Color.Transparent;
            this.lbDoiHinh.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbDoiHinh.ForeColor = System.Drawing.Color.White;
            this.lbDoiHinh.Location = new System.Drawing.Point(12, 25);
            this.lbDoiHinh.Name = "lbDoiHinh";
            this.lbDoiHinh.Size = new System.Drawing.Size(190, 30);
            this.lbDoiHinh.TabIndex = 2;
            this.lbDoiHinh.Text = "Đội Hình thi Đấu:";
            // 
            // cbClub
            // 
            this.cbClub.FormattingEnabled = true;
            this.cbClub.Location = new System.Drawing.Point(51, 115);
            this.cbClub.Name = "cbClub";
            this.cbClub.Size = new System.Drawing.Size(151, 28);
            this.cbClub.TabIndex = 3;
            // 
            // FrmXemDoiHinhThiDau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyGiaiDauBongDa.Properties.Resources.fc5edd6db81ddc1e81f640d2f5f577372;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(756, 570);
            this.Controls.Add(this.cbClub);
            this.Controls.Add(this.lbDoiHinh);
            this.Controls.Add(this.dgvDoiHinh);
            this.Name = "FrmXemDoiHinhThiDau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đội hình thi đấu";
            this.Load += new System.EventHandler(this.FrmXemDoiHinhThiDau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoiHinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDoiHinh;
        private System.Windows.Forms.Label lbDoiHinh;
        private System.Windows.Forms.ComboBox cbClub;
    }
}