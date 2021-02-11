using Microsoft.EntityFrameworkCore.Migrations;

namespace AspNetCore.Mvc.Site.Migrations
{
    public partial class RetirarTeste : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Teste",
                table: "Alunos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Teste",
                table: "Alunos",
                nullable: true);
        }
    }
}
