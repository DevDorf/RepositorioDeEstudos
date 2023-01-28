using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        public string UserName //Fazer essa validação (Allowed a-z, A-Z and 0-9 chars only)
        {
            get => UserName;

            set
            {
                if (value.Length < 4 && value.Length > 32) // Min size 4 chars and max size 32 chars
                {
                    throw new ArgumentException("Min size 4 chars and max size 32 chars");
                }
                // else if ()// Procurar a lógica.
                // {
                //     throw new ArgumentException("Allowed a-z, A-Z and 0-9 chars only");
                // }

                UserName = value;
            }
        }
        public string Email
        {
            get => Email;
            
            set
            {
                if (value == "")
                {
                    Console.WriteLine("Your email address so we are able to contact you");
                }

                Email = value;
            }
        }// 
        public string Password
        {
            get => Password;

            set
            {
                if (value.Length < 8) // Min size 8 chars
                {
                    throw new ArgumentException("Min size 8 chars.");
                }

                Password = value;
            }
        }


        public void Validar()
        {
            
        }
    }
}
