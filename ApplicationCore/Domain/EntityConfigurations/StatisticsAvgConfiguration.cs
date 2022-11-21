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
    public class StatisticsAvgConfiguration : IEntityTypeConfiguration<StatisticsAVG>
    {
        public void Configure(EntityTypeBuilder<StatisticsAVG> builder)
        {

            var statsAvg = new List<StatisticsAVG>() {
                new StatisticsAVG()
                {
                    Id = 1,
                    AvgSymbolsPerMin = 32.43f,
                    AvgAccuracy = 57,
                    AvgTime = "03:12",
                    TextsCount = 21,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Seed"
                },
                new StatisticsAVG()
                {
                    Id = 2,
                    AvgSymbolsPerMin = 42.21f,
                    AvgAccuracy = 68,
                    AvgTime = "02:48",
                    TextsCount = 3,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Seed"
                },
                new StatisticsAVG()
                {
                    Id = 3,
                    AvgSymbolsPerMin = 55.01f,
                    AvgAccuracy = 78,
                    AvgTime = "04:24",
                    TextsCount = 32,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Seed"
                },
                new StatisticsAVG()
                {
                    Id = 4,
                    AvgSymbolsPerMin = 121.17f,
                    AvgAccuracy = 83,
                    AvgTime = "03:04",
                    TextsCount = 81,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Seed"
                },
                new StatisticsAVG()
                {
                    Id = 5,
                    AvgSymbolsPerMin = 45.91f,
                    AvgAccuracy = 67,
                    AvgTime = "05:35",
                    TextsCount = 17,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Seed"
                },
                new StatisticsAVG()
                {
                    Id = 6,
                    AvgSymbolsPerMin = 51.56f,
                    AvgAccuracy = 80,
                    AvgTime = "03:00",
                    TextsCount = 26,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Seed"
                },
                new StatisticsAVG()
                {
                    Id = 7,
                    AvgSymbolsPerMin = 48.42f,
                    AvgAccuracy = 61,
                    AvgTime = "03:28",
                    TextsCount = 6,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Seed"
                },
                new StatisticsAVG()
                {
                    Id = 8,
                    AvgSymbolsPerMin = 65.23f,
                    AvgAccuracy = 73,
                    AvgTime = "06:27",
                    TextsCount = 25,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Seed"
                },
                new StatisticsAVG()
                {
                    Id = 9,
                    AvgSymbolsPerMin = 54.25f,
                    AvgAccuracy = 72,
                    AvgTime = "03:53",
                    TextsCount = 43,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Seed"
                },
                new StatisticsAVG()
                {
                    Id = 10,
                    AvgSymbolsPerMin = 43.63f,
                    AvgAccuracy = 57,
                    AvgTime = "03:03",
                    TextsCount = 24,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Seed"
                },
                new StatisticsAVG()
                {
                    Id = 11,
                    AvgSymbolsPerMin = 67.56f,
                    AvgAccuracy = 79,
                    AvgTime = "03:33",
                    TextsCount = 58,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Seed"
                },
                new StatisticsAVG()
                {
                    Id = 12,
                    AvgSymbolsPerMin = 54.23f,
                    AvgAccuracy = 74,
                    AvgTime = "02:09",
                    TextsCount = 99,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Seed"
                },
                new StatisticsAVG()
                {
                    Id = 13,
                    AvgSymbolsPerMin = 34.00f,
                    AvgAccuracy = 62,
                    AvgTime = "03:34",
                    TextsCount = 51,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Seed"
                },
                new StatisticsAVG()
                {
                    Id = 14,
                    AvgSymbolsPerMin = 58.28f,
                    AvgAccuracy = 19,
                    AvgTime = "04:39",
                    TextsCount = 7,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Seed"
                }
            };

            //builder.HasData(statsAvg);
        }
    }
}
