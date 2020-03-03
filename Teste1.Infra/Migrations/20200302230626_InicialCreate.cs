using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Teste1.Infra.Migrations
{
    public partial class InicialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Estado",
                columns: table => new
                {
                    COD_ESTADO = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ESTADO = table.Column<string>(nullable: false),
                    UF = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estado", x => x.COD_ESTADO);
                });

            migrationBuilder.CreateTable(
                name: "Cidade",
                columns: table => new
                {
                    COD_CIDADE = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    COD_ESTADO = table.Column<int>(nullable: false),
                    NOME_CIDADE = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cidade", x => x.COD_CIDADE);
                    table.ForeignKey(
                        name: "FK_Cidade_Estado_COD_ESTADO",
                        column: x => x.COD_ESTADO,
                        principalTable: "Estado",
                        principalColumn: "COD_ESTADO",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Endereco",
                columns: table => new
                {
                    COD_ENDERECO = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LOGRADOURO = table.Column<string>(nullable: false),
                    BAIRRO = table.Column<string>(nullable: true),
                    NUMERO = table.Column<string>(nullable: false),
                    COD_CIDADE = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereco", x => x.COD_ENDERECO);
                    table.ForeignKey(
                        name: "FK_Endereco_Cidade_COD_CIDADE",
                        column: x => x.COD_CIDADE,
                        principalTable: "Cidade",
                        principalColumn: "COD_CIDADE",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pessoa",
                columns: table => new
                {
                    COD_PESSOA = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    COD_ENDERECO = table.Column<int>(nullable: false),
                    NOME = table.Column<string>(nullable: false),
                    CPF = table.Column<string>(nullable: false),
                    NASCIMENTO = table.Column<DateTime>(nullable: false),
                    TELEFONE = table.Column<string>(nullable: false),
                    EMAIL = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoa", x => x.COD_PESSOA);
                    table.ForeignKey(
                        name: "FK_Pessoa_Endereco_COD_ENDERECO",
                        column: x => x.COD_ENDERECO,
                        principalTable: "Endereco",
                        principalColumn: "COD_ENDERECO",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cidade_COD_ESTADO",
                table: "Cidade",
                column: "COD_ESTADO");

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_COD_CIDADE",
                table: "Endereco",
                column: "COD_CIDADE");

            migrationBuilder.CreateIndex(
                name: "IX_Pessoa_COD_ENDERECO",
                table: "Pessoa",
                column: "COD_ENDERECO");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pessoa");

            migrationBuilder.DropTable(
                name: "Endereco");

            migrationBuilder.DropTable(
                name: "Cidade");

            migrationBuilder.DropTable(
                name: "Estado");
        }
    }
}
