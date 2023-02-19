using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstudosPOO.Models
{
    public abstract class Conta //abstract torna a classe ou métodos abstratos
    {
        protected double saldo { get; set; } //protected ele proteje o "saldo" podendo só trabalhar com ele a classe conta e quem herdar ela

        public abstract void Creditar(double valor); // metodo abstrato, é necessário implementar ele pra herdar a clase "Conta"

        public void ExibirSaldo()
        {
            System.Console.WriteLine("Seu saldo é: " + saldo);
        }
    }
}