using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlPlagas.Core.Domain;

namespace ControlPlagas.Data.Mapping
{
    public class FacturaMap : EntityTypeConfiguration<Factura>
    {
        public FacturaMap()
        {
            this.ToTable(nameof(Factura));
            this.HasKey(f => f.Id);

            this.Property(f => f.Fecha).IsRequired();
            this.Property(f => f.Precio).IsRequired();

            this.HasRequired<Cliente>(c => c.Cliente)
                .WithMany(f => f.Facturas)
                .HasForeignKey<int>(c => c.ClienteId);
        }
    }
}
