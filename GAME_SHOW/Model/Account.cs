using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAME_SHOW.Model
{
    class Account
    {
        public string email { get; set; }
        public string password { get; set; }
        public string fullName { get; set; }
        public string confirmPassword { get; set; }
        public string role { get; set; }

        public Account(string mail, string pass)
        {
            this.email = mail;
            this.password = pass;
        }

        public Account(string mail, string fullName, string role, string pass, string rePass)
        {
            this.email = mail;
            this.password = pass;
            this.confirmPassword = rePass;
            this.role = role;
            this.fullName = fullName;
        }
    }
}
