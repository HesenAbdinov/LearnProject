using LearnProject.DataAccess.Concrete.EFCore.Mappings;
using LearnProject.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace LearnProject.DataAccess.Concrete.EFCore.DataBaseContext
{
    public class LearnProjectDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=DESKTOP-KDMUQNQ;Database=LearnProject;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true";

            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new ProductMap());

            //modelBuilder.Entity<Product>()
            //.HasKey(p => p.Id); // Primary key belirtme

            //modelBuilder.Entity<Product>()
            //    .Property(p => p.Name)
            //    .IsRequired(); // Zorunlu alan belirtme

            //modelBuilder.Entity<Product>()
            //    .HasOne(p => p.Category) // Product sınıfının bir Category'si olmalıdır
            //    .WithMany(c => c.Products) // Category sınıfının birden fazla Product'ı olabilir
            //    .HasForeignKey(p => p.CategoryID); // Foreign key belirtme

            // Category sınıfı için mapping
            //modelBuilder.Entity<Category>()
            //    .HasKey(c => c.Id);

            //modelBuilder.Entity<Category>()
            //    .Property(c => c.Name)
            //    .IsRequired();

            //modelBuilder.Entity<Product>();
        }
    }
}
