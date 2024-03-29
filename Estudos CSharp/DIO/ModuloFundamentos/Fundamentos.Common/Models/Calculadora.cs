using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fundamentos.Common.Models
{
    public class Calculadora
    {
        /// <summary>
        /// Realiza uma soma de dois numeros
        /// </summary>
        /// <param name="x">O primeiro numero inteiro para somar</param>
        /// <param name="y">O segundo numero inteiro para somar</param>
        public void Somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }

        public void Subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }

        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"{x} x {y} = {x * y}");
        }

        public void Dividir(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }

        public void Potencia(int x, int y)
        {
            double pot = Math.Pow(x, y);
            Console.WriteLine($"{x} ^ {y} = {pot}");
        }

        public void Seno(double angulo)
        {
            double radiando = angulo * Math.PI / 180;
            double seno = Math.Sin(radiando);
            Console.WriteLine($"Seno de {angulo} = {Math.Round(seno, 4)}");
        }

        public void Coseno(double angulo)
        {
            double radiando = angulo * Math.PI / 180;
            double coseno = Math.Cos(radiando);
            Console.WriteLine($"Coseno de {angulo} = {Math.Round(coseno, 4)}");
        }

    public void Tangente(double angulo)
        {
            double radiando = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiando);
            Console.WriteLine($"Seno de {angulo} = {Math.Round(tangente, 4)}");
        }

        public void RaizQuadrada(double x)
        {
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"Raiz quadrada de {x} = {raiz}");
        }
    }
}