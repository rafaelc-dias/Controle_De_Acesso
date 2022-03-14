using ControleAcesso.Class;
using ControleAcesso.Domain.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ControleAcesso.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntradaFuncionariosController : ControllerBase
    {
        private static List<Movimentos> ListaEntradaFuncionarios = new();

        [HttpGet]
        public async Task<IActionResult> RetonarEntradaFuncionarios()
        {
            return Ok(ListaEntradaFuncionarios);
        }        

        [HttpPost]
        public async Task<IActionResult> AdiconarEntradaFuncionarios(Movimentos entradaFuncionario)
        {
            ListaEntradaFuncionarios.Add(entradaFuncionario);
            return Ok(ListaEntradaFuncionarios);
        }

        [HttpPut("AlterarObservacaoMovimento")]
        public async Task<IActionResult> AlterarObservacaoMovimento(MovimentosObservacaoDTO movimentoObservacaoDTO)
        {
            var movimento = ListaEntradaFuncionarios.Find(movimentoResultado => movimentoResultado.Id == movimentoObservacaoDTO.Id);

            if (movimento == null)
                return BadRequest("Movimento não encontrado");

            //movimento.AlterarObservacao(movimentoObservacaoDTO.Observacao);
            return Ok($"Observação do movimento de ID {movimentoObservacaoDTO.Id}, alterado !!!");

        }

        [HttpGet("RetonarMovimentosAbertos")]
        public async Task<IActionResult> RetonarMovimentosAbertos()
        {
            return Ok(ListaEntradaFuncionarios.FindAll(RetornoMovimentosAbertos => RetornoMovimentosAbertos.StatusMovimento == EStatusMovimento.ABERTO));
        }

        [HttpGet("RetonarMovimentosPorId{id}")]
        public async Task<IActionResult> RetonarMovimentosPorId(string id)
        {
            return Ok(ListaEntradaFuncionarios.FindAll(RetornoMovimentosAbertos => RetornoMovimentosAbertos.Id.ToString() == id));
        }

        [HttpPost("RetonarMovimentosPorSentidoTipoStatus")]
        public async Task<IActionResult> RetonarMovimentosPorSentidoTipoStatus(FiltroMovimentoDTO filtroMovimentoDTO)
        {
            return Ok(ListaEntradaFuncionarios.FindAll(RetornoSaidaCarroEmpresa => RetornoSaidaCarroEmpresa.Sentido == filtroMovimentoDTO.Sentido && RetornoSaidaCarroEmpresa.StatusMovimento == filtroMovimentoDTO.StatusMovimento));


        }


    }
}
