using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


//entidades - tabela do banco dados, que guarda as entidades
namespace modoluAPI.Entities
{
    public class Contato
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public bool ativo { get; set; }
    }
}