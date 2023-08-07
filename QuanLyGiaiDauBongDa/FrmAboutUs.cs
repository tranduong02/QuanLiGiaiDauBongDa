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
    public partial class FrmAboutUs : Form
    {
        public FrmAboutUs()
        {
            InitializeComponent();
        }
        string userName;
        public FrmAboutUs(string username) : this()
        {
            userName = username;

        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            FrmSendFeedback frmSendFeedback = new FrmSendFeedback(userName);
            frmSendFeedback.ShowDialog();
        }
    }
}
