internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello Word!");
        Console.WriteLine("Meu nome é Caio");
        Console.WriteLine("Meu e-mail é: caiorodrigue1989@gmai.com");
        Console.WriteLine("55+ (11) 94240-4406");

        string nome;
        int idade;

        Console.WriteLine("Digite o se nome:");
        nome = Console.ReadLine();

        Console.WriteLine("Digite a sua idade:");
        idade = Convert.ToInt32(Console.ReadLine());

        int dias = idade * 365;

        Console.WriteLine("Olá {0}, você já viveu {1} dias.", nome, dias);

        //Soma de dois numeros

        int n1, n2, resultado;

        Console.Write("Digite um valor: ");
        n1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite outro valor: ");
        n2 = Convert.ToInt32(Console.ReadLine());

        resultado = n1 + n2;

        Console.WriteLine("A soma entre os valore {0} e {1} é: {2}", n1, n2, resultado);

        // Esudo de Tipos Primitivos

        Console.WriteLine("Tipos Primitivos");

        string nome = "Camila";
        int numero = 33;
        long nuemroGrande = 01973147187;

        double comissao = 32.344566;
        decimal valor = Convert.ToDecimal(1000.56);
        decimal valor1 = 1000.56m;

        DateTime data = DateTime.Now;
        DateTime dataExemplo = new DateTime(2050, 12, 31);

        Console.WriteLine("{0:d}", dataExemplo);  //data curta -> 31/02/31
        Console.WriteLine("{0:D}", dataExemplo); //data longa -> sábado, 31 de fevereiro de 2050
        Console.WriteLine("{0:ddd}", dataExemplo); // só as tres primeiras letras da semana -> sab

        Console.WriteLine("{0:c}", valor1);










        byte item = 20;










        
    }
}