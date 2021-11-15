using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Lab05_DanhSachSinhVien.Model
{
    public partial class QLSVModel : DbContext
    {
        public QLSVModel()
            : base("name=QLSVModel")
        {
        }

        public virtual DbSet<FACULTY> FACULTies { get; set; }
        public virtual DbSet<STUDENT> STUDENTs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FACULTY>()
                .HasMany(e => e.STUDENTs)
                .WithRequired(e => e.FACULTY)
                .WillCascadeOnDelete(false);
        }
    }
}
