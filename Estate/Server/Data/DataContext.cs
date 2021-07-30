using Estate.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estate.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Apartment> Apartments { get; set; }
        public DbSet<Tenant> Tenants { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceLine> InvoiceLines { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Apartment>()
                .Property(x => x.Price)
                .HasColumnType("decimal(9,2)");
            modelBuilder.Entity<InvoiceLine>()
                .Property(x => x.AmountExclTax)
                .HasColumnType("decimal(9,2)");
            modelBuilder.Entity<InvoiceLine>()
                .Property(x => x.AmountInclTax)
                .HasColumnType("decimal(9,2)");
            modelBuilder.Entity<Invoice>()
                .Property(x => x.AmountExclTax)
                .HasColumnType("decimal(9,2)");
            modelBuilder.Entity<Invoice>()
                .Property(x => x.AmountInclTax)
                .HasColumnType("decimal(9,2)");
            modelBuilder.Entity<InvoiceLine>()
                .Property(x => x.DiscountPercent)
                .HasColumnType("decimal(4,2)");
        }
    }
}
