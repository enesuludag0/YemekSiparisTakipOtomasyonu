using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using YemekSiparisTakipOtomasyonu.Forms;
using static YemekSiparisTakipOtomasyonu.RestoranlarForm;

namespace YemekSiparisTakipOtomasyonu
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
            Application.Run(new InRestaurant());
        }
    }
}
