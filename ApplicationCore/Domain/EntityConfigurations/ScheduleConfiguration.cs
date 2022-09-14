using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Schedule_Project.ApplicationCore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Domain.EntityConfigurations
{
    internal class ScheduleConfiguration : IEntityTypeConfiguration<Schedule>
    {
        public void Configure(EntityTypeBuilder<Schedule> builder)
        {


            builder.HasKey(keys => new { keys.ClientId, keys.SpecialistId });
            builder
                .HasOne(schedule => schedule.Client)
                .WithMany(client => client.Schedules)
                .HasForeignKey(schedule => schedule.ClientId)
                .OnDelete(DeleteBehavior.NoAction);
            builder
                .HasOne(schedule => schedule.Specialist)
                .WithMany(specialist => specialist.Schedules)
                .HasForeignKey(schedule => schedule.SpecialistId)
                .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
