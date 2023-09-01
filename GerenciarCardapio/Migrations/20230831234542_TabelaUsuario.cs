using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GerenciarCardapio.Migrations
{
    public partial class TabelaUsuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Perfil = table.Column<int>(type: "int", nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "CategoriaProdutos",
                keyColumn: "Id",
                keyValue: 3,
                column: "NomeCategoria",
                value: "Cachaças");

            migrationBuilder.UpdateData(
                table: "CategoriaProdutos",
                keyColumn: "Id",
                keyValue: 4,
                column: "NomeCategoria",
                value: "Drinks");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DeleteData(
                table: "CategoriaProdutos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CategoriaProdutos",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "CategoriaProdutos",
                keyColumn: "Id",
                keyValue: 3,
                column: "NomeCategoria",
                value: "Drinks");

            migrationBuilder.UpdateData(
                table: "CategoriaProdutos",
                keyColumn: "Id",
                keyValue: 4,
                column: "NomeCategoria",
                value: "Cachaças");
        }
    }
}
