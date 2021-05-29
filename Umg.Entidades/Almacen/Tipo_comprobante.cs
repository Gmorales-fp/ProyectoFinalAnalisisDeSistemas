using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Umg.Entidades.Almacen
{
    class Tipo_comprobante
    {

        public int idTipoComprobante { get; set; }

        [Required]
        [StringLength(15, MinimumLength = 15, ErrorMessage = "Error")]
        public string TipoComprobante { get; set; }
        public ICollection<Venta> ventas { get; set; }
    }
}
