using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserSecurity
{
    static class Program
    {
        public static string globalString = "This is a global string.";
        public static int userid;
        public static int thislogin_logid;
        public static DateTime logindatetime;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
            // Application.Run(new FormAddUserData());
        }
    }
}
