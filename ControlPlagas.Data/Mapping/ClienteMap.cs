using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlPlagas.Core.Domain;

namespace ControlPlagas.Data.Mapping
{
    public class ClienteMap : EntityTypeConfiguration<Cliente>
    {
        public ClienteMap()
        {
            this.ToTable(nameof(Cliente));
            this.HasKey(c => c.Id);

            this.Property(c => c.NombreCompleto).HasMaxLength(256);
            this.Property(c => c.Telefono).HasMaxLength(13);
            this.Property(c => c.CorreoElectronico).HasMaxLength(256);
            this.Property(c => c.Direccion).HasMaxLength(256);
            this.Property(c => c.CodicoPostal).HasMaxLength(10);

            this.HasMany<Factura>(f => f.Facturas)
                .WithOptional(c => c.Cliente);
        }
    }
}
