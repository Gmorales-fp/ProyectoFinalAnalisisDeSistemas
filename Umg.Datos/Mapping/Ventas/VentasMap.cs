using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Umg.Entidades.Ventas;
using System;
using System.Collections.Generic;
using System.Text;

namespace Umg.Datos.Mapping.Ventas
{
    class VentasMap : IEntityTypeConfiguration<venta>
    {
        public void Configure(EntityTypeBuilder<venta> builder)
        {
            builder.ToTable("ventas")
                .HasKey(c => c.idventa);
            builder.Property(c => c.tipo_comprobante_venta)
                .HasMaxLength(10);
            builder.Property(c => c.serie_comprobante)
                .HasMaxLength(20);
            builder.Property(c => c.num_comprobante_venta)
                .HasMaxLength(20);
            builder.Property(c => c.impuesto)
                .HasMaxLength(50);
            builder.Property(c => c.total)
                .HasMaxLength(11);
            builder.Property(c => c.condicion_venta)
                .HasMaxLength(16);
        }
    }
}
