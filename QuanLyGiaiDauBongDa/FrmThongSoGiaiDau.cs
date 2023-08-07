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
    public partial class FrmThongSoGiaiDau : Form
    {
        QuanLyGiaiDauBongDaContext context = new QuanLyGiaiDauBongDaContext();
        public FrmThongSoGiaiDau()
        {
            InitializeComponent();
        }
        public void Loading()
        {
            //Tổng số trận (Tổng cộng 38 vòng đấu (mỗi đội phải đá 38 trận 1 mùa giải) )
            label10.Text = $"{38*20} trận";
            //Số trận đã kết thúc
            int NumberOfPlayedMatch = (context.MatchResults.Count())/2;
            label11.Text = NumberOfPlayedMatch.ToString() + " trận";
            //tính %
            label11.Text += " (" + (((float.Parse(NumberOfPlayedMatch.ToString())) / 760 * 100)).ToString() + "%)";
            //Số trận sắp đá
            label12.Text = (760 - NumberOfPlayedMatch).ToString() + " trận";
            label12.Text += " (" + (((float.Parse((38-NumberOfPlayedMatch).ToString())) / 760 * 100)).ToString() + "%)";

            //Số trận thắng(sân nhà)
            int TotalWinMatch = 0;
            foreach (var item in context.Matches.ToList())
            {
                foreach (var item2 in context.MatchResults.ToList())
                {
                    if(item2.MatchId == item.MatchId && item2.ClubId == item.HostId && item2.WinLose.ToLower() == "w")
                    {
                        TotalWinMatch++;
                    }
                }
            }
            label13.Text = TotalWinMatch.ToString();
            //Số trận thắng (sân khách)
            int TotalWinMatchGuest = 0;
            foreach (var item in context.Matches.ToList())
            {
                foreach (var item2 in context.MatchResults.ToList())
                {
                    if (item2.MatchId == item.MatchId && item2.ClubId == item.GuestId && item2.WinLose.ToLower() == "w")
                    {
                        TotalWinMatchGuest++;
                    }
                }
            }
            label14.Text = TotalWinMatchGuest.ToString();
            //Số trận hòa:
            int NumberOfDraw = context.MatchResults.Where(s => s.WinLose == "D").Count() / 2;
            label15.Text = NumberOfDraw.ToString();
            //Số bàn thắng(sân nhà)
            int TotalWinScoreMatch = 0;
            foreach (var item in context.Matches.ToList())
            {
                foreach (var item2 in context.MatchResults.ToList())
                {
                    if (item2.MatchId == item.MatchId && item2.ClubId == item.HostId && item2.WinLose.ToLower() == "w")
                    {
                        TotalWinScoreMatch+= (int)item2.GoalScore;
                    }
                }
            }
            label16.Text = TotalWinScoreMatch.ToString();
            //Số bàn thắng (sân khách)
            int TotalWinScoreMatchGuest = 0;
            foreach (var item in context.Matches.ToList())
            {
                foreach (var item2 in context.MatchResults.ToList())
                {
                    if (item2.MatchId == item.MatchId && item2.ClubId == item.GuestId && item2.WinLose.ToLower() == "w")
                    {
                        TotalWinScoreMatchGuest+=(int)item2.GoalScore;
                    }
                }
            }
            label17.Text = TotalWinScoreMatchGuest.ToString();


            //Top Thẻ Phạt

        }

        private void FrmThongSoGiaiDau_Load(object sender, EventArgs e)
        {
            Loading();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
