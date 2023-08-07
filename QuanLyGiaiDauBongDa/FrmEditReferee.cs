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
    public partial class FrmEditReferee : Form
    {
        QuanLyGiaiDauBongDaContext context = new QuanLyGiaiDauBongDaContext();
        public int referee_id;
        public FrmEditReferee(int id)
        {
            referee_id = id;
            InitializeComponent();
        }

        private void FrmEditReferee_Load(object sender, EventArgs e)
        {
            var referee = context.Referees.Where(s => s.RefereeId == referee_id).FirstOrDefault();
            txtRefereeID.Text = referee.RefereeId.ToString();
            txtNameReferee.Text = referee.RefereeName.ToString();
            cbCountry.DataSource = context.Countries.ToList();
            cbCountry.DisplayMember = "Name";
            cbCountry.ValueMember = "CountryId";
            cbCountry.SelectedValue = referee.CountryId;
            if(referee.YearStarted != null)
            {
                txtYearWork.Text = (DateTime.Now.Year - (int)referee.YearStarted).ToString();
            }
            dtpDob.Value = DateTime.Parse(referee.Dob.ToString());

            if (referee.Image != null)
            {
                avatarReferee.BackgroundImage = Image.FromFile(@"..\..\..\Resources\" + referee.Image);
            }
            else
            {
                avatarReferee.BackgroundImage = Image.FromFile(@"..\..\..\Resources\logo.png");
            }

            txtAvatar.Text = referee.Image;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                avatarReferee.Image = new Bitmap(opnfd.FileName);
                txtAvatar.Text = opnfd.SafeFileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var referee = context.Referees.SingleOrDefault(s => s.RefereeId == referee_id);
            try
            {
                var result = MessageBox.Show("Are you want to update data?", "Thông Báo", MessageBoxButtons.OKCancel);
                if (referee != null && result == DialogResult.OK)
                {
                    referee.RefereeName = txtNameReferee.Text.Trim();
                    referee.Dob = dtpDob.Value;
                    referee.CountryId = int.Parse(cbCountry.SelectedValue.ToString());
                    referee.YearStarted = int.Parse(txtYearWork.Text.Trim().ToString());

                    referee.Image = txtAvatar.Text.Trim();
                    context.Referees.Update(referee);
                    context.SaveChanges();
                    MessageBox.Show("Update Successful!");
                    FrmDanhSachTrongTai frmDanhSachTrongTai = (FrmDanhSachTrongTai)Application.OpenForms["FrmDanhSachTrongTai"];
                    frmDanhSachTrongTai.Loading();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo");
                throw;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var referee = context.Referees.SingleOrDefault(s => s.RefereeId == referee_id);
            try
            {
                var result = MessageBox.Show("Are you want to delete data?", "Thông Báo", MessageBoxButtons.OKCancel);
                if (referee != null && result == DialogResult.OK)
                {
                    context.Referees.Remove(referee);
                    context.SaveChanges();
                    MessageBox.Show("Delete Successful!");
                    FrmDanhSachTrongTai frmDanhSachTrongTai = (FrmDanhSachTrongTai)Application.OpenForms["FrmDanhSachTrongTai"];
                    frmDanhSachTrongTai.Loading();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo");
                throw;
            }
        }
    }
}
