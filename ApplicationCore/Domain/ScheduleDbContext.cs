
using Microsoft.EntityFrameworkCore;
using Schedule_Project.ApplicationCore.Domain.Entities;

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
            builder.UseSqlServer("Data Source=.;Database=EFCore;Integrated Security=True");

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>(entity =>
            {
                entity.HasOne(user => user.Client)
                .WithOne(client => client.User)
                .HasForeignKey<Client>(client => client.Id);
            });

            builder.Entity<User>(entity =>
            {
                entity.HasOne(user => user.Specialist)
                .WithOne(specialist => specialist.User)
                .HasForeignKey<Specialist>(specialist => specialist.Id);
            });


            builder.Entity<Review>()
                .HasKey(review => new { review.ClientId, review.SpecialistId });
            builder.Entity<Review>()
                .HasOne(review => review.Client)
                .WithMany(client => client.Reviews)
                .HasForeignKey(review => review.ClientId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.Entity<Review>()
                .HasOne(review => review.Specialist)
                .WithMany(specialist => specialist.Reviews)
                .HasForeignKey(review => review.SpecialistId)
                .OnDelete(DeleteBehavior.Cascade);






            builder.Entity<Schedule>()
                .HasKey(keys => new { keys.ClientId, keys.SpecialistId });
            builder.Entity<Schedule>()
                .HasOne(schedule => schedule.Client)
                .WithMany(client => client.Schedules)
                .HasForeignKey(schedule => schedule.ClientId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.Entity<Schedule>()
                .HasOne(schedule => schedule.Specialist)
                .WithMany(specialist => specialist.Schedules)
                .HasForeignKey(schedule => schedule.SpecialistId)
                .OnDelete(DeleteBehavior.Cascade);


            builder.Entity<User>()
                .Property(u => u.RowVersion)
                .IsRowVersion();

      





        }
        
    }
}
