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
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable(@"Product", @"dbo");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name).HasColumnName("Name");
            builder.Property(p => p.CategoryID).HasColumnName("CategoryID");
            builder.Property(p => p.Height).HasColumnName("Height");
            builder.Property(p => p.Weight).HasColumnName("Weight");
            builder.Property(p => p.Width).HasColumnName("Width");
            builder.Property(p => p.Explanation).HasColumnName("Explanation");
            builder.Property(p => p.AddedDate).HasColumnName("AddedDate");
            builder.Property(p => p.AddedBy).HasColumnName("AddedBy");
        }
    }
}
