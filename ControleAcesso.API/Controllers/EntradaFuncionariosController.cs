using ControleAcesso.Class;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ControleAcesso.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntradaFuncionariosController : ControllerBase
    {
        private static List<Movimento> ListaEntradaFuncionarios = new();

        [HttpGet]
        public async Task<IActionResult> RetonarEntradaFuncionarios()
        {
            return Ok(ListaEntradaFuncionarios);
        }        

        [HttpPost]
        public async Task<IActionResult> AdiconarEntradaFuncionarios(Movimento entradaFuncionario)
        {
            ListaEntradaFuncionarios.Add(entradaFuncionario);
            return Ok(ListaEntradaFuncionarios);
        }           

        
    }
}
