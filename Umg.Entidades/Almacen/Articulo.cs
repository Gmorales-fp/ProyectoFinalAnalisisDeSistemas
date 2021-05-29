using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Umg.Entidades.Almacen
{
    class Articulo
    {
        //idArticulo, codigo 15, nombre 30, precio_venta,stock,decipcion
        //idcategoria, idEstado
        public int idArticulo { get; set; }

        [Required]
        [StringLength(15, MinimumLength = 15, ErrorMessage = "Error")]
        public string codigo { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Error")]
        public double precio_venta { get; set; }
        public int stock { get; set; }
        public string descripcion { get; set; }
        public int idCategoria { get; set; }
        public int idEstado { get; set; }
        public Categoria categoria { get; set; }
        public ICollection<DetalleVenta> detalleVentas { get; set; } 
        public Estado estado { get; set; }



    }
}
