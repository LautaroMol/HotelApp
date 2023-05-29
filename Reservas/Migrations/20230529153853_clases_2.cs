using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Reservas.BData.Migrations
{
    /// <inheritdoc />
    public partial class clases_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReservaId",
                table: "Huesped",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Reservas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fecha_inicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fecha_fin = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservas", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Huesped_ReservaId",
                table: "Huesped",
                column: "ReservaId");

            migrationBuilder.CreateIndex(
                name: "Id_Reserva_UQ",
                table: "Reservas",
                column: "Id",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Huesped_Reservas_ReservaId",
                table: "Huesped",
                column: "ReservaId",
                principalTable: "Reservas",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Huesped_Reservas_ReservaId",
                table: "Huesped");

            migrationBuilder.DropTable(
                name: "Reservas");

            migrationBuilder.DropIndex(
                name: "IX_Huesped_ReservaId",
                table: "Huesped");

            migrationBuilder.DropColumn(
                name: "ReservaId",
                table: "Huesped");
        }
    }
}
