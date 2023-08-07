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
    public partial class FrmAddClub : Form
    {
        public FrmAddClub()
        {
            InitializeComponent();
        }

        QuanLyGiaiDauBongDaContext context = new QuanLyGiaiDauBongDaContext();


        private void FrmAddClub_Load(object sender, EventArgs e)
        {
            cbStadium.DataSource = context.Stadia.ToList();
            cbStadium.DisplayMember = "Name";
            cbStadium.ValueMember = "StadiumId";

            cbCountry.DataSource = context.Countries.ToList();
            cbCountry.DisplayMember = "Name";
            cbCountry.ValueMember = "CountryId";
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                var result = MessageBox.Show("Are you want to add data?", "Thông Báo", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    Club club = new Club()
                    {
                        Name = txtNameClub.Text.ToUpper().Trim(),
                        YearCreated = txtYear.Text.Trim(),
                        Address = txtAddress.Text.Trim(),
                        City = txtCity.Text.Trim(),
                        StadiumId = (int)cbStadium.SelectedValue,
                        CountryId = (int)cbCountry.SelectedValue,
                        LogoUrl = txtFileName.Text,
                    };
                    context.Clubs.Add(club);
                    context.SaveChanges();
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                }
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                picLogo.Image = new Bitmap(opnfd.FileName);
                txtFileName.Text = opnfd.SafeFileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
