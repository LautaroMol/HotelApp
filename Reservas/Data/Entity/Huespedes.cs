using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Reservas.BData.Data.Entity
{
    [Index(nameof(DNI), Name = "Huespedes_DNI_UQ", IsUnique = true)]
    public class Huespedes
    {
        [Key] public string DNI { get; set; } = "";
        [Required(ErrorMessage = "El Nombre es Obligatorio")]
        [MaxLength(50, ErrorMessage = "Solo se aceptan hasta 50 caracteres en el Nombre")]
        public string Nombres { get; set; } = "";
        [Required(ErrorMessage = "El Apellido es Obligatorio")]
        [MaxLength(50, ErrorMessage = "Solo se aceptan hasta 50 caracteres en el Apellido")]
        public string Apellidos { get; set; } = "";
        [Required(ErrorMessage = "El Correo es Obligatorio")]
        [MaxLength(30, ErrorMessage = "Solo se aceptan hasta 30 caracteres en el Correo")]
        public string Correo { get; set; } = "";
        [Required(ErrorMessage = "La Tarjeta es Obligatoria")]
        [MaxLength(20, ErrorMessage = "Solo se aceptan hasta 20 caracteres en La Tarjeta")]
        public string Tarjeta { get; set; } = "";
    }
}
