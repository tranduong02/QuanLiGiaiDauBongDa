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
    public partial class FrmXemDoiHinhThiDau : Form
    {
        QuanLyGiaiDauBongDaContext context = new QuanLyGiaiDauBongDaContext();
        Match match = new Match();
        public FrmXemDoiHinhThiDau(Match match)
        {
            InitializeComponent();
            this.match = match;
        }

        private void FrmXemDoiHinhThiDau_Load(object sender, EventArgs e)
        {
            try
            {
                cbClub.DataSource = new List<string>() { "Host", "Guest" };
                cbClub.SelectedValueChanged += delegate (object sender, EventArgs e) { cbClub_SelectedValueChanged(this, e, cbClub.SelectedIndex); };
                LoadDoiHinh(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadDoiHinh(int index)
        {
            match.Host = context.Clubs.SingleOrDefault(c => c.ClubId == match.HostId);
            match.Guest = context.Clubs.SingleOrDefault(c => c.ClubId == match.GuestId);
            lbDoiHinh.Text = "Đội Hình Thi Đấu:\n" + match.Host.Name + " vs " + match.Guest.Name + " Ngày: " + match.PlayDate.ToString();

            cbClub.SelectedIndex = index;
            if (cbClub.SelectedIndex == 0)
            {
                dgvDoiHinh.DataSource = (from p in context.Teams
                                         where p.MatchId == match.MatchId && p.Player.ClubId == match.HostId
                                         select new { p.PlayerId, p.Player.Name, p.Player.PositionId, p.Starting }).ToList();
            } else if (cbClub.SelectedIndex == 1)
            {
                dgvDoiHinh.DataSource = (from p in context.Teams
                                       where p.MatchId == match.MatchId && p.Player.ClubId == match.GuestId
                                       select new { p.PlayerId, p.Player.Name, p.Player.PositionId, p.Starting }).ToList();
            }

            dgvDoiHinh.Columns[1].Width = 210;
        }

        private void cbClub_SelectedValueChanged(object sender, EventArgs e, int index)
        {
            try
            {
                LoadDoiHinh(index);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
