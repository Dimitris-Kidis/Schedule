


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

            
            builder.HasOne(user => user.UserInfo)
                .WithOne(client => client.User)
                .HasForeignKey<UserInfo>(client => client.Id);
            

            builder.HasOne(user => user.StatisticsAVG)
                .WithOne(specialist => specialist.User)
                .HasForeignKey<StatisticsAVG>(specialist => specialist.Id);

        }
    }
}
