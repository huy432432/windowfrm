using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT1
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
            Application.Run(new frmDangNhap());

            string debugPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Config.ini");

            string configContent = @"[DatabaseConnection]
            Permission=ReadWrite
            ServerName=YourServerName
            DatabaseName=YourDatabaseName
            UserName=YourUserName
            Password=YourPassword";

            File.WriteAllText(debugPath, configContent);
            Console.WriteLine("Config.ini has been created in Debug folder.");
        }
    }
}
