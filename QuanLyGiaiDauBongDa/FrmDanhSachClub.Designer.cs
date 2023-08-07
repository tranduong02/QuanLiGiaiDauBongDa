
namespace QuanLyGiaiDauBongDa
{
    partial class FrmDanhSachClub
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
            this.dgvClub = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelNameClub = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTotalNumber = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvClub
            // 
            this.dgvClub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClub.Location = new System.Drawing.Point(43, 249);
            this.dgvClub.Name = "dgvClub";
            this.dgvClub.RowHeadersWidth = 51;
            this.dgvClub.RowTemplate.Height = 29;
            this.dgvClub.Size = new System.Drawing.Size(1065, 458);
            this.dgvClub.TabIndex = 0;
            this.dgvClub.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClub_CellClick);
            this.dgvClub.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClub_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(804, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Thêm Club";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // picLogo
            // 
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picLogo.Location = new System.Drawing.Point(59, 22);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(170, 159);
            this.picLogo.TabIndex = 2;
            this.picLogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(298, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Năm Thành Lập:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(298, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Địa chỉ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Thành Phố:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(298, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Quốc Gia:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(298, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Sân vận động:";
            // 
            // labelNameClub
            // 
            this.labelNameClub.AutoSize = true;
            this.labelNameClub.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNameClub.Location = new System.Drawing.Point(304, 9);
            this.labelNameClub.Name = "labelNameClub";
            this.labelNameClub.Size = new System.Drawing.Size(116, 28);
            this.labelNameClub.TabIndex = 16;
            this.labelNameClub.Text = "Name Club";
            // 
            // txtYear
            // 
            this.txtYear.AutoSize = true;
            this.txtYear.Location = new System.Drawing.Point(447, 47);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(13, 20);
            this.txtYear.TabIndex = 17;
            this.txtYear.Text = " ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(447, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(447, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(447, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "label10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(447, 179);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "label11";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(447, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "label7";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(804, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 29);
            this.button2.TabIndex = 23;
            this.button2.Text = " Xóa Club";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(804, 136);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(173, 29);
            this.button3.TabIndex = 24;
            this.button3.Text = " Chỉnh Sửa Thông Tin";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(804, 179);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 20);
            this.label12.TabIndex = 25;
            this.label12.Text = "Tổng số đội bóng:";
            // 
            // txtTotalNumber
            // 
            this.txtTotalNumber.AutoSize = true;
            this.txtTotalNumber.Location = new System.Drawing.Point(940, 179);
            this.txtTotalNumber.Name = "txtTotalNumber";
            this.txtTotalNumber.Size = new System.Drawing.Size(23, 20);
            this.txtTotalNumber.TabIndex = 26;
            this.txtTotalNumber.Text = "xx";
            this.txtTotalNumber.Click += new System.EventHandler(this.txtTotalNumber_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(676, 17);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(254, 27);
            this.txtSearch.TabIndex = 27;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(942, 17);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 29);
            this.button4.TabIndex = 28;
            this.button4.Text = "Tìm Kiếm";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button7
            // 
            this.button7.Image = global::QuanLyGiaiDauBongDa.Properties.Resources.exit;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button7.Location = new System.Drawing.Point(1005, 713);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(122, 45);
            this.button7.TabIndex = 29;
            this.button7.Text = "Exit";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.picLogo);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtTotalNumber);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.labelNameClub);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtYear);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(43, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1065, 213);
            this.panel1.TabIndex = 30;
            // 
            // FrmDanhSachClub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyGiaiDauBongDa.Properties.Resources.football_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1157, 770);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.dgvClub);
            this.Name = "FrmDanhSachClub";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDanhSachClub";
            this.Load += new System.EventHandler(this.FrmDanhSachDoiBong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClub;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelNameClub;
        private System.Windows.Forms.Label txtYear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label txtTotalNumber;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel1;
    }
}