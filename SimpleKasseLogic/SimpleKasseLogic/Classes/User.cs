using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleKasseLogic.Classes
{
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string lastlog { get; set; }

        public User(string userName, string password,  string lastlog,string role)
        {
            UserName = userName;
            Password = password;
            Role = role;
            this.lastlog = lastlog;
        }

        public User() { }
    }
}
