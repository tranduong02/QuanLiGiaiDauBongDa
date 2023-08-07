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
    public partial class FrmAddMatch : Form
    {
        QuanLyGiaiDauBongDaContext context = new QuanLyGiaiDauBongDaContext();
        public FrmAddMatch()
        {
            InitializeComponent();
        }
        class Play_Stage
        {
            public string key { get; set; }
            public string value { get; set; }
        }

        private void Loadmatch()
        {
            context = new QuanLyGiaiDauBongDaContext();

            cbGuest.DataSource = context.Clubs.ToList();
            cbGuest.DisplayMember = "Name";
            cbGuest.ValueMember = "Name";
            cbGuest.SelectedIndex = -1;

            cbHost.DataSource = context.Clubs.ToList();
            cbHost.DisplayMember = "Name";
            cbHost.ValueMember = "Name";
            cbHost.SelectedIndex = -1;

            cbVenue.DataSource = context.Venues.ToList();
            cbVenue.DisplayMember = "Name";
            cbVenue.ValueMember = "VenueId";
            cbHost.SelectedIndex = 1;

            cbReferee.DataSource = context.Referees.ToList();
            cbReferee.DisplayMember = "RefereeName";
            cbReferee.ValueMember = "RefereeId";

            //Note: play_stage – this indicates that in which stage a match is going on,
            //i.e.G for Group stage, R for Round of 16 stage, Q for Quarter final stage,
            //S for Semi Final stage, and F for Final

            Dictionary<string, string> list = new Dictionary<string, string>();

            var play_stages = new List<Play_Stage>()
      {
        new Play_Stage() { key = "G", value = "Vòng Bảng" },
        new Play_Stage() { key = "R", value = "Vòng Loại 16 trận" },
        new Play_Stage() { key = "Q", value = "Tứ Kết" },
        new Play_Stage() { key = "S", value = "Bán Kết" },
        new Play_Stage() { key = "F", value = "Chung Kết" },
      };

            cbStage.DataSource = play_stages;
            cbStage.ValueMember = "key";
            cbStage.DisplayMember = "value";
            cbStage.SelectedIndex = 0;

        }
        private void FrmAddMatch_Load(object sender, EventArgs e)
        {
            try
            {
                Loadmatch();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbVenue_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCapacity.Text = "Hello";
        }

        private void cbVenue_SelectedIndexChanged_1(object sender, EventArgs e)
        {


        }

        private void cbHost_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbHost.SelectedIndex != -1)
            {
                string x = cbHost.SelectedValue.ToString();
                foreach (var item in context.Clubs.ToList())
                {
                    if (x == item.Name && item.LogoUrl != null)
                    {
                        pictureBox1.Image = Image.FromFile(@"..\..\..\Resources\" + item.LogoUrl);

                    }
                }
            }

        }

        private void cbGuest_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGuest.SelectedIndex != -1)
            {
                string x = cbGuest.SelectedValue.ToString();
                foreach (var item in context.Clubs.ToList())
                {
                    if (x == item.Name && item.LogoUrl != null)
                    {
                        pic2.Image = Image.FromFile(@"..\..\..\Resources\" + item.LogoUrl);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var x = MessageBox.Show("Are you sure want to create?", "Warning", MessageBoxButtons.YesNo);
                if (x == DialogResult.Yes)
                {
                    int host_id = context.Clubs.FirstOrDefault(s => s.Name == cbHost.SelectedValue.ToString()).ClubId;
                    int guest_id = context.Clubs.FirstOrDefault(s => s.Name == cbGuest.SelectedValue.ToString()).ClubId;
                    Match match = new Match();
                    match.PlayDate = DateTime.Parse(dateTimePicker1.Value.ToString());
                    match.HostId = host_id;
                    match.GuestId = guest_id;

                    match.RefereeId = int.Parse(cbReferee.SelectedValue.ToString());
                    match.VenueId = int.Parse(cbVenue.SelectedValue.ToString());
                    match.PlayStage = cbStage.SelectedValue.ToString();
                    context.Matches.Add(match);
                    context.SaveChanges();
                    MessageBox.Show("Create Successful!");

                    FrmLichThiDau frmLichThiDau = (FrmLichThiDau)Application.OpenForms["FrmLichThiDau"];
                    frmLichThiDau.LoadMatch();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}
