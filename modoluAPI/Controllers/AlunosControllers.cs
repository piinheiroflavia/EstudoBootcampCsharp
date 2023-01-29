using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace modoluAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlunosControllers : ControllerBase
    {
        
        [HttpGet("CadastroAlunos")]
        //retorna um resultado http
        public IActionResult CadastroDosAlunos()
        {
            var obj = new
            {
                Data = DateTime.Now.ToLongDateString(),
                Hora = DateTime.Now.ToShortTimeString(),
                NomeCompleto = "Ana Pinheiro",
                Matricula = "22930",
                Cpf = "000000000",
                DataNascimento = "00/00/0000"
            };
            return Ok(obj);
        }
    }
}