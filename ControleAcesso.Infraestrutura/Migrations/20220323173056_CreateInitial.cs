using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ControleAcesso.Infraestrutura.Migrations
{
    public partial class CreateInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pessoas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Documento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Veiculos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Placa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modelo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veiculos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EntradasFuncionarios",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataSaida = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Sentido = table.Column<int>(type: "int", nullable: false),
                    StatusMovimento = table.Column<int>(type: "int", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VeiculoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PessoaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntradasFuncionarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EntradasFuncionarios_Pessoas_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Pessoas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EntradasFuncionarios_Veiculos_VeiculoId",
                        column: x => x.VeiculoId,
                        principalTable: "Veiculos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MovimentosPesagem",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TipoMovimento = table.Column<int>(type: "int", nullable: false),
                    PesoChegada = table.Column<double>(type: "float", nullable: false),
                    PesoSaida = table.Column<double>(type: "float", nullable: false),
                    TotalPesoNotaFiscal = table.Column<double>(type: "float", nullable: false),
                    StatusPesagem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sentido = table.Column<int>(type: "int", nullable: false),
                    StatusMovimento = table.Column<int>(type: "int", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VeiculoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PessoaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovimentosPesagem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MovimentosPesagem_Pessoas_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Pessoas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovimentosPesagem_Veiculos_VeiculoId",
                        column: x => x.VeiculoId,
                        principalTable: "Veiculos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SaidasCarrosEmpresa",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    KmSaida = table.Column<int>(type: "int", nullable: false),
                    NivelCombustivelSaida = table.Column<int>(type: "int", nullable: false),
                    HoraSaida = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KmEntrada = table.Column<int>(type: "int", nullable: false),
                    NivelCombustivelEntrada = table.Column<int>(type: "int", nullable: true),
                    HoraEntrada = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Destino = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sentido = table.Column<int>(type: "int", nullable: false),
                    StatusMovimento = table.Column<int>(type: "int", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VeiculoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PessoaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaidasCarrosEmpresa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SaidasCarrosEmpresa_Pessoas_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Pessoas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SaidasCarrosEmpresa_Veiculos_VeiculoId",
                        column: x => x.VeiculoId,
                        principalTable: "Veiculos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NotasFiscais",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdMovimento = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NumeroNotaFiscal = table.Column<int>(type: "int", nullable: false),
                    PesoNotaFiscal = table.Column<double>(type: "float", nullable: false),
                    EntradaFuncionarioId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MovimentoPesagemId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SaidaCarroEmpresaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotasFiscais", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NotasFiscais_EntradasFuncionarios_EntradaFuncionarioId",
                        column: x => x.EntradaFuncionarioId,
                        principalTable: "EntradasFuncionarios",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NotasFiscais_MovimentosPesagem_MovimentoPesagemId",
                        column: x => x.MovimentoPesagemId,
                        principalTable: "MovimentosPesagem",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NotasFiscais_SaidasCarrosEmpresa_SaidaCarroEmpresaId",
                        column: x => x.SaidaCarroEmpresaId,
                        principalTable: "SaidasCarrosEmpresa",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Observacoes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdMovimento = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Obs = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EntradaFuncionarioId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MovimentoPesagemId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SaidaCarroEmpresaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Observacoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Observacoes_EntradasFuncionarios_EntradaFuncionarioId",
                        column: x => x.EntradaFuncionarioId,
                        principalTable: "EntradasFuncionarios",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Observacoes_MovimentosPesagem_MovimentoPesagemId",
                        column: x => x.MovimentoPesagemId,
                        principalTable: "MovimentosPesagem",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Observacoes_SaidasCarrosEmpresa_SaidaCarroEmpresaId",
                        column: x => x.SaidaCarroEmpresaId,
                        principalTable: "SaidasCarrosEmpresa",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Pessoas",
                columns: new[] { "Id", "Documento", "Nome" },
                values: new object[,]
                {
                    { new Guid("99ec3771-460e-439e-fe6e-08da0cd45f35"), "123", "Deku" },
                    { new Guid("99ec3771-460e-439e-fe6e-08da0cd45f36"), "654", "Bakugo" },
                    { new Guid("99ec3771-460e-439e-fe6e-08da0cd45f37"), "987", "Uraraka" },
                    { new Guid("99ec3771-460e-439e-fe6e-08da0cd45f38"), "965", "Toshiro" },
                    { new Guid("99ec3771-460e-439e-fe6e-08da0cd45f39"), "458", "Ishida" }
                });

            migrationBuilder.InsertData(
                table: "Veiculos",
                columns: new[] { "Id", "Modelo", "Placa" },
                values: new object[,]
                {
                    { new Guid("98ec3771-460e-439e-fe6e-08da0cd45f35"), "Gurgel", "TYU6458" },
                    { new Guid("99ec3771-460e-439e-fe6e-08da0cd45f30"), "Variant", "ABC1234" },
                    { new Guid("99ec3771-460e-439e-fe6e-08da0cd45f31"), "Fiat 147", "ASD5654" },
                    { new Guid("99ec3771-460e-439e-fe6e-08da0cd45f33"), "Opala", "CVB2987" },
                    { new Guid("99ec3771-460e-439e-fe6e-08da0cd45f34"), "Chevet", "ERT5965" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_EntradasFuncionarios_PessoaId",
                table: "EntradasFuncionarios",
                column: "PessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_EntradasFuncionarios_VeiculoId",
                table: "EntradasFuncionarios",
                column: "VeiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_MovimentosPesagem_PessoaId",
                table: "MovimentosPesagem",
                column: "PessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_MovimentosPesagem_VeiculoId",
                table: "MovimentosPesagem",
                column: "VeiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_NotasFiscais_EntradaFuncionarioId",
                table: "NotasFiscais",
                column: "EntradaFuncionarioId");

            migrationBuilder.CreateIndex(
                name: "IX_NotasFiscais_MovimentoPesagemId",
                table: "NotasFiscais",
                column: "MovimentoPesagemId");

            migrationBuilder.CreateIndex(
                name: "IX_NotasFiscais_SaidaCarroEmpresaId",
                table: "NotasFiscais",
                column: "SaidaCarroEmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Observacoes_EntradaFuncionarioId",
                table: "Observacoes",
                column: "EntradaFuncionarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Observacoes_MovimentoPesagemId",
                table: "Observacoes",
                column: "MovimentoPesagemId");

            migrationBuilder.CreateIndex(
                name: "IX_Observacoes_SaidaCarroEmpresaId",
                table: "Observacoes",
                column: "SaidaCarroEmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_SaidasCarrosEmpresa_PessoaId",
                table: "SaidasCarrosEmpresa",
                column: "PessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_SaidasCarrosEmpresa_VeiculoId",
                table: "SaidasCarrosEmpresa",
                column: "VeiculoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NotasFiscais");

            migrationBuilder.DropTable(
                name: "Observacoes");

            migrationBuilder.DropTable(
                name: "EntradasFuncionarios");

            migrationBuilder.DropTable(
                name: "MovimentosPesagem");

            migrationBuilder.DropTable(
                name: "SaidasCarrosEmpresa");

            migrationBuilder.DropTable(
                name: "Pessoas");

            migrationBuilder.DropTable(
                name: "Veiculos");
        }
    }
}
