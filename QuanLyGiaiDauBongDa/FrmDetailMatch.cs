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
    public partial class FrmDetailMatch : Form
    {
        QuanLyGiaiDauBongDaContext context = new QuanLyGiaiDauBongDaContext();
        Match match = new();
        public FrmDetailMatch(Match match)
        {
            InitializeComponent();
            this.match = match;
        }

        private void FrmDetailMatch_Load(object sender, EventArgs e)
        {
            try
            {
                LoadDetail();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadDetail()
        {
            lbDate.Text = "Giờ thi đấu: " +  match.PlayDate.ToString();
            match.Host = context.Clubs.SingleOrDefault(c => c.ClubId == match.HostId);
            match.Guest = context.Clubs.SingleOrDefault(c => c.ClubId == match.GuestId);

            //Host content
            pbHost.Image = Image.FromFile(@"..\..\..\Resources\" + match.Host.LogoUrl);
            pbHost.SizeMode = PictureBoxSizeMode.Zoom;
            lbHost.Text = match.Host.Name;
            MatchResult hostResult = context.MatchResults.SingleOrDefault(r => r.MatchId == match.MatchId
                                                                            && r.ClubId == match.HostId);
            lbHostGoal.Text = hostResult.GoalScore.ToString();
            var hostcards = (from c in context.Cards
                             where c.MatchId == match.MatchId && c.Player.ClubId == match.HostId
                             select c).ToList();

            //Guest content
            pbGuest.Image = Image.FromFile(@"..\..\..\Resources\" + match.Guest.LogoUrl);
            pbGuest.SizeMode = PictureBoxSizeMode.Zoom;
            lbGuest.Text = match.Guest.Name;
            MatchResult guestResult = context.MatchResults.SingleOrDefault(r => r.MatchId == match.MatchId
                                                                && r.ClubId == match.GuestId);
            lbGuestGoal.Text = guestResult.GoalScore.ToString();
            var guestcards = (from c in context.Cards
                             where c.MatchId == match.MatchId && c.Player.ClubId == match.GuestId
                             select c).ToList();

            //Goal content
            FlowLayoutPanel hostGoal = new FlowLayoutPanel();
            hostGoal.Size = new Size(240, 90);
            hostGoal.AutoScroll = true;
            hostGoal.FlowDirection = FlowDirection.TopDown;
            var hgoals = (from g in context.Goals
                          where g.MatchId == match.MatchId && g.Player.ClubId == match.HostId
                          select new { g.Player.Name, g.GoalTime }).ToList();
            foreach (var g in hgoals)
            {
                hostGoal.Controls.Add(new Label
                {
                    Text = g.Name + " " + g.GoalTime.ToString() + "'",
                    AutoSize = true,
                    Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
                });
            }

            FlowLayoutPanel guestGoal = new FlowLayoutPanel();
            guestGoal.Size = new Size(225, 90);
            guestGoal.AutoScroll = true;
            guestGoal.FlowDirection = FlowDirection.TopDown;
            var ggoals = (from g in context.Goals
                          where g.MatchId == match.MatchId && g.Player.ClubId == match.GuestId
                          select new { g.Player.Name, g.GoalTime }).ToList();
            foreach (var g in ggoals)
            {
                guestGoal.Controls.Add(new Label
                {
                    Text = g.Name + " " + g.GoalTime.ToString() + "'",
                    Size = new Size(215, 30),
                    TextAlign = ContentAlignment.TopRight,
                    Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
                });
            }

            PictureBox fb = new PictureBox();
            fb.Size = new Size(20, 20);
            fb.Image = Image.FromFile(@"..\..\..\Resources\football.png");
            fb.SizeMode = PictureBoxSizeMode.Zoom;

            flpGoal.FlowDirection = FlowDirection.LeftToRight;
            flpGoal.Controls.Add(hostGoal);
            flpGoal.Controls.Add(fb);
            flpGoal.Controls.Add(guestGoal);

            //Detail content
            FlowLayoutPanel hostDetail = new FlowLayoutPanel();
            hostDetail.Size = new Size(125, 300);
            hostDetail.FlowDirection = FlowDirection.TopDown;
            hostDetail.Controls.Add(new Label { Text = hostResult.Shots.ToString(), AutoSize = true });
            hostDetail.Controls.Add(new Label { Text = hostResult.Ontarget.ToString(), AutoSize = true });
            hostDetail.Controls.Add(new Label { Text = hostResult.Control.ToString() + "%", AutoSize = true });
            hostDetail.Controls.Add(new Label { Text = hostResult.Fouls.ToString(), AutoSize = true });
            hostDetail.Controls.Add(new Label { Text = (from c in hostcards where c.CardType == false select c).ToList().Count.ToString(), AutoSize = true });
            hostDetail.Controls.Add(new Label { Text = (from c in hostcards where c.CardType == true select c).ToList().Count.ToString(), AutoSize = true });
            hostDetail.Controls.Add(new Label { Text = hostResult.Offsides.ToString(), AutoSize = true });
            hostDetail.Controls.Add(new Label { Text = hostResult.Corners.ToString(), AutoSize = true });

            FlowLayoutPanel guestDetail = new FlowLayoutPanel();
            guestDetail.Size = new Size(125, 300);
            guestDetail.FlowDirection = FlowDirection.TopDown;
            guestDetail.Controls.Add(new Label { Text = guestResult.Shots.ToString(), Size = new Size(115,40), TextAlign = ContentAlignment.MiddleRight});
            guestDetail.Controls.Add(new Label { Text = guestResult.Ontarget.ToString(), AutoSize = true, Anchor = AnchorStyles.Right });
            guestDetail.Controls.Add(new Label { Text = guestResult.Control.ToString()+"%", AutoSize = true, Anchor = AnchorStyles.Right });
            guestDetail.Controls.Add(new Label { Text = guestResult.Fouls.ToString(), AutoSize = true, Anchor = AnchorStyles.Right });
            guestDetail.Controls.Add(new Label { Text = (from c in guestcards where c.CardType == false select c).ToList().Count.ToString(), AutoSize = true, Anchor = AnchorStyles.Right });
            guestDetail.Controls.Add(new Label { Text = (from c in guestcards where c.CardType == true select c).ToList().Count.ToString(), AutoSize = true, Anchor = AnchorStyles.Right });
            guestDetail.Controls.Add(new Label { Text = guestResult.Offsides.ToString(), AutoSize = true, Anchor = AnchorStyles.Right });
            guestDetail.Controls.Add(new Label { Text = guestResult.Corners.ToString(), AutoSize = true, Anchor = AnchorStyles.Right });

            FlowLayoutPanel titleDetail = new FlowLayoutPanel();
            titleDetail.Size = new Size(250, 300);
            titleDetail.FlowDirection = FlowDirection.TopDown;
            //titleDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            titleDetail.Controls.Add(new Label { Text = "Số lần sút", AutoSize = true, Anchor = AnchorStyles.None});
            titleDetail.Controls.Add(new Label { Text = "Số lần sút trúng đích", AutoSize = true, Anchor = AnchorStyles.None });
            titleDetail.Controls.Add(new Label { Text = "Kiểm soát bóng", AutoSize = true, Anchor = AnchorStyles.None });
            titleDetail.Controls.Add(new Label { Text = "Số lần phạm lỗi", AutoSize = true, Anchor = AnchorStyles.None });
            titleDetail.Controls.Add(new Label { Text = "Thẻ vàng", AutoSize = true, Anchor = AnchorStyles.None });
            titleDetail.Controls.Add(new Label { Text = "Thẻ đỏ", AutoSize = true, Anchor = AnchorStyles.None });
            titleDetail.Controls.Add(new Label { Text = "Số lần việt vị", AutoSize = true, Anchor = AnchorStyles.None });
            titleDetail.Controls.Add(new Label { Text = "Số lần phạt góc", AutoSize = true, Anchor = AnchorStyles.None });

            flpDetail.BorderStyle = BorderStyle.Fixed3D;
            flpDetail.Controls.Add(hostDetail);
            flpDetail.Controls.Add(titleDetail);
            flpDetail.Controls.Add(guestDetail);

            //Đội hình ra sân button click
            btnDoiHinh.Click += delegate (object sender, EventArgs e) { btnDoiHinh_Click(this, e, match); };
        }

        private void btnDoiHinh_Click(object sender, EventArgs e, Match m)
        {
            FrmXemDoiHinhThiDau frmXemDoiHinhThiDau = new FrmXemDoiHinhThiDau(m);
            frmXemDoiHinhThiDau.ShowDialog();
        }
    }
}
