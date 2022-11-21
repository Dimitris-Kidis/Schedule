


using ApplicationCore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TYPO.ApplicationCore.Domain.Entities;

namespace TYPO.ApplicationCore.Domain.EntityConfigurations
{
    public class UsersConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder
                .HasIndex(u => u.Email)
                    .IsUnique();

            builder.HasOne(user => user.UserInfo)
                .WithOne(client => client.User)
                .HasForeignKey<UserInfo>(client => client.Id);


            builder.HasOne(user => user.StatisticsAVG)
                .WithOne(specialist => specialist.User)
                .HasForeignKey<StatisticsAVG>(specialist => specialist.Id);

            var users = new List<User>() {
                    new User()
                    {
                        Id = 1,
                        IsAdmin = true,
                        Email = "admin@admin.com",
                        FirstName = "Admin",
                        LastName = "Admin",
                        Password = "adminadmin",
                        Age = 22,
                        Gender = "M",
                        CreatedAt = DateTime.Now,
                        CreatedBy = "Seed"
                    },
                    new User()
                    {
                        Id = 2,
                        IsAdmin = false,
                        Email = "dinalups@google.com",
                        FirstName = "Dina",
                        LastName = "Lupsha",
                        Password = "32rg342k3",
                        Age = 23,
                        Gender = "F",
                        CreatedAt = DateTime.Now,
                        CreatedBy = "Seed"
                    },
                    new User()
                    {
                        Id = 3,
                        IsAdmin = false,
                        Email = "lenkapenka@yahoo.com",
                        FirstName = "Elena",
                        LastName = "Yarynych",
                        Password = "vvkkkdan",
                        Age = 25,
                        Gender = "F",
                        CreatedAt = DateTime.Now,
                        CreatedBy = "Seed"
                    },
                    new User()
                    {
                        Id = 4,
                        IsAdmin = false,
                        Email = "svetkach@mail.ru",
                        FirstName = "Svetlana",
                        LastName = "Soltic",
                        Password = "chuwinss",
                        Age = 31,
                        Gender = "F",
                        CreatedAt = DateTime.Now,
                        CreatedBy = "Seed"
                    },
                    new User()
                    {
                        Id = 5,
                        IsAdmin = false,
                        Email = "vasssty@google.com",
                        FirstName = "Igor",
                        LastName = "Ejov",
                        Password = "ejejejeje",
                        Age = 41,
                        Gender = "M",
                        CreatedAt = DateTime.Now,
                        CreatedBy = "Seed"
                    },
                    new User()
                    {
                        Id = 6,
                        IsAdmin = false,
                        Email = "nastinasti@yahoo.com",
                        FirstName = "Anastasia",
                        LastName = "Pantelei",
                        Password = "barbarbar",
                        Age = 27,
                        Gender = "F",
                        CreatedAt = DateTime.Now,
                        CreatedBy = "Seed"
                    },
                    new User()
                    {
                        Id = 7,
                        IsAdmin = false,
                        Email = "sergosergo@simpals.md",
                        FirstName = "Serghei",
                        LastName = "Romanenco",
                        Password = "barbarbar",
                        Age = 45,
                        Gender = "M",
                        CreatedAt = DateTime.Now,
                        CreatedBy = "Seed"
                    },
                    new User()
                    {
                        Id = 8,
                        IsAdmin = false,
                        Email = "ivaia@google.com",
                        FirstName = "Ivan",
                        LastName = "Veselov",
                        Password = "veseloveselo",
                        Age = 30,
                        Gender = "M",
                        CreatedAt = DateTime.Now,
                        CreatedBy = "Seed"
                    },
                    new User()
                    {
                        Id = 9,
                        IsAdmin = false,
                        Email = "serenawww@yahoo.com",
                        FirstName = "Serena",
                        LastName = "Williams",
                        Password = "tennistennis",
                        Age = 36,
                        Gender = "F",
                        CreatedAt = DateTime.Now,
                        CreatedBy = "Seed"
                    },
                    new User()
                    {
                        Id = 10,
                        IsAdmin = false,
                        Email = "nadinadi@mail.ru",
                        FirstName = "Nadejda",
                        LastName = "Romanenco",
                        Password = "habibihabibi",
                        Age = 41,
                        Gender = "F",
                        CreatedAt = DateTime.Now,
                        CreatedBy = "Seed"
                    },
                    new User()
                    {
                        Id = 11,
                        IsAdmin = false,
                        Email = "ionvasisis@google.com",
                        FirstName = "Ivan",
                        LastName = "Vasilashco",
                        Password = "internintern",
                        Age = 24,
                        Gender = "M",
                        CreatedAt = DateTime.Now,
                        CreatedBy = "Seed"
                    },
                    new User()
                    {
                        Id = 12,
                        IsAdmin = false,
                        Email = "yankinan@google.com",
                        FirstName = "Anastasia",
                        LastName = "Yankina",
                        Password = "photophoto",
                        Age = 26,
                        Gender = "F",
                        CreatedAt = DateTime.Now,
                        CreatedBy = "Seed"
                    },
                    new User()
                    {
                        Id = 13,
                        IsAdmin = false,
                        Email = "adriadri@yahoo.com",
                        FirstName = "Adriana",
                        LastName = "Rindunica",
                        Password = "ffwf43rf4",
                        Age = 22,
                        Gender = "F",
                        CreatedAt = DateTime.Now,
                        CreatedBy = "Seed"
                    },
                    new User()
                    {
                        Id = 14,
                        IsAdmin = false,
                        Email = "ponama@mail.ru",
                        FirstName = "Daria",
                        LastName = "Ponomarenko",
                        Password = "artartart",
                        Age = 22,
                        Gender = "F",
                        CreatedAt = DateTime.Now,
                        CreatedBy = "Seed"
                    }
                };


            //builder.HasData(users);
        }
    }
}
