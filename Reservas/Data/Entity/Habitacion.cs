using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Reservas.BData.Data.Entity
{
    [Index(nameof(Nhab), Name = "Habitacion_Nhab_UQ", IsUnique=true)]
    public class Habitacion
    {
        [Key] public int Nhab { get; set; }
        [Required(ErrorMessage = "El numero de camas es Obligatorio")]
        [MaxLength(2, ErrorMessage = "Solo se aceptan hasta 2 caracteres en el numero de camas")]
        public int camas { get; set; }
        [Required(ErrorMessage = "El estado es Obligatorio")]
        [MaxLength(40, ErrorMessage = "Solo se aceptan hasta 40 caracteres en el estado")]
        public string Estado { get; set; } = "";
        [Required(ErrorMessage = "El Precio es Obligatorio")]
        [MaxLength(10, ErrorMessage = "Solo se aceptan hasta 10 caracteres en el Precio y 2 decimales")]
        public decimal Precio { get; set; }
        [MaxLength(10, ErrorMessage = "Solo se aceptan hasta 10 caracteres en la seña y 2 decimales")]
        public decimal Senia { get; set; }
        public int idres { get; set; }
        public List<Reserva> reservas { get; set; }
    }
}
