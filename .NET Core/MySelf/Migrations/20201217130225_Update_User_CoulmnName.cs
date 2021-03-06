﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace MySelf.Migrations
{
    public partial class Update_User_CoulmnName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Register",
                newName: "UserName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Register",
                newName: "Name");
        }
    }
}
