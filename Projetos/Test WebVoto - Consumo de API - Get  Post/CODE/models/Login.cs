using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CODE.models
{
    public class Login
    {
        public Login(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }

        public string UserName { get; set; }
        public string Password { get; set; }
    }
}