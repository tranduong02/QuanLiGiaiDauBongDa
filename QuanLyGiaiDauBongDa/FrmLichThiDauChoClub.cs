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
    public partial class FrmLichThiDauChoClub : Form
    {
        QuanLyGiaiDauBongDaContext context = new QuanLyGiaiDauBongDaContext();
        //Khởi tạo object Câu Lạc Bộ
        readonly Club club = new();
        public FrmLichThiDauChoClub(Club club)
        {
            InitializeComponent();
            this.club = club;
        }

        private void FrmLichThiDauChoClub_Load(object sender, EventArgs e)
        {
            try
            {
                LoadSchedule();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadSchedule()
        {
            lbClub.Text = club.Name;
            pbClub.Image = Image.FromFile(@"..\..\..\Resources\" + club.LogoUrl);
            pbClub.SizeMode = PictureBoxSizeMode.Zoom;
            flpSchedule.AutoScroll = true;

            List<Match> matches = new List<Match>();
            foreach (var item in context.Matches.ToList())
            {
                if (item.HostId == club.ClubId || item.GuestId == club.ClubId)
                {
                    item.Host = context.Clubs.SingleOrDefault(s => s.ClubId == item.HostId);
                    item.Guest = context.Clubs.SingleOrDefault(s => s.ClubId == item.GuestId);
                    matches.Add(item);
                }   
            }

            foreach (Match item in matches)
            {
                //Tạo panel cho trận đấu
                FlowLayoutPanel match = new FlowLayoutPanel();
                match.BackColor = Color.WhiteSmoke;
                match.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                match.Size = new System.Drawing.Size(flpSchedule.Width-30, 70);

                //Nội dung kết quả trận đấu
                Label time = new Label();
                time.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                time.AutoSize = true;
                time.Text = item.PlayDate.ToString() + ":";
                match.Controls.Add(time);

                Label content = new Label();
                content.Size = new System.Drawing.Size(420, 70);
                content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                MatchResult result1 = context.MatchResults.FirstOrDefault(r => r.MatchId == item.MatchId && r.ClubId == club.ClubId);
                MatchResult result2 = context.MatchResults.FirstOrDefault(r => r.MatchId == item.MatchId && r.ClubId != club.ClubId);
                string displayresult = "";
                if (result1 != null)
                {
                    displayresult = $"{result1.GoalScore} - {result2.GoalScore}";
                }
                if (item.HostId == club.ClubId)
                {
                    content.Text = "HOST VS " + item.Guest.Name + "\n         " + displayresult;
                }
                else
                {
                    content.Text = "GUEST VS " + item.Host.Name + "\n          " + displayresult;
                }

                Button squad = new Button();
                squad.Size = new System.Drawing.Size(70, 60);
                squad.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                squad.Text = "Squad";
                squad.Click += delegate (object sender, EventArgs e) { btnSquad_Click(this, e, club.ClubId, item); };

                Button detail = new Button();
                detail.Size = new System.Drawing.Size(70, 60);
                detail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                detail.Text = "Detail";
                detail.Click += delegate (object sender, EventArgs e) { btnDetail_Click(this, e, item); };

                match.Controls.Add(content);
                match.Controls.Add(squad);
                match.Controls.Add(detail);
                

                flpSchedule.Controls.Add(match);
            }
        }
        private void btnSquad_Click(object sender, EventArgs e, int c, Match m)
        {
            FrmDoiHinhThiDau squad = new FrmDoiHinhThiDau(c, m);
            squad.ShowDialog();
        }

        private void btnDetail_Click(object sender, EventArgs e, Match m)
        {
            if ((from r in context.MatchResults where r.MatchId == m.MatchId select r).Any())
            {
                FrmDetailMatch frmDetailMatch = new FrmDetailMatch(m);
                this.Hide();
                frmDetailMatch.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Trận đấu chưa diễn ra");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmListPlayer list = new FrmListPlayer(club.ClubId);
            this.Hide();
            list.ShowDialog();
            this.Show();
        }
    }
}
