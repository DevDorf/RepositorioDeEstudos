using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo_Explorando.Models
{
    public class Pessoa
    {
        public Pessoa()
        {

        }

        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        private string _nome;
        private string _sobrenome;
        private int _idade;
        

        public string Nome
        { 
            get => _nome.ToUpper();
            
            
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio.");
                }

                _nome = value;
            } 
        }   
        public string Sobrenome 
        {
            get => _sobrenome;


            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pde ser vazio.");
                }

                _sobrenome = value;
            } 
        }

        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

        public int Idade
        { 
            get => _idade;

            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("O valor não pode se menor que zero");
                }
                _idade = value;
            }
        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        }

    }
}