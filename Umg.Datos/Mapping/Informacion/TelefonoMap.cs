using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Umg.Entidades.Informacion;
using Umg.Entidades.Usuarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace Umg.Datos.Mapping.Informacion
{
   public class TelefonoMap : IEntityTypeConfiguration<Telefono>
    {
        public void Configure(EntityTypeBuilder<Telefono> builder)
        {
            builder.ToTable("Telefono")
                .HasKey(c => c.Id_Telefono);
            builder.Property(c => c.Tel_Personal)
                .HasMaxLength(11);
            builder.Property(c => c.Tel_Casa)
                .HasMaxLength(11);
        }
    }
}
