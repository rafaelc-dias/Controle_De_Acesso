using ControleAcesso.Class;
using ControleAcesso.Domain.Interfaces;
using ControleAcesso.Infraestrutura.Contexto;
using Microsoft.EntityFrameworkCore;

namespace ControleAcesso.Infraestrutura.Repositorio
{
    public class MovimentoPesagemRepositorio : IMovimentoPesagemRepositorio
    {
        protected ControleAcessoContext _context;

        public MovimentoPesagemRepositorio(ControleAcessoContext context)
        {
            _context = context; 

        }
        public async Task AlterarStatusFechado(Guid movimentoId)
        {
            var movimentopesquisa = await Pesquisar(movimentoId);

            if (movimentopesquisa != null)
            {
                movimentopesquisa.AlteraStatusFechado();

                _context.MovimentosPesagem.Update(movimentopesquisa);
                await _context.SaveChangesAsync();

            }
        }

        public async Task DefinirPesoSaida(Guid movimentoId, double pesoSaida)
        {
            var movimentopesquisa = await Pesquisar(movimentoId);

            if (movimentopesquisa != null)
            {
                movimentopesquisa.DefinirPesoSaida(pesoSaida);

                _context.MovimentosPesagem.Update(movimentopesquisa);
                await _context.SaveChangesAsync();

                await DefinirStatusPesagem(movimentoId);

            }
        }

        public async Task DefinirStatusPesagem(Guid movimentoId)
        {
            var movimentopesquisa = await Pesquisar(movimentoId);

            if (movimentopesquisa != null)
            {
                movimentopesquisa.DefinirStatusPesagem();

                _context.MovimentosPesagem.Update(movimentopesquisa);
                await _context.SaveChangesAsync();

            }
        }

        public async Task<int> Cadastrar(MovimentoPesagem movimento)
        {
            int retorno = 0;

            if (movimento != null)
            {
                _context.MovimentosPesagem.AddAsync(movimento);
                retorno = await _context.SaveChangesAsync();
            }
            return retorno;
        }

        public async Task<int> Atualizar(MovimentoPesagem movimento)
        {
            int retorno = 0;

            try
            {

                if (movimento != null)
                {
                    _context.MovimentosPesagem.Update(movimento);
                    //retorno = await _context.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return retorno;
        }


        public async Task Excluir(Guid movimentoId)
        {
            var movimentopesquisa = await Pesquisar(movimentoId);

            if (movimentopesquisa != null)
            {
                movimentopesquisa.AlteraStatusFechado();

                _context.MovimentosPesagem.Remove(movimentopesquisa);
                await _context.SaveChangesAsync();

            }
        }

        public async Task<List<MovimentoPesagem>> Listar()
        {
            return await _context.MovimentosPesagem
                .Include(veiculo => veiculo.Veiculo)
                .Include(pessoa => pessoa.Pessoa)
                .Include(observacoes => observacoes.Observacoes)
                .ToListAsync();
        }

        public async Task<MovimentoPesagem> Pesquisar(Guid movimentoId)
        {
            return await _context.MovimentosPesagem
                .Include(veiculo => veiculo.Veiculo)
                .Include(pessoa => pessoa.Pessoa)
                .Include(observacoes => observacoes.Observacoes)
                .FirstOrDefaultAsync(p => p.Id.Equals(movimentoId));
        }
    }
}
