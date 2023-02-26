using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fundamentos.Common.Models
{   

    /// <summary>
    /// Representa uma pessoa
    /// </summary>
    public class Pessoa
    {
        public string nome { get; set; }
        public int idade { get; set; }

    /// <summary>
    /// aza a pessoa se apresentar, diendo seu nome e sua idade
    /// </summary>
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {nome} e tenho {idade} anos.");
        }
    }
}