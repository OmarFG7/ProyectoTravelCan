using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoTravelCan.Migrations
{
    public partial class Correcion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reseñas_AspNetUsers_UsuarioId",
                table: "Reseñas");

            migrationBuilder.DropIndex(
                name: "IX_Reseñas_UsuarioId",
                table: "Reseñas");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Reseñas");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Correo",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Password1",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Password2",
                table: "AspNetUsers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UsuarioId",
                table: "Reseñas",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Correo",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password1",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password2",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reseñas_UsuarioId",
                table: "Reseñas",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reseñas_AspNetUsers_UsuarioId",
                table: "Reseñas",
                column: "UsuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
