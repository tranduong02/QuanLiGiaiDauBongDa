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
    public partial class FrmAddReferee : Form
    {
        QuanLyGiaiDauBongDaContext context = new QuanLyGiaiDauBongDaContext();
        public FrmAddReferee()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAddReferee_Load(object sender, EventArgs e)
        {
            cbCountry.DataSource = context.Countries.ToList();
            cbCountry.DisplayMember = "Name";
            cbCountry.ValueMember = "CountryId";
            cbCountry.SelectedItem = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var x = MessageBox.Show("Are you sure want to create?", "Warning", MessageBoxButtons.YesNo);
            if (x == DialogResult.Yes)
            {
                Referee referee = new Referee();
                referee.RefereeName = txtNameReferee.Text.Trim();
                referee.CountryId = int.Parse(cbCountry.SelectedIndex.ToString());
                referee.YearStarted = int.Parse(txtYearWork.Text.Trim());
                referee.Dob = dtpDob.Value;
                referee.Image = txtImage.Text.Trim();
                context.Referees.Add(referee);
                context.SaveChanges();
                MessageBox.Show("Create Successful!");
                FrmDanhSachTrongTai frmDanhSachTrongTai = (FrmDanhSachTrongTai)Application.OpenForms["FrmDanhSachTrongTai"];
                frmDanhSachTrongTai.Loading();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(opnfd.FileName);
                txtImage.Text = opnfd.SafeFileName;
            }
        }
    }
}
