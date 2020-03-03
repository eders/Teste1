using Microsoft.EntityFrameworkCore.Migrations;

namespace Teste1.Infra.Migrations
{
    public partial class aplicandoSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Estado",
                columns: new[] { "COD_ESTADO", "ESTADO", "UF" },
                values: new object[] { 1, "Mato Grosso do Sul", "MS" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "COD_CIDADE", "COD_ESTADO", "NOME_CIDADE" },
                values: new object[] { 1, 1, "Camp Grande" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "COD_CIDADE", "COD_ESTADO", "NOME_CIDADE" },
                values: new object[] { 2, 1, "Corumbá" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "COD_CIDADE", "COD_ESTADO", "NOME_CIDADE" },
                values: new object[] { 3, 1, "Dourados" });

            migrationBuilder.InsertData(
                table: "Endereco",
                columns: new[] { "COD_ENDERECO", "BAIRRO", "COD_CIDADE", "LOGRADOURO", "NUMERO" },
                values: new object[,]
                {
                    { 1, null, 1, "Centro", "1" },
                    { 2, null, 1, "Bairro", "2" },
                    { 3, null, 2, "Centro", "1" },
                    { 4, null, 2, "Bairro", "2" },
                    { 5, null, 3, "Centro", "1" },
                    { 6, null, 3, "Bairro", "2" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Endereco",
                keyColumn: "COD_ENDERECO",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Endereco",
                keyColumn: "COD_ENDERECO",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Endereco",
                keyColumn: "COD_ENDERECO",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Endereco",
                keyColumn: "COD_ENDERECO",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Endereco",
                keyColumn: "COD_ENDERECO",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Endereco",
                keyColumn: "COD_ENDERECO",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "COD_CIDADE",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "COD_CIDADE",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "COD_CIDADE",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Estado",
                keyColumn: "COD_ESTADO",
                keyValue: 1);
        }
    }
}
