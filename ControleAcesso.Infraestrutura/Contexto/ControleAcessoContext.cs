using ControleAcesso.Class;
using ControleAcesso.Domain.Modelos;
using Microsoft.EntityFrameworkCore;

namespace ControleAcesso.Infraestrutura.Contexto
{
    public class ControleAcessoContext : DbContext
    {
        public DbSet<Pessoas> Pessoas { get; set; }
        public DbSet<Veiculos> Veiculos { get; set;}
        public DbSet<NotasFiscais> NotasFiscais { get; set; }
        public DbSet<Observacao> Observacao { get; set;}
        public DbSet<Movimentos> Movimentos { get; set; }
        public DbSet<MovimentosPesagem> MovimentosPesagem { get; set; }
        public DbSet<SaidaCarroEmpresa> SaidaCarroEmpresa { get; set; }

        public ControleAcessoContext(DbContextOptions options) : base(options)
        {
            
        }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
