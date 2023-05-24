using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservas.BData.Data.Entity
{
    public class Habitacion
    {
        [Key] public int Nhab { get; set; }
        public int camas { get; set; }
        public string Estado { get; set; } = "";
        public int Precio { get; set; }
    }
}
