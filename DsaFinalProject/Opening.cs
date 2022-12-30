using DsaFinalProject.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DsaFinalProject
{
    public partial class Opening : Form
    {
        private string pathForUsers = "UsersInfo.txt";
        public string PathForUsers { get => pathForUsers; set => pathForUsers = value; }
        public Opening()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            //hide signup form
            this.Hide();
            //create an instance for Signin form
            SignIN signIn = new SignIN();
            //show signin form
            signIn.ShowDialog();
            //show signup form again
            this.Show();
        }

        private void Opening_Load(object sender, EventArgs e)
        {
            userDL.readUsersfromFile(PathForUsers);
        }

      
    }
}
