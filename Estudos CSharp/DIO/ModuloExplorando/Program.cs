using Exemplo_Explorando.Models;
using System.Globalization;
using Newtonsoft.Json;


int numero = 20;
bool par = false;

par = numero.EhPar();

string mensagem = "O numero " + numero + " " + " é " + (par ? "par" : "impar");
Console.WriteLine(mensagem);














// MeuArray<int> arrayInteiro = new MeuArray<int>();

// arrayInteiro.AdicionarElementoArray(30);

// Console.WriteLine(arrayInteiro[0]);



// MeuArray<string> arrayString = new MeuArray<string>();

// arrayString.AdicionarElementoArray("Teste");

// Console.WriteLine(arrayString[0]);
















// dynamic variavelDinamica = 4;

// Console.WriteLine($"Tipo de variavel: {variavelDinamica.GetType()}, valor: {variavelDinamica}");

// variavelDinamica = "Texto";
// Console.WriteLine($"Tipo de variavel: {variavelDinamica.GetType()}, valor: {variavelDinamica}");

// variavelDinamica = true;
// Console.WriteLine($"Tipo de variavel: {variavelDinamica.GetType()}, valor: {variavelDinamica}");







// string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

// List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

// var listaAnonimo = listaVenda.Select(x => new { x.Produto, x.Preco }); // o "x" representa cada elemento da lista

// foreach (var venda in listaAnonimo)
// {
//     Console.WriteLine($"Produto: {venda.Produto}, Preço: {venda.Preco}");
// }



// var tipoAnonimo = new { Nome = "Caio", Sobrenome = "Rodrigues", Altura = 1.74 };

// Console.WriteLine("Nome: " + tipoAnonimo.Nome);
// Console.WriteLine("Sobrenome: " + tipoAnonimo.Sobrenome);
// Console.WriteLine("Altura: " + tipoAnonimo.Altura);











// bool? desejaReceberEmail = null; //Representação do NULO

// if (desejaReceberEmail.HasValue && desejaReceberEmail.Value)
// {
//     System.Console.WriteLine("O usuuário optou por receber e-mail");
// }
// else
// {
//     System.Console.WriteLine("O usuário não respondeu ou optou por não receber");
// }
















// string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

// List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

// foreach (Venda venda in listaVenda)
// {
//     System.Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}" + $"{(venda.Desconto.HasValue ? $" Desconto de: {venda.Desconto}" : "")}"); 
// }




// DateTime dataAtual = DateTime.Now;

// List<Venda> listaVendas = new List<Venda>();

// Venda v1 = new Venda(1, "Materia de escritório", 25.00M, dataAtual);
// Venda v2 = new Venda(2, "Licença de Software", 100.00M, dataAtual);

// listaVendas.Add(v1);
// listaVendas.Add(v2);


// string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

// File.WriteAllText("Arquivos/vendas.json", serializado);

// System.Console.WriteLine(serializado);

















// int numero = 20;
// bool ehPar = false;

////if ternário
//ehPar = numero % 2 == 0;
//Console.WriteLine($"O número {numero} é " + (ehPar ? "par" : "impar"));


////if comum
// if (numero % 2 == 0)
// {
//     Console.WriteLine($"O numero {numero} é par");
// }
// else
// {
//     Console.WriteLine($"O numero {numero} é impar");
// }














// Pessoa p1 = new Pessoa("Caio", "Rodrigues");
// //Assim chama o contrutor

// (string nome, string sobrenome) = p1;
// //Assim chama o deconstrutor

// Console.WriteLine($"{nome} {sobrenome}");








// LeituraArquivo arquivo = new LeituraArquivo();

// var (sucesso, linhasArquivos, _) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");
// // a variável que esta com o "_", esta sendo descartada, porem ainda podendo ser reutilizada quando necessária. 


// if (sucesso)
// {
//     //Console.WriteLine($"Quantidade de linhas do arquivo: {QuantidadeLinhas}");
//     foreach (string linha in linhasArquivos)
//     {
//         Console.WriteLine(linha);
//     }
// }
// else
// {
//     Console.WriteLine("Não foi possivel ler o arquivo");
// }


















// (int, string, string, decimal) tupla = (1, "Caio", "Rodrigues", 1.80M);

// //Outros exemplos de sintaxe da Tupla
// // ValueTuple<int, string, string, decimal> outroExemploTupla = (1, "Caio", "Rodrigues", 1.80M);
// // var outroExemploTuplaCreate = Tuple.Create(1, "Caio", "Rodrigues", 1.80M);

// Console.WriteLine($"Id: {tupla.Item1}");
// Console.WriteLine($"Nome: {tupla.Item2}");
// Console.WriteLine($"Sobrenome: {tupla.Item3}");
// Console.WriteLine($"Altura: {tupla.Item4}");













// Dictionary<string, string> estados = new Dictionary<string, string>();

// estados.Add("SP", "São Paulo");
// estados.Add("BA", "Bahia");
// estados.Add("MG", "Minas Gerais");


// Console.WriteLine(estados["MG"]);



// foreach (var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// Console.WriteLine("------------");

// estados.Remove("BA");
// estados["SP"] = "São Paulo - valor aterado";

// foreach (var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// string chave = "BA";
// Console.WriteLine($"Verificando o elemento: {chave}");

// if (estados.ContainsKey(chave))
// {
//     Console.WriteLine($"Valor existente: {chave}");
// }
// else
// {
//     Console.WriteLine($"Valor não existe. É seguro adicionar a chave: {chave}");
// }
















// Stack<int> pilha = new Stack<int>();

// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);

// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");

// pilha.Push(20);

// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }











// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento: {fila.Dequeue}");
// fila.Enqueue(10);

// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }




























//new ExemploExcecao().Metodo1();






//string[] linhas = File.ReadAllLines("Arquivos/arquivo_Leitura.txt");
//Console.WriteLine("Chegou ate aqui!");


// try
// {
//     string[] linhas = File.ReadAllLines("Arquivos/arquivo_Leitura.txt");

//     foreach (string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }
// } 
// catch(FileNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado.{ex.Message}");
// }
// catch(DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho da pasta não enconrado");
// }
// catch(Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma exceção genérica! {ex.Message}"); 
// }
// finally
// {
//     Console.WriteLine("Chegou até aqui!");
// }

















//string dataString = "2022-13-18 18:00";

// bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);

// if (sucesso)
// {
//     Console.WriteLine($"Conversão realizada com sucesso {data}");
// }
// else
// {
//     Console.WriteLine($"{dataString} não é uma data válida");
// }






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
