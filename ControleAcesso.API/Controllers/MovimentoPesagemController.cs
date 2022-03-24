using ControleAcesso.Class;
using ControleAcesso.Domain.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ControleAcesso.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovimentoPesagemController : ControllerBase
    {
        private static List<MovimentoPesagem> lMovimentosPesagem = new();

        /*[HttpPost("AdiconarMovimentosPesagem")]
        public async Task<IActionResult> AdiconarMovimentosPesagem(MovimentoPesagemDTO movimentosPesagemDTO)
        {
            var MovimentosPesagem = new MovimentoPesagem(movimentosPesagemDTO.PesoChegada, movimentosPesagemDTO.Sentido, movimentosPesagemDTO.TipoMovimento, movimentosPesagemDTO.StatusMovimento,
                                                            movimentosPesagemDTO.Data, movimentosPesagemDTO.Veiculo, movimentosPesagemDTO.Motorista);
            var id = MovimentosPesagem.Id;
            lMovimentosPesagem.Add(MovimentosPesagem);
            return Ok($"Foi inserida Movimento com Pesagem de ID {id} ");
        }

        /*[HttpPut("AdiconarMovimentosPesagemPesosaida")]
        public async Task<IActionResult> AdiconarMovimentosPesagemPesosaida(MovimentoPesagemPesoSaidaDTO movimentosPesagemPesoSaidaDTO)
        {
            var movimentosPesagem = lMovimentosPesagem.Find(MovimentoPesagemResultado => MovimentoPesagemResultado.Id == movimentosPesagemPesoSaidaDTO.ID);

            if (movimentosPesagem == null)
                return BadRequest("Movimento Pesagem não encontrado");

            movimentosPesagem.DefinePesosaida(movimentosPesagemPesoSaidaDTO.PesoSaida);

            movimentosPesagem.DefineStatusPesagem();

            return Ok($"Peso de saida adicionado ao movimento de ID {movimentosPesagemPesoSaidaDTO.ID} !!!");
        }

        /*[HttpPut("AdiconarNotaFiscalMovimentosPesagem")]
        public async Task<IActionResult> AdiconarNotaFiscalMovimentosPesagem(NotaFiscalDTO notasFiscaisDTO)
        {
            var movimentosPesagem = lMovimentosPesagem.Find(MovimentoPesagemResultado => MovimentoPesagemResultado.Id == notasFiscaisDTO.IdMovimento);

            if (movimentosPesagem == null)
                return BadRequest("Movimento Pesagem não encontrado");

            //movimentosPesagem.IncluiNotaFiscalPesagem(notasFiscaisDTO);

            movimentosPesagem.DefineStatusPesagem();


            return Ok($"Nota Fiscal inseriada do movimento de ID {movimentosPesagem.Id}, alterado !!!");
        }*/

        [HttpPut("AlterarObservacaoMovimento")]
        public async Task<IActionResult> AlterarObservacaoMovimento(MovimentoObservacaoDTO movimentoObservacaoDTO)
        {
            var movimento = lMovimentosPesagem.Find(movimentoResultado => movimentoResultado.Id == movimentoObservacaoDTO.Id);

            if (movimento == null)
                return BadRequest("Movimento não encontrado");

            //movimento.AlterarObservacao(movimentoObservacaoDTO.Observacao);
            return Ok($"Observação do movimento de ID {movimentoObservacaoDTO.Id}, alterado !!!");

        }

        /*[HttpGet("RetonarRecebimentos")]
        public async Task<IActionResult> RetonarRecebimentos()
        {
            return Ok(lMovimentosPesagem.FindAll(RetornoSaidaCarroEmpresa => RetornoSaidaCarroEmpresa.TipoMovimento == ETipoMovimento.RECEBIMENTO));
        }

        [HttpGet("RetonarExpedicoes")]
        public async Task<IActionResult> RetonarExpedicoes()
        {
            return Ok(lMovimentosPesagem.FindAll(RetornoSaidaCarroEmpresa => RetornoSaidaCarroEmpresa.TipoMovimento == ETipoMovimento.EXPEDICAO));
        }

        [HttpGet("RetonarMovimentosAbertos")]
        public async Task<IActionResult> RetonarMovimentosAbertos()
        {
            return Ok(lMovimentosPesagem.FindAll(RetornoMovimentosAbertos => RetornoMovimentosAbertos.StatusMovimento == EStatusMovimento.ABERTO));
        }*/

        [HttpGet("RetonarMovimentosPorId{id}")]
        public async Task<IActionResult> RetonarMovimentosPorId(string id)
        {
            return Ok(lMovimentosPesagem.FindAll(RetornoMovimentosAbertos => RetornoMovimentosAbertos.Id.ToString() == id));
        }

        [HttpPost("RetonarMovimentosPorSentidoTipoStatus")]
        public async Task<IActionResult> RetonarMovimentosPorSentidoTipoStatus(FiltroMovimentoDTO filtroMovimentoDTO)
        {
            return Ok(lMovimentosPesagem.FindAll(RetornoSaidaCarroEmpresa => RetornoSaidaCarroEmpresa.Sentido == filtroMovimentoDTO.Sentido && RetornoSaidaCarroEmpresa.StatusMovimento == filtroMovimentoDTO.StatusMovimento));


        }
    }
}
