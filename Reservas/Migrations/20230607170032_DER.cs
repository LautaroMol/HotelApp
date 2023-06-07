using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Reservas.BData.Migrations
{
    /// <inheritdoc />
    public partial class DER : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Habitaciones",
                columns: table => new
                {
                    Nhab = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    camas = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Precio = table.Column<decimal>(type: "Decimal(10,2)", maxLength: 10, nullable: false),
                    Senia = table.Column<decimal>(type: "Decimal(10,2)", maxLength: 10, nullable: false),
                    idres = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Habitaciones", x => x.Nhab);
                });

            migrationBuilder.CreateTable(
                name: "Reservas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fecha_inicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fecha_fin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DNI = table.Column<int>(type: "int", nullable: false),
                    Nhab = table.Column<int>(type: "int", nullable: false),
                    HabitacionNhab = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservas_Habitaciones_HabitacionNhab",
                        column: x => x.HabitacionNhab,
                        principalTable: "Habitaciones",
                        principalColumn: "Nhab");
                });

            migrationBuilder.CreateTable(
                name: "Huesped",
                columns: table => new
                {
                    DNI = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nombres = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Tarjeta = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ReservaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Huesped", x => x.DNI);
                    table.ForeignKey(
                        name: "FK_Huesped_Reservas_ReservaId",
                        column: x => x.ReservaId,
                        principalTable: "Reservas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "Habitacion_Nhab_UQ",
                table: "Habitaciones",
                column: "Nhab",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "Huespedes_DNI_UQ",
                table: "Huesped",
                column: "DNI",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Huesped_ReservaId",
                table: "Huesped",
                column: "ReservaId");

            migrationBuilder.CreateIndex(
                name: "Id_Reserva_UQ",
                table: "Reservas",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_HabitacionNhab",
                table: "Reservas",
                column: "HabitacionNhab");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Huesped");

            migrationBuilder.DropTable(
                name: "Reservas");

            migrationBuilder.DropTable(
                name: "Habitaciones");
        }
    }
}
