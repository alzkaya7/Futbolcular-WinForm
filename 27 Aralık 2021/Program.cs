using Futbol;
using System;
using System.Windows.Forms;

namespace _27_Aralık_2021
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
            Application.Run(new Hoşgeldiniz());
        }
    }
}
