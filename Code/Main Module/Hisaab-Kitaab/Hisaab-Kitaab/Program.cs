using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hisaab_Kitaab
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public static string globalParentHead = "";
        public static string inv_units = "S"; // SPL,SP,SL,PL,S,P,L
        public static string globalString; //user name
        public static int userid;
        public static int thislogin_logid;
        public static string db_name = "";
        public static string db_path = "";

       [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Choose_CLCA("CA"));
            //Application.Run(new List_Single_Entry_Book());
            //Application.Run(new List_Account_Head());
            //Application.Run(new List_Account_Head_Opening_Balances());
            Application.Run(new Login());
            //Application.Run(new Good_Receipt_Note());
            //Application.Run(new Other_Book());
        }
        //public static TreeView HelperFunc(dataconnection dtconn, TreeView tv)
        //{
        //    return tv;
        //}
    }
}
