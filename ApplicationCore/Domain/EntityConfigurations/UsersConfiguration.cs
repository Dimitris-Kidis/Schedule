


using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Schedule_Project.ApplicationCore.Domain.Entities;

namespace Schedule_Project.ApplicationCore.Domain.EntityConfigurations
{
    internal class UsersConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {

            
            builder.HasOne(user => user.Client)
                .WithOne(client => client.User)
                .HasForeignKey<Client>(client => client.Id);
            

            builder.HasOne(user => user.Specialist)
                .WithOne(specialist => specialist.User)
                .HasForeignKey<Specialist>(specialist => specialist.Id);

        }
    }
}
