using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MinhaCantina.Servidor.Migrations
{
    /// <inheritdoc />
    public partial class AcrecentaURLImagemNaTabelaProduto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagemURL",
                table: "Produtos",
                type: "text",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagemURL",
                table: "Produtos");
        }
    }
}
