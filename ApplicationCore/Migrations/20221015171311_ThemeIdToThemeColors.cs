using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApplicationCore.Migrations
{
    public partial class ThemeIdToThemeColors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ThemeId",
                table: "UserInfos");

            migrationBuilder.RenameColumn(
                name: "UserEmail",
                table: "Reviews",
                newName: "UserId");

            migrationBuilder.AddColumn<string>(
                name: "ThemeColors",
                table: "UserInfos",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ThemeColors",
                table: "UserInfos");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Reviews",
                newName: "UserEmail");

            migrationBuilder.AddColumn<int>(
                name: "ThemeId",
                table: "UserInfos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
