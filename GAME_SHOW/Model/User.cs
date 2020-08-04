using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAME_SHOW.Model
{
    public class User
    {
        public string id { get; set; }
        public string login { get; set; }
        public string email { get; set; }
        public string role { get; set; }

        public User(string id, string login, string email, string role)
        {
            this.email = email;
            this.login = login;
            this.id = id;
            this.role = role;
        }
    }
}
