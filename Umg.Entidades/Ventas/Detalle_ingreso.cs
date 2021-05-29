using System;
using System.Collections.Generic;
using System.Text;

namespace Umg.Entidades.Almacen
{
    class Detalle_ingreso
    {
        public int idDetalle { get; set; }
        public int cantidad { get; set; }
        public decimal precio { get; set; }
        public int idIngreso { get; set; }
        public Ingreso ingreso { get; set; }
        public Articulo articulo { get; set; }
        public Ingreso ingreso { get; set; }
    }
}
