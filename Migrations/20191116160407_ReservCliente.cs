using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoTravelCan.Migrations
{
    public partial class ReservCliente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "clientesId",
                table: "Reservas",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_clientesId",
                table: "Reservas",
                column: "clientesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_Clientes_clientesId",
                table: "Reservas",
                column: "clientesId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Clientes_clientesId",
                table: "Reservas");

            migrationBuilder.DropIndex(
                name: "IX_Reservas_clientesId",
                table: "Reservas");

            migrationBuilder.DropColumn(
                name: "clientesId",
                table: "Reservas");
        }
    }
}
