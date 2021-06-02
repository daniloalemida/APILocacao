using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Locacao.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Agencia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CEP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Logradouro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    Complemento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bairro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agencia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CheckLists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarroLimpo = table.Column<bool>(type: "bit", nullable: false),
                    TanqueCheio = table.Column<bool>(type: "bit", nullable: false),
                    Amassado = table.Column<bool>(type: "bit", nullable: false),
                    Arranhoes = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckLists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CPF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Data_nasc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CEP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Logradouro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    Complemento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bairro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Celular = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Role = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Devolucao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubTotal = table.Column<double>(type: "float", nullable: false),
                    ValorTotalPagar = table.Column<double>(type: "float", nullable: false),
                    ValorAdicional = table.Column<double>(type: "float", nullable: false),
                    IdCheckListDevolucao = table.Column<int>(type: "int", nullable: false),
                    IdOperador = table.Column<int>(type: "int", nullable: false),
                    IdAluguel = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devolucao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MarcaVeiculo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarcaVeiculo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ModeloVeiculo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModeloVeiculo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Operadores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Matricula = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Role = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Operadores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Retirada",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCheckListRetirada = table.Column<int>(type: "int", nullable: false),
                    IdOperador = table.Column<int>(type: "int", nullable: false),
                    IdAluguel = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Retirada", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Veiculo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Placa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValorDiaria = table.Column<double>(type: "float", nullable: false),
                    CapacidadeTanqueCombustivel = table.Column<int>(type: "int", nullable: false),
                    CapacidadePortaMalas = table.Column<int>(type: "int", nullable: false),
                    IdMarca = table.Column<int>(type: "int", nullable: false),
                    IdModelo = table.Column<int>(type: "int", nullable: false),
                    Ano = table.Column<int>(type: "int", nullable: false),
                    FotoVeiculo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarroDisponivel = table.Column<bool>(type: "bit", nullable: false),
                    IdAgencia = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veiculo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Aluguel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VeiculoId = table.Column<int>(type: "int", nullable: true),
                    TotalDiariasLocacao = table.Column<double>(type: "float", nullable: false),
                    ValorTotal = table.Column<double>(type: "float", nullable: false),
                    ClienteId = table.Column<int>(type: "int", nullable: true),
                    DataRetirada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdAgenciaRetirada = table.Column<int>(type: "int", nullable: false),
                    LocalDevolucaoId = table.Column<int>(type: "int", nullable: true),
                    DataDevolucao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdRetirada = table.Column<int>(type: "int", nullable: false),
                    IdDevolucao = table.Column<int>(type: "int", nullable: false),
                    LocacaoAtiva = table.Column<bool>(type: "bit", nullable: false),
                    IdDevolucaoVeiculo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aluguel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Aluguel_Agencia_LocalDevolucaoId",
                        column: x => x.LocalDevolucaoId,
                        principalTable: "Agencia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Aluguel_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Aluguel_Veiculo_VeiculoId",
                        column: x => x.VeiculoId,
                        principalTable: "Veiculo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Aluguel_ClienteId",
                table: "Aluguel",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Aluguel_LocalDevolucaoId",
                table: "Aluguel",
                column: "LocalDevolucaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Aluguel_VeiculoId",
                table: "Aluguel",
                column: "VeiculoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aluguel");

            migrationBuilder.DropTable(
                name: "CheckLists");

            migrationBuilder.DropTable(
                name: "Devolucao");

            migrationBuilder.DropTable(
                name: "MarcaVeiculo");

            migrationBuilder.DropTable(
                name: "ModeloVeiculo");

            migrationBuilder.DropTable(
                name: "Operadores");

            migrationBuilder.DropTable(
                name: "Retirada");

            migrationBuilder.DropTable(
                name: "Agencia");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Veiculo");
        }
    }
}
