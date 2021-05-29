using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Umg.Entidades.Almacen
{
    class DetalleVenta
    {

        //idDetalle, cantidad, precio, descuento, idventa,idArticulo
        public int idDetalle { get; set; }
        public int cantidad { get; set; }
        public decimal precio { get; set; }
        public decimal descuento { get; set; }
        public int idventa { get; set; }
        public int idArticulo { get; set; }
        public Articulo articulo { get; set; }
        public Venta venta { get; set; }
        
    }
}
