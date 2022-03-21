using ControleAcesso.Class;
using ControleAcesso.Domain.Interfaces;
using ControleAcesso.Infraestrutura.Contexto;
using Microsoft.EntityFrameworkCore;

namespace ControleAcesso.Infraestrutura.Repositorio
{
    public class EntradaFuncionarioRepositorio : IEntradaFuncionarioRepositorio
    {
        protected ControleAcessoContext _context;

        public EntradaFuncionarioRepositorio(ControleAcessoContext context)
        {
            _context = context;
        }

        public async Task AlterarStatus(Guid movimentoId, EStatusMovimento status)
        {
            var movimentopesquisa = await Pesquisar(movimentoId);
            if (movimentopesquisa != null)
            {
                movimentopesquisa.AlteraStatus(status);

                _context.EntradasFuncionarios.Update(movimentopesquisa);
                await _context.SaveChangesAsync();

            }
        }

        public async Task<int> Cadastrar(EntradaFuncionario movimento)
        {
            int retorno = 0;

            if (movimento != null)
                await _context.EntradasFuncionarios.AddAsync(movimento);
            retorno = await _context.SaveChangesAsync();

            return retorno;
        }

        public async Task Excluir(Guid movimentoId)
        {
            var movimento = await Pesquisar(movimentoId);
            if (movimento != null && movimento.Id.Equals(movimentoId))
                _context.EntradasFuncionarios.Remove(movimento);
            await _context.SaveChangesAsync();
        }

        public async Task<List<EntradaFuncionario>> Listar()
        {
            return await _context.EntradasFuncionarios
                .Include(veiculo => veiculo.Veiculo)
                .Include(pessoa => pessoa.Pessoa)
                .ToListAsync();
        }

        public async Task<EntradaFuncionario> Pesquisar(Guid MovimentoId)
        {
            return await _context.EntradasFuncionarios.FirstOrDefaultAsync(p => p.Id.Equals(MovimentoId));
        }
    }

}

