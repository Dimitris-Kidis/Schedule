using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApplicationCore.Migrations
{
    public partial class NewRepo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "Users",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TwoFactorEnabled",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(8216), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(8223), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(8226), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(8230), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(8234), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(8239), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(8243), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(8246), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(8250), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(8255), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(8259), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(8263), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(8266), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(8270), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(2549), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(2557), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(2561), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(2564), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(2568), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(2573), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(2577), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(2581), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(2585), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(2589), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(2593), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(2597), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(2601), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(2605), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(8036), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(8044), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(8048), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(8053), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(8057), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(8062), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(8066), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(8070), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(8074), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(8110), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(8114), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(8119), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(8123), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(8127), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "StatisticsAVG",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(2723), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "StatisticsAVG",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(2731), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "StatisticsAVG",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(2735), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "StatisticsAVG",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(2739), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "StatisticsAVG",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(2744), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "StatisticsAVG",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(2749), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "StatisticsAVG",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(2753), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "StatisticsAVG",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(2757), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "StatisticsAVG",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(2761), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "StatisticsAVG",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(2765), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "StatisticsAVG",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(2769), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "StatisticsAVG",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(2807), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "StatisticsAVG",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(2813), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "StatisticsAVG",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(2817), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(2407), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(2414), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(2418), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(2422), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(2426), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(2431), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(2435), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(2439), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(2443), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(2448), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(2452), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(2456), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(2459), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(2463), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "SignUpAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(2180), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Local).AddTicks(2137) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "SignUpAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(2211), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Local).AddTicks(2209) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "SignUpAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(2217), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Local).AddTicks(2215) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "SignUpAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(2222), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Local).AddTicks(2220) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "SignUpAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(2228), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Local).AddTicks(2226) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "SignUpAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(2237), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Local).AddTicks(2235) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "SignUpAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(2242), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Local).AddTicks(2240) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "SignUpAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(2247), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Local).AddTicks(2246) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "SignUpAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(2253), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Local).AddTicks(2251) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "SignUpAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(2297), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Local).AddTicks(2295) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "SignUpAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(2303), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Local).AddTicks(2302) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "SignUpAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(2308), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Local).AddTicks(2307) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "SignUpAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(2314), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Local).AddTicks(2312) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "SignUpAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(2319), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Local).AddTicks(2318) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedAt" },
                values: new object[] { "7a8ab5b6-7d09-4120-a9b3-01b74e8e8598", new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(7753), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedAt" },
                values: new object[] { "f681d88e-4d3f-481e-a680-1437e275aab6", new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(7788), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedAt" },
                values: new object[] { "acbcf66d-3f07-4656-8236-4dd2de583e64", new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(7795), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedAt" },
                values: new object[] { "258bddb6-0013-4b8d-913c-92eed47d9e23", new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(7802), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "CreatedAt" },
                values: new object[] { "c2e90764-6e9d-4aa9-a818-698245eed994", new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(7810), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "CreatedAt" },
                values: new object[] { "df94df36-045b-4e4a-b212-93c23167bba2", new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(7819), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "CreatedAt" },
                values: new object[] { "b416e3a7-6a4b-4c91-a053-9261613ea9e2", new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(7826), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "CreatedAt" },
                values: new object[] { "b102ee82-9d19-4021-8c52-1155cd2a7be4", new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(7832), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "CreatedAt" },
                values: new object[] { "e8b8c2c9-27ed-41ec-9adf-a7d2d4223040", new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(7842), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "CreatedAt" },
                values: new object[] { "f7997978-d3f7-4c35-a8e6-2642aae5a58e", new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(7850), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "CreatedAt" },
                values: new object[] { "3a228499-5f61-4bbf-8c59-6b7fd771e2cc", new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(7857), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ConcurrencyStamp", "CreatedAt" },
                values: new object[] { "2c2526d1-82c3-4adc-a955-158086753022", new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(7863), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ConcurrencyStamp", "CreatedAt" },
                values: new object[] { "6e6d931d-a3d3-4d50-b53c-184bccfe4d90", new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(7870), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ConcurrencyStamp", "CreatedAt" },
                values: new object[] { "285e1c2e-f1fe-421d-a898-3de3fab2d454", new DateTimeOffset(new DateTime(2022, 10, 29, 20, 6, 42, 626, DateTimeKind.Unspecified).AddTicks(7876), new TimeSpan(0, 3, 0, 0, 0)) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "TwoFactorEnabled",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(3075), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(3080), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(3083), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(3085), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(3088), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(3091), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(3093), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(3096), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(3098), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(3101), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(3104), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(3106), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(3109), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(3111), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Unspecified).AddTicks(9965), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Unspecified).AddTicks(9970), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Unspecified).AddTicks(9973), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Unspecified).AddTicks(9975), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Unspecified).AddTicks(9978), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Unspecified).AddTicks(9981), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Unspecified).AddTicks(9984), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Unspecified).AddTicks(9986), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Unspecified).AddTicks(9989), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Unspecified).AddTicks(9992), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Unspecified).AddTicks(9994), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Unspecified).AddTicks(9997), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Unspecified).AddTicks(9999), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(2), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(2976), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(2982), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(2985), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(2988), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(2990), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(2994), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(2997), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(2999), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(3002), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(3005), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(3008), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(3011), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(3013), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(3016), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "StatisticsAVG",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(67), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "StatisticsAVG",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(72), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "StatisticsAVG",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(75), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "StatisticsAVG",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(77), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "StatisticsAVG",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(80), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "StatisticsAVG",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(83), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "StatisticsAVG",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(85), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "StatisticsAVG",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(88), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "StatisticsAVG",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(90), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "StatisticsAVG",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(94), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "StatisticsAVG",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(96), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "StatisticsAVG",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(99), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "StatisticsAVG",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(101), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "StatisticsAVG",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(104), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Unspecified).AddTicks(9870), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Unspecified).AddTicks(9875), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Unspecified).AddTicks(9878), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Unspecified).AddTicks(9880), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Unspecified).AddTicks(9883), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Unspecified).AddTicks(9886), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Unspecified).AddTicks(9889), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Unspecified).AddTicks(9891), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Unspecified).AddTicks(9894), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Unspecified).AddTicks(9897), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Unspecified).AddTicks(9900), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Unspecified).AddTicks(9902), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Unspecified).AddTicks(9905), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Texts",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Unspecified).AddTicks(9907), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "SignUpAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Unspecified).AddTicks(9675), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Local).AddTicks(9639) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "SignUpAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Unspecified).AddTicks(9698), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Local).AddTicks(9696) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "SignUpAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Unspecified).AddTicks(9702), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Local).AddTicks(9701) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "SignUpAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Unspecified).AddTicks(9706), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Local).AddTicks(9705) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "SignUpAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Unspecified).AddTicks(9709), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Local).AddTicks(9708) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "SignUpAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Unspecified).AddTicks(9715), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Local).AddTicks(9714) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "SignUpAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Unspecified).AddTicks(9719), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Local).AddTicks(9718) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "SignUpAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Unspecified).AddTicks(9722), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Local).AddTicks(9721) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "SignUpAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Unspecified).AddTicks(9726), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Local).AddTicks(9725) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "SignUpAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Unspecified).AddTicks(9730), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Local).AddTicks(9729) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "SignUpAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Unspecified).AddTicks(9733), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Local).AddTicks(9732) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "SignUpAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Unspecified).AddTicks(9736), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Local).AddTicks(9735) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "SignUpAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Unspecified).AddTicks(9761), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Local).AddTicks(9760) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "SignUpAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Unspecified).AddTicks(9765), new TimeSpan(0, 3, 0, 0, 0)), new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Local).AddTicks(9764) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(2811), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(2835), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(2839), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(2842), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(2844), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(2848), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(2851), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(2854), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(2857), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(2860), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(2863), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(2866), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(2868), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(2871), new TimeSpan(0, 3, 0, 0, 0)));
        }
    }
}
