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
    public class UsersInfoConfiguration : IEntityTypeConfiguration<UserInfo>
    {
        public void Configure(EntityTypeBuilder<UserInfo> builder)
        {

            var usersInfo = new List<UserInfo>() {
                    new UserInfo()
                    {
                        Id = 1,
                        SignUpAt = DateTime.Now,
                        Language = "English",
                        CreatedAt = DateTime.Now,
                        CreatedBy = "Seed"
                    },
                    new UserInfo()
                    {
                        Id = 2,
                        SignUpAt = DateTime.Now,
                        Language = "Russian",
                        CreatedAt = DateTime.Now,
                        CreatedBy = "Seed"
                    },
                    new UserInfo()
                    {
                        Id = 3,
                        SignUpAt = DateTime.Now,
                        Language = "English",
                        CreatedAt = DateTime.Now,
                        CreatedBy = "Seed"
                    },
                    new UserInfo()
                    {
                        Id = 4,
                        SignUpAt = DateTime.Now,
                        Language = "Russian",
                        CreatedAt = DateTime.Now,
                        CreatedBy = "Seed"
                    },
                    new UserInfo()
                    {
                        Id = 5,
                        SignUpAt = DateTime.Now,
                        Language = "English",
                        CreatedAt = DateTime.Now,
                        CreatedBy = "Seed"
                    },
                    new UserInfo()
                    {
                        Id = 6,
                        SignUpAt = DateTime.Now,
                        Language = "Russian",
                        CreatedAt = DateTime.Now,
                        CreatedBy = "Seed"
                    },
                    new UserInfo()
                    {
                        Id = 7,
                        SignUpAt = DateTime.Now,
                        Language = "Romanian",
                        CreatedAt = DateTime.Now,
                        CreatedBy = "Seed"
                    },
                    new UserInfo()
                    {
                        Id = 8,
                        SignUpAt = DateTime.Now,
                        Language = "Russian",
                        CreatedAt = DateTime.Now,
                        CreatedBy = "Seed"
                    },
                    new UserInfo()
                    {
                        Id = 9,
                        SignUpAt = DateTime.Now,
                        Language = "Russian",
                        CreatedAt = DateTime.Now,
                        CreatedBy = "Seed"
                    },
                    new UserInfo()
                    {
                        Id = 10,
                        SignUpAt = DateTime.Now,
                        Language = "English",
                        CreatedAt = DateTime.Now,
                        CreatedBy = "Seed"
                    },
                    new UserInfo()
                    {
                        Id = 11,
                        SignUpAt = DateTime.Now,
                        Language = "English",
                        CreatedAt = DateTime.Now,
                        CreatedBy = "Seed"
                    },
                    new UserInfo()
                    {
                        Id = 12,
                        SignUpAt = DateTime.Now,
                        Language = "Russian",
                        CreatedAt = DateTime.Now,
                        CreatedBy = "Seed"
                    },
                    new UserInfo()
                    {
                        Id = 13,
                        SignUpAt = DateTime.Now,
                        Language = "English",
                        CreatedAt = DateTime.Now,
                        CreatedBy = "Seed"
                    },
                    new UserInfo()
                    {
                        Id = 14,
                        SignUpAt = DateTime.Now,
                        Language = "Romanian",
                        CreatedAt = DateTime.Now,
                        CreatedBy = "Seed"
                    }
            };

            builder.HasData(usersInfo);
        }
    }
}

