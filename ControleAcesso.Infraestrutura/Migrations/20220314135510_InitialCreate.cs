using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ControleAcesso.Infraestrutura.Migrations
{
    public partial class InitialCreate : Migration
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
                name: "Movimentos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Sentido = table.Column<int>(type: "int", nullable: false),
                    TipoMovimento = table.Column<int>(type: "int", nullable: false),
                    StatusMovimento = table.Column<int>(type: "int", nullable: false),
                    Data = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VeiculoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PessoaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PesoChegada = table.Column<double>(type: "float", nullable: true),
                    PesoSaida = table.Column<double>(type: "float", nullable: true),
                    TotalPesoNotaFiscal = table.Column<double>(type: "float", nullable: true),
                    StatusPesagem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KmSaida = table.Column<int>(type: "int", nullable: true),
                    NivelCombustivelSaida = table.Column<int>(type: "int", nullable: true),
                    HoraSaida = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KmEntrada = table.Column<int>(type: "int", nullable: true),
                    NivelCombustivelEntrada = table.Column<int>(type: "int", nullable: true),
                    HoraEntrada = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Destino = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movimentos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movimentos_Pessoas_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Pessoas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Movimentos_Veiculos_VeiculoId",
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
                    MovimentosId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotasFiscais", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NotasFiscais_Movimentos_MovimentosId",
                        column: x => x.MovimentosId,
                        principalTable: "Movimentos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Observacao",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdMovimento = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Obs = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MovimentosId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Observacao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Observacao_Movimentos_MovimentosId",
                        column: x => x.MovimentosId,
                        principalTable: "Movimentos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movimentos_PessoaId",
                table: "Movimentos",
                column: "PessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_Movimentos_VeiculoId",
                table: "Movimentos",
                column: "VeiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_NotasFiscais_MovimentosId",
                table: "NotasFiscais",
                column: "MovimentosId");

            migrationBuilder.CreateIndex(
                name: "IX_Observacao_MovimentosId",
                table: "Observacao",
                column: "MovimentosId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NotasFiscais");

            migrationBuilder.DropTable(
                name: "Observacao");

            migrationBuilder.DropTable(
                name: "Movimentos");

            migrationBuilder.DropTable(
                name: "Pessoas");

            migrationBuilder.DropTable(
                name: "Veiculos");
        }
    }
}
