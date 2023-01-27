using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Teste.models;
using System.Text.Json;
using System.Text.Json.Serialization;

using (var client = new HttpClient())
{
    client.BaseAddress = new Uri("https://date.nager.at");
    client.DefaultRequestHeaders.Accept.Clear();
    //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
    Console.WriteLine("passou aqui");
    HttpResponseMessage response = await client.GetAsync("/api/v3/PublicHolidays/2023/BR");
    if (response.IsSuccessStatusCode)
    {  //GET
        string feriado = await response.Content.ReadAsStringAsync();
        var feriadosRetorno = JsonSerializer.Deserialize<List<Feriado>>(feriado);
        foreach (var item in feriadosRetorno)
        {
            Console.WriteLine($"Data: {item.date} Código do País: {item.countryCode}");
        }

        Console.ReadKey();
    }
}
//POST

using (var client = new HttpClient())
{
    client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com");
    var cha = new Post {title = "foo", body = "bar", userId = 1 };
    var response = await client.PostAsJsonAsync("posts", cha);
    if (response.IsSuccessStatusCode)
    {
        Console.WriteLine("post criado");
        Console.ReadKey();
    }   
}

