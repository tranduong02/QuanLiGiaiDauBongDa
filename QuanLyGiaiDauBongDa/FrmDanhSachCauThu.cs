using Microsoft.EntityFrameworkCore;
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
    public partial class FrmDanhSachCauThu : Form
    {
        QuanLyGiaiDauBongDaContext context = new QuanLyGiaiDauBongDaContext();

        public FrmDanhSachCauThu()
        {
            InitializeComponent();
        }
        public void LoadPlayer()
        {
            context = new QuanLyGiaiDauBongDaContext();
            var players = (from s in context.Players.ToList()
                           join k in context.Clubs.ToList() on s.ClubId equals k.ClubId
                           select new
                           {
                               s.PlayerId,
                               s.Name,
                               Dob = s.Dob,
                               s.Height,
                               s.Weight,
                               s.PositionId,
                               Club = k.Name,
                               s.Image
                           }
                           ).ToList();

            label6.DataBindings.Clear();
            label7.DataBindings.Clear();
            label8.DataBindings.Clear();
            label9.DataBindings.Clear();
            label10.DataBindings.Clear();
            label12.DataBindings.Clear();

            avatarPlayer.BackgroundImage = Image.FromFile(@"..\..\..\Resources\a1.jpg");
            dgvPlayer.DataSource = players;

            dgvPlayer.Update();
            dgvPlayer.Refresh();
        }

        private void FrmDanhSachCauThu_Load(object sender, EventArgs e)
        {
            LoadPlayer();
        }

        private void dgvPlayer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label6.Text = dgvPlayer.CurrentRow.Cells["Name"].Value.ToString();
            label7.Text = dgvPlayer.CurrentRow.Cells["PositionId"].Value.ToString();
            label8.Text = dgvPlayer.CurrentRow.Cells["Height"].Value.ToString() + " cm";
            label9.Text = dgvPlayer.CurrentRow.Cells["Weight"].Value.ToString() + " kg";
            label10.Text = dgvPlayer.CurrentRow.Cells["Club"].Value.ToString();
            label12.Text = dgvPlayer.CurrentRow.Cells["Dob"].Value.ToString();

            if (dgvPlayer.CurrentRow.Cells["Image"].Value != null && dgvPlayer.CurrentRow.Cells["Image"].Value != "")
            {
                avatarPlayer.BackgroundImage = Image.FromFile(@"..\..\..\Resources\" + dgvPlayer.CurrentRow.Cells["Image"].Value.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var player = context.Players.SingleOrDefault(s => s.PlayerId == (int)dgvPlayer.CurrentRow.Cells["PlayerId"].Value);
                if (MessageBox.Show("Are you want to delete?", "Thông báo?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    context.Players.Remove(player);
                    int count = context.SaveChanges();
                    if (count > 0)
                    {
                        MessageBox.Show("Delete success");
                    }
                }
                LoadPlayer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var player_id = (int)dgvPlayer.CurrentRow.Cells["PLayerID"].Value;
            FrmEditPlayer frmEditPlayer = new FrmEditPlayer(player_id);
            this.Hide();
            if (frmEditPlayer.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                dgvPlayer.Refresh();
                this.LoadPlayer();
            }
            this.Show();
        }

        private void dgvPlayer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
