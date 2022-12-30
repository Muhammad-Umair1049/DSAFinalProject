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
    public partial class SignIN : Form
    {
        public SignIN()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            //hide signin form
            this.Hide();
            //create an instance for opening form
            Opening signIn = new Opening();
            //show opening form
            signIn.ShowDialog();
            //show opening form again
            this.Show();
        }
    }
}
