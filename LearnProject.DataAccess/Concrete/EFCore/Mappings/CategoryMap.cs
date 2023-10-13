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
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable(@"Categories", @"dbo");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Name).HasColumnName("Name");
            builder.Property(c => c.AddedDate).HasColumnName("AddedDate");
            builder.Property(c => c.AddedBy).HasColumnName("AddedBy");
            builder.Property(c => c.IsActive).HasColumnName("IsActive");

        }
    }
}
