using ControleAcesso.Class;

namespace ControleAcesso.Domain.Interfaces
{
    public interface IVeiculoRepositorio
    {
        Task Cadastrar(Veiculo veiculo);
        Task Atualizar(Veiculo veiculo);
        Task<List<Veiculo>> Listar();
        Task Excluir(Guid veiculoId);
        Task<Veiculo> Pesquisar(Guid veiculoId);
    }
}
