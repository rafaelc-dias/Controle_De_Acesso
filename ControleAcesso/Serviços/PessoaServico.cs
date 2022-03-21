using ControleAcesso.Class;
using ControleAcesso.Domain.Interfaces;

namespace ControleAcesso.Domain.Serviços
{
    public class PessoaServico : IPessoaServico
    {
        private readonly IPessoaRepositorio _pessoasRepositorio;

        public PessoaServico(IPessoaRepositorio pessoasRepositorio)
        {
            _pessoasRepositorio = pessoasRepositorio;
        }
        public async Task Atualizar(Pessoa pessoas)
        {
            try
            {
                await _pessoasRepositorio.Atualizar(pessoas);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task Cadastrar(Pessoa pessoas)
        {
            try
            {
                await _pessoasRepositorio.Cadastrar(pessoas);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task Excluir(Guid pessoaId)
        {
            try
            {
                await _pessoasRepositorio.Excluir(pessoaId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<Pessoa>> Listar()
        {
            try
            {
                return await _pessoasRepositorio.Listar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Pessoa> Pesquisar(Guid pessoaId)
        {
            try
            {
                return await _pessoasRepositorio.Pesquisar(pessoaId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
