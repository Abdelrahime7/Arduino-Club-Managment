using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WammeedBuisness;
namespace Wammedh1
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            DataTable tb = ClsBiUsers.GetAllUsers();
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LoginFRm frm = new LoginFRm();
            if ((tb.Rows.Count)!=0)
            {
                Application.Run(frm);

            }
            else
            {
                Application.Run(new AccuileFrm(frm));

            }
        }
    }
}
