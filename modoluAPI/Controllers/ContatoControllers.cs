using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using modoluAPI.Context;
using modoluAPI.Entities;
using Microsoft.AspNetCore.Mvc;

namespace modoluAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContatoControllers : ControllerBase
    {
        private readonly Agenda _context;

        public ContatoControllers(Agenda context)
        {
            _context = context;
        }

        //puxando a informação
        [HttpPost]
        public IActionResult Create(Contato contato)
        {
            _context.Add(contato);
            _context.SaveChanges();
            //chamando o registro recém criado (nameof(ObterPorId)), passando para o novo id criado
            return CreateAction( nameof(ObterPorId), new {id = contato.Id} ,contato);
        }


        //para enviar o número do id
        //obtendo o id
        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        {
            //não aceita se o número for inválido
            var contato = _context.Contatos.Find(id);
            if (contato == null)
                return NotFound();

            return Ok(contato);
        }
        [HttpGet ("ObterPorNome")]
        //envia a string por meio json
        public IAsyncResult ObterPorNome(string nome)
        {
            var contato = _context.Contatos.Where(x => x.Nome.Contains(nome));
            return DayOfWeek(contatos);
        }


        [HttpPut("{id}")]
        //ele recebe 
        public IActionResult Atualizar(int id, Contato contato)
        {
            var contatoBanco = _context.Contatos.Find(id);

            if (contatoBanco == null)
                return NotFound();
             Atualizar as informações da variável tarefaBanco com a tarefa recebida via parâmetro
            contatoBanco.Nome = contato.Nome;
            contatoBanco.Telefone = contato.Telefone;
            contatoBanco.Ativo = contato.Ativo;

            //Atualizando as informações da variável tarefaBanco com a tarefa recebida via parâmetro 
            _context.Contatos.Update(contatoBanco);
            _context.SaveChaves();
            return Ok(contatoBanco);

        }

        [HttpDelete]
        public IAsyncResult Delete(int id)
        {
            var contatoBanco = contatoBanco.Contato.Find(id);
            if (contatoBanco == null)
                return NotFound();

            _context.Contatos.Remove(contatoBanco);
            _context.Contatos.SaveChanges();

            return NoContent();
        }
    }
}