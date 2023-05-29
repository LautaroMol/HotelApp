using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservas.BData.Data.Entity
{
    [Index(nameof(Id), Name = "Id_Reserva_UQ", IsUnique = true)]
    public class Reserva
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "La Fecha de inicio es Obligatoria")]
        public DateTime fecha_inicio { get; set; }
        [Required(ErrorMessage = "La Fecha de fin es Obligatoria")]
        public DateTime fecha_fin { get; set; }
        public List<Huespedes> huespedes { get; set; }

        
    }
}
