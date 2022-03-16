using ControleAcesso.Class;

namespace ControleAcesso.Domain.Interfaces
{
    public interface IVeiculosServico
    {
        Task Cadastrar(Veiculos veiculo);
        Task Atualizar(Veiculos veiculo);
        Task<List<Veiculos>> Listar();
        Task Excluir(Guid veiculoId);
        Task<Veiculos> Pesquisar(Guid veiculoId);
    }
}
