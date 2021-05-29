using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Umg.Entidades.Almacen;
using System;
using System.Collections.Generic;
using System.Text;

namespace Umg.Datos.Mapping.Almacen
{
   public class ArticuloMap : IEntityTypeConfiguration<articulo>
    {
        public void Configure(EntityTypeBuilder<articulo> builder)
        {
            builder.ToTable("Articulo")
                .HasKey(c => c.idArticulo);
            builder.Property(c => c.codigo)
                .HasMaxLength(50);
            builder.Property(c => c.nombre)
                .HasMaxLength(50);
            builder.Property(c => c.venta)
                .HasMaxLength(11);
            builder.Property(c => c.stock)
                .HasMaxLength(50);
            builder.Property(c => c.descripcion)
                .HasMaxLength(256);
            builder.Property(c => c.condicion)
                .HasMaxLength(10);
            builder.Property(c => c.idmarca)
                .HasMaxLength(100);
        }
    }
}
