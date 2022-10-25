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
    public class ReviewsConfiguration : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {

            var reviews = new List<Review>()
            {
                new Review()
                {
                    Id = 1,
                    ReviewContent = "Content1",
                    UserId = 1,
                    TextId = 1,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Seed"
                },
                new Review()
                {
                    Id = 2,
                    ReviewContent = "Content2",
                    UserId = 2,
                    TextId = 2,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Seed"
                },
                new Review()
                {
                    Id = 3,
                    ReviewContent = "Content3",
                    UserId = 3,
                    TextId = 3,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Seed"
                },
                new Review()
                {
                    Id = 4,
                    ReviewContent = "Content4",
                    UserId = 4,
                    TextId = 4,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Seed"
                },
                new Review()
                {
                    Id = 5,
                    ReviewContent = "Content5",
                    UserId = 5,
                    TextId = 5,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Seed"
                },
                new Review()
                {
                    Id = 6,
                    ReviewContent = "Content6",
                    UserId = 6,
                    TextId = 6,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Seed"
                },
                new Review()
                {
                    Id = 7,
                    ReviewContent = "Content7",
                    UserId = 7,
                    TextId = 7,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Seed"
                },
                new Review()
                {
                    Id = 8,
                    ReviewContent = "Content8",
                    UserId = 8,
                    TextId = 8,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Seed"
                },
                new Review()
                {
                    Id = 9,
                    ReviewContent = "Content9",
                    UserId = 9,
                    TextId = 9,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Seed"
                },
                new Review()
                {
                    Id = 10,
                    ReviewContent = "Content10",
                    UserId = 10,
                    TextId = 10,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Seed"
                },
                new Review()
                {
                    Id = 11,
                    ReviewContent = "Content11",
                    UserId = 11,
                    TextId = 11,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Seed"
                },
                new Review()
                {
                    Id = 12,
                    ReviewContent = "Content12",
                    UserId = 12,
                    TextId = 12,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Seed"
                },
                new Review()
                {
                    Id = 13,
                    ReviewContent = "Content13",
                    UserId = 13,
                    TextId = 13,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Seed"
                },
                new Review()
                {
                    Id = 14,
                    ReviewContent = "Content14",
                    UserId = 14,
                    TextId = 14,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Seed"
                }
            };

            builder.HasData(reviews);
        }
    }
}
