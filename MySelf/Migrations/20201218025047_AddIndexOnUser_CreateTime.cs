using Microsoft.EntityFrameworkCore.Migrations;

namespace MySelf.Migrations
{
    public partial class AddIndexOnUser_CreateTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Register_CreateTime",
                table: "Register",
                column: "CreateTime",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Register_CreateTime",
                table: "Register");
        }
    }
}
