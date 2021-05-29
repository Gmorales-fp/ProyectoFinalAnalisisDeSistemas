using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Umg.Entidades.Almacen
{
    class Ingreso
    {
        //idingreso, tipo_comprobante 15, serie_comprobante 15, num_comprobante 15,
        //fecha_hora, impuesto, total, idUsuario,idEstado

        public int idingreso { get; set; }

        [Required]
        [StringLength(15, MinimumLength = 15, ErrorMessage = "Error")]
        public string tipo_comprobante { get; set; }

        [Required]
        [StringLength(15, MinimumLength = 15, ErrorMessage = "Error")]
        public string serie_comprobante { get; set; }

        [Required]
        [StringLength(15, MinimumLength = 15, ErrorMessage = "Error")]
        public string num_comprobante { get; set; }
        public DateTime fecha_hora { get; set; }
        public decimal impuesto { get; set; }
        public decimal total { get; set; }
        public int idUsuario { get; set; }
        public int idEstado { get; set; }
        public ICollection<Detalle_ingreso> detalle_Ingresos { get; set; }
        public Usuario usuario { get; set; }
        public Estado estado { get; set; }
    }
}
