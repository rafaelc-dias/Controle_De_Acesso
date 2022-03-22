using ControleAcesso.Class;
using ControleAcesso.Domain.Modelos;
using ControleAcesso.Infraestrutura.Mappings;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ControleAcesso.Infraestrutura.Contexto
{
    public class ControleAcessoContext : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Veiculo> Veiculos { get; set;}
        public DbSet<NotaFiscal> NotasFiscais { get; set; }
        public DbSet<Observacao> Observacoes { get; set;}
        //public DbSet<Movimento> Movimentos { get; set; }
        public DbSet<MovimentoPesagem> MovimentosPesagem { get; set; }
        public DbSet<SaidaCarroEmpresa> SaidasCarrosEmpresa { get; set; }
        public DbSet<EntradaFuncionario> EntradasFuncionarios { get; set; }

        public ControleAcessoContext(DbContextOptions options) : base(options)
        {
            
        }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new EntradaFuncionarioMap());

            modelBuilder.ApplyConfiguration(new SaidaCarroEmpresaMap());

            base.OnModelCreating(modelBuilder);

           
        }

        
    }
}
