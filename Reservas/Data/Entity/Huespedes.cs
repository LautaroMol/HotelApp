using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservas.BData.Data.Entity
{
    public class Huespedes
    {
        [Key] public string DNI { get; set; } = "";
        public string Nombres { get; set; } = "";
        public string Apellidos { get; set; } = "";
        public string Correo { get; set; } = "";
        public string Tarjeta { get; set; } = "";
    }
}
