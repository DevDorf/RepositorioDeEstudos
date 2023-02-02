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

    var create = new NewUser ("CaioRodrigues", "caiorodrigues1989@gmail.com", "0811476693");
    var response = await client.PostAsJsonAsync("/api/users/create", create);

    string newUserResponse = await response.Content.ReadAsStringAsync();
    var newUserRetorno = JsonSerializer.Deserialize<Response>(newUserResponse);
}

using (var client = new HttpClient()) //POST - Login
{
    client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com"); //Trocar o Base address ao final (https://gene.lacuna.cc/)

    var user = new NewUser();
    var newLogin = new Login (user.UserName, user.Password); //Recebe os valores da NewUser
    var response = await client.PostAsJsonAsync("/api/users/login", newLogin);

    string loginResponse = await response.Content.ReadAsStringAsync();
    var loginRetorno = JsonSerializer.Deserialize<Response>(loginResponse);
    var tokenRetorno = JsonSerializer.Deserialize<Token>(loginResponse); //dessa forma ele dáo response de maneira separada?
}

using (var client = new HttpClient()) //GET - Jobs
{
    var Token = new Token();

    client.BaseAddress = new Uri("https://date.nager.at"); //Trocar o Base address ao final (https://gene.lacuna.cc/)
    client.DefaultRequestHeaders.Accept.Clear();
    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Token.AccessToken);

    HttpResponseMessage response = await client.GetAsync("api/dna/jobs");

    if (response.IsSuccessStatusCode)//GET
    {
        string jobResponse = await response.Content.ReadAsStringAsync();
        var jobRetorno = JsonSerializer.Deserialize<List<Jobs>>(jobResponse);

        foreach (var job in jobRetorno)
        {
            if (job.Type == "DecodeStrand")
            {
                string strandDecode = Conversor.EncodeBinaryToBase64(job.StrandEncoded);

                using (var clientDecodeStrand = new HttpClient()) //POST - decode
                {
                    client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com"); //Trocar o Base address ao final (https://gene.lacuna.cc/)
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Token.AccessToken);

                    var responseDecodeStrand = await client.PostAsJsonAsync($"/api/dna/jobs/{job.Id}/decode", new { strand = strandDecode });
                    string decodeResponseString = await responseDecodeStrand.Content.ReadAsStringAsync();
                    var decodeRetorno = JsonSerializer.Deserialize<Response>(decodeResponseString);
                }
            }
            else if (job.Type == "EncodeStrand")
            {
                string strandEncode = Conversor.EncodeBase64ToBinary(job.Strand);

                using (var clientEncodeStrand = new HttpClient()) //POST - encode
                {
                    client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com"); //Trocar o Base address ao final (https://gene.lacuna.cc/)
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Token.AccessToken);

                    var responseEncodeStrand = await client.PostAsJsonAsync($"/api/dna/jobs/{job.Id}/encode", new { strandEncode = strandEncode });
                    string encodeResponseString = await responseEncodeStrand.Content.ReadAsStringAsync();
                    var decodeRetorno = JsonSerializer.Deserialize<Response>(encodeResponseString);
                }
            }

            else if (job.Type == "CheckGene")
            {

            }
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
//O encapsulamento deve ser na classe "NewUser" ou na classe "login"