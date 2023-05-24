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
        public Context(DbContextOptions options) : base(options) 
        { 
        }

    }
}
