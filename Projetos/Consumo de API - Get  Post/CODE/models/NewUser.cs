using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CODE.models
{
    public class NewUser
    {
        public NewUser()
        {

        }
        
        public NewUser(string userName, string email, string password) // Construtor
        {
            UserName = userName;
            Email = email;
            Password = password;
        }

        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password{ get; set; }
    }
}