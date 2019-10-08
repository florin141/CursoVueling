using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlPlagas.Core.Domain;

namespace ControlPlagas.Data.Mapping
{
    public class ServiciosMap : EntityTypeConfiguration<Servicio>
    {
        public ServiciosMap()
        {
            this.ToTable(nameof(Servicio));
            this.HasKey(s => s.Id);

            this.Property(s => s.NombreServicio).HasMaxLength(128).IsRequired();
            this.Property(s => s.Precio).IsRequired();

            this.HasMany<Trabajador>(tr => tr.Trabajadores)
                .WithMany(s => s.Servicios)
                .Map(ts =>
                {
                    ts.MapLeftKey("IdServicio");
                    ts.MapRightKey("IdTrabajador");
                    ts.ToTable("ServicioTrabajador");
                });

            this.HasMany<Recurso>(r => r.Recursos)
                .WithMany(s => s.Servicios)
                .Map(rs =>
                {
                    rs.MapLeftKey("IdServicio");
                    rs.MapRightKey("IdRecurso");
                    rs.ToTable("ServicioRecurso");
                });

            this.HasMany<Factura>(f => f.Facturas)
                .WithMany(s => s.Servicios)
                .Map(fs =>
                {
                    fs.MapLeftKey("IdServicio");
                    fs.MapRightKey("IdFactura");
                    fs.ToTable("ServicioFactura");
                });


        }
    }
}
