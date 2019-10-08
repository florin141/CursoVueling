using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlPlagas.Data.Mapping;

namespace ControlPlagas.Data
{
    public class ControlPlagasObjectContext : DbContext
    {
        public ControlPlagasObjectContext() 
            : base("ControlPlagasDb")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<ControlPlagasObjectContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ServiciosMap());
            modelBuilder.Configurations.Add(new ClienteMap());
            modelBuilder.Configurations.Add(new FacturaMap());
            modelBuilder.Configurations.Add(new TrabajadorMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
