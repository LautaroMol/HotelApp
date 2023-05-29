﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Reservas.BData;

#nullable disable

namespace Reservas.BData.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230529152440_clases_1")]
    partial class clases_1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Reservas.BData.Data.Entity.Habitacion", b =>
                {
                    b.Property<int>("Nhab")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Nhab"));

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<int>("Precio")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<int>("camas")
                        .HasMaxLength(2)
                        .HasColumnType("int");

                    b.HasKey("Nhab");

                    b.HasIndex(new[] { "Nhab" }, "Habitacion_Nhab_UQ")
                        .IsUnique();

                    b.ToTable("Habitaciones");
                });

            modelBuilder.Entity("Reservas.BData.Data.Entity.Huespedes", b =>
                {
                    b.Property<string>("DNI")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Tarjeta")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("DNI");

                    b.HasIndex(new[] { "DNI" }, "Huespedes_DNI_UQ")
                        .IsUnique();

                    b.ToTable("Huesped");
                });
#pragma warning restore 612, 618
        }
    }
}
