// See https://aka.ms/new-console-template for more information

Console.Write("Digite o valor do produto: ");
decimal valor = Convert.ToDecimal(Console.ReadLine());

Console.Write("Digite a quantidade desejada: ");
int quantidade = Convert.ToInt32(Console.ReadLine());

decimal resultado = quantidade * valor;

Console.WriteLine("O valor total da compra é: {0:c}", resultado);

Console.WriteLine("Qual o numero de parcelas?");
int numParcela = Convert.ToInt32(Console.ReadLine());

decimal parcela = resultado / numParcela;

Console.Write("Você tera uma parcela de: {0:c}", parcela);
