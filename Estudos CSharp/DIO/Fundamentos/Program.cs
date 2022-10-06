using Fundamentos.Models;



// ARRAYS

int[] numeros = new int[6];

//Preenchendo o arrays
numeros[0] = 40;
numeros[1] = 5;
numeros[2] = 52;
numeros[3] = 17;
numeros[4] = 6;
numeros[5] = 10;

// percorrer o arrays

// for (int i = 0; i < 6; i++)
// {
//     Console.WriteLine("numeros[i]");
// }

foreach(int n in numeros)
{
    Console.WriteLine(n);
}

// ordenar
Array.Sort(numeros);

Array.Reverse(numeros);

foreach(int n in numeros)
{
    Console.WriteLine(n);
}

// Pesquisar
int indice = Array.IndexOf(numeros, 10);
if (indice == -1)
{
    Console.WriteLine("O numero não fi encontrado");
}
else
{
    Console.WriteLine($"Encontrado {numeros[indice]} na poscição {indice}");
}
















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




// int soma = 0, numero = 0;

// do 
// {
//     Console.WriteLine("Digite um numero: (zero para)");
//     numero = Convert.ToInt32(Console.ReadLine());
    
//     soma += numero;

// } while (numero != 0);

// Console.WriteLine($"Total da soma dos numeros digitados é {soma}");






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




// int numero = 5;

// for (int contador = 1; contador <= 10; contador++)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// }




// int numeroIncremento = 10;
// Console.WriteLine("Incrementando o 10");
// numeroIncremento++;

// Console.WriteLine(numeroIncremento);

// int numeroDecremento = 10;
// Console.WriteLine("Decrementando o 10");
// numeroDecremento--;

// Console.WriteLine(numeroDecremento);



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
