using Microsoft.EntityFrameworkCore;
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
    public partial class FrmLichThiDau : Form
    {
        QuanLyGiaiDauBongDaContext context = new QuanLyGiaiDauBongDaContext();
        public FrmLichThiDau()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panel.Size = new Size((300), 100);
            flowLayoutPanel1.Controls.Add(panel);
        }

        private void FrmLichThiDau_Load(object sender, EventArgs e)
        {
            try
            {
                LoadMatch();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }

        public void LoadMatch()
        {
            //context = new QuanLyGiaiDauBongDaContext();
            List<Match> matches = new List<Match>();
            foreach (var item in context.Matches.ToList())
            {
                item.Host = context.Clubs.SingleOrDefault(s => s.ClubId == item.HostId);
                item.Guest = context.Clubs.SingleOrDefault(s => s.ClubId == item.GuestId);
                matches.Add(item);
            }
            foreach (var item in matches)
            {
                FlowLayoutPanel panel = new FlowLayoutPanel();
                panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                panel.AutoSize = true;

                panel.Width = flowLayoutPanel1.Width;

                //CONTENT OF PANEL
                Label textBox = new Label();
                textBox.Text = item.PlayDate.ToString();
                textBox.Size = new Size(180, 20);

                Button btnHost = new Button();
                btnHost.Size = new Size(100, 100);
                btnHost.BackgroundImage = Image.FromFile(@"..\..\..\Resources\" + item.Host.LogoUrl);
                btnHost.ImageAlign = ContentAlignment.MiddleCenter;
                btnHost.BackgroundImageLayout = ImageLayout.Stretch;


                Button btnGuest = new Button();
                btnGuest.Size = new Size(100, 100);
                btnGuest.BackgroundImage = Image.FromFile(@"..\..\..\Resources\" + item.Guest.LogoUrl);
                btnGuest.ImageAlign = ContentAlignment.MiddleCenter;
                btnGuest.BackgroundImageLayout = ImageLayout.Stretch;


                panel.FlowDirection = FlowDirection.LeftToRight;

                panel.Controls.Add(new Label() { Text = "Ngày Thi Đấu: ", AutoSize = true });
                panel.Controls.Add(textBox);
                panel.Controls.Add(btnHost);
                panel.Controls.Add(new Label() { Text = "VS", Width = 50 });
                panel.Controls.Add(btnGuest);

                //Kiểm tra xem đã tham gia thi đấu chưa
                var haveResult = false;
                foreach (var x in context.MatchResults.ToList())
                {
                    if (x.MatchId == item.MatchId)
                    {
                        haveResult = true;
                    }
                }
                //Đã tham gia thi đấu hiển thị kết quả:
                var f = 1;
                if (haveResult == true)
                {
                    foreach (var h in context.MatchResults.ToList())
                    {
                        if (h.MatchId == item.MatchId)
                        {
                            Label s = new Label();
                            s.Text = h.GoalScore.ToString();
                            s.Size = new Size(40, 20);
                            if (f == 1)
                            {
                                s.Text += "    - ";
                                f++;
                            }
                            panel.Controls.Add(s);
                        }
                    }
                }

                //Xem thông tin chi tiết trận đấu:
                Button details = new Button();
                details.Text = "Chi Tiết";
                details.AutoSize = true;
                panel.Controls.Add(details);
                details.Click += delegate (object sender, EventArgs e) { btnDetail_Click(this, e, item); };


                flowLayoutPanel1.Controls.Add(panel);
                flowLayoutPanel1.AutoScroll = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmAddMatch frmAddMatch = new FrmAddMatch();
            this.Hide();
            frmAddMatch.ShowDialog();
            this.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDetail_Click(object sender, EventArgs e, Match m)
        {
            if ((from r in context.MatchResults where r.MatchId == m.MatchId select r).Any())
            {
                FrmDetailMatch detail = new FrmDetailMatch(m);
                detail.ShowDialog();
                this.Refresh();
            }
            else
            {
                FrmEditMatch result = new FrmEditMatch(m);
                result.ShowDialog();
                this.Refresh();
            }
        }
    }
}
