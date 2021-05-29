using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Umg.Entidades.Almacen
{
    class Venta
    {
        //idventa, serie_comprobante varchar15, num_comprobante varchar15, fecha_hora, impuesto,total,
        //idTipoComprobante,idusuario, idEstado
        public int idventa { get; set; }

        [Required]
        [StringLength(15, MinimumLength = 15, ErrorMessage = "Error")]
        public string serie_comprobante { get; set; }

        [Required]
        [StringLength(15, MinimumLength = 15, ErrorMessage = "Error")]
        public string num_comprobante { get; set; }
        public DateTime fecha_hora { get; set; }
        public decimal impuesto { get; set; }
        public decimal total { get; set; }
        public int idTipoComprobante { get; set; }
        public int idusuario { get; set; }
        public int idEstado { get; set; }
        public ICollection<DetalleVenta> detalleVentas { get; set; }
        public Usuario usuario { get; set; }
        public Tipo_comprobante tipo_Comprobante { get; set; }
        public Estado estado { get; set; }

        
    }
}
