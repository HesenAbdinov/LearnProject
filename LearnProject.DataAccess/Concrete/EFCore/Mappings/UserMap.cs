using LearnProject.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnProject.DataAccess.Concrete.EFCore.Mappings
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable(@"Users", @"dbo");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name).HasColumnName("Name");

            builder.Property(p => p.Id).HasColumnName("Id");

            builder.Property(p => p.Email).HasColumnName("Email");

            builder.Property(p => p.Phone).HasColumnName("Phone");

            builder.Property(p => p.Surname).HasColumnName("Surname");

            builder.Property(p => p.Active).HasColumnName("Active");

            builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate");

            //builder.Property(p => p.Explanation).HasColumnName("Explanation");

            //Relations
            builder.HasMany(u => u.Products)
               .WithOne(p => p.InsertedUser)
               .HasForeignKey(p => p.InsertedUserId);

            //builder
            //    .HasMany(u => u.Products)
            //    .WithOne(p => p.InsertedUser);
            //.HasForeignKey(p => p.InsertedUserId);
            //.HasOne(u => u.Products) // User sınıfının birnece Productu olmalıdır
            //.WithMany(p => p.InsertedUserId) // Category sınıfının birden fazla Product'ı olabilir
            //.HasForeignKey(p => p.InsertedUserId); // Foreign key belirtme
        }
    }
}
