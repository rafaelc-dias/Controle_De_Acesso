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
            
            /*builder.Property("HoraEntrada").HasDefaultValue("00:00");
            builder.Property("KmEntrada").HasDefaultValue("0");
            builder.Property("NivelCombustivelEntrada").HasDefaultValue("0");*/

         }
    }

    public class PessoaMap : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.ToTable("Pessoas");
            builder.HasKey(c => c.Id);
            builder.HasData(
                new Pessoa(Guid.Parse("99ec3771-460e-439e-fe6e-08da0cd45f35"),"123","Deku"),
                new Pessoa(Guid.Parse("99ec3771-460e-439e-fe6e-08da0cd45f36"), "654", "Bakugo"),
                new Pessoa(Guid.Parse("99ec3771-460e-439e-fe6e-08da0cd45f37"), "987", "Uraraka"),
                new Pessoa(Guid.Parse("99ec3771-460e-439e-fe6e-08da0cd45f38"), "965", "Toshiro"),
                new Pessoa(Guid.Parse("99ec3771-460e-439e-fe6e-08da0cd45f39"), "458", "Ishida")
                );

            /*builder.Property("HoraEntrada").HasDefaultValue("00:00");
            builder.Property("KmEntrada").HasDefaultValue("0");
            builder.Property("NivelCombustivelEntrada").HasDefaultValue("0");*/

        }
    }

    public class VeiculoMap : IEntityTypeConfiguration<Veiculo>
    {
        public void Configure(EntityTypeBuilder<Veiculo> builder)
        {
            builder.ToTable("Veiculos");
            builder.HasKey(c => c.Id);
            builder.HasData(
                new Veiculo(Guid.Parse("99ec3771-460e-439e-fe6e-08da0cd45f30"), "ABC1234", "Variant"),
                new Veiculo(Guid.Parse("99ec3771-460e-439e-fe6e-08da0cd45f31"), "ASD5654", "Fiat 147"),
                new Veiculo(Guid.Parse("99ec3771-460e-439e-fe6e-08da0cd45f33"), "CVB2987", "Opala"),
                new Veiculo(Guid.Parse("99ec3771-460e-439e-fe6e-08da0cd45f34"), "ERT5965", "Chevet"),
                new Veiculo(Guid.Parse("98ec3771-460e-439e-fe6e-08da0cd45f35"), "TYU6458", "Gurgel")
                );

            /*builder.Property("HoraEntrada").HasDefaultValue("00:00");
            builder.Property("KmEntrada").HasDefaultValue("0");
            builder.Property("NivelCombustivelEntrada").HasDefaultValue("0");*/

        }
    }


}
