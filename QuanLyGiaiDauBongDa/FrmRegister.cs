

using QuanLyGiaiDauBongDa.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyGiaiDauBongDa
{
    public partial class FrmRegister : Form
    {
        QuanLyGiaiDauBongDaContext _db = new QuanLyGiaiDauBongDaContext();
        public FrmRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (ValidateInfomation())
            {
                bool isExist = CheckExistAccount();
                if (isExist)
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Account account = new Account()
                    {
                        Username = txtUsername.Text.Trim(),
                        FullName = txtFname.Text.Trim(),
                        Email = txtEmail.Text.Trim(),
                        Password = txtPassword.Text,
                        Dob = dateTimePickerDOB.Value
                    };

                    RoleAccount roll_acc = new RoleAccount { Username = txtUsername.Text.Trim(), RoleId = 2 };
                    try
                    {
                       
                           
                        _db.Accounts.Add(account);
                        _db.RoleAccounts.Add(roll_acc);
                        int count = _db.SaveChanges();

                        if (count > 0)
                        {
                            MessageBox.Show("Tạo tài khoản thành công");
                            this.Hide();
                            FrmLogin frmLogin = new FrmLogin();

                            frmLogin.ShowDialog();
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message, "Error");
                    }

                }
            }



        }

        private bool CheckExistAccount()
        {
            bool isExist = false;
            var account = (from a in _db.Accounts select new { a.Username }).ToList();
            foreach (var acc in account)
            {
                if (txtUsername.Text.Trim().Equals(acc.Username))
                {
                    isExist = true;
                }
            }
            return isExist;
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            this.Hide();
            frmLogin.ShowDialog();
        }
        private bool ValidateInfomation()
        {
            string mess = "";
            if (txtUsername.Text.Trim().Equals("") || txtPassword.Text.Trim().Equals("") || txtEmail.Text.Trim().Equals("") || txtConfirmPassword.Text.Trim().Equals("") || txtFname.Text.Trim().Equals(""))
            {
                mess += "Bạn phải nhập đầy đủ thông tin";
            }
            else if (!Regex.IsMatch(txtUsername.Text.Trim(), "^[A-Za-z0-9]+$"))
            {
                mess += "Tên đăng nhập không được chứa kí tự đặc biệt";
            }
            else if (!Regex.IsMatch(txtPassword.Text, "^[A-Za-z0-9]{6,32}$"))
            {
                mess += "Mật khẩu phải có độ dài từ 6 đến 32 kí tự và không chứa kí tự đặc biệt";
            }
            else if (!txtPassword.Text.Equals(txtConfirmPassword.Text))
            {
                mess += "Xác nhận mật khẩu không trùng với mật khẩu";
            }
            else if (!Regex.IsMatch(txtEmail.Text.Trim(), @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" + @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" + @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"))
            {
                mess += "Email không hợp lệ ";
            }
            else if (CheckCaptcha(txtCaptcha.Text.Trim(), Captcha.Trim()) == false)
            {
                mess += "Captcha không đúng";
            }
            if (mess.Equals(""))
                return true;
            else
            {
                MessageBox.Show(mess, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public string Captcha;
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
        public void verifyEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            string captcha = CreateCaptcha();
            Captcha = captcha;
            bool isSend = Send(txtEmail.Text.Trim(), "Lấy mã captcha để verify tài khoản của bạn", "Mã captcha của bạn là: " + captcha);
            if (isSend)
            {
                MessageBox.Show("Một email chứa captcha đã gửi vào tài khoản của bạn !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



        }
        public bool CheckCaptcha(string txt, string captcha)
        {
            bool isMatchCaptcha;

            if (txt.Trim().Equals(captcha.Trim()))
            {
                isMatchCaptcha = true;
            }
            else { isMatchCaptcha = false; }
            return isMatchCaptcha;
        }


        public bool Send(string sendto, string subject, string content)
        {
            bool isSend;
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
                isSend = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isSend = false;
            }
            return isSend;
        }
    }
}

