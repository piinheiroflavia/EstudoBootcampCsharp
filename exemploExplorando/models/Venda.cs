using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using  Newtonsoft.Json;

namespace exemploExplorando.models
{
    public class Venda
    {
        public int Id { get; set; }

        [JsonProperty("Nome_Produto")]
        public string Produto { get; set; }
        public Venda(string produto)
        {
            Produto = produto;
        }

        public decimal Preco {get; set;}
        public DateTime DataVenda { get; set; }
        public decimal? Desconto { get; set; }
    }
}