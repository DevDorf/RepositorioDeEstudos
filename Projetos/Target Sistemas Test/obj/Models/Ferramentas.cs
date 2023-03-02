using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Target_Sistemas_Test.obj.Models
{
    public static bool Fibonacci(string numeroTest)
    {
        int numeroAnterior = 0;
        int numeroAtual = 1;
        int fibonacci;
        List<sequenciaFibonacci> ;
        bool ehFibonacci = false;

        for (int i = 0; i <= numeroTest; i++)
        {
            fibonacci = numeroAnterior + numeroAtual;
            sequenciaFibonacci.add(fibonacci);
            numeroAnterior = numeroAtual;
            numeroAtual = fibonacci;
        }

        ehFibonacci = numeroTest.  sequenciaFibonacci;

        if(ehFibonacci == true)
        {
             $"O numero {numeroTest} pertence a sequência Fibonacci";
        }
        else
        {
            
        }

    }
}