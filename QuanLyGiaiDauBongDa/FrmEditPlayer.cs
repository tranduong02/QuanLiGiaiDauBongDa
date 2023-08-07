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
    public partial class FrmEditPlayer : Form
    {
        QuanLyGiaiDauBongDaContext context = new QuanLyGiaiDauBongDaContext();
        public int player_id;
        public FrmEditPlayer(int id)
        {
            player_id = id;
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void FrmEditPlayer_Load(object sender, EventArgs e)
        {
            var player = context.Players.Where(s => s.PlayerId == player_id).FirstOrDefault();
            txtPlayerID.Text = player.PlayerId.ToString();
            txtNamePlayer.Text = player.Name.ToString();
            txtDob.Text = player.Dob;
            height.Maximum = 200;
            weight.Value = int.Parse(player.Weight);
            weight.Maximum = 200;
            height.Value = int.Parse(player.Height);
            cbClub.DataSource = context.Clubs.ToList();
            cbClub.DisplayMember = "Name";
            cbClub.ValueMember = "ClubId";
            cbClub.SelectedValue = player.ClubId;

            cbPosition.DataSource = context.PlayingPositions.ToList();
            cbPosition.DisplayMember = "Name";
            cbPosition.ValueMember = "PositionId";
            cbPosition.SelectedValue = player.PositionId;

            if (player.Image != null)
            {
                avatarPlayer.BackgroundImage = Image.FromFile(@"..\..\..\Resources\" + player.Image);
            }
            else
            {
                avatarPlayer.BackgroundImage = Image.FromFile(@"..\..\..\Resources\logo.png");
            }

            txtAvatar.Text = player.Image;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            var player = context.Players.SingleOrDefault(s => s.PlayerId == player_id);
            try
            {
                var result = MessageBox.Show("Are you want to update data?", "Thông Báo", MessageBoxButtons.OKCancel);
                if (player != null && result == DialogResult.OK)
                {
                    player.Name = txtNamePlayer.Text.ToUpper().Trim();
                    player.Dob = txtDob.Text.ToString();
                    player.PositionId = cbPosition.SelectedValue.ToString();
                    player.Weight = weight.Value.ToString();
                    player.Height = height.Value.ToString();
                    player.ClubId = int.Parse(cbClub.SelectedValue.ToString());

                    player.Image = txtAvatar.Text.Trim();

                    FrmListPlayer frmListPlayer = (FrmListPlayer)Application.OpenForms["FrmListPlayer"];
                    frmListPlayer.Refresh();
                    frmListPlayer.Loading();

                    context.Players.Update(player);
                    context.SaveChanges();
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                }
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo");
                throw;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                avatarPlayer.Image = new Bitmap(opnfd.FileName);
                txtAvatar.Text = opnfd.SafeFileName;
            }

        }
    }
}
