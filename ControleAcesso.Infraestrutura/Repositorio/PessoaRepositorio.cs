using ControleAcesso.Class;
using ControleAcesso.Domain.Interfaces;
using ControleAcesso.Infraestrutura.Contexto;

using Microsoft.EntityFrameworkCore;

namespace ControleAcesso.Infraestrutura.Repositorio
{
    public class PessoaRepositorio : IPessoaRepositorio
    {
        private readonly ControleAcessoContext context;
        public PessoaRepositorio(ControleAcessoContext context)
        {
            this.context = context;

        }

        public async Task Atualizar(Pessoa pessoa)
        {
            var pessoapesquisa = await Pesquisar(pessoa.Id);
            if (pessoapesquisa != null && pessoapesquisa.Id.Equals(pessoa.Id))
            {
                pessoapesquisa.AltearNomePessoa(pessoa.Nome);
                context.Pessoas.Update(pessoapesquisa);
                await context.SaveChangesAsync();

            }
                
        }

        public async Task Cadastrar(Pessoa pessoa)
        {
            if (pessoa != null)
                await context.Pessoas.AddAsync(pessoa);
                await context.SaveChangesAsync();
        }

        public async Task Excluir(Guid pessoaId)
        {
            var pessoa = await Pesquisar(pessoaId);
            if(pessoa != null && pessoa.Id.Equals(pessoaId))
                context.Pessoas.Remove(pessoa);
                await context.SaveChangesAsync();
        }

        public async Task<List<Pessoa>> Listar()
        {
            return await context.Pessoas.ToListAsync();
        }

        public async Task<Pessoa> Pesquisar(Guid pessoaId)
        {
            return await context.Pessoas.FirstOrDefaultAsync(p => p.Id.Equals(pessoaId));
        }
    }
}
