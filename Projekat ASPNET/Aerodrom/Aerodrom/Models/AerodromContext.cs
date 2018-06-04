using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Aerodrom.Models
{
    public class AerodromContext : DbContext
    {
        public AerodromContext():base("AzureConnection")
        {
        }

        public DbSet<Karta> Karta { get; set; }
        public DbSet<Dostava> Dostava { get; set; }

        //Ova funkcija se koriste da bi se ukinulo automatsko dodavanje množine u nazive
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}