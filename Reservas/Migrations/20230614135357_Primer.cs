using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Reservas.BData.Migrations
{
    /// <inheritdoc />
    public partial class Primer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    idPersona = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservas", x => x.Id);
                });

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
                    idres = table.Column<int>(type: "int", nullable: false),
                    ReservaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Habitaciones", x => x.Nhab);
                    table.ForeignKey(
                        name: "FK_Habitaciones_Reservas_ReservaId",
                        column: x => x.ReservaId,
                        principalTable: "Reservas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Persona",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(type: "nvarchar(55)", maxLength: 55, nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(55)", maxLength: 55, nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    NumTarjeta = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ReservaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persona", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Persona_Reservas_ReservaId",
                        column: x => x.ReservaId,
                        principalTable: "Reservas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Huesped",
                columns: table => new
                {
                    DNI = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nombres = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    checking = table.Column<bool>(type: "bit", maxLength: 30, nullable: false),
                    Num_Hab = table.Column<int>(type: "int", nullable: false),
                    PersonaId = table.Column<int>(type: "int", nullable: false),
                    HabitacionNhab = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Huesped", x => x.DNI);
                    table.ForeignKey(
                        name: "FK_Huesped_Habitaciones_HabitacionNhab",
                        column: x => x.HabitacionNhab,
                        principalTable: "Habitaciones",
                        principalColumn: "Nhab");
                });

            migrationBuilder.CreateIndex(
                name: "Habitacion_Nhab_UQ",
                table: "Habitaciones",
                column: "Nhab",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Habitaciones_ReservaId",
                table: "Habitaciones",
                column: "ReservaId");

            migrationBuilder.CreateIndex(
                name: "Huespedes_DNI_UQ",
                table: "Huesped",
                column: "DNI",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Huesped_HabitacionNhab",
                table: "Huesped",
                column: "HabitacionNhab");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_ReservaId",
                table: "Persona",
                column: "ReservaId");

            migrationBuilder.CreateIndex(
                name: "Id_Reserva_UQ",
                table: "Reservas",
                column: "Id",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Huesped");

            migrationBuilder.DropTable(
                name: "Persona");

            migrationBuilder.DropTable(
                name: "Habitaciones");

            migrationBuilder.DropTable(
                name: "Reservas");
        }
    }
}
