using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo_Explorando.Models
{
    public static class IntExtensions
    {
        public static bool EhPar(this int numero)//"this is" esta extendendo para todos os numeros inteiros vão ter acesso a esse metodo extendido.
        {
            return numero % 2 == 0;
        }
    }
}