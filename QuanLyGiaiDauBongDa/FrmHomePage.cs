using QuanLyGiaiDauBongDa.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyGiaiDauBongDa
{
    public partial class FrmHomePage : Form
    {
        QuanLyGiaiDauBongDaContext context = new QuanLyGiaiDauBongDaContext();
        public FrmHomePage()
        {
            InitializeComponent();
        }
        string userName;
        public Account account;
        public FrmHomePage(string username): this()
        {
            userName = username;
            account = context.Accounts.FirstOrDefault(s => s.Username == userName);
        }
        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FrmHomePage_Load(object sender, EventArgs e)
        {
            label1.Text += account.FullName;
            txtTime.Text = DateTime.Now.ToShortDateString().ToString() + "\nThe weather is good today. Let's go outside!";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void ádToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmDanhSachTrongTai frmDanhSachTrongTai = new FrmDanhSachTrongTai();
            this.Hide();
            frmDanhSachTrongTai.ShowDialog();
            this.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
             
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmDanhSachClub frmDanhSachDoiBong = new FrmDanhSachClub();
            this.Hide();
            frmDanhSachDoiBong.ShowDialog();
            this.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
        }
        


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmLichThiDau FrmLichThiDau = new FrmLichThiDau();
            this.Hide();
            FrmLichThiDau.ShowDialog();
            this.Show();
        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            FrmAboutUs frmAboutUs = new FrmAboutUs(userName);
            this.Hide();
            frmAboutUs.ShowDialog();
            this.Show();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmBangXepHang frmBangXepHang = new FrmBangXepHang();
            this.Hide();
            frmBangXepHang.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmDanhSachCauThu frmDanhSachCauThu = new FrmDanhSachCauThu();
            this.Hide();
            frmDanhSachCauThu.ShowDialog();
            this.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FrmTheThucThamGia frmTheThucThamGia = new FrmTheThucThamGia();
            this.Hide();
            frmTheThucThamGia.ShowDialog();
            this.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmThongSoGiaiDau frmThongSoGiaiDau = new FrmThongSoGiaiDau();
            this.Hide();
            frmThongSoGiaiDau.ShowDialog();
            this.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmSettingAccount frmSettingAccount = new FrmSettingAccount(userName);
            this.Hide();
            frmSettingAccount.ShowDialog();
            this.Show();
        }
    }
}
