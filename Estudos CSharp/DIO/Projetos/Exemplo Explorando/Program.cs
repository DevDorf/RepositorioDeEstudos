using Exemplo_Explorando.Models;

Pessoa p1 = new Pessoa(nome: "Caio", sobrenome: "Rodrigues");
Pessoa p2 = new Pessoa(nome: "Tuã", sobrenome: "Souza");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();















// Pessoa p1 = new Pessoa();
// p1.Nome = "Caio";
// p1.Sobrenome = "Rodrigues";
// p1.Idade = 33;
// p1.Apresentar();
