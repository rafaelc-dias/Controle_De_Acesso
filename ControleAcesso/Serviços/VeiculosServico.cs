using ControleAcesso.Class;
using ControleAcesso.Domain.Interfaces;

namespace ControleAcesso.Domain.Serviços
{
    public class VeiculosServico : IVeiculosServico
    {
        private readonly IVeiculosRepositorio _veiculosRepositorio;
        public VeiculosServico(IVeiculosRepositorio veiculosRepositorio)
        {
            _veiculosRepositorio = veiculosRepositorio;
        }

        public async Task Atualizar(Veiculos veiculo)
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
    

        public async Task Cadastrar(Veiculos veiculo)
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

        public async Task<List<Veiculos>> Listar()
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

        public async Task<Veiculos> Pesquisar(Guid veiculoId)
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
