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
    public partial class FrmAddGoal : Form
    {
        QuanLyGiaiDauBongDaContext context = new QuanLyGiaiDauBongDaContext();
        Match match = new();
        public FrmAddGoal(Match match)
        {
            InitializeComponent();
            this.match = match;
        }

        private void FrmAddGoal_Load(object sender, EventArgs e)
        {
            try
            {
                match.Host = context.Clubs.SingleOrDefault(c => c.ClubId == match.HostId);
                match.Guest = context.Clubs.SingleOrDefault(c => c.ClubId == match.GuestId);
                cbClub.DataSource = new List<Club>() { match.Host, match.Guest };
                cbClub.SelectedValueChanged += delegate (object sender, EventArgs e) { cbClub_SelectedValueChanged(this, e, cbClub.SelectedIndex); };
                LoadForm(match.HostId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadForm(int index)
        {

            cbClub.ValueMember = "ClubId";
            cbClub.DisplayMember = "Name";
            cbPlayer.Text = "";
            cbPlayer.DataSource = (from p in context.Teams
                                   where p.MatchId == match.MatchId && p.Player.ClubId ==int.Parse(cbClub.SelectedValue.ToString())
                                   select new { p.PlayerId, p.Player.Name, p.Player.PositionId, p.Starting }).ToList();
            cbPlayer.DisplayMember = "Name";
            cbPlayer.ValueMember = "PlayerId";
        }

        private void cbClub_SelectedValueChanged(object sender, EventArgs e, int index)
        {
            try
            {
                LoadForm(index);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                context.Goals.Add(new Goal()
                {
                    MatchId = match.MatchId,
                    PlayerId = int.Parse(cbPlayer.SelectedValue.ToString()),
                    GoalTime = int.Parse(txtTime.Text.Trim())
                });
                if (context.SaveChanges() > 0)
                {
                    MessageBox.Show("Add goal Successful");
                    this.Close();
                } else
                {
                    MessageBox.Show("Add failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
