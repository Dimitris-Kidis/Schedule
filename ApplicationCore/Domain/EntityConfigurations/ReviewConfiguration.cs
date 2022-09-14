using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Schedule_Project.ApplicationCore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Domain.EntityConfigurations
{
    internal class ReviewConfiguration : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {


            builder.HasKey(review => new { review.ClientId, review.SpecialistId });
            builder
                .HasOne(review => review.Client)
                .WithMany(client => client.Reviews)
                .HasForeignKey(review => review.ClientId)
                .OnDelete(DeleteBehavior.NoAction);
            builder
                .HasOne(review => review.Specialist)
                .WithMany(specialist => specialist.Reviews)
                .HasForeignKey(review => review.SpecialistId)
                .OnDelete(DeleteBehavior.NoAction);

        }
    }
}

