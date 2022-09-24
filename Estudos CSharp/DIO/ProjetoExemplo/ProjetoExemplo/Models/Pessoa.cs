using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoExemplo.Models
{
    internal class Pessoa
    {
        public string name { get; set; }
        public int idade { get; set; }

        public void Apresenta()
        {
            Console.WriteLine($"Meu nome é {nome} e tenho {idade} anos");

        }
        
    }
}
