
namespace QuanLyGiaiDauBongDa
{
    partial class FrmAddMatch
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.cbHost = new System.Windows.Forms.ComboBox();
            this.cbGuest = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbReferee = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.cbVenue = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbStage = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::QuanLyGiaiDauBongDa.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(138, 138);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pic2
            // 
            this.pic2.BackColor = System.Drawing.Color.Transparent;
            this.pic2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic2.Image = global::QuanLyGiaiDauBongDa.Properties.Resources.logo;
            this.pic2.Location = new System.Drawing.Point(632, 138);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(155, 155);
            this.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic2.TabIndex = 2;
            this.pic2.TabStop = false;
            // 
            // cbHost
            // 
            this.cbHost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHost.FormattingEnabled = true;
            this.cbHost.Location = new System.Drawing.Point(138, 324);
            this.cbHost.Name = "cbHost";
            this.cbHost.Size = new System.Drawing.Size(151, 28);
            this.cbHost.TabIndex = 3;
            this.cbHost.SelectedIndexChanged += new System.EventHandler(this.cbHost_SelectedIndexChanged);
            // 
            // cbGuest
            // 
            this.cbGuest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGuest.FormattingEnabled = true;
            this.cbGuest.Location = new System.Drawing.Point(632, 324);
            this.cbGuest.Name = "cbGuest";
            this.cbGuest.Size = new System.Drawing.Size(151, 28);
            this.cbGuest.TabIndex = 4;
            this.cbGuest.SelectedIndexChanged += new System.EventHandler(this.cbGuest_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dateTimePicker1.Location = new System.Drawing.Point(338, 396);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(386, 575);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "Match";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(234, 401);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Thời Gian:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(234, 439);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Địa Điểm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(234, 478);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Trọng Tài:";
            // 
            // cbReferee
            // 
            this.cbReferee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbReferee.FormattingEnabled = true;
            this.cbReferee.Location = new System.Drawing.Point(338, 478);
            this.cbReferee.Name = "cbReferee";
            this.cbReferee.Size = new System.Drawing.Size(193, 28);
            this.cbReferee.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(556, 442);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Sức Chứa:";
            // 
            // txtCapacity
            // 
            this.txtCapacity.Location = new System.Drawing.Point(636, 439);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(90, 27);
            this.txtCapacity.TabIndex = 13;
            // 
            // cbVenue
            // 
            this.cbVenue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVenue.FormattingEnabled = true;
            this.cbVenue.Location = new System.Drawing.Point(338, 436);
            this.cbVenue.Name = "cbVenue";
            this.cbVenue.Size = new System.Drawing.Size(193, 28);
            this.cbVenue.TabIndex = 59;
            this.cbVenue.SelectedIndexChanged += new System.EventHandler(this.cbVenue_SelectedIndexChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(234, 526);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 61;
            this.label5.Text = "Vòng Đấu:";
            // 
            // cbStage
            // 
            this.cbStage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStage.FormattingEnabled = true;
            this.cbStage.Location = new System.Drawing.Point(338, 526);
            this.cbStage.Name = "cbStage";
            this.cbStage.Size = new System.Drawing.Size(193, 28);
            this.cbStage.TabIndex = 62;
            // 
            // FrmAddMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyGiaiDauBongDa.Properties.Resources._270901;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(904, 630);
            this.Controls.Add(this.cbStage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbVenue);
            this.Controls.Add(this.txtCapacity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbReferee);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cbGuest);
            this.Controls.Add(this.cbHost);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmAddMatch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddMatch";
            this.Load += new System.EventHandler(this.FrmAddMatch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ComboBox cbHost;
        private System.Windows.Forms.ComboBox cbGuest;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbReferee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.ComboBox cbVenue;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbStage;
    }
}