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
    public partial class FrmListPlayer : Form
    {
        public FrmListPlayer()
        {
            InitializeComponent();
        }
        int CID;
        public FrmListPlayer(int clubId) : this()
        {
            CID = clubId;

        }

        readonly QuanLyGiaiDauBongDaContext context = new QuanLyGiaiDauBongDaContext();


        public void Loading()
        {
            ImageList imgList = new ImageList() { ImageSize = new Size(68, 68) };
            imgList.Images.Clear();
            var players = (from s in context.Players.ToList()
                           join k in context.Clubs.ToList() on s.ClubId equals k.ClubId
                           join p in context.PlayingPositions.ToList() on s.PositionId equals p.PositionId
                           where k.ClubId == CID
                           select new
                           {
                               s.PlayerId,
                               s.Name,
                               Dob = s.Dob,
                               s.Height,
                               s.Weight,
                               s.PositionId,
                               Possition = p.Name,
                               Club = k.Name,
                               s.Image
                           }
                           ).ToList();
            try
            {
                foreach (var item in players.ToList())
                {
                    if (item.Image != "" && item.Image != null)
                    {
                        imgList.Images.Add(Image.FromFile(@"..\..\..\Resources\" + item.Image));
                    }
                    else
                    {
                        imgList.Images.Add(Image.FromFile(@"..\..\..\Resources\mu.png"));
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            lvPlayer.FullRowSelect = true;
            lvPlayer.GridLines = true;
            lvPlayer.LargeImageList = imgList;
            lvPlayer.Items.Clear();
            int temp = 0;
            foreach (var item in players.ToList())
            {
                ListViewItem item1 = new ListViewItem();
                item1.Text = item.Name + Environment.NewLine + item.Possition + Environment.NewLine + Environment.NewLine;
                item1.Name = item.PlayerId.ToString();
                item1.ImageIndex = temp;
                lvPlayer.Items.Add(item1);
                temp++;
            }
        }



        private void FrmListPlayer_Load(object sender, EventArgs e)
        {
            Loading();
        }

        private void lvPlayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lsv = sender as ListView;
            if (lsv.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in lsv.SelectedItems)
                {
                    var player = context.Players.FirstOrDefault(s => s.PlayerId == int.Parse(item.Name));
                    FrmEditPlayer frmEdit = new FrmEditPlayer(player.PlayerId);
                    frmEdit.ShowDialog();
                }
            }

        }
    }
}
