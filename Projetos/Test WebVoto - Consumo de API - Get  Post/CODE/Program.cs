using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using CODE.models;
using System.Text.Json;
using System.Text.Json.Serialization;

using (var client = new HttpClient())
{
    client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com"); //Trocar o Base address ao final (https://gene.lacuna.cc/)

    var creat = new NewUser ("CaioRodrigues", "caiorodrigues1989@gmail.com", "estagiodev");
    var response = await client.PostAsJsonAsync("/api/users/create", creat);
    var conect = response.IsSuccessStatusCode;  

    if (conect == true)
    {
        //Tratamento feitos nas prop da classe
        Console.WriteLine("Code: Success");
        Console.WriteLine("Message: Seu usuario foi criado.");
        //Console.ReadKey();  //Pra qual situação realmente deve ser usado?
    }
    else
    {
        //Tratamento feitos nas prop da classe
        Console.WriteLine($"Code: Error");
        Console.WriteLine($"Message: ");
    } 
}

using (var client = new HttpClient())
{
    client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com"); //Trocar o Base address ao final (https://gene.lacuna.cc/)

    var user = new NewUser();
    var newLogin = new Login (user.UserName, user.Password); //Recebe os valores da classe NewUser
    var response = await client.PostAsJsonAsync("/api/users/login", newLogin);
    var conect = response.IsSuccessStatusCode;

    if (conect == true)
    {
        //Tratamento feitos nas prop da classe
        Console.WriteLine($"accessToken");
        Console.WriteLine($"Code: Success");
        Console.WriteLine($"Message:");
    }
    else
    {
        Console.WriteLine($"Code: Error");
        Console.WriteLine($"Message: ");
    }
}

using (var client = new HttpClient())
{
    client.BaseAddress = new Uri("https://date.nager.at"); //Trocar o Base address ao final (https://gene.lacuna.cc/)
    client.DefaultRequestHeaders.Accept.Clear(); //Authorization = Bearer <Access Token> <AcessToken> aquired on 2.2

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
        
        Console.WriteLine($"Code:");// ['Success', 'Error']
        Console.WriteLine($"Message:");
        Console.ReadKey();
    }
}

using (var client = new HttpClient())
{
    //Header//Authorization = Bearer <Access Token> //<AcessToken> aquired on 2.2

    client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com"); //Trocar o Base address ao final (https://gene.lacuna.cc/)

    var id = new Jobs();// O valor vai receber ele mesmo pra conseguir ter uma leitura direto da classe?
    var idJob = new Jobs {Id = id.Id};//Dessa forma, consigo receber o id da classe e colocar na rota dinamica abaixo?
    var response = await client.PostAsJsonAsync("/api/dna/jobs/{id}/decode", idJob);
    var conect = response.IsSuccessStatusCode;

    if (conect == true)
    {
        //Chamar o metodo da classe "Jobs" que vai decodar o strand em formato string

        //Tratamento feitos nas prop da classe
        Console.WriteLine($"Code:");// ['Success', 'Error', 'Fail', 'Unauthorized']
        Console.WriteLine($"Message:");
    }
}

using (var client = new HttpClient())
{
    //Header//Authorization = Bearer <Access Token> //<AcessToken> aquired on 2.2

    client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com"); //Trocar o Base address ao final (https://gene.lacuna.cc/)

    var id = new Jobs();// O valor vai receber ele mesmo pra conseguir ter uma leitura direto da classe?
    var idJob = new Jobs {Id = id.Id};//Dessa forma, consigo receber o id da classe e colocar na rota dinamica abaixo?
    var response = await client.PostAsJsonAsync("/api/dna/jobs/{id}/encode", idJob);
    var conect = response.IsSuccessStatusCode;

    if (conect == true)
    {
        //Chamar o metodo da classe "Jobs" que vai decodar o strand em formato binário

        //Tratamento feitos nas prop da classe
        Console.WriteLine($"Code:");// ['Success', 'Error', 'Fail', 'Unauthorized']
        Console.WriteLine($"Message:");
    }
}

using (var client = new HttpClient())
{
    //Header//Authorization = Bearer <Access Token> //<AcessToken> aquired on 2.2

    client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com"); //Trocar o Base address ao final (https://gene.lacuna.cc/)

    var id = new Jobs();// O valor vai receber ele mesmo pra conseguir ter uma leitura direto da classe?
    var idJob = new Jobs {Id = id.Id};//Dessa forma, consigo receber o id da classe e colocar na rota dinamica abaixo?
    var response = await client.PostAsJsonAsync("/api/dna/jobs/{id}/gene", idJob);
    var conect = response.IsSuccessStatusCode;

    if (conect == true)
    {
        //Chamar o metodo da classe "Jobs" que vai comparar a fita molde, para saber se ela está mais de 50% presente dentro da outra.

        //Tratamento feitos nas prop da classe
        Console.WriteLine($"Code:");// ['Success', 'Error', 'Fail', 'Unauthorized']
        Console.WriteLine($"Message:");
    }
}


// using (var client = new HttpClient())
// {
//     client.BaseAddress = new Uri("https://date.nager.at");
//     client.DefaultRequestHeaders.Accept.Clear();

//     HttpResponseMessage response = await client.GetAsync("api/users/create");

//     if (response.IsSuccessStatusCode)
//     {  //GET
//         string feriado = await response.Content.ReadAsStringAsync();
//         var feriadosRetorno = JsonSerializer.Deserialize<List<Feriado>>(feriado);
//         foreach (var item in feriadosRetorno)
//         {
//             Console.WriteLine($"Data: {item.date} Código do País: {item.countryCode}");
//         }

//         Console.ReadKey();
//     }
// }







//POST

// using (var client = new HttpClient())
// {
//     client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com");
//     var cha = new Post {title = "foo", body = "bar", userId = 1 };
//     var response = await client.PostAsJsonAsync("posts", cha);
//     if (response.IsSuccessStatusCode)
//     {
//         Console.WriteLine("post criado");
//         Console.ReadKey();
//     }   
// }


