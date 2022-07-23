using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace GetStartedWithASPMVC_SqlsugarDbcontext
{
    public partial class AlbertSqlsugarDbcontext : DbContext
    {
        public AlbertSqlsugarDbcontext()
            : base("name=AlbertSqlsugarDbcontext")
        {
        }

        public virtual DbSet<T_CurrentUser> T_CurrentUser { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<T_CurrentUser>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<T_CurrentUser>()
                .Property(e => e.Account)
                .IsUnicode(false);

            modelBuilder.Entity<T_CurrentUser>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<T_CurrentUser>()
                .Property(e => e.Email)
                .IsUnicode(false);
        }
    }
}
