using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstudosPOO.Models
{
    public class Professor : Pessoa
    {
        public double Salario { get; set; }

         public override void Apresentar()// colocando "sealed" a gnt não permite que esse comportamente seja herdado.
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, sou professor e recebo R$ {Salario}");
        }
    }
}