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
    public partial class FrmSettingAccount : Form
    {
        QuanLyGiaiDauBongDaContext context = new QuanLyGiaiDauBongDaContext();
        string userName;
        Account account;
        public FrmSettingAccount(string username)
        {
            InitializeComponent();
            userName = username;
            account = context.Accounts.SingleOrDefault(s => s.Username == userName);

        }


        private void verifyEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void Loading()
        {

            txtUsername.Text = account.Username.ToString().Trim();
            txtFname.Text = account.FullName.Trim();
            txtEmail.Text = account.Email.Trim();
            txtPassword.Text = account.Password.Trim();
            dateTimePickerDOB.Value = DateTime.Parse(account.Dob.ToString());
            
        }

        private void FrmSettingAccount_Load(object sender, EventArgs e)
        {
            Loading();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var x = MessageBox.Show("Are you sure want to delete account?\nOnce deleted account cannot be recovered", "Warning", MessageBoxButtons.YesNo);
            if(x == DialogResult.Yes)
            {
                context.Accounts.Remove(account);
                context.SaveChanges();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var x = MessageBox.Show("Are you sure want to update?", "Warning", MessageBoxButtons.YesNo);
            if(x == DialogResult.Yes)
            {
                account.FullName = txtFname.Text.Trim();
                account.Email = txtEmail.Text.Trim();
                account.Password = txtPassword.Text.Trim();
                account.Dob = dateTimePickerDOB.Value;
                context.Accounts.Update(account);
                context.SaveChanges();
                Loading();
                MessageBox.Show("Update Successful!");
            }
        }
    }
}
