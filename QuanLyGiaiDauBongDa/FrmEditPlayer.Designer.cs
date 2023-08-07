
namespace QuanLyGiaiDauBongDa
{
    partial class FrmEditPlayer
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
            this.label8 = new System.Windows.Forms.Label();
            this.txtAvatar = new System.Windows.Forms.TextBox();
            this.cbClub = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.avatarPlayer = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPlayerID = new System.Windows.Forms.TextBox();
            this.txtNamePlayer = new System.Windows.Forms.TextBox();
            this.labelNameClub = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.weight = new System.Windows.Forms.NumericUpDown();
            this.height = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.txtDob = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.height)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(40, 362);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 20);
            this.label8.TabIndex = 64;
            this.label8.Text = "Image";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtAvatar
            // 
            this.txtAvatar.Location = new System.Drawing.Point(100, 359);
            this.txtAvatar.Name = "txtAvatar";
            this.txtAvatar.Size = new System.Drawing.Size(155, 27);
            this.txtAvatar.TabIndex = 63;
            // 
            // cbClub
            // 
            this.cbClub.FormattingEnabled = true;
            this.cbClub.Location = new System.Drawing.Point(502, 251);
            this.cbClub.Name = "cbClub";
            this.cbClub.Size = new System.Drawing.Size(262, 28);
            this.cbClub.TabIndex = 62;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(657, 353);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 29);
            this.button3.TabIndex = 60;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(532, 353);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 29);
            this.button2.TabIndex = 59;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.avatarPlayer);
            this.panel1.Location = new System.Drawing.Point(36, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 209);
            this.panel1.TabIndex = 58;
            // 
            // avatarPlayer
            // 
            this.avatarPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.avatarPlayer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.avatarPlayer.Location = new System.Drawing.Point(3, 3);
            this.avatarPlayer.Name = "avatarPlayer";
            this.avatarPlayer.Size = new System.Drawing.Size(215, 201);
            this.avatarPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatarPlayer.TabIndex = 43;
            this.avatarPlayer.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(88, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 29);
            this.button1.TabIndex = 57;
            this.button1.Text = "Import Image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPlayerID
            // 
            this.txtPlayerID.Location = new System.Drawing.Point(502, 83);
            this.txtPlayerID.Name = "txtPlayerID";
            this.txtPlayerID.ReadOnly = true;
            this.txtPlayerID.Size = new System.Drawing.Size(262, 27);
            this.txtPlayerID.TabIndex = 56;
            // 
            // txtNamePlayer
            // 
            this.txtNamePlayer.Location = new System.Drawing.Point(502, 119);
            this.txtNamePlayer.Name = "txtNamePlayer";
            this.txtNamePlayer.Size = new System.Drawing.Size(262, 27);
            this.txtNamePlayer.TabIndex = 53;
            // 
            // labelNameClub
            // 
            this.labelNameClub.AutoSize = true;
            this.labelNameClub.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNameClub.Location = new System.Drawing.Point(352, 86);
            this.labelNameClub.Name = "labelNameClub";
            this.labelNameClub.Size = new System.Drawing.Size(55, 20);
            this.labelNameClub.TabIndex = 52;
            this.labelNameClub.Text = "Mã ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(352, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 51;
            this.label6.Text = "Club:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(352, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 20);
            this.label5.TabIndex = 50;
            this.label5.Text = "Chiều Cao (cm):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(352, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 49;
            this.label4.Text = "Cân Nặng (kg):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(352, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 48;
            this.label3.Text = "Năm Sinh:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(352, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "Tên Cầu Thủ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(352, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 46;
            // 
            // weight
            // 
            this.weight.Location = new System.Drawing.Point(502, 185);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(150, 27);
            this.weight.TabIndex = 66;
            // 
            // height
            // 
            this.height.Location = new System.Drawing.Point(502, 218);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(150, 27);
            this.height.TabIndex = 67;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(352, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 68;
            this.label7.Text = "Vị Trí:";
            // 
            // cbPosition
            // 
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.Location = new System.Drawing.Point(502, 293);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(262, 28);
            this.cbPosition.TabIndex = 69;
            // 
            // txtDob
            // 
            this.txtDob.Location = new System.Drawing.Point(502, 155);
            this.txtDob.Name = "txtDob";
            this.txtDob.Size = new System.Drawing.Size(262, 27);
            this.txtDob.TabIndex = 71;
            // 
            // FrmEditPlayer
            // 
            this.AcceptButton = this.button2;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDob);
            this.Controls.Add(this.cbPosition);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.height);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAvatar);
            this.Controls.Add(this.cbClub);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPlayerID);
            this.Controls.Add(this.txtNamePlayer);
            this.Controls.Add(this.labelNameClub);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmEditPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEditPlayer";
            this.Load += new System.EventHandler(this.FrmEditPlayer_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.avatarPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.height)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAvatar;
        private System.Windows.Forms.ComboBox cbClub;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox avatarPlayer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPlayerID;
        private System.Windows.Forms.TextBox txtNamePlayer;
        private System.Windows.Forms.Label labelNameClub;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown weight;
        private System.Windows.Forms.NumericUpDown height;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbPosition;
        private System.Windows.Forms.TextBox txtDob;
    }
}