using System;
using System.Threading;
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
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("zh-CHS");
            Application.Run(new OrderManagementTool());
            //Application.Run(new DataImportingPage());
        }
    }
}
