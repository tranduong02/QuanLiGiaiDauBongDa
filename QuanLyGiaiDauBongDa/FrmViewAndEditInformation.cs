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
    public partial class FrmViewAndEditInformation : Form
    {
        int clubid;
        public FrmViewAndEditInformation(int clubid)
        {
            InitializeComponent();
            this.clubid = clubid;
        }

        QuanLyGiaiDauBongDaContext context = new QuanLyGiaiDauBongDaContext();

        private void loadList()
        {
            //dgv3.DataSource = context.Ranking2s.ToList();
            dgv4.DataSource = context.Players.ToList();

            var Club = (from c in context.Clubs
                        select new
                        {
                            c.ClubId,
                            c.Name,
                            c.YearCreated,
                            CountryName = c.Country.Name,
                            c.City,
                            c.Address,
                            StadiumName = c.Stadium.Name,
                            c.LogoUrl
                        }).ToList();
            txtClub.DataBindings.Clear();
            txtName.DataBindings.Clear();
            txtYearCreate.DataBindings.Clear();
            txtCountry.DataBindings.Clear();
            txtCity.DataBindings.Clear();
            txtAdress.DataBindings.Clear();
            txtStadium.DataBindings.Clear();
            txtLogoURL.DataBindings.Clear();
            txtClub.DataBindings.Add("Text", Club, "ClubId");
            txtName.DataBindings.Add("Text", Club, "Name");
            txtYearCreate.DataBindings.Add("Text", Club, "YearCreated");
            txtCountry.DataBindings.Add("Text", Club, "CountryName");
            txtCity.DataBindings.Add("Text", Club, "City");
            txtAdress.DataBindings.Add("Text", Club, "Address");
            txtStadium.DataBindings.Add("Text", Club, "StadiumName");
            //txtLogoURL.DataBindings.Add("Text", Club, "LogoUrl");
            dgvClub.DataSource = Club;
             
            var Rank = (from c in context.Ranking2s
                        select new
                        {
                            c.ClubId,
                            c.ClubName,
                            c.Played,
                            c.Won,
                            c.Drawn,
                            c.Lost,
                            c.Gd,
                            c.Point
                        }).ToList();
            textBox9.DataBindings.Clear();
            textBox10.DataBindings.Clear();
            textBox11.DataBindings.Clear();
            textBox12.DataBindings.Clear();
            textBox13.DataBindings.Clear();
            textBox14.DataBindings.Clear();
            textBox15.DataBindings.Clear();
            textBox16.DataBindings.Clear();

            
            textBox10.DataBindings.Add("Text", Rank, "ClubID");
            textBox11.DataBindings.Add("Text", Rank, "ClubName");
            textBox12.DataBindings.Add("Text", Rank, "Played");
            textBox13.DataBindings.Add("Text", Rank, "Won");
            textBox14.DataBindings.Add("Text", Rank, "Drawn");
            textBox15.DataBindings.Add("Text", Rank, "Lost");
            textBox16.DataBindings.Add("Text", Rank, "GD");
            textBox9.DataBindings.Add("Text", Rank, "Point");
            
            dgv3.DataSource = Rank;

     }

        private void FrmViewAndEditInformation_Load(object sender, EventArgs e)
        {
            try
            {
                loadList();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDELETE_Click(object sender, EventArgs e)
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
                        loadList();
                    }
                }      
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }


        //private void btnEDIT_Click(object sender, EventArgs e)
        //{
        //    var club = (context.Clubs.SingleOrDefault(c => c.ClubId == Convert.ToInt32(txtClub.Text)));
        //    FrmEditClub frmEditClub = new FrmEditClub(c);
        //    this.Hide();
        //    if (frmEditClub.ShowDialog() == System.Windows.Forms.DialogResult.OK)
        //    {
        //        dgvClub.Refresh();
        //        loadList();
        //    }
        //    this.Show();
        //}

        

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

     

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            FrmAddClub frmAddClub = new FrmAddClub();
            this.Hide();
            if (frmAddClub.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                dgvClub.Refresh();
                loadList();
            }
            this.Show();
        }

        private void btnTHOAT_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmLichThiDauChoClub club = new FrmLichThiDauChoClub(context.Clubs.SingleOrDefault(c => c.ClubId == clubid));
            this.Hide();
            club.ShowDialog();
            this.Show();
        }
    }
}
