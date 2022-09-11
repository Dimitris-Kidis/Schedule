﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Schedule_Project.ApplicationCore.Domain;

#nullable disable

namespace Schedule_Project.Migrations
{
    [DbContext(typeof(ScheduleDbContext))]
    partial class ScheduleDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Schedule_Project.ApplicationCore.Domain.Entities.Client", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Interests")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Schedule_Project.ApplicationCore.Domain.Entities.Review", b =>
                {
                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<int>("SpecialistId")
                        .HasColumnType("int");

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReviewText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Stars")
                        .HasColumnType("int");

                    b.Property<string>("Time")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClientId", "SpecialistId");

                    b.HasIndex("SpecialistId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("Schedule_Project.ApplicationCore.Domain.Entities.Schedule", b =>
                {
                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<int>("SpecialistId")
                        .HasColumnType("int");

                    b.Property<string>("MeetingDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MeetingTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ScheduleId")
                        .HasColumnType("int");

                    b.HasKey("ClientId", "SpecialistId");

                    b.HasIndex("SpecialistId");

                    b.ToTable("Schedules");
                });

            modelBuilder.Entity("Schedule_Project.ApplicationCore.Domain.Entities.Service", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Duration")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ServiceName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SpecialistId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SpecialistId");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("Schedule_Project.ApplicationCore.Domain.Entities.Specialist", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Domain")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkExperience")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Specialists");
                });

            modelBuilder.Entity("Schedule_Project.ApplicationCore.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsClient")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfilePic")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Schedule_Project.ApplicationCore.Domain.Entities.UserInfo", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfMeetings")
                        .HasColumnType("int");

                    b.Property<string>("SearchHistory")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("SignUpAt")
                        .HasColumnType("Date");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserInfos");
                });

            modelBuilder.Entity("Schedule_Project.ApplicationCore.Domain.Entities.Client", b =>
                {
                    b.HasOne("Schedule_Project.ApplicationCore.Domain.Entities.User", "User")
                        .WithOne("Client")
                        .HasForeignKey("Schedule_Project.ApplicationCore.Domain.Entities.Client", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Schedule_Project.ApplicationCore.Domain.Entities.Review", b =>
                {
                    b.HasOne("Schedule_Project.ApplicationCore.Domain.Entities.Client", "Client")
                        .WithMany("Reviews")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Schedule_Project.ApplicationCore.Domain.Entities.Specialist", "Specialist")
                        .WithMany("Reviews")
                        .HasForeignKey("SpecialistId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Specialist");
                });

            modelBuilder.Entity("Schedule_Project.ApplicationCore.Domain.Entities.Schedule", b =>
                {
                    b.HasOne("Schedule_Project.ApplicationCore.Domain.Entities.Client", "Client")
                        .WithMany("Schedules")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Schedule_Project.ApplicationCore.Domain.Entities.Specialist", "Specialist")
                        .WithMany("Schedules")
                        .HasForeignKey("SpecialistId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Specialist");
                });

            modelBuilder.Entity("Schedule_Project.ApplicationCore.Domain.Entities.Service", b =>
                {
                    b.HasOne("Schedule_Project.ApplicationCore.Domain.Entities.Specialist", "Specialist")
                        .WithMany()
                        .HasForeignKey("SpecialistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Specialist");
                });

            modelBuilder.Entity("Schedule_Project.ApplicationCore.Domain.Entities.Specialist", b =>
                {
                    b.HasOne("Schedule_Project.ApplicationCore.Domain.Entities.User", "User")
                        .WithOne("Specialist")
                        .HasForeignKey("Schedule_Project.ApplicationCore.Domain.Entities.Specialist", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Schedule_Project.ApplicationCore.Domain.Entities.UserInfo", b =>
                {
                    b.HasOne("Schedule_Project.ApplicationCore.Domain.Entities.User", null)
                        .WithMany("userInfos")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Schedule_Project.ApplicationCore.Domain.Entities.Client", b =>
                {
                    b.Navigation("Reviews");

                    b.Navigation("Schedules");
                });

            modelBuilder.Entity("Schedule_Project.ApplicationCore.Domain.Entities.Specialist", b =>
                {
                    b.Navigation("Reviews");

                    b.Navigation("Schedules");
                });

            modelBuilder.Entity("Schedule_Project.ApplicationCore.Domain.Entities.User", b =>
                {
                    b.Navigation("Client")
                        .IsRequired();

                    b.Navigation("Specialist")
                        .IsRequired();

                    b.Navigation("userInfos");
                });
#pragma warning restore 612, 618
        }
    }
}
