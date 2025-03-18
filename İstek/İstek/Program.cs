using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İstek
{
    internal static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Splash Screen'i göster
            StartPage splash = new StartPage();
            splash.ShowDialog(); // Splash ekranda kalır

            // Splash kapandıktan sonra ana formu aç
            Application.Run(new İlkForm());
        }
    }
}
