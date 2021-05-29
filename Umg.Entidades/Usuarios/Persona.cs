using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Umg.Entidades.Usuarios
{
    class Persona
    {
        public int idPersona { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 25, ErrorMessage = "Error")]
        public string Nombre { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 25, ErrorMessage = "Error")]
        public string Tipo_persona { get; set; }
        [Required]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "Error")]
        public string Tipo_documento { get; set; }
        [Required]
        [StringLength(15, MinimumLength = 15, ErrorMessage = "Error")]
        public string num_documento { get; set; }
        public int Id_Direccion { get; set; }
        public int Id_Telefono { get; set; }
        public int Id_Email { get; set; }

        //realcion con la tabla direccion  
        public Direcciones { get; set; }

        //realcion con la tabla Email  
        public Email Emails { get; set; }

        //realcion con la tabla telefono
        public Telefono Telefonos { get; set; }
        public int idEstado { get; set; }
        public ICollection<Usuario> usuarios { get; set; }
        public Estado estado { get; set; }

    }
}
