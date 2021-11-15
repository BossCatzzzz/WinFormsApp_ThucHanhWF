using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Lab04_QuanLySanPham.Model
{
    public partial class QLSPModel : DbContext
    {
        public QLSPModel()
            : base("name=QLSPModel")
        {
        }

        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<ORDER> ORDERs { get; set; }
        public virtual DbSet<PRODUCT> PRODUCTs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Invoice>()
                .HasMany(e => e.ORDERs)
                .WithRequired(e => e.Invoice)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ORDER>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<PRODUCT>()
                .Property(e => e.BuyPrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<PRODUCT>()
                .Property(e => e.SellPrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<PRODUCT>()
                .HasMany(e => e.ORDERs)
                .WithRequired(e => e.PRODUCT)
                .WillCascadeOnDelete(false);
        }
    }
}
