using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial1_AP2_VictorPalma.Models
{
    public class Articulos
    {
        [Key]
        public int ArticuloId { get; set; }
        [Required(ErrorMessage ="Es obligatorio ingresar una descripción del articulo")]
        public string Descripcion { get; set; }
        [Range(minimum:1, maximum:999)]
        public int Existencia { get; set; }
        public double Costo { get; set; }
        public double ValorInventario { get; set; }

    }
}
