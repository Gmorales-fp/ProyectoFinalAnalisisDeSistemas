using System;
using System.Collections.Generic;
using System.Text;

namespace Umg.Entidades.Almacen
{
    class Estado
    {
        public int idEstado { get; set; }
        public string Estado { get; set; }
        public ICollection<Ingreso> ingresos { get; set; }
        public ICollection<Persona> personas { get; set; }
        public ICollection<Categoria> categorias { get; set; }
        public ICollection<Venta> ventas { get; set; }
        public ICollection<Rol> rols { get; set; }
        public ICollection<Articulo> articulos { get; set; }





}
}
