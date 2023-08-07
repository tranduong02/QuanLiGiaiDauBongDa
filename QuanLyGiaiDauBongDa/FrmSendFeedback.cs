using QuanLyGiaiDauBongDa.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyGiaiDauBongDa
{
    public partial class FrmSendFeedback : Form
    {
        public FrmSendFeedback()
        {
            InitializeComponent();
        }
        string userName;
        QuanLyGiaiDauBongDaContext db = new QuanLyGiaiDauBongDaContext();
        public FrmSendFeedback(string username) : this()
        {
            userName = username;
            
        }
        private bool ValidateInfomation()
        {
            string mess = "";
            if (txtContent.Text.Trim().Equals("") || txtSubject.Text.Trim().Equals(""))
            {
                mess += "Bạn phải nhập đầy đủ thông tin";
            }
            else if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked && !radioButton5.Checked)
            {
                mess += "Hãy đánh giá app !";
            }
           
            if (mess.Equals(""))
                return true;
            else
            {
                MessageBox.Show(mess, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
           if(ValidateInfomation())
            {
                Rate rate = new Rate();
                if (radioButton1.Checked)
                {
                    rate.RateId = 5;
                }else if (radioButton2.Checked)
                {
                    rate.RateId = 4;
                }
                else if (radioButton3.Checked)
                {
                    rate.RateId = 3;
                }
                else if (radioButton4.Checked)
                {
                    rate.RateId = 2;
                }
                else if (radioButton1.Checked)
                {
                    rate.RateId = 1;
                }
                var accounts = (from account in db.Accounts select new { account.Username, account.Password }).ToList();
                Feedback feedback = new Feedback();
                foreach (var acc in accounts)
                {
                    if (acc.Username.Equals(userName))
                    {
                        feedback.Username = acc.Username;
                    }

                }
                feedback.RateId = rate.RateId;
                feedback.Problem = txtSubject.Text.Trim();
                feedback.Content = txtContent.Text.Trim();

                try
                {
                    db.Feedbacks.Add(feedback);
                    int count = db.SaveChanges();
                    if (count > 0)
                    {
                        MessageBox.Show("Cảm ơn đánh giá của bạn !");
                        txtContent.Text = "";
                        txtSubject.Text = "";
                        radioButton1.Checked = true;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;
                        radioButton5.Checked = false;
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
               
            }
        }

        private void FrmSendFeedback_Load(object sender, EventArgs e)
        {
            labelUsername.Text = userName;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
        }
    }
}
