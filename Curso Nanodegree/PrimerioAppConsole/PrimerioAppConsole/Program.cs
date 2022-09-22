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
        Console.ReadLine();







        
    }
}