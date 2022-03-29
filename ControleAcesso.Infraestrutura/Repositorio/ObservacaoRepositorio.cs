using ControleAcesso.Domain.Interfaces;
using ControleAcesso.Domain.Modelos;
using ControleAcesso.Infraestrutura.Contexto;
using Microsoft.EntityFrameworkCore;

namespace ControleAcesso.Infraestrutura.Repositorio
{
    public class ObservacaoRepositorio : IObservacaoRepositorio
    {
        public readonly ControleAcessoContext _context;

        public ObservacaoRepositorio(ControleAcessoContext context)
        {
            _context = context; 
        }
        public async Task<Observacao> Atualizar(Observacao Observacao)
        {
            var resposta =  _context.Observacoes.Update(Observacao);
            await _context.SaveChangesAsync();

            return resposta.Entity;
        }

        public async Task<Observacao> Cadastrar(Observacao Observacao)
        {
            var resposta = await _context.Observacoes.AddAsync(Observacao);
            await _context.SaveChangesAsync();

            return resposta.Entity;
        }

        public async Task<Observacao> Excluir(Guid observacaoID)
        {
            var observacao = await Pesquisar(observacaoID);
            
            var resposta =  _context.Observacoes.Remove(observacao);
            await _context.SaveChangesAsync();

            return resposta.Entity;
        }

        public async Task<List<Observacao>> Listar()
        {
            return await _context.Observacoes.ToListAsync();
        }

        public async Task<List<Observacao>> ListarObservacoesMovimento(Guid movimentoId)
        {
            //return await _context.Observacoes.Where(p => p.IdMovimento.Equals(movimentoId)).ToListAsync();
            return await _context.Observacoes.ToListAsync();
        }

        public async Task<Observacao> Pesquisar(Guid observacaoID)
        {
            return await _context.Observacoes.FirstOrDefaultAsync(p => p.Id.Equals(observacaoID));
        }
    }
}
