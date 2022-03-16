using ControleAcesso.Class;

namespace ControleAcesso.Domain.Interfaces
{
    public interface IPessoasServico
    {
        Task Cadastrar(Pessoas pessoas);
        Task Atualizar(Pessoas pessoas);
        Task<List<Pessoas>> Listar();
        Task Excluir(Guid pessoaId);
        Task<Pessoas> Pesquisar(Guid pessoaId);
    }
}
