using ControleAcesso.Class;
using ControleAcesso.Domain.DTO;
using ControleAcesso.Domain.Interfaces;
using ControleAcesso.Infraestrutura.Contexto;
using Microsoft.EntityFrameworkCore;

namespace ControleAcesso.Infraestrutura.Repositorio
{
    public class SaidaCarroEmpresaRepositorio : ISaidaCarroEmpresaRepositorio 
    {
        protected ControleAcessoContext _context ;

        public SaidaCarroEmpresaRepositorio(ControleAcessoContext context)
        {
            _context = context;
        }

        public async Task AlterarStatusFechado(Guid movimentoId)
        {
            var movimentopesquisa = await Pesquisar(movimentoId);
            if (movimentopesquisa != null)
            {
                movimentopesquisa.AlteraStatusFechado();

                _context.SaidasCarrosEmpresa.Update(movimentopesquisa);
                await _context.SaveChangesAsync();

            }
        }

        public async Task InserirEntrada(Guid movimentoId, int kmEntrada, int nivelCombustivelEntrada, string horaEntrada)
        {
            var movimentopesquisa = await Pesquisar(movimentoId);
            if (movimentopesquisa != null)
            {
                movimentopesquisa.InserirDadosEntrada(kmEntrada, nivelCombustivelEntrada, horaEntrada);

                _context.SaidasCarrosEmpresa.Update(movimentopesquisa);
                await _context.SaveChangesAsync();

            }
        }

        public async Task<int> Cadastrar(SaidaCarroEmpresa movimento)
        {
            int retorno = 0;

            if (movimento != null)
            {
                await _context.SaidasCarrosEmpresa.AddAsync(movimento);
                retorno = await _context.SaveChangesAsync();
            }

            return retorno;
        }

        public async Task Excluir(Guid movimentoId)
        {
            var movimento = await Pesquisar(movimentoId);
            if (movimento != null && movimento.Id.Equals(movimentoId))
            {
                _context.SaidasCarrosEmpresa.Remove(movimento);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<SaidaCarroEmpresa>> Listar()
        {
            return await _context.SaidasCarrosEmpresa
                .Include(veiculo => veiculo.Veiculo)
                .Include(pessoa => pessoa.Pessoa)
                .ToListAsync();
        }

        public async Task<SaidaCarroEmpresa> Pesquisar(Guid movimentoId)
        {
            return await _context.SaidasCarrosEmpresa.FirstOrDefaultAsync(p => p.Id.Equals(movimentoId));
        }
    }





}

