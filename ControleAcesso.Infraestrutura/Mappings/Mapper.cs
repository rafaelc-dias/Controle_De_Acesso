using ControleAcesso.Class;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ControleAcesso.Infraestrutura.Mappings
{

   public class EntradaFuncionarioMap : IEntityTypeConfiguration<EntradaFuncionario>
    {
        public void Configure(EntityTypeBuilder<EntradaFuncionario> builder)
        {
            builder.ToTable("EntradasFuncionarios");
            builder.HasKey(c => c.Id);
            
        }
    }

    public class SaidaCarroEmpresaMap : IEntityTypeConfiguration<SaidaCarroEmpresa>
    {
        public void Configure(EntityTypeBuilder<SaidaCarroEmpresa> builder)
        {
            builder.ToTable("SaidasCarrosEmpresa");
            builder.HasKey(c => c.Id);
            
        }
    }


    //public class MovimentoMap : IEntityTypeConfiguration<Movimento>
    //{
    //    public void Configure(EntityTypeBuilder<Movimento> builder)
    //    {
    //        builder.ToTable("Movimentos");
    //        builder.HasKey(c => c.Id);





    //    }
    //}
}
