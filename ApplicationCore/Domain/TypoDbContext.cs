

using ApplicationCore.Domain.Entities;
using ApplicationCore.Domain.EntityConfigurations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TYPO.ApplicationCore.Domain.Entities;
using TYPO.ApplicationCore.Domain.EntityConfigurations;

namespace TYPO.ApplicationCore.Domain
{
    public class TypoDbContext : /*IdentityDbContext*/ /*IdentityDbContext<User, Role, int, UserClaim, UserRole, UserLogin, RoleClaim, UserToken>*/DbContext
    {


        public DbSet<User> Users { get; set; }
        public DbSet<UserInfo> UserInfos { get; set; }
        public DbSet<StatisticsAVG> StatisticsAVG { get; set; }
        public DbSet<Statistics> Statistics { get; set; }
        public DbSet<Text> Texts { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Image> Images { get; set; }

        public TypoDbContext()
        {

        }

        public TypoDbContext(DbContextOptions<TypoDbContext> options) : base(options)
        {

        }


        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Data Source=.;Database=TYPO;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.ApplyConfiguration<UserInfo>(new UsersInfoConfiguration());
            builder.ApplyConfiguration<Text>(new TextsConfigurations());
            builder.ApplyConfiguration<Review>(new ReviewsConfiguration());
            builder.ApplyConfiguration<StatisticsAVG>(new StatisticsAvgConfiguration());
            builder.ApplyConfiguration<User>(new UsersConfiguration());
            builder.ApplyConfiguration<Statistics>(new StatisticsConfiguration());
            builder.ApplyConfiguration<Image>(new ImagesConfiguration());

            



        }
        
    }
}
