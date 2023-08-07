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
    public partial class FrmEditMatch : Form
    {
        QuanLyGiaiDauBongDaContext context = new QuanLyGiaiDauBongDaContext();
        Match match = new();
        private int hostGoalScore = 0;
        private int guestGoalScore = 0;
        public FrmEditMatch(Match match)
        {
            InitializeComponent();
            this.match = match;
        }

        private void FrmEditMatch_Load(object sender, EventArgs e)
        {
            try
            {
                LoadForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadForm()
        {
            match.Host = context.Clubs.SingleOrDefault(c => c.ClubId == match.HostId);
            match.Guest = context.Clubs.SingleOrDefault(c => c.ClubId == match.GuestId);

            pbHost.Image = Image.FromFile(@"..\..\..\Resources\" + match.Host.LogoUrl);
            pbHost.SizeMode = PictureBoxSizeMode.Zoom;
            lbHost.Text = match.Host.Name;

            pbGuest.Image = Image.FromFile(@"..\..\..\Resources\" + match.Guest.LogoUrl);
            pbGuest.SizeMode = PictureBoxSizeMode.Zoom;
            lbGuest.Text = match.Guest.Name;

            //Goal
            FlowLayoutPanel hostGoal = new FlowLayoutPanel();
            hostGoal.Size = new Size(300, 70);
            hostGoal.AutoScroll = true;
            hostGoal.FlowDirection = FlowDirection.TopDown;
            var hgoals = (from g in context.Goals
                          where g.MatchId == match.MatchId && g.Player.ClubId == match.HostId
                          select new { g.Player.Name, g.GoalTime }).ToList();
            hostGoalScore = hgoals.Count;
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
            guestGoal.Size = new Size(315, 70);
            guestGoal.AutoScroll = true;
            guestGoal.FlowDirection = FlowDirection.TopDown;
            var ggoals = (from g in context.Goals
                          where g.MatchId == match.MatchId && g.Player.ClubId == match.GuestId
                          select new { g.Player.Name, g.GoalTime }).ToList();
            guestGoalScore = ggoals.Count;
            foreach (var g in ggoals)
            {
                guestGoal.Controls.Add(new Label
                {
                    Text = g.Name + " " + g.GoalTime.ToString() + "'",
                    Size = new Size(305, 30),
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

            //Card
            lbHostYCard.Text = (from c in context.Cards
                                where c.MatchId == match.MatchId && c.Player.ClubId == match.HostId && c.CardType == false
                                select c).ToList().Count.ToString();
            lbHostRCard.Text = (from c in context.Cards
                                where c.MatchId == match.MatchId && c.Player.ClubId == match.HostId && c.CardType == true
                                select c).ToList().Count.ToString();
            lbGuestYCard.Text = (from c in context.Cards
                                 where c.MatchId == match.MatchId && c.Player.ClubId == match.GuestId && c.CardType == false
                                 select c).ToList().Count.ToString();
            lbGuestRCard.Text = (from c in context.Cards
                                 where c.MatchId == match.MatchId && c.Player.ClubId == match.GuestId && c.CardType == true
                                 select c).ToList().Count.ToString();

            this.button3.Click += delegate (object sender, EventArgs e) { button3_Click(this, e, match); };
            this.button2.Click += delegate (object sender, EventArgs e) { button2_Click(this, e, match); };
        }

        private void button3_Click(object sender, EventArgs e, Match m)
        {
            FrmAddGoal addgoal = new FrmAddGoal(m);
            addgoal.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e, Match m)
        {
            FrmAddCard addcard = new FrmAddCard(m);
            addcard.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                context.MatchResults.Add(new MatchResult()
                {
                    MatchId = match.MatchId,
                    ClubId = match.HostId,
                    GoalScore = hostGoalScore,
                    Shots = (int)nudHostShots.Value,
                    Ontarget = (int)nudHostOnTarget.Value,
                    Control = (int)nudHostControl.Value,
                    Fouls = (int)nudHostFouls.Value,
                    Corners = (int)nudHostCorner.Value,
                    Offsides = (int)nudHostOffside.Value,
                    WinLose = (hostGoalScore > guestGoalScore)?"W":(hostGoalScore  == guestGoalScore)?"D":"L"
                });
                context.MatchResults.Add(new MatchResult()
                {
                    MatchId = match.MatchId,
                    ClubId = match.GuestId,
                    GoalScore = guestGoalScore,
                    Shots = (int)nudGuestShots.Value,
                    Ontarget = (int)nudGuestOnTarget.Value,
                    Control = (int)nudGuestControl.Value,
                    Fouls = (int)nudGuestFouls.Value,
                    Corners = (int)nudGuestCorner.Value,
                    Offsides = (int)nudGuestOffside.Value,
                    WinLose = (hostGoalScore < guestGoalScore) ? "W" : (hostGoalScore == guestGoalScore) ? "D" : "L"
                });
                if (context.SaveChanges()>0)
                {
                    MessageBox.Show("Save successful");
                    this.Close();
                } else
                {
                    MessageBox.Show("Save failed");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
