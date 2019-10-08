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

            base.OnModelCreating(modelBuilder);
        }
    }
}
