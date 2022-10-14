using Fundamentos.Common.Models;
using System.IO;
using System.Collections;





Calculadora calc = new Calculadora();
calc.Somar(10, 20);












// // Coleções

// //Dicionários
// // Dictionary<string, string> dados = new Dictionary<string, string>;

// // dados.Add("Nome", "Jose da Silva");
// // dados.Add("Rg", "4764634");
// // dados.Add("Telefone", "(11) 942404406");

// // Console.WriteLine(dados["Nome"]);
// // Console.WriteLine(dados["Rg"]);
// // Console.WriteLine(dados["Telefone"]);



// Pilha - FILO First in, last out

// Stack<string> pilha = new Stack<string>();
// pilha.Push("Objeto1");
// pilha.Push("Objeto2");
// pilha.Push("Objeto3");

// while (pilha.Count > 0)
// {
//     string item = pilha.Pop();
//     Console.WriteLine(item);
// }







//fila - FIFO fisrt in, first out
// Queue<string> fila = new Queue<string>();

// fila.Enqueue("Processo1");
// fila.Enqueue("Processo2");
// fila.Enqueue("Processo3");

// while (fila.Count > 0)
// {
//     string item = fila.Dequeue();
//     Console.WriteLine(item);
// }




// Lista

List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("BA");
listaString.Add("MG");
listaString.Add("RJ");

Console.WriteLine($"Itens na minha lista: {listaString.Count} = Capacidade: {listaString.Capacity}");

listaString.Add("SC");

Console.WriteLine($"Itens na minha lista: {listaString.Count} = Capacidade: {listaString.Capacity}");

listaString.Remove("MG");

Console.WriteLine($"Itens na minha lista: {listaString.Count} = Capacidade: {listaString.Capacity}");






// for(int contador = 0; contador < listaString.Count; contador++)
// {
//     Console.WriteLine($"Posição Nº {contador} - {listaString[contador]}");
// }


// int contadorForeach = 0;
// foreach(int item in listaString)
// {
//     Console.WriteLine($"Posição {contadorForeach} - {listaString[contadorForeach]}");
// }






// -------------------------------------------------------------------------------
// List<string> cidades = new List<string>();
// cidades.Add("São Paulo");
// cidades.Add("Rio de Janeiro");
// cidades.Add("Belém");

// List<int> numeros = new List<int>();
// numeros.Add(10);
// numeros.Add(78);

// foreach (string cid in cidades)
// {
//     Console.WriteLine(cid);
// }

// foreach(int num in numeros)
// {
//     Console.WriteLine(num);
// }



// como era antigamente
// ArrayList lista = new ArrayList();
// lista.Add("São Paulo");
// lista.Add("Rio de Janeiro");
// lista.Add("Belém");


// string cidade = Convert.ToString(lista[1]);

// foreach (string cid in lista)
// {
//     Console.WriteLine(cid);
// }

// lista.Remove("Belém");
// lista.Insert(0, "Londres");

// Console.WriteLine("-----------------------");

// foreach (string cid in lista)
// {
//     Console.WriteLine(cid);
// }
// int tamanho = lista.Count; //conta quantos elemente tem na coleção

// Console.WriteLine($"Tamanho: {tamanho}");












// ARRAYS

// int[] arrayInteiros =new int[3];

// arrayInteiros[0] = 72;
// arrayInteiros[1] = 64;
// arrayInteiros[2] =50;

// Caso precise do valor do contador, usar FOR
// for (int contador = 0; contador < arrayInteiros.Length; contador++)
// {
//     Console.WriteLine($"Posição Nº {contador} - {arrayInteiros[contador]}");
// }

// int contadorForeach = 0;
// foreach(int valor in arrayInteiros)
// {
//     Console.WriteLine($"Posição Nº {contadorForeach} - {valor}");
//     contadorForeach++;
// }



//Mudar o tamanha do array

//Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

// Copiar um array (Exemplo do que o Arrys.Resize faz por baixo dos panos)

// int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
// Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);


//-------------------------------------------------------------------

// int[] numeros = new int[6];

// //Preenchendo o arrays
// numeros[0] = 40;
// numeros[1] = 5;
// numeros[2] = 52;
// numeros[3] = 17;
// numeros[4] = 6;
// numeros[5] = 10;



// // percorrer o arrays

// // for (int i = 0; i < 6; i++)
// // {
// //     Console.WriteLine("numeros[i]");
// // }

// foreach(int n in numeros)
// {
//     Console.WriteLine(n);
// }



// // ordenar
// Array.Sort(numeros);

// Array.Reverse(numeros);

// foreach(int n in numeros)
// {
//     Console.WriteLine(n);
// }



// // Pesquisar
// int indice = Array.IndexOf(numeros, 10);
// if (indice == -1)
// {
//     Console.WriteLine("O numero não fi encontrado");
// }
// else
// {
//     Console.WriteLine($"Encontrado {numeros[indice]} na poscição {indice}");
// }



// // Tamanho do Arrays

// int tamanho = numeros.Length;
// Console.WriteLine(tamanho);



// // Exemplo System IO

// string[] arquivos = Directory.GetFiles(@"C:\windows\web", "*.*", SearchOption.AllDirectories);
// foreach(string arq in arquivos)
// {
//     Console.WriteLine(arq);
// }










// Exemplo menu

// string opcao;
// bool exibirMenu = true;

// while (exibirMenu)
// {
//     Console.Clear();
//     Console.WriteLine("Digite a sua opção: ");
//     Console.WriteLine("1 - Cadastrar Cliente");
//     Console.WriteLine("2 - Buscar Cliente");
//     Console.WriteLine("3 - Apagar Cliente");
//     Console.WriteLine("4 - Encerrar");

//     opcao = Console.ReadLine();

//     switch(opcao)
//     {
//         case "1":
//             Console.WriteLine("Cadastro de cliente");
//             break;

//         case "2":
//             Console.WriteLine("Busca de Cliente");
//             break;

//         case "3":
//             Console.WriteLine("Apagar Cliente");
//             break;

//         case "4":
//             Console.WriteLine("Encerrar");
//             exibirMenu = false; //Termina apenas o while e continua o programa
//             //Environment.Exit(0); Fecha o programa inteiro
//             break;

//         default:
//             Console.WriteLine("Opção invalida");
//             break;
//     }
// }

// Console.WriteLine("O programa de encerrou");








// Do while

// int soma = 0, numero = 0;

// do 
// {
//     Console.WriteLine("Digite um numero: (zero para)");
//     numero = Convert.ToInt32(Console.ReadLine());
    
//     soma += numero;

// } while (numero != 0);

// Console.WriteLine($"Total da soma dos numeros digitados é {soma}");













// while

// int numero = 5;
// int contador = 1;

// while (contador <= 10)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
//     contador++;
//     if (contador == 5)
//     {
//         break;
//     }
// }









// for

// int numero = 5;

// for (int contador = 1; contador <= 10; contador++)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// }










// Incremento e descremento

// int numeroIncremento = 10;
// Console.WriteLine("Incrementando o 10");
// numeroIncremento++;

// Console.WriteLine(numeroIncremento);

// int numeroDecremento = 10;
// Console.WriteLine("Decrementando o 10");
// numeroDecremento--;

// Console.WriteLine(numeroDecremento);









// Operadores matematicos

// Calculadora calc = new Calculadora();

// calc.Somar(10, 30);
// calc.Subtrair(10, 50);
// calc.Multiplicar(15, 45);
// calc.Dividir(2, 2);
// calc.Potencia(3, 3);
// calc.Seno(30);
// calc.Coseno(30);
// calc.Tangente(30);
// calc.RaizQuadrada(9);









// Operador not(!)

// bool choveu = false;
// bool estaTarde = false;

// if (!choveu && !estaTarde)
// {
//     Console.WriteLine("Vou pedalar");
// }
// else
// {
//     Console.WriteLine("Vou pedalar outro dia");
// }


// Operador our (||)

// Condição

// bool eMaiorDeIdade = true;
// bool possuiAutorizacaoDoResponsavel = true;

// if (eMaiorDeIdade || possuiAutorizacaoDoResponsavel)
// {
//     Console.WriteLine("Entrada Liberada");
// }
// else
// {
//     Console.WriteLine("Entrada não liberada");
// }








// Switch

// Console.WriteLine("Digite uma letra: ");
// string letra = Console.ReadLine();


// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("Vogal");
//         break;

//     default:
//         Console.WriteLine("Não é uma vogal");
//         break;
// }




// if (letra == "a" ||
//     letra == "e" ||
//     letra == "i" ||
//     letra == "o" ||
//     letra == "u")
// {
//     Console.WriteLine("Vogal");
// }
// else
// {
//     Console.WriteLine("Não é uma vogal");
// }




// if(letra == "a")
// {
//     Console.WriteLine("Vogal");
// }
// else if(letra == "e")
// {
//     Console.WriteLine("Vogal");
// }
// else if(letra =="i")
// {
//     Console.WriteLine("Vogal");
// }
// else if(letra == "o")
// {
//     Console.WriteLine("Vogal");
// }
// else if(letra == "u")
// {
//     Console.WriteLine("Vogal");
// }
// else
// {
//     Console.WriteLine("Não é uma vogal");
// }









// int quantidadeEmEstoque = 10;
// int quantidadeCompra = 4;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade da compra: {quantidadeCompra}");
// Console.WriteLine($"É possivel realizar a venda? {possivelVenda}");

// if(quantidadeCompra == 0)
// {
//     Console.WriteLine("Venda Invalida");
// }
// else if(possivelVenda) 
// {
//     Console.WriteLine("Venda Realizada");
// }
// else
// {
//     Console.WriteLine("Desculpe, não temos a quantidade em estoque!");
// }




// string a = "15-";

// int b = 0;

// int.TryParse(a, out b);

// Console.WriteLine(b);
// Console.WriteLine("Conversão realizada com sucesso!");




// int inteiro = 5;
// string a = inteiro.ToString();

// Console.WriteLine(a);



// Cast - Casting
// int a = Convert.ToInt32("5");
// int a = int.Parse("5");

// Console.WriteLine(a);






// int a = 10;
// int b = 20;

// int c = a + b;

// c += 5;

// Console.WriteLine(c);





// DateTime dataAtual = DateTime.Now.AddDays(5);
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));


// string apresentacao = "Olá, seja bem vindo";

// int quantidade = 1;
// quantidade = 10;

// double altura = 1.80;

// decimal preco = 1.80M;

// bool condicao = true;

// Console.WriteLine(apresentacao);
// Console.WriteLine("Valo da variavel quantidade: " + quantidade);
// Console.WriteLine("Valor da variavel altura: " + altura.ToString("0.00"));
// Console.WriteLine("Valor da variavel preço: " + preco);
// Console.WriteLine("Valor da variavel condição:" + condicao);




// Pessoa pessoa1 = new Pessoa();

// pessoa1.nome = "Caio";
// pessoa1.idade = 33;
// pessoa1.Apresentar();
