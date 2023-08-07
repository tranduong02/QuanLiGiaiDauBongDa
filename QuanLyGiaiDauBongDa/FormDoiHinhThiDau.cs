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
    public partial class FrmDoiHinhThiDau : Form
    {
        QuanLyGiaiDauBongDaContext context = new QuanLyGiaiDauBongDaContext();
        readonly int clubid = new();
        readonly Match match = new();
        int count = 0;
        int starting_count = 0;
        public FrmDoiHinhThiDau(int clubid, Match match)
        {
            InitializeComponent();
            this.clubid = clubid;
            this.match = match;
        }

        private void FrmDoiHinhThiDau_Load(object sender, EventArgs e)
        {
            if (match.Host.ClubId == clubid)
            {
                lbDoiHinh.Text += " vs " + match.Guest.Name + " Ngày: " + match.PlayDate.ToString();
            }
            else
            {
                lbDoiHinh.Text += " vs " + match.Host.Name + " Ngày: " + match.PlayDate.ToString();
            }
            var doihinh = (from p in context.Teams
                           where p.MatchId == match.MatchId && p.Player.ClubId == clubid
                           select new {p.PlayerId, p.Player.Name, p.Player.PositionId, p.Starting}).ToList();
            if (doihinh.Any())
            {
                dgvDoiHinh.DataSource = doihinh;
                dgvDoiHinh.Columns[1].Width = 250;
                lbCount.Text = "";
                btnSelect.Text = "Reset";
            } else
            {
                try
                {
                    LoadDoiHinh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void LoadDoiHinh()
        {
            dgvDoiHinh.DataSource = (from p in context.Players where p.ClubId == clubid select new { p.PlayerId, p.Name, p.PositionId }).ToList();
            lbCount.Text = "Số cầu thủ đã chọn: " + count.ToString() + " Số cầu thủ ra sân: " + starting_count.ToString();
            
            // Thêm cột select players
            DataGridViewCheckBoxColumn select = new DataGridViewCheckBoxColumn();
            select.Name = "Select";
            dgvDoiHinh.Columns.Add(select);
            dgvDoiHinh.CellValueChanged += new DataGridViewCellEventHandler(dgvDoiHinh_ValueChanged);

            //Thêm cột Substitute
            DataGridViewCheckBoxColumn substitute = new DataGridViewCheckBoxColumn();
            substitute.Name = "Substitute";
            dgvDoiHinh.Columns.Add(substitute);

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (btnSelect.Text == "Select")
            {
                if (starting_count == 11)
                {
                    try
                    {
                        foreach (DataGridViewRow row in dgvDoiHinh.Rows)
                        {
                            if (Convert.ToBoolean(row.Cells["Select"].Value))
                            {
                                context.Teams.Add(new Team()
                                {
                                    PlayerId = int.Parse(row.Cells["PlayerId"].Value.ToString()),
                                    MatchId = match.MatchId,
                                    Starting = !Convert.ToBoolean(row.Cells["Substitute"].Value)
                                });
                            }
                        }
                        if (context.SaveChanges() > 0)
                        {
                            MessageBox.Show("Select successful");
                            this.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Số cầu thủ ra sân cần phải là 11 cầu thủ", "Warning");
                }
            } else
            {
                try
                {
                    foreach (DataGridViewRow row in dgvDoiHinh.Rows)
                    {
                        context.Teams.Remove(context.Teams.FirstOrDefault(p => p.MatchId == match.MatchId 
                                                                            && p.PlayerId == int.Parse(row.Cells["PlayerId"].Value.ToString())));
                    }
                    if (context.SaveChanges() > 0)
                    {
                        MessageBox.Show("Reset successful");
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dgvDoiHinh_ValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            count = 0;
            starting_count = 0;
            foreach (DataGridViewRow row in dgvDoiHinh.Rows)
            {
                if (Convert.ToBoolean(row.Cells["Select"].Value))
                {
                    count++;
                    if (!Convert.ToBoolean(row.Cells["Substitute"].Value))
                    {
                        starting_count++;
                    }
                }
            }
            lbCount.Text = "Số cầu thủ đã chọn: " + count.ToString() + " Số cầu thủ ra sân: " + starting_count.ToString();
        }
    }
}
