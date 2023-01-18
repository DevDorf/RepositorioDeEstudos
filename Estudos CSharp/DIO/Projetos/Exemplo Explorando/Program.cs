using Exemplo_Explorando.Models;
using System.Globalization;

string dataString = "2022-13-18 18:00";


bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);

if (sucesso)
{
    Console.WriteLine($"Conversão realizada com sucesso {data}");
}
else
{
    Console.WriteLine($"{dataString} não é uma data válida");
}






//DateTime data = DateTime.Parse(dataString);

//Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));

























// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

// decimal valorMonetario = 82.40M;

// Console.WriteLine($"{valorMonetario:C}");

// Console.WriteLine(valorMonetario.ToString("N2"));

// double porcentagem = .3421;

// Console.WriteLine(porcentagem.ToString("P"));

// int numero = 123456;
// Console.WriteLine(numero.ToString("##-##-##"));







// Pessoa p1 = new Pessoa(nome: "Caio", sobrenome: "Rodrigues");
// Pessoa p2 = new Pessoa(nome: "Tuã", sobrenome: "Souza");

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Ingles";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();















// Pessoa p1 = new Pessoa();
// p1.Nome = "Caio";
// p1.Sobrenome = "Rodrigues";
// p1.Idade = 33;
// p1.Apresentar();
