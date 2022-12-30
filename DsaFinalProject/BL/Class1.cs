using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DsaFinalProject.BL
{
    internal class userBL
    {
        private string username;
        private string password;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }


        // Parameterized Constructors
        public userBL(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }
    }
}
