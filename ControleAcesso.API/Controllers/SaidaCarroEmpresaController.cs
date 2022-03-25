using ControleAcesso.Class;
using ControleAcesso.Domain.DTO;
using ControleAcesso.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ControleAcesso.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SaidaCarroEmpresaController : ControllerBase
    {
        private readonly ISaidaCarroEmpresaServico _saidaCarroEmpresaServico;

        public SaidaCarroEmpresaController(ISaidaCarroEmpresaServico saidaCarroEmpresaServico)
        {
            _saidaCarroEmpresaServico = saidaCarroEmpresaServico;
        }

        [HttpPost]
        [Route("cadastrar")]
        public async Task<IActionResult> cadastrar(SaidaCarroEmpresaSaidaDTO movimento)
        {
            try
            {
                if (await _saidaCarroEmpresaServico.Cadastrar(movimento) > 0)
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

                var _response = await _saidaCarroEmpresaServico.Listar();
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
                await _saidaCarroEmpresaServico.AlterarStatusFechado(movimentoId);
                return Ok("Atualizado !!!!");
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        [HttpPut]
        [Route("inserirentrada")]
        public async Task<IActionResult> InserirEntrada(SaidaCarroEmpresaEntradaDTO movimento)
        {
            try
            {
                await _saidaCarroEmpresaServico.InserirEntrada(movimento);
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
                await _saidaCarroEmpresaServico.Excluir(id);
                return Ok("Exclusão");
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }






    }
}
