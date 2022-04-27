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
    internal class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.Property(x => x.TableId).IsRequired(true);
            builder.Property(x => x.StaffId).IsRequired(true);
            builder.Property(x => x.OrderTypeId).IsRequired(true);
            builder.Property(x => x.CreatedAt).HasDefaultValue(DateTime.UtcNow.AddHours(4));
            builder.Property(x => x.UpdatedAt).HasDefaultValue(DateTime.UtcNow.AddHours(4));
            builder.Property(x => x.IsDeleted).HasDefaultValue(false);
        }
    }
}
