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

        public string UserName
        {
            get => UserName;

            set
            {
                Regex allowedChars = new Regex(@"[a-zA-Z_0-9]");
                bool aprovedChars = allowedChars.IsMatch(value);

                bool aprovedSize = value.Length < 4 && value.Length > 32;

                if (!aprovedSize)
                {
                    value = "Min size 4 chars and max size 32 chars";
                }
                else if (!aprovedChars)
                {
                    value = "Allowed a-z, A-Z and 0-9 chars only";
                }
                else if (!aprovedChars && !aprovedSize)
                {
                    value = "Min size 4 chars and max size 32 chars and allowed a-z, A-Z and 0-9 chars only";
                }

                UserName = value;
            }
        }
        public string Email { get; set; }

        public string Password{ get; set; }
    }
}