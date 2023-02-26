using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Exemplo_Explorando.Models
{
    public class Venda
    {
        public int Id { get; set; }

        [JsonProperty("Nome_Produto")] // adicionando uma informação adicional para indicar o valor que esta chegando da descerialização
        public string Produto { get; set; }

        public decimal Preco { get; set; }
        public DateTime DataVenda { get; set; }
        public decimal? Desconto { get; set; } //colocando a interrogação, a gente coloca o null como valor válido
    }
}