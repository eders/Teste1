using Microsoft.EntityFrameworkCore.Migrations;

namespace Teste1.Infra.Migrations
{
    public partial class aplicandobairro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Endereco",
                keyColumn: "COD_ENDERECO",
                keyValue: 1,
                column: "BAIRRO",
                value: "CENTRO");

            migrationBuilder.UpdateData(
                table: "Endereco",
                keyColumn: "COD_ENDERECO",
                keyValue: 2,
                column: "BAIRRO",
                value: "BAIRRO");

            migrationBuilder.UpdateData(
                table: "Endereco",
                keyColumn: "COD_ENDERECO",
                keyValue: 3,
                column: "BAIRRO",
                value: "CENTRO");

            migrationBuilder.UpdateData(
                table: "Endereco",
                keyColumn: "COD_ENDERECO",
                keyValue: 4,
                column: "BAIRRO",
                value: "BAIRRO");

            migrationBuilder.UpdateData(
                table: "Endereco",
                keyColumn: "COD_ENDERECO",
                keyValue: 5,
                column: "BAIRRO",
                value: "CENTRO");

            migrationBuilder.UpdateData(
                table: "Endereco",
                keyColumn: "COD_ENDERECO",
                keyValue: 6,
                column: "BAIRRO",
                value: "BAIRRO");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Endereco",
                keyColumn: "COD_ENDERECO",
                keyValue: 1,
                column: "BAIRRO",
                value: null);

            migrationBuilder.UpdateData(
                table: "Endereco",
                keyColumn: "COD_ENDERECO",
                keyValue: 2,
                column: "BAIRRO",
                value: null);

            migrationBuilder.UpdateData(
                table: "Endereco",
                keyColumn: "COD_ENDERECO",
                keyValue: 3,
                column: "BAIRRO",
                value: null);

            migrationBuilder.UpdateData(
                table: "Endereco",
                keyColumn: "COD_ENDERECO",
                keyValue: 4,
                column: "BAIRRO",
                value: null);

            migrationBuilder.UpdateData(
                table: "Endereco",
                keyColumn: "COD_ENDERECO",
                keyValue: 5,
                column: "BAIRRO",
                value: null);

            migrationBuilder.UpdateData(
                table: "Endereco",
                keyColumn: "COD_ENDERECO",
                keyValue: 6,
                column: "BAIRRO",
                value: null);
        }
    }
}
