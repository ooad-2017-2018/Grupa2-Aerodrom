namespace Aerodrom.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AerodromModel : DbContext
    {
        public AerodromModel()
            : base("name=AerodromModel")
        {
        }

        public virtual DbSet<Karta> Kartas { get; set; }
        public virtual DbSet<KorisnikTabela> KorisnikTabelas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KorisnikTabela>()
                .Property(e => e.createdAt)
                .HasPrecision(3);

            modelBuilder.Entity<KorisnikTabela>()
                .Property(e => e.updatedAt)
                .HasPrecision(3);

            modelBuilder.Entity<KorisnikTabela>()
                .Property(e => e.version)
                .IsFixedLength();

            modelBuilder.Entity<KorisnikTabela>()
                .Property(e => e.datumRodjenja)
                .HasPrecision(3);
        }
    }
}
