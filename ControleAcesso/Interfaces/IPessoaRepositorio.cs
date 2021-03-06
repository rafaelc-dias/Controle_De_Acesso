using ControleAcesso.Class;

namespace ControleAcesso.Domain.Interfaces
{
    public interface IPessoaRepositorio
    {
        Task Cadastrar(Pessoa pessoas);
        Task Atualizar(Pessoa pessoas);
        Task<List<Pessoa>> Listar();
        Task Excluir(Guid pessoaId);
        Task<Pessoa> Pesquisar(Guid pessoaId);


    }
}
