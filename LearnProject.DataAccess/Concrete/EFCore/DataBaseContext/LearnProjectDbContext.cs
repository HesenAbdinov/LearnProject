using LearnProject.DataAccess.Concrete.EFCore.Mappings;
using LearnProject.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
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
            modelBuilder.ApplyConfiguration<Category>(new CategoryMap());
            modelBuilder.ApplyConfiguration<Product>(new ProductMap());
        }

    }
}
