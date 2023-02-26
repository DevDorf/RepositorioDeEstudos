using System;
using EstudosPOO.Models;
using EstudosPOO.Interfaces;
using EstudosPOO.Helper;

namespace EstudosPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            var caminho = "D:\\C\\DevDorf\\Git\\Csharp\\Estudos CSharp\\DIO\\Modulo POO\\ManipulandoArquivos";
            var caminhoPathCombine = Path.Combine(caminho, "PastaTeste 1");
            var caminhoArquivo = Path.Combine(caminho, "arquivo-teste-stream.txt");
            var caminhoArquivoTeste = Path.Combine(caminho, "arquivo-teste-stream.txt");
            var caminhoArquivoTesteCopia = Path.Combine(caminho, "arquivo-teste-bkp.txt");
            var novoCaminhoArqivo = Path.Combine(caminho, "PastaTeste 2", "arquivo-teste-stream.txt");

            var listaString = new List<string> { "Linha 1", "Linha 2", "Linha 3" };
            var listaStringContinuacao = new List<string> { "Linha 4", "Linha 5", "Linha 6" };

            FileHelper helper = new FileHelper();
            //helper.ListarDiretorios(caminho);
            //helper.ListarArquivosDiretorios(caminho);
            //helper.CriarDiretorio(caminhoPathCombine);
            //helper.ApagarDiretorio(caminhoPathCombine, true);
            //helper.CriarArquivoTexto(caminhoArquivo, "Olá! Teste de escrita de arquivo");
            // helper.CriarArquivoTextoStream(caminhoArquivo, listaString);
            // helper.AdicionarTextoStream(caminhoArquivo, listaStringContinuacao);
            // helper.LerArquivoStream(caminhoArquivo);
            //helper.MoverArquivo(caminhoArquivo, novoCaminhoArqivo, false);
            //helper.CopiarArquivo(caminhoArquivoTeste, caminhoArquivoTesteCopia, false);
            helper.DeletarArquivo(caminhoArquivoTesteCopia);



            // ICalculadora calc = new Calculadora();
            // System.Console.WriteLine(calc.Somar(10, 20));



            // Computador comp = new Computador();
            // System.Console.WriteLine(comp.ToString());

            // Corrente c = new Corrente();
            // c.Creditar(100);

            // c.ExibirSaldo();




            // Calculadora calc = new Calculadora();
            // System.Console.WriteLine("Resultado da prieira soma: " + calc.Somar(10, 10));
            // System.Console.WriteLine("Resultado da segunda soma: " + calc.Somar(10, 10, 10));



            // Aluno p1 = new Aluno();

            // p1.Nome = "SeuDorf";
            // p1.Idade = 33;
            // p1.Documento = "08112";
            // p1.Nota = 9.5;

            // p1.Apresentar();

            // Professor p2 = new Professor();

            // p2.Nome = "Buta";
            // p2.Idade = 22;
            // p2.Documento = "5888754";
            // p2.Salario = 1.000;

            // p2.Apresentar();





            // valores válidos
            // Retangulo r = new Retangulo();
            // r.DefinirMedidas(30, 30);

            // System.Console.WriteLine($"Área: {r.ObterArea()}");

            // // valores inválidos
            // Retangulo r2 = new Retangulo();
            // r.DefinirMedidas(0, 30);

            // System.Console.WriteLine($"Área: {r2.ObterArea()}");




            // Pessoa p1 = new Pessoa();

            // p1.Nome = "SeuDorf";
            // p1.Idade = 33;

            // p1.Apresentar();

        }
    }
}


