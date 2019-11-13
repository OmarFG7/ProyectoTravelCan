using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoTravelCan.Migrations
{
    public partial class IncluidoReseña1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdU",
                table: "Reseñas");

            migrationBuilder.AddColumn<string>(
                name: "CorreoUsuario",
                table: "Reseñas",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CorreoUsuario",
                table: "Reseñas");

            migrationBuilder.AddColumn<int>(
                name: "IdU",
                table: "Reseñas",
                nullable: true);
        }
    }
}
