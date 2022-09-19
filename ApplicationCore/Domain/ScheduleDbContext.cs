
using ApplicationCore.Domain.EntityConfigurations;
using Microsoft.EntityFrameworkCore;
using Schedule_Project.ApplicationCore.Domain.Entities;
using Schedule_Project.ApplicationCore.Domain.EntityConfigurations;

namespace Schedule_Project.ApplicationCore.Domain
{
    public class ScheduleDbContext : DbContext
    {
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Specialist> Specialists { get; set; }
        public DbSet<UserInfo> UserInfos { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Data Source=.;Database=SCHEDULE;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.ApplyConfiguration<User>(new UsersConfiguration());
            builder.ApplyConfiguration<Review>(new ReviewConfiguration());
            builder.ApplyConfiguration<Schedule>(new ScheduleConfiguration());


        }
        
    }
}
