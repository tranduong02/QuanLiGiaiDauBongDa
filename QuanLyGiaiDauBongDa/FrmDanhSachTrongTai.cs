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
    public partial class FrmDanhSachTrongTai : Form
    {
        QuanLyGiaiDauBongDaContext context = new QuanLyGiaiDauBongDaContext();
        public FrmDanhSachTrongTai()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public void Loading()
        {
            ImageList imgList = new ImageList() { ImageSize = new Size(68, 68) };
            imgList.Images.Clear();
            foreach (var item in context.Referees.ToList())
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
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.LargeImageList = imgList;
            listView1.Items.Clear();
            int temp = 0;
            foreach (var item in context.Referees.ToList())
            {
                ListViewItem item1 = new ListViewItem();
                item1.Text = item.RefereeName;
                item1.ImageIndex = temp;
                listView1.Items.Add(item1);
                temp ++;
            }
        }

        private void FrmDanhSachTrongTai_Load(object sender, EventArgs e)
        {
            Loading();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lsv = sender as ListView;

            if (lsv.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in lsv.SelectedItems)
                {
                    int referee_id = context.Referees.FirstOrDefault(s => s.RefereeName.Trim() == item.Text.Trim()).RefereeId;
                    FrmEditReferee frmEditReferee = new FrmEditReferee(referee_id);
                    frmEditReferee.ShowDialog();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAddReferee frmAddReferee = new FrmAddReferee();
            frmAddReferee.ShowDialog();
        }
    }
}
