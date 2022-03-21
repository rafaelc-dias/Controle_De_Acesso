using ControleAcesso.Class;
using ControleAcesso.Domain.Interfaces;

namespace ControleAcesso.Domain.Serviços
{
    public class VeiculoServico : IVeiculoServico
    {
        private readonly IVeiculoRepositorio _veiculosRepositorio;
        public VeiculoServico(IVeiculoRepositorio veiculosRepositorio)
        {
            _veiculosRepositorio = veiculosRepositorio;
        }

        public async Task Atualizar(Veiculo veiculo)
        {
            try
            {
                await _veiculosRepositorio.Atualizar(veiculo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    

        public async Task Cadastrar(Veiculo veiculo)
        {
        try
        {
            await _veiculosRepositorio.Cadastrar(veiculo);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

        public async Task Excluir(Guid veiculoId)
        {
            try
            {
                await _veiculosRepositorio.Excluir(veiculoId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<Veiculo>> Listar()
        {
            try
            {
                return await _veiculosRepositorio.Listar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Veiculo> Pesquisar(Guid veiculoId)
        {
            try
            {
                return await _veiculosRepositorio.Pesquisar(veiculoId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
