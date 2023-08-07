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
    public partial class FrmBangXepHang : Form
    {
        QuanLyGiaiDauBongDaContext context = new QuanLyGiaiDauBongDaContext();
        public FrmBangXepHang()
        {
            InitializeComponent();
        }
        public void LoadList()
        {
            var BangXepHang = (from c in context.Clubs.ToList()
                               select new
                               {
                                   c.ClubId,
                                   c.LogoUrl,
                                   c.Name,
                                   Thắng = CountWin(c.ClubId),
                                   Hòa = CountDraw(c.ClubId),
                                   Thua = CountLose(c.ClubId),
                                   SốBànThắng = TotalNumberOfGoal(c.ClubId),
                                   Điểm = CaculatePoint(c.ClubId)
                               }).OrderByDescending(x => x.Điểm).ToList();
            dgvBangXepHang.DataSource = BangXepHang;

        }

        private void FrmBangXepHang_Load(object sender, EventArgs e)
        {
            try
            {
                LoadList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo");
            }
        }

        //Tính số trận thắng/thua/hòa mỗi đội
        public int CountWin(int? clubID)
        {
            int result = 0;
            var sWin = context.MatchResults.Where(x => x.ClubId == clubID).Where(s => s.WinLose == "W");
            result = sWin.Count();
            return result;

        }
        public int CountLose(int? clubID)
        {
            int result = 0;
            var sLose = context.MatchResults.Where(x => x.ClubId == clubID).Where(s => s.WinLose == "L");
            result = sLose.Count();
            return result;
        }
        public int CountDraw(int? clubID)
        {
            int result = 0;
            var sDraw = context.MatchResults.Where(x => x.ClubId == clubID).Where(s => s.WinLose == "D");
            result = sDraw.Count();
            return result;
        }

        //Tính số điểm mỗi club
        public int CaculatePoint(int? clubID)
        {
            return CountWin(clubID) * 3 + CountDraw(clubID);
        }

        //Tính số bàn thắng
        public int TotalNumberOfGoal(int? clubID)
        {
            var s = context.MatchResults.Where(s => s.ClubId == clubID).ToList();
            int result = 0;
            foreach (var item in s)
            {
                result += (int)item.GoalScore;
            }
            return result;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
