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
    }
}
