using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApplicationCore.Migrations
{
    public partial class ThemeType2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ThemeType_UserInfos_UserInfoId",
                table: "ThemeType");

            migrationBuilder.AlterColumn<int>(
                name: "UserInfoId",
                table: "ThemeType",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_ThemeType_UserInfos_UserInfoId",
                table: "ThemeType",
                column: "UserInfoId",
                principalTable: "UserInfos",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ThemeType_UserInfos_UserInfoId",
                table: "ThemeType");

            migrationBuilder.AlterColumn<int>(
                name: "UserInfoId",
                table: "ThemeType",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ThemeType_UserInfos_UserInfoId",
                table: "ThemeType",
                column: "UserInfoId",
                principalTable: "UserInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
