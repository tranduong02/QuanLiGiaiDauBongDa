
namespace QuanLyGiaiDauBongDa
{
    partial class FrmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegister));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.linkLogin = new System.Windows.Forms.LinkLabel();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.labelDOB = new System.Windows.Forms.Label();
            this.labelFname = new System.Windows.Forms.Label();
            this.verifyEmail = new System.Windows.Forms.LinkLabel();
            this.txtCaptcha = new System.Windows.Forms.TextBox();
            this.dateTimePickerDOB = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(217, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(382, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AccessibleName = "label1";
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(217, 149);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(4);
            this.label1.Size = new System.Drawing.Size(123, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tên Đăng Nhập:";
            // 
            // label2
            // 
            this.label2.AccessibleName = "label1";
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(217, 311);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(4);
            this.label2.Size = new System.Drawing.Size(123, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AccessibleName = "label1";
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(217, 181);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(4);
            this.label3.Size = new System.Drawing.Size(123, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Mật khẩu:";
            // 
            // label4
            // 
            this.label4.AccessibleName = "label1";
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(217, 214);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(4);
            this.label4.Size = new System.Drawing.Size(123, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Xác nhận mật khẩu:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(356, 149);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(221, 23);
            this.txtUsername.TabIndex = 12;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(354, 311);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(221, 23);
            this.txtEmail.TabIndex = 13;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(355, 181);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(221, 23);
            this.txtPassword.TabIndex = 14;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(356, 214);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(221, 23);
            this.txtConfirmPassword.TabIndex = 15;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(502, 377);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 16;
            this.btnRegister.Text = "Đăng ký";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // linkLogin
            // 
            this.linkLogin.AutoSize = true;
            this.linkLogin.Location = new System.Drawing.Point(363, 403);
            this.linkLogin.Name = "linkLogin";
            this.linkLogin.Size = new System.Drawing.Size(214, 15);
            this.linkLogin.TabIndex = 17;
            this.linkLogin.TabStop = true;
            this.linkLogin.Text = "Already have an account? Back to login";
            this.linkLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLogin_LinkClicked);
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(355, 246);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(221, 23);
            this.txtFname.TabIndex = 19;
            // 
            // labelDOB
            // 
            this.labelDOB.AccessibleName = "label1";
            this.labelDOB.BackColor = System.Drawing.SystemColors.Control;
            this.labelDOB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDOB.Location = new System.Drawing.Point(216, 279);
            this.labelDOB.Name = "labelDOB";
            this.labelDOB.Padding = new System.Windows.Forms.Padding(4);
            this.labelDOB.Size = new System.Drawing.Size(124, 23);
            this.labelDOB.TabIndex = 21;
            this.labelDOB.Text = "Ngày sinh:";
            // 
            // labelFname
            // 
            this.labelFname.AccessibleName = "label1";
            this.labelFname.BackColor = System.Drawing.SystemColors.Control;
            this.labelFname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFname.Location = new System.Drawing.Point(217, 246);
            this.labelFname.Name = "labelFname";
            this.labelFname.Padding = new System.Windows.Forms.Padding(4);
            this.labelFname.Size = new System.Drawing.Size(123, 23);
            this.labelFname.TabIndex = 22;
            this.labelFname.Text = "Tên đầy đủ:";
            // 
            // verifyEmail
            // 
            this.verifyEmail.AutoSize = true;
            this.verifyEmail.Location = new System.Drawing.Point(581, 319);
            this.verifyEmail.Name = "verifyEmail";
            this.verifyEmail.Size = new System.Drawing.Size(45, 15);
            this.verifyEmail.TabIndex = 23;
            this.verifyEmail.TabStop = true;
            this.verifyEmail.Text = "Gửi mã";
            this.verifyEmail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.verifyEmail_LinkClicked);
            // 
            // txtCaptcha
            // 
            this.txtCaptcha.Location = new System.Drawing.Point(422, 340);
            this.txtCaptcha.Name = "txtCaptcha";
            this.txtCaptcha.Size = new System.Drawing.Size(85, 23);
            this.txtCaptcha.TabIndex = 24;
            // 
            // dateTimePickerDOB
            // 
            this.dateTimePickerDOB.Location = new System.Drawing.Point(355, 279);
            this.dateTimePickerDOB.Name = "dateTimePickerDOB";
            this.dateTimePickerDOB.Size = new System.Drawing.Size(220, 23);
            this.dateTimePickerDOB.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AccessibleName = "label1";
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(354, 340);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(4);
            this.label5.Size = new System.Drawing.Size(62, 23);
            this.label5.TabIndex = 26;
            this.label5.Text = "Captcha:";
            // 
            // FrmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyGiaiDauBongDa.Properties.Resources.LoginBackground1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePickerDOB);
            this.Controls.Add(this.txtCaptcha);
            this.Controls.Add(this.verifyEmail);
            this.Controls.Add(this.labelFname);
            this.Controls.Add(this.labelDOB);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.linkLogin);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmRegister";
            this.Text = "FrmRegister";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.LinkLabel linkLogin;
        private System.Windows.Forms.TextBox txtFname;
       
        private System.Windows.Forms.Label labelDOB;
        private System.Windows.Forms.Label labelFname;
        private System.Windows.Forms.LinkLabel verifyEmail;
        private System.Windows.Forms.TextBox txtCaptcha;
        private System.Windows.Forms.DateTimePicker dateTimePickerDOB;
        private System.Windows.Forms.Label label5;
    }
}