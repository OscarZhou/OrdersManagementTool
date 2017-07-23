using System;
using System.Windows.Forms;

namespace OrderManagementTool
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
            Application.Run(new OrderManagementTool());
            //Application.Run(new DataImportingPage());
        }
    }
}
