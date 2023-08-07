
namespace QuanLyGiaiDauBongDa
{
    partial class FrmSettingAccount
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.dateTimePickerDOB = new System.Windows.Forms.DateTimePicker();
            this.labelFname = new System.Windows.Forms.Label();
            this.labelDOB = new System.Windows.Forms.Label();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.dateTimePickerDOB);
            this.panel1.Controls.Add(this.labelFname);
            this.panel1.Controls.Add(this.labelDOB);
            this.panel1.Controls.Add(this.txtFname);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(76, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(643, 416);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(250, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 20);
            this.label4.TabIndex = 48;
            this.label4.Text = "Thông Tin Cá Nhân";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(466, 326);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 46;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(353, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 45;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(198, 335);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(103, 20);
            this.linkLabel1.TabIndex = 43;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Xóa Tài Khoản";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // dateTimePickerDOB
            // 
            this.dateTimePickerDOB.Location = new System.Drawing.Point(270, 220);
            this.dateTimePickerDOB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePickerDOB.Name = "dateTimePickerDOB";
            this.dateTimePickerDOB.Size = new System.Drawing.Size(251, 27);
            this.dateTimePickerDOB.TabIndex = 42;
            // 
            // labelFname
            // 
            this.labelFname.AccessibleName = "label1";
            this.labelFname.BackColor = System.Drawing.SystemColors.Control;
            this.labelFname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFname.Location = new System.Drawing.Point(112, 161);
            this.labelFname.Name = "labelFname";
            this.labelFname.Padding = new System.Windows.Forms.Padding(5);
            this.labelFname.Size = new System.Drawing.Size(141, 31);
            this.labelFname.TabIndex = 39;
            this.labelFname.Text = "Tên đầy đủ:";
            // 
            // labelDOB
            // 
            this.labelDOB.AccessibleName = "label1";
            this.labelDOB.BackColor = System.Drawing.SystemColors.Control;
            this.labelDOB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDOB.Location = new System.Drawing.Point(112, 216);
            this.labelDOB.Name = "labelDOB";
            this.labelDOB.Padding = new System.Windows.Forms.Padding(5);
            this.labelDOB.Size = new System.Drawing.Size(142, 31);
            this.labelDOB.TabIndex = 38;
            this.labelDOB.Text = "Ngày sinh:";
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(269, 165);
            this.txtFname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(252, 27);
            this.txtFname.TabIndex = 37;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(270, 119);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(252, 27);
            this.txtPassword.TabIndex = 33;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(269, 268);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(252, 27);
            this.txtEmail.TabIndex = 32;
            // 
            // txtUsername
            // 
            this.txtUsername.Enabled = false;
            this.txtUsername.Location = new System.Drawing.Point(271, 77);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = true;
            this.txtUsername.Size = new System.Drawing.Size(252, 27);
            this.txtUsername.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AccessibleName = "label1";
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(112, 119);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5);
            this.label3.Size = new System.Drawing.Size(141, 31);
            this.label3.TabIndex = 29;
            this.label3.Text = "Mật khẩu:";
            // 
            // label2
            // 
            this.label2.AccessibleName = "label1";
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(113, 264);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5);
            this.label2.Size = new System.Drawing.Size(141, 31);
            this.label2.TabIndex = 28;
            this.label2.Text = "Email:";
            // 
            // label1
            // 
            this.label1.AccessibleName = "label1";
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(112, 77);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(141, 31);
            this.label1.TabIndex = 27;
            this.label1.Text = "Tên Đăng Nhập:";
            // 
            // FrmSettingAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyGiaiDauBongDa.Properties.Resources.football_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(809, 537);
            this.Controls.Add(this.panel1);
            this.Name = "FrmSettingAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSettingAccount";
            this.Load += new System.EventHandler(this.FrmSettingAccount_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePickerDOB;
        private System.Windows.Forms.Label labelFname;
        private System.Windows.Forms.Label labelDOB;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}