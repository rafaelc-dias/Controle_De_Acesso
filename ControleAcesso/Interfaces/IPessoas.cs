using ControleAcesso.Class;

namespace ControleAcesso.Domain.Interfaces
{
    public interface IPessoas
    {
        Task Cadastrar(Pessoas pessoas);
        Task Atualizar(Pessoas pessoas);
        Task<List<Pessoas>> Listar();
        Task Excluir(string pessoaId);
        Task<Pessoas> Pesquisar(string pessoaId);


    }
}
