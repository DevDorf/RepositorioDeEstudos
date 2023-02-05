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
    try
    {
        client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com"); //Trocar o Base address ao final (https://gene.lacuna.cc/)

        var create = new NewUser ("CaioRodrigues", "caiorodrigues1989@gmail.com", "0811476693");
        var response = await client.PostAsJsonAsync("/api/users/create", create);

        string newUserResponse = await response.Content.ReadAsStringAsync();
        var newUserRetorno = JsonSerializer.Deserialize<Response>(newUserResponse);
    }
    catch (System.Exception)
    {
        throw;
    }
}

using (var client = new HttpClient()) //POST - Login
{
    try
    {
        client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com"); //Trocar o Base address ao final (https://gene.lacuna.cc/)

        var user = new NewUser();
        var newLogin = new Login (user.UserName, user.Password); //Recebe os valores da NewUser
        var response = await client.PostAsJsonAsync("/api/users/login", newLogin);

        string loginResponse = await response.Content.ReadAsStringAsync();
        var loginRetorno = JsonSerializer.Deserialize<Response>(loginResponse);
        var tokenRetorno = JsonSerializer.Deserialize<Token>(loginResponse); //dessa forma ele dá o response pra cada classe?    
    }
    catch (System.Exception)
    {
        throw;
    }
    
}

using (var client = new HttpClient()) //GET - Jobs
{
    try
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

                        var responseDecodeStrand = await client.PostAsJsonAsync($"/api/dna/jobs/{job.Id}/decode", new JobsReturn(strandDecode, "", false)); // verificar os parametrosda classe JobReturn
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

                        var responseEncodeStrand = await client.PostAsJsonAsync($"/api/dna/jobs/{job.Id}/encode", new JobsReturn("", strandEncode, false)); // verificar como colocar apenas 1 parametro da classe JobReturn
                        string encodeResponseString = await responseEncodeStrand.Content.ReadAsStringAsync();
                        var decodeRetorno = JsonSerializer.Deserialize<Response>(encodeResponseString);
                    }
                }

                else if (job.Type == "CheckGene")
                {
                    dynamic isActvated = Conversor.GeneCheck(job.StrandEncoded, job.GeneEncoded);

                    using (var clientGeneEncode = new HttpClient()) //POST - gene
                    {
                        client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com"); //Trocar o Base address ao final (https://gene.lacuna.cc/)
                        client.DefaultRequestHeaders.Accept.Clear();
                        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Token.AccessToken);

                        var responseGeneEncode = await client.PostAsJsonAsync($"/api/dna/jobs/{job.Id}/gene", new JobsReturn("", "", isActvated)); // verificar os parametrosda classe JobReturn
                        string geneEncodeResponseString = await responseGeneEncode.Content.ReadAsStringAsync();
                        var geneEncodeRetorno = JsonSerializer.Deserialize<Response>(geneEncodeResponseString);
                    }
                }
            }
        }    
    }
    catch (System.Exception)
    {
        
        throw;
    }
}

//Usar um método para as conecxoes?
//O encapsulamento deve ser na classe "NewUser" ou na classe "login"