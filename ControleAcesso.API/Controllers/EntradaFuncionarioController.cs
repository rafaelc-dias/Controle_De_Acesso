using ControleAcesso.Class;
using ControleAcesso.Domain.DTO;
using ControleAcesso.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ControleAcesso.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntradaFuncionarioController : ControllerBase
    {
        private readonly IEntradaFuncionarioServico _entradafuncionarioServico;

        public EntradaFuncionarioController(IEntradaFuncionarioServico entradafuncionarioServico)
        {
            _entradafuncionarioServico = entradafuncionarioServico;
        }

        [HttpGet]
        [Route("listar")]
        public async Task<IActionResult> listar()
        {
            try
            {
               
                var _response = await _entradafuncionarioServico.Listar();
                return Ok(_response);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        [Route("cadastrar")]
        public async Task<IActionResult> AdiconarEntradaFuncionarios(EntradaFuncionarioDTO entradaFuncionarioDTO)
        {
            try
            {
                if (await _entradafuncionarioServico.Cadastrar(entradaFuncionarioDTO) > 0)
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

        [HttpPut]
        [Route("alterarstatus/{movimentoId}")]
        public async Task<IActionResult> AlterarStatusfechado(Guid movimentoId)
        {
            try
            {
                await _entradafuncionarioServico.AlterarStatusFechado(movimentoId);
                return Ok("Atualizado !!!!");
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        [HttpPut]
        [Route("adicionadatasaida/{movimentoId}")]
        public async Task<IActionResult> AdicionaDatdaSaida(Guid movimentoId)
        {
            try
            {
                await _entradafuncionarioServico.AdicionaDataSaida(movimentoId);
                return Ok("Atualizado !!!!");
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        [HttpDelete]
        [Route("excluir/{id}")]
        public async Task<IActionResult> RemoverEntradaFuncionario(Guid id)
        {
            try
            {
                await _entradafuncionarioServico.Excluir(id);
                return Ok("Exclusão");
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
    }
}
