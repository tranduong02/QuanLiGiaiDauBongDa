using QuanLyGiaiDauBongDa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyGiaiDauBongDa
{
    static class Program
    {
        static QuanLyGiaiDauBongDaContext context = new QuanLyGiaiDauBongDaContext();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FrmLichThiDauChoClub(context.Clubs.First(c => c.ClubId == 3)));
            Application.Run(new FrmLogin());
        }
    }
}

