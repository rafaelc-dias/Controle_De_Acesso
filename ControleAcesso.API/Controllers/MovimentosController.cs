using ControleAcesso.Class;
using ControleAcesso.Domain.DTO;
using Microsoft.AspNetCore.Mvc;

namespace ControleAcesso.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovimentosController : ControllerBase
    {
        private static List<Movimentos> lEntradaFuncionarios = new();
        private static List<SaidaCarroEmpresa> lSaidaCarroEmpresa = new();
        private static List<MovimentosPesagem> lMovimentosPesagem = new();

        [HttpGet("RetonarEntradaFuncionarios")]
        public async Task<IActionResult> RetonarEntradaFuncionarios()
        {
            return Ok(lEntradaFuncionarios);
        }

        [HttpPost("AdicionarEntradaFuncionarios")]
        public async Task<IActionResult> AdicionarEntradaFuncionarios(MovimentosDTO entradaFuncionario)
        {
            Movimentos entradaFunc = new(entradaFuncionario.Sentido, entradaFuncionario.TipoMovimento, entradaFuncionario.StatusMovimento, entradaFuncionario.Data, entradaFuncionario.Veiculo, entradaFuncionario.Motorista, entradaFuncionario.Observacao);
            lEntradaFuncionarios.Add(entradaFunc);
            return Ok(lEntradaFuncionarios);
        }

        [HttpPut("AlterarObservacaoMovimento")]
        public async Task<IActionResult> AlterarObservacaoMovimento(MovimentosObservacaoDTO movimentoObservacaoDTO)
        {
            if(movimentoObservacaoDTO.TipoMovimento == ETipoMovimento.ENTRADAFUNCIONARIO)
            {
                var movimento = lEntradaFuncionarios.Find(movimentoResultado => movimentoResultado.Id == movimentoObservacaoDTO.Id);

                movimento.AlterarObservacao(movimentoObservacaoDTO.Observacao);

                return Ok($"Observação do movimento de ID {movimentoObservacaoDTO.Id}, alterado !!!");
            }
            else if (movimentoObservacaoDTO.TipoMovimento == ETipoMovimento.SAIDACARROEMPRESA)
            {
                var movimento = lSaidaCarroEmpresa.Find(movimentoResultado => movimentoResultado.Id == movimentoObservacaoDTO.Id);

                movimento.AlterarObservacao(movimentoObservacaoDTO.Observacao);

                return Ok($"Observação do movimento de ID {movimentoObservacaoDTO.Id}, alterado !!!");
            }
            else if (movimentoObservacaoDTO.TipoMovimento == ETipoMovimento.EXPEDICAO || movimentoObservacaoDTO.TipoMovimento == ETipoMovimento.RECEBIMENTO)
            {
                var movimento = lMovimentosPesagem.Find(movimentoResultado => movimentoResultado.Id == movimentoObservacaoDTO.Id);

                movimento.AlterarObservacao(movimentoObservacaoDTO.Observacao);

                return Ok($"Observação do movimento de ID {movimentoObservacaoDTO.Id}, alterado !!!");
            }

            return BadRequest("Movimento não encontrado");


        }

        [HttpGet("RetonarSaidaCarroEmpresa")]
        public async Task<IActionResult> RetonarSaidaCarroEmpresa()
        {
            return Ok(lSaidaCarroEmpresa.FindAll(RetornoSaidaCarroEmpresa => RetornoSaidaCarroEmpresa.TipoMovimento == ETipoMovimento.SAIDACARROEMPRESA));
        }

        [HttpPost("AdiconarSaidaCarroEmpresaSaida")]
        public async Task<IActionResult> AdiconarSaidaCarroEmpresaSaida(SaidaCarroEmpresaSaidaDTO saidaCarroEmpresasaidaDTO)
        {
            var saidaCarroEmpresa = new SaidaCarroEmpresa(saidaCarroEmpresasaidaDTO.KmSaida, saidaCarroEmpresasaidaDTO.NivelCombustivelSaida, saidaCarroEmpresasaidaDTO.HoraSaida, saidaCarroEmpresasaidaDTO.Destino, saidaCarroEmpresasaidaDTO.Sentido, saidaCarroEmpresasaidaDTO.TipoMovimento, saidaCarroEmpresasaidaDTO.StatusMovimento, saidaCarroEmpresasaidaDTO.Data, saidaCarroEmpresasaidaDTO.Veiculo, saidaCarroEmpresasaidaDTO.Motorista, saidaCarroEmpresasaidaDTO.Observacao);
            var id = saidaCarroEmpresa.Id;
            lSaidaCarroEmpresa.Add(saidaCarroEmpresa);
            return Ok($"Foi inserida a Saida de Carro da Empresa de ID {id} ");
        }

        [HttpPut("AdiconarSaidaCarroEmpresaEntrada")]
        public async Task<IActionResult> AdiconarSaidaCarroEmpresaEntrada(SaidaCarroEmpresaEntradaDTO saidaCarroEmpresaEntradaDTO)
        {
            var saidaCarroEmpres = lSaidaCarroEmpresa.Find(saidaCarroEmpresResultado => saidaCarroEmpresResultado.Id == saidaCarroEmpresaEntradaDTO.Id);

            if (saidaCarroEmpres == null)
                return BadRequest("Saida de Carro da Empresa não encontrado");

            saidaCarroEmpres.InsereDadosEntrada(saidaCarroEmpresaEntradaDTO.KmEntrada, saidaCarroEmpresaEntradaDTO.NivelCombustivelEntrada, saidaCarroEmpresaEntradaDTO.HoraEntrada);

            return Ok($"Observação do movimento de ID {saidaCarroEmpresaEntradaDTO.Id}, alterado !!!");
        }

        [HttpPost("AdiconarMovimentosPesagem")]
        public async Task<IActionResult> AdiconarMovimentosPesagem(MovimentosPesagemDTO movimentosPesagemDTO)
        {
            var MovimentosPesagem = new MovimentosPesagem(movimentosPesagemDTO.PesoChegada, movimentosPesagemDTO.Sentido, movimentosPesagemDTO.TipoMovimento, movimentosPesagemDTO.StatusMovimento,
                                                            movimentosPesagemDTO.Data, movimentosPesagemDTO.Veiculo, movimentosPesagemDTO.Motorista, movimentosPesagemDTO.Observacao) ;
            var id = MovimentosPesagem.Id;
            lMovimentosPesagem.Add(MovimentosPesagem);
            return Ok($"Foi inserida Movimento com Pesagem de ID {id} ");
        }

        [HttpPut("AdiconarMovimentosPesagemPesosaida")]
        public async Task<IActionResult> AdiconarMovimentosPesagemPesosaida(MovimentosPesagemPesoSaidaDTO movimentosPesagemPesoSaidaDTO)
        {
            var movimentosPesagem = lMovimentosPesagem.Find(MovimentoPesagemResultado => MovimentoPesagemResultado.Id == movimentosPesagemPesoSaidaDTO.ID);

            if (movimentosPesagem == null)
                return BadRequest("Movimento Pesagem não encontrado");

            movimentosPesagem.DefinePesosaida(movimentosPesagemPesoSaidaDTO.PesoSaida);


            return Ok($"Peso de saida adicionado ao movimento de ID {movimentosPesagemPesoSaidaDTO.ID} !!!");
        }

        [HttpPut("AdiconarNotaFiscalMovimentosPesagem")]
        public async Task<IActionResult> AdiconarNotaFiscalMovimentosPesagem(NotasFiscaisDTO notasFiscaisDTO)
        {
            var movimentosPesagem = lMovimentosPesagem.Find(MovimentoPesagemResultado => MovimentoPesagemResultado.Id == notasFiscaisDTO.IdMovimento);

            if (movimentosPesagem == null)
                return BadRequest("Movimento Pesagem não encontrado");

            movimentosPesagem.IncluiNotaFiscalPesagem(notasFiscaisDTO);

            movimentosPesagem.DefineStatusPesagem();


            return Ok($"Nota Fiscal inseriada do movimento de ID {movimentosPesagem.Id}, alterado !!!");
        }

        [HttpGet("RetonarRecebimentos")]
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
            return Ok(Movimentos.FindAll(RetornoMovimentosAbertos => RetornoMovimentosAbertos.StatusMovimento == EStatusMovimento.ABERTO));
        }

        [HttpGet("RetonarMovimentosPorId{id}")]
        public async Task<IActionResult> RetonarMovimentosPorId(string id)
        {
            return Ok(Movimentos.FindAll(RetornoMovimentosAbertos => RetornoMovimentosAbertos.Id.ToString() == id));
        }

        [HttpPost("RetonarMovimentosPorSentidoTipoStatus")]
        public async Task<IActionResult> RetonarMovimentosPorSentidoTipoStatus(FiltroMovimentoDTO filtroMovimentoDTO)
        {
            return Ok(Movimentos.FindAll(RetornoSaidaCarroEmpresa => RetornoSaidaCarroEmpresa.Sentido == filtroMovimentoDTO.Sentido && 
                                                                     RetornoSaidaCarroEmpresa.TipoMovimento == filtroMovimentoDTO.TipoMovimento && 
                                                                     RetornoSaidaCarroEmpresa.StatusMovimento == filtroMovimentoDTO.StatusMovimento));

            
        }


    }
}
