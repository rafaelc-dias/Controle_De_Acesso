using ControleAcesso.Class;
using ControleAcesso.Domain.Interfaces;

namespace ControleAcesso.Domain.Serviços
{
    public class PessoasServico : IPessoas
    {
        private readonly IPessoas _pessoasRepositorio;

        public PessoasServico(IPessoas pessoasRepositorio)
        {
            _pessoasRepositorio = pessoasRepositorio;
        }
        public async Task Atualizar(Pessoas pessoas)
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

        public async Task Cadastrar(Pessoas pessoas)
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

        public async Task Excluir(string pessoaId)
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

        public async Task<List<Pessoas>> Listar()
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

        public async Task<Pessoas> Pesquisar(string pessoaId)
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
