using Microsoft.EntityFrameworkCore;
using MyBlog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBlog.DAL.Config
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Category> builder)
        {
            builder.Property(x => x.CategoryName)
            .IsRequired()
            .HasMaxLength(256);

            builder.Property(x => x.Description)
                .IsRequired(false);


        }
    }
}
