using ControleAcesso.Class;
using ControleAcesso.Domain.Interfaces;
using ControleAcesso.Infraestrutura.Contexto;

using Microsoft.EntityFrameworkCore;

namespace ControleAcesso.Infraestrutura.Repositorio
{
    public class PessoasRepositorio : IPessoas
    {
        private readonly ControleAcessoContext context;
        public PessoasRepositorio(ControleAcessoContext context)
        {
            this.context = context;

        }

        public async Task Atualizar(Pessoas pessoa)
        {
            var pessoapesquisa = await Pesquisar(pessoa.Id.ToString());
            if (pessoapesquisa != null && pessoapesquisa.Id.Equals(pessoa.Id))
            {
                pessoapesquisa.AltearNomePessoa(pessoa.Nome);
                context.Pessoas.Update(pessoapesquisa);            

            }
                
        }

        public async Task Cadastrar(Pessoas pessoa)
        {
            if (pessoa != null)
                await context.Pessoas.AddAsync(pessoa);
                await context.SaveChangesAsync();
        }

        public async Task Excluir(string pessoaId)
        {
            var pessoa = await Pesquisar(pessoaId);
            if(pessoa != null && pessoa.Id.Equals(pessoaId))
                context.Pessoas.Remove(pessoa);
        }

        public async Task<List<Pessoas>> Listar()
        {
            return await context.Pessoas.ToListAsync();
        }

        public async Task<Pessoas> Pesquisar(string pessoaId)
        {
            return await context.Pessoas.FirstOrDefaultAsync(p => p.Id.Equals(pessoaId));
        }
    }
}
