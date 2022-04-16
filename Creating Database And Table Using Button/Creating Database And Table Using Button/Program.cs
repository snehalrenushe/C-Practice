using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Creating_Database_And_Table_Using_Button
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
            Application.Run(new Create_Database_And_Table());
        }
    }
}
