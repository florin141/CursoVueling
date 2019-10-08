using ControlPlagas.Core.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlPlagas.Data.Mapping
{
    public class TrabajadorMap : EntityTypeConfiguration<Trabajador>
    {
        public TrabajadorMap()
        {
            this.ToTable(nameof(Trabajador));
            this.HasKey(t => t.Id);

            this.Property(t => t.NombreCompleto).HasMaxLength(128).IsRequired();
            this.Property(t => t.Salario).IsRequired();

            this.Property(t => t.Categoria);
        }
    }
}
