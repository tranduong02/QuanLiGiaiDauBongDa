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
    public partial class FrmEditClub : Form
    {
        public int club_id;
        public FrmEditClub(int id)
        {
            club_id = id;
            InitializeComponent();
        }
        QuanLyGiaiDauBongDaContext context = new QuanLyGiaiDauBongDaContext();

        private void labelNameClub_Click(object sender, EventArgs e)
        {


        }

        private void FrmEditClub_Load(object sender, EventArgs e)
        {
            var club = context.Clubs.Where(s => s.ClubId == club_id).FirstOrDefault();
            txtNameClub.Text = club.Name;
            txtYear.Text = club.YearCreated;
            txtAddress.Text = club.Address;
            txtCity.Text = club.City;
            cbStadium.DataSource = context.Stadia.ToList();
            cbStadium.DisplayMember = "Name";
            cbStadium.ValueMember = "StadiumId";
            cbStadium.SelectedValue = club.StadiumId;

            cbCountry.DataSource = context.Countries.ToList();
            cbCountry.DisplayMember = "Name";
            cbCountry.ValueMember = "CountryId";
            cbCountry.SelectedValue = club.CountryId;
            if (club.LogoUrl != null)
            {
                picLogo.BackgroundImage = Image.FromFile(@"..\..\..\Resources\" + club.LogoUrl);
            }
            else
            {
                picLogo.BackgroundImage = Image.FromFile(@"..\..\..\Resources\logo.png");
            }

            txtLogo2.Text = club.LogoUrl;
            txtYear.Text = club.YearCreated;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var club = context.Clubs.SingleOrDefault(s => s.ClubId == club_id);
            try
            {
                var result = MessageBox.Show("Are you want to update data?", "Thông Báo", MessageBoxButtons.OKCancel);
                if (club != null && result == DialogResult.OK)
                {
                    club.Name = txtNameClub.Text.ToUpper().Trim();
                    club.YearCreated = txtYear.Text.Trim();
                    club.Address = txtAddress.Text.Trim();
                    club.City = txtCity.Text.Trim();
                    club.StadiumId = (int)cbStadium.SelectedValue;
                    club.CountryId = (int)cbCountry.SelectedValue;
                    //club.LogoUrl = System.IO.Path.GetFileName(picLogo.ImageLocation);
                    club.LogoUrl = txtLogo2.Text.Trim();

                    context.Clubs.Update(club);
                    FrmDanhSachClub frmDanhSachClub = (FrmDanhSachClub)Application.OpenForms["FrmDanhSachClub"];
                    frmDanhSachClub.LoadList();
                    context.SaveChanges();
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                }
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo");
                throw;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                picLogo.Image = new Bitmap(opnfd.FileName);
                txtLogo2.Text = opnfd.SafeFileName;
            }
        }
    }
}
