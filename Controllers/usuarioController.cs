using Microsoft.AspNetCore.Mvc;

namespace AgendaContatos_WebAPI
{

    [Route("[Controller]")]
    public class usuarioController : ControllerBase
    {
        [HttpGet("ObterDataHoraAtual")]
        public IActionResult ObterDataHora()
        {
            var obj = new
            {
                Data = DateTime.Now.ToLongDateString(),
                Hora = DateTime.Now.ToShortDateString()
            };

            return Ok (obj);
        }

        //Metodo com parametro
        [HttpGet("Apresentar/{nome}")]
        public IActionResult Apresentar (string nome) 
        {
            var mensagem = $"Olá {nome}, seja bem vindo ! ";
            return Ok (new {mensagem});
        }
        
    }
}