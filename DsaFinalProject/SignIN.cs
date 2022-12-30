using DsaFinalProject.DL;
using DsaFinalProject.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DsaFinalProject.BL;

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

        private void btSignIn_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            userBL u = new userBL(username, password);
            u = userDL.isUser(u);
            userUI.wrongCredentials(u);
            if (u != null)
            {
                MessageBox.Show("Welcome");

            }
        }


       
    }
}
