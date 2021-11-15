using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace OnTapWinForm.Model
{
    public partial class QLSACHModel : DbContext
    {
        public QLSACHModel()
            : base("name=QLSACHModel1")
        {
        }

        public virtual DbSet<LOAISACH> LOAISACHes { get; set; }
        public virtual DbSet<SACH> SACHes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LOAISACH>()
                .HasMany(e => e.SACHes)
                .WithRequired(e => e.LOAISACH)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SACH>()
                .Property(e => e.MaSach)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
