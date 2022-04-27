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
    internal class StaffConfiguration : IEntityTypeConfiguration<Staff>
    {
        public void Configure(EntityTypeBuilder<Staff> builder)
        {
            builder.Property(x => x.FullName).HasMaxLength(100).IsRequired(true);
            builder.Property(x => x.StaffTypeId).IsRequired(true);
            builder.Property(x => x.Salary).HasColumnType("decimal(10,2)");
            builder.Property(x => x.PhoneNumber).HasMaxLength(50).IsRequired(true);
            builder.Property(x => x.Pin).IsRequired(true).HasMaxLength(9999);
            builder.Property(x => x.CreatedAt).HasDefaultValue(DateTime.UtcNow.AddHours(4));
            builder.Property(x => x.UpdatedAt).HasDefaultValue(DateTime.UtcNow.AddHours(4));
            builder.Property(x => x.IsDeleted).HasDefaultValue(false);
        }
    }
}
