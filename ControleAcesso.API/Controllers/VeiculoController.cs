using ControleAcesso.Class;
using ControleAcesso.Domain.DTO;
using ControleAcesso.Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ControleAcesso.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeiculoController : ControllerBase
    {
        private readonly IVeiculoServico _veiculosServico;

        public VeiculoController(IVeiculoServico veiculosServico)
        {
            _veiculosServico = veiculosServico;
        }

        [HttpGet]
        [Route("listar")]
        public async Task<IActionResult> listar()
        {
            try
            {
                return Ok(await _veiculosServico.Listar());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        [Route("pesquisar/{id}")]
        public async Task<IActionResult> RetonarVeiculos(Guid id)
        {
            try
            {
                return Ok(await _veiculosServico.Pesquisar(id));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        [Route("cadastrar")]
        public async Task<IActionResult> AdiconarVeiculos(VeiculoDTO veiculoDTO)
        {
            try
            {
                await _veiculosServico.Cadastrar(veiculoDTO.ConverteVeiculo());
                return Ok("Cadastrado !!!!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut]
        [Route("atualizar")]
        public async Task<IActionResult> AlterarVeiculos(VeiculoDTO veiculoDTO)
        {
            try
            {
                await _veiculosServico.Atualizar(veiculoDTO.ConverteVeiculo());
                return Ok("Atualizado !!!!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete]
        [Route("excluir/{id}")]
        public async Task<IActionResult> RemoverVeiculos(Guid id)
        {
            try
            {
                await _veiculosServico.Excluir(id);
                return Ok("Exclusão");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
