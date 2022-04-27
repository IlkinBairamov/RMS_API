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
    internal class TableConfiguration : IEntityTypeConfiguration<Table>
    {
        public void Configure(EntityTypeBuilder<Table> builder)
        {
            builder.Property(x => x.Number).HasMaxLength(50).IsRequired(true);
            builder.Property(x=>x.AmountOfSeat).IsRequired(true);
            builder.Property(x=>x.Deposite).IsRequired(false);
            builder.Property(x => x.HasDeposite).HasDefaultValue(false).IsRequired(true);
            builder.Property(x=>x.HallId).IsRequired(true);
            builder.Property(x => x.CreatedAt).HasDefaultValue(DateTime.UtcNow.AddHours(4));
            builder.Property(x => x.UpdatedAt).HasDefaultValue(DateTime.UtcNow.AddHours(4));
            builder.Property(x => x.IsDeleted).HasDefaultValue(false);
        }
    }
}
