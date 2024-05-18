using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FunWithXml_API.Migrations
{
    /// <inheritdoc />
    public partial class RefresTokenOnModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RefreshToken",
                table: "LoginModel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "RefreshTokenExpiryTime",
                table: "LoginModel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RefreshToken",
                table: "LoginModel");

            migrationBuilder.DropColumn(
                name: "RefreshTokenExpiryTime",
                table: "LoginModel");
        }
    }
}
