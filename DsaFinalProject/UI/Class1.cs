using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DsaFinalProject.BL;
namespace DsaFinalProject.UI
{
    internal class userUI
    {
        public static void wrongCredentials(userBL u)
        {
            if (u == null)
            {
                MessageBox.Show("Invalid UserID or Password");
            }
        }

    }
}
