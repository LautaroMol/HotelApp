using Microsoft.EntityFrameworkCore;
using Reservas.BData.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservas.BData
{
    public class Context : DbContext
    {
        public DbSet<Huespedes> Huesped => Set<Huespedes>();
        public DbSet<Habitacion> Habitaciones => Set<Habitacion>();
        public DbSet<Reserva> Reservas => Set<Reserva>();
        public Context(DbContextOptions options) : base(options) 
        { 
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Habitacion>(o =>
            {
                o.Property(b => b.Precio).HasColumnType("Decimal(10,2)");
                o.Property(b => b.Senia).HasColumnType("Decimal(10,2)");
            });
            base.OnModelCreating(modelBuilder);
        }

    }
}
