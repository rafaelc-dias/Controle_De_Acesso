using ControleAcesso.Class;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ControleAcesso.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoasController : ControllerBase
    {
        private static List<Pessoas> ListaPessoas = new();

        [HttpGet]
        public async Task<IActionResult> RetonarPessoas()
        {
            return Ok(ListaPessoas);
        }

        [HttpGet("{documento}")]
        public async Task<IActionResult> RetonarPessoas(string documento)
        {
            var pessoa = ListaPessoas.Find(pessoaResultado => pessoaResultado.Documento == documento);

            if (pessoa == null)
                return BadRequest("Pessoa não encontrada");
            return Ok(pessoa);
        }

        [HttpPost]
        public async Task<IActionResult> AdiconarPessoa(Pessoas pessoa)
        {
            ListaPessoas.Add(pessoa);
            return Ok(ListaPessoas);
        }

        [HttpPut]
        public async Task<IActionResult> AlterarPessoa(Pessoas pessoaProcurada)
        {
            var pessoa = ListaPessoas.Find(pessoaResultado => pessoaResultado.Documento == pessoaProcurada.Documento);

            if (pessoa == null)
                return BadRequest("Pessoa não encontrada");

            pessoa.AltearNomePessoa(pessoaProcurada.Nome);
           
            return Ok(pessoa);
        }

        [HttpDelete("{documento}")]
        public async Task<IActionResult> RemoverPessoas(string documento)
        {
            var pessoa = ListaPessoas.Find(pessoaResultado => pessoaResultado.Documento == documento);

            if (pessoa == null)
                return BadRequest("Pessoa não encontrada");
            ListaPessoas.Remove(pessoa);
            return Ok(pessoa);
        }
    }
}
