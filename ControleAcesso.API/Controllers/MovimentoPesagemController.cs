using ControleAcesso.Class;
using ControleAcesso.Domain.DTO;
using ControleAcesso.Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ControleAcesso.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovimentoPesagemController : ControllerBase
    {
        private readonly IMovimentoPesagemServico _movimentoPesagemServico;

        public MovimentoPesagemController(IMovimentoPesagemServico movimentoPesagemServico)
        {
            _movimentoPesagemServico = movimentoPesagemServico;
        }

        [HttpPost]
        [Route("cadastrar")]
        public async Task<IActionResult> cadastrarexpedicao(MovimentoPesagemDTO movimento)
        {
            try
            {
                if (await _movimentoPesagemServico.Cadastrar(movimento) > 0)
                {
                    return Ok("Cadastrado !!!!");
                }
                else
                {
                    return NoContent();
                }


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        [Route("listar")]
        public async Task<IActionResult> listar()
        {
            try
            {

                var _response = await _movimentoPesagemServico.Listar();
                return Ok(_response);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut]
        [Route("alterarstatusfechado/{movimentoId}")]
        public async Task<IActionResult> AlterarStatusfechado(Guid movimentoId)
        {
            try
            {
                await _movimentoPesagemServico.AlterarStatusFechado(movimentoId);
                return Ok("Atualizado !!!!");
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        [HttpPut]
        [Route("definirpesosaida")]
        public async Task<IActionResult> DefinirPesoSaida(MovimentoPesagemPesoSaidaDTO movimento)
        {
            try
            {
                await _movimentoPesagemServico.DefinirPesoSaida(movimento);
                return Ok("Atualizado !!!!");
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        [HttpPut]
        [Route("definirstatuspesagem")]
        public async Task<IActionResult> DefinirStatusPesagem(Guid movimentoId)
        {
            try
            {
                await _movimentoPesagemServico.DefinirStatusPesagem(movimentoId);
                return Ok("Atualizado !!!!");
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        [HttpPut]
        [Route("inserirobservacao")]
        public async Task<IActionResult> InserirObservacao(ObservacaoMovimentoPesagemDTO observacaoDTO)
        {
            try
            {
                await _movimentoPesagemServico.InsereObservacao(observacaoDTO);
                return Ok("Atualizado !!!!");
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        [HttpDelete]
        [Route("excluir/{id}")]
        public async Task<IActionResult> RemoverSaidaCarroEmpresa(Guid id)
        {
            try
            {
                await _movimentoPesagemServico.Excluir(id);
                return Ok("Exclusão");
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }




    }
}
