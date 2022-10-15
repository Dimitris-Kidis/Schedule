using ApplicationCore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Domain.EntityConfigurations
{
    public class StatisticsConfiguration : IEntityTypeConfiguration<Statistics>
    {
        public void Configure(EntityTypeBuilder<Statistics> builder)
        {

            
            //builder.Property(x => x.Id).HasColumnName("Id").HasColumnType("int").ValueGeneratedOnAdd();
            //builder
            //    .HasOne(stats => stats.User)
            //    .WithMany(text => text.Statistics)
            //    .HasForeignKey(review => review.Id)
            //    .OnDelete(DeleteBehavior.NoAction);
            //builder
            //    .HasOne(stats => stats.Text)
            //    .WithMany(user => user.Statistics)
            //    .HasForeignKey(text => text.Id)
            //    .OnDelete(DeleteBehavior.NoAction);


        }
    }
}
