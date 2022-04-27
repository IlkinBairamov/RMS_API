using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RMS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Data.Configurations
{
    internal class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(x=>x.Name).HasMaxLength(50).IsRequired(true);
            builder.Property(x => x.Amount).HasColumnType("decimal(10,2)");
            builder.Property(x => x.CostPrice).HasColumnType("decimal(10,2)").IsRequired(true);
            builder.Property(x => x.ProductTypeId).IsRequired(true);
            builder.Property(x => x.CreatedAt).HasDefaultValue(DateTime.UtcNow.AddHours(4));
            builder.Property(x => x.UpdatedAt).HasDefaultValue(DateTime.UtcNow.AddHours(4));
            builder.Property(x => x.IsDeleted).HasDefaultValue(false);
        }
    }
}
