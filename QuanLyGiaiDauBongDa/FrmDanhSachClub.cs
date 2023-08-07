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
    public partial class FrmDanhSachClub : Form
    {
        public FrmDanhSachClub()
        {
            InitializeComponent();
        }
        QuanLyGiaiDauBongDaContext context = new QuanLyGiaiDauBongDaContext();

        public string search;
        public void LoadList()
        {
            //Select data clubs include country,  tables
            //var clubs = (context.Clubs
            //    .Include(x => x.Stadium).Include(y => y.Country)).ToList();
            context = new QuanLyGiaiDauBongDaContext();
            var clubs = (from s in context.Clubs.ToList()
                         join m in context.Countries on s.CountryId equals m.CountryId
                         join h in context.Stadia on s.StadiumId equals h.StadiumId
                         select new
                         {
                             s.ClubId,
                             s.Name,
                             s.YearCreated,
                             s.Address,
                             s.City,
                             CountryName = m.Name,
                             StadiumName = h.Name,
                             s.LogoUrl
                         }).ToList();

            if(search != "" && search != null)
            {
                clubs = clubs.FindAll(s => s.Name.ToLower().Contains(search.ToLower())).ToList();
            }

            label7.DataBindings.Clear();
            label8.DataBindings.Clear();
            label9.DataBindings.Clear();
            label10.DataBindings.Clear();
            label11.DataBindings.Clear();
            labelNameClub.DataBindings.Clear();
            label7.DataBindings.Add("Text", clubs, "YearCreated");
            label8.DataBindings.Add("Text", clubs, "Address");
            label9.DataBindings.Add("Text", clubs, "City");
            label10.DataBindings.Add("Text", clubs, "CountryName");
            label11.DataBindings.Add("Text", clubs, "StadiumName");
            labelNameClub.DataBindings.Add("Text", clubs, "Name");
            picLogo.BackgroundImage = Image.FromFile(@"..\..\..\Resources\mu.png");
            label8.AutoSize = true;
            label11.AutoSize = true;
            dgvClub.DataSource = clubs;

            dgvClub.Update();
            dgvClub.Refresh();

            txtTotalNumber.Text = clubs.Count.ToString();
        }

        private void FrmDanhSachDoiBong_Load(object sender, EventArgs e)
        {
            try
            {
                LoadList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var cub_id = (int)dgvClub.CurrentRow.Cells["ClubId"].Value;
            FrmEditClub frmEditClub = new FrmEditClub(cub_id);
            this.Hide();
            if (frmEditClub.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                dgvClub.Refresh();
                this.LoadList();
            }
            this.Show();
        }

        private void dgvClub_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvClub.CurrentRow.Cells["LogoUrl"].Value != null)
            {
                picLogo.BackgroundImage = Image.FromFile(@"..\..\..\Resources\" + dgvClub.CurrentRow.Cells["LogoUrl"].Value.ToString());
            }
        }

        private void txtTotalNumber_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var club = context.Clubs.SingleOrDefault(s => s.ClubId == (int)dgvClub.CurrentRow.Cells["ClubId"].Value);
                if (MessageBox.Show("Are you want to delete?", "Thông báo?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    context.Clubs.Remove(club);
                    int count = context.SaveChanges();
                    if (count > 0)
                    {
                        MessageBox.Show("Delete success");
                    }
                }
                LoadList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAddClub frmAddClub = new FrmAddClub();
            this.Hide();
            if (frmAddClub.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                dgvClub.Refresh();
                this.LoadList();
            }
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            search = txtSearch.Text.Trim();
            LoadList();
        }

        private void dgvClub_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
