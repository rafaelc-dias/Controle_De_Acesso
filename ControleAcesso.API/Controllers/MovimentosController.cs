using ControleAcesso.Class;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ControleAcesso.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovimentosController : ControllerBase
    {
        private static List<Movimento> Movimentos = new();

        [HttpGet("RetonarEntradaFuncionarios")]
        public async Task<IActionResult> RetonarEntradaFuncionarios()
        {
            return Ok(Movimentos.FindAll(RetornoEntradaFuncionarios => RetornoEntradaFuncionarios.TipoMovimento == ETipoMovimento.ENTRADAFUNCIONARIO));
        }

        [HttpPost("AdiconarEntradaFuncionarios")]
        public async Task<IActionResult> AdiconarEntradaFuncionarios(Movimento entradaFuncionario)
        {
            Movimentos.Add(entradaFuncionario);
            return Ok(Movimentos);
        }

        [HttpGet("RetonarSaidaCarroEmpresa")]
        public async Task<IActionResult> RetonarSaidaCarroEmpresa()
        {
            return Ok(Movimentos.FindAll(RetornoSaidaCarroEmpresa => RetornoSaidaCarroEmpresa.TipoMovimento == ETipoMovimento.SAIDACARROEMPRESA));
        }

        [HttpPost("AdiconarSaidaCarroEmpresa")]
        public async Task<IActionResult> AdiconarSaidaCarroEmpresa(SaidaCarroEmpresa saidaCarroEmpresa)
        {
            Movimentos.Add(saidaCarroEmpresa);
            return Ok(Movimentos);
        }

        [HttpGet("RetonarRecebimentos")]
        public async Task<IActionResult> RetonarRecebimentos()
        {
            return Ok(Movimentos.FindAll(RetornoSaidaCarroEmpresa => RetornoSaidaCarroEmpresa.TipoMovimento == ETipoMovimento.RECEBIMENTO));
        }

        [HttpGet("RetonarExpedicoes")]
        public async Task<IActionResult> RetonarExpedicoes()
        {
            return Ok(Movimentos.FindAll(RetornoSaidaCarroEmpresa => RetornoSaidaCarroEmpresa.TipoMovimento == ETipoMovimento.EXPEDICAO));
        }

        [HttpPost("AdiconarRecebimentoExpedicao")]
        public async Task<IActionResult> AdiconarRecebimentoExpedicao(MovimentoPesagem movimentoPesagem)
        {
            Movimentos.Add(movimentoPesagem);
            return Ok(Movimentos);
        }


    }
}
