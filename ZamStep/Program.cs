using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SSR
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MDIPrincipal principal = MDIPrincipal.Singleton;

            Splash splash = new Splash();
            if (splash.ShowDialog() == DialogResult.OK)
            {
                Application.Run(principal);
            }
        }
    }
}
