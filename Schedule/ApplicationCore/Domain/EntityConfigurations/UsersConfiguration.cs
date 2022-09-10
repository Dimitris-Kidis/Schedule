


using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Schedule_Project.ApplicationCore.Domain.Entities;

namespace Schedule_Project.ApplicationCore.Domain.EntityConfigurations
{
    internal class UsersConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {



        }
    }
}
