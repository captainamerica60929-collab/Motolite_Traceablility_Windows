using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using  ABD2_Finishing;

namespace  ABD2_Finishing
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
            Application.Run(new Login());
        }
    }
}
