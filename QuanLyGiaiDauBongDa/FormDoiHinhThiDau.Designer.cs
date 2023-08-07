namespace QuanLyGiaiDauBongDa
{
    partial class FrmDoiHinhThiDau
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
            this.lbDoiHinh = new System.Windows.Forms.Label();
            this.dgvDoiHinh = new System.Windows.Forms.DataGridView();
            this.btnSelect = new System.Windows.Forms.Button();
            this.lbCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoiHinh)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDoiHinh
            // 
            this.lbDoiHinh.AutoSize = true;
            this.lbDoiHinh.BackColor = System.Drawing.Color.Transparent;
            this.lbDoiHinh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbDoiHinh.ForeColor = System.Drawing.Color.White;
            this.lbDoiHinh.Location = new System.Drawing.Point(12, 22);
            this.lbDoiHinh.Name = "lbDoiHinh";
            this.lbDoiHinh.Size = new System.Drawing.Size(167, 28);
            this.lbDoiHinh.TabIndex = 0;
            this.lbDoiHinh.Text = "Đội hình thi đấu";
            // 
            // dgvDoiHinh
            // 
            this.dgvDoiHinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoiHinh.Location = new System.Drawing.Point(41, 71);
            this.dgvDoiHinh.Name = "dgvDoiHinh";
            this.dgvDoiHinh.RowHeadersWidth = 51;
            this.dgvDoiHinh.RowTemplate.Height = 29;
            this.dgvDoiHinh.Size = new System.Drawing.Size(700, 362);
            this.dgvDoiHinh.TabIndex = 1;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(638, 454);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(103, 32);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.lbCount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCount.Location = new System.Drawing.Point(22, 454);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(64, 24);
            this.lbCount.TabIndex = 3;
            this.lbCount.Text = "count";
            // 
            // FrmDoiHinhThiDau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyGiaiDauBongDa.Properties.Resources.DoiHinh1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(787, 498);
            this.Controls.Add(this.lbCount);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.dgvDoiHinh);
            this.Controls.Add(this.lbDoiHinh);
            this.Name = "FrmDoiHinhThiDau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đội hình ra sân";
            this.Load += new System.EventHandler(this.FrmDoiHinhThiDau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoiHinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDoiHinh;
        private System.Windows.Forms.DataGridView dgvDoiHinh;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label lbCount;
    }
}