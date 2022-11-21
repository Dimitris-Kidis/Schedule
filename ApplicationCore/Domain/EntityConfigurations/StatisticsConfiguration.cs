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


            var stats = new List<Statistics>() {
                    new Statistics()
                    {
                        Id = 1,
                        UserId = 1,
                        TextId = 1,
                        SharedVia = "VK",
                        NumberOfMistakes = 3,
                        SymbolsPerMinute = 54,
                        Accuracy = 68.7f,
                        Time = "02:30",
                        CreatedAt = DateTime.Now,
                        CreatedBy = "Seed"
                    },
                    new Statistics()
                    {
                        Id = 2,
                        UserId = 2,
                        TextId = 2,
                        SharedVia = "VK",
                        NumberOfMistakes = 3,
                        SymbolsPerMinute = 54,
                        Accuracy = 68.7f,
                        Time = "02:30",
                        CreatedAt = DateTime.Now,
                        CreatedBy = "Seed"
                    },
                    new Statistics()
                    {
                        Id = 3,
                        UserId = 3,
                        TextId = 3,
                        SharedVia = "VK",
                        NumberOfMistakes = 3,
                        SymbolsPerMinute = 54,
                        Accuracy = 68.7f,
                        Time = "02:30",
                        CreatedAt = DateTime.Now,
                        CreatedBy = "Seed"
                    },
                    new Statistics()
                    {
                        Id = 4,
                        UserId = 4,
                        TextId = 4,
                        SharedVia = "VK",
                        NumberOfMistakes = 3,
                        SymbolsPerMinute = 54,
                        Accuracy = 68.7f,
                        Time = "02:30",
                        CreatedAt = DateTime.Now,
                        CreatedBy = "Seed"
                    },
                    new Statistics()
                    {
                        Id = 5,
                        UserId = 5,
                        TextId = 5,
                        SharedVia = "VK",
                        NumberOfMistakes = 3,
                        SymbolsPerMinute = 54,
                        Accuracy = 68.7f,
                        Time = "02:30",
                        CreatedAt = DateTime.Now,
                        CreatedBy = "Seed"
                    },
                    new Statistics()
                    {
                        Id = 6,
                        UserId = 6,
                        TextId = 6,
                        SharedVia = "VK",
                        NumberOfMistakes = 3,
                        SymbolsPerMinute = 54,
                        Accuracy = 68.7f,
                        Time = "02:30",
                        CreatedAt = DateTime.Now,
                        CreatedBy = "Seed"
                    },
                    new Statistics()
                    {
                        Id = 7,
                        UserId = 7,
                        TextId = 7,
                        SharedVia = "VK",
                        NumberOfMistakes = 3,
                        SymbolsPerMinute = 54,
                        Accuracy = 68.7f,
                        Time = "02:30",
                        CreatedAt = DateTime.Now,
                        CreatedBy = "Seed"
                    },
                    new Statistics()
                    {
                        Id = 8,
                        UserId = 8,
                        TextId = 8,
                        SharedVia = "VK",
                        NumberOfMistakes = 3,
                        SymbolsPerMinute = 54,
                        Accuracy = 68.7f,
                        Time = "02:30",
                        CreatedAt = DateTime.Now,
                        CreatedBy = "Seed"
                    },
                    new Statistics()
                    {
                        Id = 9,
                        UserId = 9,
                        TextId = 9,
                        SharedVia = "VK",
                        NumberOfMistakes = 3,
                        SymbolsPerMinute = 54,
                        Accuracy = 68.7f,
                        Time = "02:30",
                        CreatedAt = DateTime.Now,
                        CreatedBy = "Seed"
                    },
                    new Statistics()
                    {
                        Id = 10,
                        UserId = 10,
                        TextId = 10,
                        SharedVia = "VK",
                        NumberOfMistakes = 3,
                        SymbolsPerMinute = 54,
                        Accuracy = 68.7f,
                        Time = "02:30",
                        CreatedAt = DateTime.Now,
                        CreatedBy = "Seed"
                    },
                    new Statistics()
                    {
                        Id = 11,
                        UserId = 11,
                        TextId = 11,
                        SharedVia = "VK",
                        NumberOfMistakes = 3,
                        SymbolsPerMinute = 54,
                        Accuracy = 68.7f,
                        Time = "02:30",
                        CreatedAt = DateTime.Now,
                        CreatedBy = "Seed"
                    },
                    new Statistics()
                    {
                        Id = 12,
                        UserId = 12,
                        TextId = 12,
                        SharedVia = "VK",
                        NumberOfMistakes = 3,
                        SymbolsPerMinute = 54,
                        Accuracy = 68.7f,
                        Time = "02:30",
                        CreatedAt = DateTime.Now,
                        CreatedBy = "Seed"
                    },
                    new Statistics()
                    {
                        Id = 13,
                        UserId = 13,
                        TextId = 13,
                        SharedVia = "VK",
                        NumberOfMistakes = 3,
                        SymbolsPerMinute = 54,
                        Accuracy = 68.7f,
                        Time = "02:30",
                        CreatedAt = DateTime.Now,
                        CreatedBy = "Seed"
                    },
                    new Statistics()
                    {
                        Id = 14,
                        UserId = 14,
                        TextId = 14,
                        SharedVia = "VK",
                        NumberOfMistakes = 3,
                        SymbolsPerMinute = 54,
                        Accuracy = 68.7f,
                        Time = "02:30",
                        CreatedAt = DateTime.Now,
                        CreatedBy = "Seed"
                    }
            };


            //builder.HasData(stats);


        }
    }
}
