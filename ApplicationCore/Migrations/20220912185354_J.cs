using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Schedule_Project.Migrations
{
    public partial class J : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Clients_ClientId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Specialists_SpecialistId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_Clients_ClientId",
                table: "Schedules");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_Specialists_SpecialistId",
                table: "Schedules");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Clients_ClientId",
                table: "Reviews",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Specialists_SpecialistId",
                table: "Reviews",
                column: "SpecialistId",
                principalTable: "Specialists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_Clients_ClientId",
                table: "Schedules",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_Specialists_SpecialistId",
                table: "Schedules",
                column: "SpecialistId",
                principalTable: "Specialists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Clients_ClientId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Specialists_SpecialistId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_Clients_ClientId",
                table: "Schedules");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_Specialists_SpecialistId",
                table: "Schedules");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Clients_ClientId",
                table: "Reviews",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Specialists_SpecialistId",
                table: "Reviews",
                column: "SpecialistId",
                principalTable: "Specialists",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_Clients_ClientId",
                table: "Schedules",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_Specialists_SpecialistId",
                table: "Schedules",
                column: "SpecialistId",
                principalTable: "Specialists",
                principalColumn: "Id");
        }
    }
}
