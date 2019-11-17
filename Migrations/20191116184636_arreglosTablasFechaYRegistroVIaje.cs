using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoTravelCan.Migrations
{
    public partial class arreglosTablasFechaYRegistroVIaje : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DescripcionCompleta",
                table: "Viajes",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DescripcionCompleta",
                table: "Viajes");
        }
    }
}
