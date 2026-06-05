using System;
using System.Windows.Forms;

namespace PharmacyManagementSystem
{
    static class Program
    {
        public static PharmacyDB DB = new PharmacyDB();

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}