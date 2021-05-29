using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Umg.Entidades.Usuarios
{
    class Rol
    {
        //idrol, nombre, descripcion, idEstado
        public int idrol { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 25, ErrorMessage = "Error")]
        public string nombre { get; set; }

        [Required]
        [StringLength(250, MinimumLength = 50, ErrorMessage = "Error")]
        public string descipcion { get; set; }
        public int idEstado { get; set; }
        public ICollection<Usuario> usuarios { get; set; }
        public Estado estado { get; set; }

    }
}
