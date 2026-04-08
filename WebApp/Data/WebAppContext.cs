
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApp.Models;

namespace WebApp.Data
{
    public class WebAppContext : DbContext
    {
        public WebAppContext (DbContextOptions<WebAppContext> options)
            : base(options)
        {
        }

        public DbSet<WebApp.Models.Category> Category { get; set; } = default!;
        public DbSet<WebApp.Models.Order> Order { get; set; } = default!;
        public DbSet<WebApp.Models.OrderItem> OrderItem { get; set; } = default!;
        public DbSet<WebApp.Models.Payment> Payment { get; set; } = default!;
        public DbSet<WebApp.Models.Product> Product { get; set; } = default!;
        public DbSet<WebApp.Models.ProductTag> ProductTag { get; set; } = default!;
        public DbSet<WebApp.Models.Tag> Tag { get; set; } = default!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .HasPrecision(15, 2);
            modelBuilder.Entity<Payment>()
                .Property(p => p.Amount)
                .HasPrecision(15, 2); 
            // Many-to-Many (Option B)
            modelBuilder.Entity<ProductTag>()
                .HasKey(pt => new { pt.ProductId, pt.TagId });

            modelBuilder.Entity<ProductTag>()
                .HasOne(pt => pt.Product)
                .WithMany(p => p.ProductTags)
                .HasForeignKey(pt => pt.ProductId);

            modelBuilder.Entity<ProductTag>()
                .HasOne(pt => pt.Tag)
                .WithMany(t => t.ProductTags)
                .HasForeignKey(pt => pt.TagId);
        }
    }
}
