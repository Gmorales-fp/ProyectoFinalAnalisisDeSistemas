using System;
using System.Collections.Generic;
using System.Text;

namespace Umg.Entidades.Usuarios
{
    class Usuario
    {
        public int idusuario { get; set; }
        public string password_hash { get; set; }
        public string password_sal { get; set; }
        public int idPersona { get; set; }
        public int idRol { get; set; }
        public ICollection<Ingreso> ingresos { get; set; }
        public ICollection<Venta> ventas { get; set; }
        public Rol rol { get; set; }
        public Persona persona { get; set; }

    }
}
