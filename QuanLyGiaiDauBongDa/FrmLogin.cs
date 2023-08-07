
using QuanLyGiaiDauBongDa.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyGiaiDauBongDa
{
    public partial class FrmLogin : Form
    {
        QuanLyGiaiDauBongDaContext _db = new QuanLyGiaiDauBongDaContext();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            
        }

       

        private void btnLogin_Click(object sender, EventArgs e)
        {
            

            try
            {
                var accounts = (from a in _db.Accounts join b in _db.RoleAccounts on a.Username equals b.Username select new { a.Username, a.Password, b.RoleId, a.ClubId }).ToList();
                bool isLogin = false;
                int roleId = 2;
                int clubId = 0;
                foreach (var a in accounts)
                {
                    if (txtUsername.Text.Trim().Equals(a.Username) && txtPassword.Text.Trim().Equals(a.Password))
                    {
                        isLogin = true;
                        roleId = a.RoleId;
                        if (a.ClubId != null)
                        {
                            clubId = (int)a.ClubId;
                        }
                    }
                }
                if (isLogin) {
                    MessageBox.Show("Bạn đã đăng nhập thành công !", "Thông Báo", MessageBoxButtons.OK);
                    if (roleId == 1)
                    {
                        FrmHomePage h = new FrmHomePage(txtUsername.Text.Trim());
                        this.Hide();//ẩn form login
                        h.ShowDialog();
                    } else
                    {
                        FrmViewAndEditInformation vae = new FrmViewAndEditInformation(clubId);
                        this.Hide();
                        vae.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
          
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát chương trình?","Thông Báo",MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.Cancel)
            {
                e.Cancel = true;//cancel event e
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRegister frmRegister = new FrmRegister();
            this.Hide();
            frmRegister.ShowDialog();
           
        }
        public string CreateCaptcha()
        {
            const string characterArray = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            StringBuilder strCaptcha = new StringBuilder();
            Random rand = new Random();
            for (int i = 0; i < 7; i++)
            {

                string str = characterArray[rand.Next(characterArray.Length)].ToString();
                strCaptcha.Append(str);
            }
            return strCaptcha.ToString();
        }

        public void Send(string sendto, string subject, string content)
        {
            string _from = "slenderman9196@gmail.com";
            string _pass = "Yeuthuy111";
            //sendto: Email receiver (người nhận)
            //subject: Tiêu đề email
            //content: Nội dung của email
            //Nếu gửi email thành công, sẽ trả về kết quả: OK, không thành công sẽ trả về thông tin l�-i
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress(_from);
                mail.To.Add(sendto);
                mail.Subject = subject;
                mail.IsBodyHtml = true;
                mail.Body = content;

                mail.Priority = MailPriority.High;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential(_from, _pass);
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public string Captcha;
        private void linkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                var accounts = (from account in _db.Accounts select new { account.Username, account.Password,account.Email }).ToList();
                Account a = new Account();
                foreach (var acc in accounts)
                {
                    if (txtUsername.Text.Trim().Equals(acc.Username))
                    {
                        a.Email = acc.Email;
                    }

                }
                string captcha = CreateCaptcha();
                Captcha = captcha;
                Send(a.Email.Trim(), "Reset mật khẩu", "Mật khẩu mới của bạn là: " + captcha);
                MessageBox.Show("Một email mật khẩu mới đã được gửi vào email tài khoản của bạn !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var newAccount = _db.Accounts.SingleOrDefault(a => a.Username == txtUsername.Text.Trim());
               if(newAccount!=null)
                   
                    {
                    newAccount.Password = captcha;
                        int count = _db.SaveChanges();
                        if (count > 0)
                        {
                            MessageBox.Show("Reset mật khẩu thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Refresh();
                        }
                    }

                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
