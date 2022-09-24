using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoExemplo.Models
{
    internal class Pessoa 
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void Apresenta()
        {
            Console.WriteLine($"Meu nome é {Nome} e tenho {Idade} anos");

        }
        
    }
}
