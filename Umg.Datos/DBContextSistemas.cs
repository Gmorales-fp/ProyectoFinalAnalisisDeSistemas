using Microsoft.EntityFrameworkCore;
using Umg.Datos.Mapping.Almacen;
using Umg.Datos.Mapping.Informacion;
using Umg.Datos.Mapping.Usuarios;
using Umg.Datos.Mapping.Ventas;
using Umg.Entidades.Almacen;
using Umg.Entidades.Informacion;
using Umg.Entidades.Usuarios;
using Umg.Entidades.Ventas;

namespace Umg.Datos
{
    public class DbContextSistema : DbContext
    {

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<articulo> Articulos { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Direccion> Direccions { get; set; }
        public DbSet<Email> Emails { get; set; }
        public DbSet<Municipio> Municipios { get; set; }
        public DbSet<Telefono> Telefonos { get; set; }
        public DbSet<persona> Personas { get; set; }
        public DbSet<Rol> Rols { get; set; }
        public DbSet<usuario> Usuarios { get; set; }
        public DbSet<detalle_ingreso> Detalle_Ingresos { get; set; }
        public DbSet<detalle_venta> Detalle_Ventas { get; set; }
        public DbSet<ingreso> Ingresos { get; set; }
        public DbSet<venta> Ventas { get; set; }













        public DbContextSistema(DbContextOptions<DbContextSistema> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new CategoriaMap());

            modelBuilder.ApplyConfiguration(new ArticuloMap());

            modelBuilder.ApplyConfiguration(new PersonaMap());

            modelBuilder.ApplyConfiguration(new RolMap());

            modelBuilder.ApplyConfiguration(new UsuariosMap());

            modelBuilder.ApplyConfiguration(new DetalleIngresoMap());

            modelBuilder.ApplyConfiguration(new DetalleVentaMap());

            modelBuilder.ApplyConfiguration(new IngresoMap());

            modelBuilder.ApplyConfiguration(new VentasMap());

            modelBuilder.ApplyConfiguration(new DepartamentoMap());

            modelBuilder.ApplyConfiguration(new DireccionMap());

            modelBuilder.ApplyConfiguration(new EmailMap());

            modelBuilder.ApplyConfiguration(new MunicipioMap());

            modelBuilder.ApplyConfiguration(new TelefonoMap());




        }
    }
}