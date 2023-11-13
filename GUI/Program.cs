using GUI.NguoiDung;
using GUI.SanPham;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.DatMon;
namespace GUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new QuanLySanPham());
            //Application.Run(new GUI.QLGiamGia.TrangChuGiamGia());
            //Application.Run(new GUI.DatMon.DatMon());
        }
    }
}
