using ControleAcesso.Class;
using ControleAcesso.Domain.DTO;
using ControleAcesso.Domain.Interfaces;
using ControleAcesso.Domain.Serviços;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ControleAcesso.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        private readonly IPessoaServico _pessoasServicos;

        public PessoaController(IPessoaServico pessoasServiços)
        {
            _pessoasServicos = pessoasServiços;
        }

        [HttpGet]
        [Route("listar")]
        public async Task<IActionResult> Listar()
        {
            try
            {
                return Ok(await _pessoasServicos.Listar());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        [Route("pesquisar/{id}")]
        public async Task<IActionResult> RetonarPessoas(Guid id)
        {
            try
            {
                return Ok(await _pessoasServicos.Pesquisar(id));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        [Route("cadastrar")]
        public async Task<IActionResult> AdiconarPessoa(PessoaDTO pessoaDTO)
        {
            try
            {
                await _pessoasServicos.Cadastrar(pessoaDTO.ConverterPessoa());
                return Ok("Cadastrado !!!!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut]
        [Route("atualizar")]
        public async Task<IActionResult> AlterarPessoa(PessoaDTO pessoaDTO)
        {
            try
            {
                await _pessoasServicos.Atualizar(pessoaDTO.ConverterPessoa());
                return Ok("Atualizado !!!!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete]
        [Route("excluir/{id}")]
        public async Task<IActionResult> RemoverPessoas(Guid id)
        {
            try
            {
                await _pessoasServicos.Excluir(id);
                return Ok("Exclusão");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
