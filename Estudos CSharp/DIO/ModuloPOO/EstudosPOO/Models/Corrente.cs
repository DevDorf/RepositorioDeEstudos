using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstudosPOO.Models
{
    public class Corrente : Conta //herda a classe abstrata "Conta"
    {
        public override void Creditar(double valor)
        {
            base.saldo = valor; // base deixa claro que estou manipulando o valor da classe herdada.
        }
    }
}