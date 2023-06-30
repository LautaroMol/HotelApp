using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Reservas.BData.Migrations
{
    /// <inheritdoc />
    public partial class Vemos12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "Habitacion_Nhab_UQ",
                table: "Habitaciones");

            migrationBuilder.InsertData(
                table: "Habitaciones",
                columns: new[] { "Nhab", "Estado", "Precio", "ReservaId", "Senia", "camas" },
                values: new object[] { 1, "Reservada", 200m, null, 30m, 20 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Habitaciones",
                keyColumn: "Nhab",
                keyValue: 1);

            migrationBuilder.CreateIndex(
                name: "Habitacion_Nhab_UQ",
                table: "Habitaciones",
                column: "Nhab",
                unique: true);
        }
    }
}
