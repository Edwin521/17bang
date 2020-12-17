using Microsoft.EntityFrameworkCore.Migrations;

namespace MySelf.Migrations
{
    public partial class Add_User_FailedTry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FailedTry",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FailedTry",
                table: "Users");
        }
    }
}
