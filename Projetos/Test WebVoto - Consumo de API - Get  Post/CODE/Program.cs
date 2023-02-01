using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using CODE.models;
using System.Text.Json;
using System.Text.Json.Serialization;
using DotNetOpenAuth;
using DotNetOpenAuth.OAuth2;


using (var client = new HttpClient()) //POST - NewUser
{
    client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com"); //Trocar o Base address ao final (https://gene.lacuna.cc/)

    Console.WriteLine("UserName: ");
    string userNameIn = Console.ReadLine();

    Console.WriteLine("Email: ");
    string emailIn = Convert.ToString(Console.ReadLine());

    Console.WriteLine("Password: ");
    string passwordIn = Convert.ToString(Console.ReadLine());


    var creat = new NewUser (userNameIn, emailIn, passwordIn);
    var response = await client.PostAsJsonAsync("/api/users/create", creat);

    // if (response.IsSuccessStatusCode)
    // {
    //     Console.WriteLine("Code: Success");
    //     Console.WriteLine("Message: Seu usuario foi criado.");
    //     //Console.ReadKey();  //Pra qual situação realmente deve ser usado?
    // }
    // else
    // {
    //     Console.WriteLine($"Code: Error");
    //     Console.WriteLine($"Message: Verifique suas informações.");
    // } 
}

using (var client = new HttpClient()) //POST - Login
{
    client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com"); //Trocar o Base address ao final (https://gene.lacuna.cc/)

    var user = new NewUser();
    var newLogin = new Login (user.UserName, user.Password); //Recebe os valores da NewUser
    var response = await client.PostAsJsonAsync("/api/users/login", newLogin);
    // OAuth[newLogin.UserName] = consumerKey;
    // OAuth[newLogin.Password] = consumerSecret;
    
    // if (response.IsSuccessStatusCode)
    // {
    //     //Tratamento feitos nas prop da classe
    //     Console.WriteLine($"accessToken");
    //     Console.WriteLine($"Code: Success");
    //     Console.WriteLine($"Message:");
    // }
    // else
    // {
    //     Console.WriteLine($"Code: Error");
    //     Console.WriteLine($"Message: ");
    // }
}

using (var client = new HttpClient()) //GET - Jobs
{
    client.BaseAddress = new Uri("https://date.nager.at"); //Trocar o Base address ao final (https://gene.lacuna.cc/)
    client.DefaultRequestHeaders.Accept.Clear();
    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "");

    HttpResponseMessage response = await client.GetAsync("api/dna/jobs");

    if (response.IsSuccessStatusCode)//GET
    {
        string job = await response.Content.ReadAsStringAsync();

        var jobRetorno = JsonSerializer.Deserialize<List<Jobs>>(job);

        foreach (var item in jobRetorno)
        {
            Console.WriteLine($"Id: {item.Id} Type: {item.Type}");
            Console.WriteLine($"Strand: {item.Strand}");
            Console.WriteLine($"Strand Encoded {item.StrandEncoded}");
            Console.WriteLine($"Gene Encoded {item.GeneEncoded}");
        }
        
        // Console.WriteLine("Code: Success");
        // Console.WriteLine("Message: ");
    }
    // else
    // {
    //     Console.WriteLine("Code: Error!");
    //     Console.WriteLine("Message: ");
    // }
}

using (var client = new HttpClient()) //POST - decode
{
    client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com"); //Trocar o Base address ao final (https://gene.lacuna.cc/)
    client.DefaultRequestHeaders.Accept.Clear();
    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "");

    var idJob = new Jobs {Id = ""};//Dessa forma, consigo receber o id da classe e colocar na rota dinamica abaixo?
    var response = await client.PostAsJsonAsync("/api/dna/jobs/{id}/decode", idJob);

    // if (response.IsSuccessStatusCode)
    // {
    //     Chamar o metodo da classe "Jobs" que vai decodar o strand em formato string

    //     Tratamento feitos nas prop da classe
    //     Console.WriteLine($"Code:");// ['Success', 'Error', 'Fail', 'Unauthorized']
    //     Console.WriteLine($"Message:");
    // }
}

using (var client = new HttpClient()) //POST - encode
{
    client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com"); //Trocar o Base address ao final (https://gene.lacuna.cc/)
    client.DefaultRequestHeaders.Accept.Clear();
    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "");

    var id = new Jobs();// O valor vai receber ele mesmo pra conseguir ter uma leitura direto da classe?
    var idJob = new Jobs {Id = id.Id};//Dessa forma, consigo receber o id da classe e colocar na rota dinamica abaixo?
    var response = await client.PostAsJsonAsync("/api/dna/jobs/{id}/encode", idJob);

    // if (response.IsSuccessStatusCode;)
    // {
    //     Chamar o metodo da classe "Jobs" que vai decodar o strand em formato binário

    //     Tratamento feitos nas prop da classe
    //     Console.WriteLine($"Code:");// ['Success', 'Error', 'Fail', 'Unauthorized']
    //     Console.WriteLine($"Message:");
    // }
}

using (var client = new HttpClient()) //POST - gene
{
    client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com"); //Trocar o Base address ao final (https://gene.lacuna.cc/)
    client.DefaultRequestHeaders.Accept.Clear();
    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "");

    var id = new Jobs();// O valor vai receber ele mesmo pra conseguir ter uma leitura direto da classe?
    var idJob = new Jobs {Id = id.Id};//Dessa forma, consigo receber o id da classe e colocar na rota dinamica abaixo?
    var response = await client.PostAsJsonAsync("/api/dna/jobs/{id}/gene", idJob);

    // if (response.IsSuccessStatusCode)
    // {
    //     Chamar o metodo da classe "Jobs" que vai comparar a fita molde, para saber se ela está mais de 50% presente dentro da outra.

    //     Tratamento feitos nas prop da classe
    //     Console.WriteLine($"Code:");// ['Success', 'Error', 'Fail', 'Unauthorized']
    //     Console.WriteLine($"Message:");
    // }
}


//Usar um método para as conecxoes?
//Quando o tratamento da propriedade é na saida, eu jogo no get?
//Verificar a linha da autorização com token
//As mensgens no NewUser são necessárias ou a api vai trazer esse retorno?


//O foreach já esta jogando os os valores nas propriedades da classe jobs?
//Coloco read.line no NewUser ou deixo um valor atribuido?
//Faço uma nova classe para os metodos de retorno, ou crio os métodos dentro da propria classe "jobs"


//O encapsulamento deve ser na classe "NewUser" ou na classe "login"
//Não há tratamento na classe "Login"