using ControleAcesso.Class;
using ControleAcesso.Domain.Interfaces;
using ControleAcesso.Infraestrutura.Contexto;
using Microsoft.EntityFrameworkCore;

namespace ControleAcesso.Infraestrutura.Repositorio
{
    public class VeiculoRepositorio : IVeiculoRepositorio
    {
        protected ControleAcessoContext _context;

        public VeiculoRepositorio(ControleAcessoContext context)
        {
            _context = context;
        }
        public async Task Atualizar(Veiculo veiculo)
        {
            var veiculopesquisa = await Pesquisar(veiculo.Id);
            if (veiculopesquisa != null && veiculopesquisa.Id.Equals(veiculo.Id))
            {
                veiculopesquisa.AlterarModeloVeiculo(veiculo.Modelo);
                _context.Veiculos.Update(veiculopesquisa);
                await _context.SaveChangesAsync();

            }
        }

        public async Task Cadastrar(Veiculo veiculo)
        {
            if (veiculo != null)
                await _context.Veiculos.AddAsync(veiculo);
                await _context.SaveChangesAsync();
        }

        public async Task Excluir(Guid veiculoId)
        {
            var veiculo = await Pesquisar(veiculoId);
            if (veiculo != null && veiculo.Id.Equals(veiculoId))
                _context.Veiculos.Remove(veiculo);
                await _context.SaveChangesAsync();
        }

        public async Task<List<Veiculo>> Listar()
        {
            return await _context.Veiculos.ToListAsync();
        }

        public async Task<Veiculo> Pesquisar(Guid veiculoId)
        {
            return await _context.Veiculos.FirstOrDefaultAsync(p => p.Id.Equals(veiculoId));
        }
    }
}
