using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using modoluAPI.Entities;


//é a classe que vai acessar o banco de dados, 
namespace modoluAPI.Context
{
    public class Agenda : DbContext
    {
        public Agenda(DbContextOptions<Agenda> options) : base(options)
        {

        }

        //toda set está liganda a criação de tabelas
        //ligando ao banco de dados
        //propriedade
        public DbSet<Contato> Contatos {get; set;}
    }
}