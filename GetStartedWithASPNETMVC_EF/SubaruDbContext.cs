using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace GetStartedWithASPNETMVC_EF
{
    public partial class SubaruDbContext : DbContext
    {
        public SubaruDbContext()
            : base("name=SubaruDbContext")
        {
        }

        public virtual DbSet<Offline> Offline { get; set; }
        public virtual DbSet<Online> Online { get; set; }
        public virtual DbSet<Rework> Rework { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Offline>()
                .Property(e => e.ProductType)
                .IsUnicode(false);

            modelBuilder.Entity<Online>()
                .Property(e => e.ProductType)
                .IsUnicode(false);

            modelBuilder.Entity<Rework>()
                .Property(e => e.ProductType)
                .IsUnicode(false);
        }
    }
}
