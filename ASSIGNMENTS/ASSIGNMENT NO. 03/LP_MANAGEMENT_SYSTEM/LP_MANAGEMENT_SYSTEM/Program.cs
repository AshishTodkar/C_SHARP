using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LP_MANAGEMENT_SYSTEM
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_Login_Page());
        }
    }
}
