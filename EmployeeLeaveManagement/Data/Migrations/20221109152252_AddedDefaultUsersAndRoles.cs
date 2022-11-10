using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeLeaveManagement.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TaxId",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "cac43a6e-f7bb-4448-baaf-lad431ccbbf", "a0fba762-0f25-4b19-9b08-fc32a8e1d879", "Administrator", "ADMINISTRATOR" },
                    { "cac44a6e-f7nb-5448-bbaf-lad631ccbbf", "992a7d7a-074f-403c-b640-63f6cd0b5339", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "cac43a6n-f7bb-4448-baaf-lad431ccbbf", 0, "85b008d2-a9db-47fb-85d1-e85ccfd6bf42", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEGwRhJRQjYjTn58bVCv24aQ1+wVnYel6eKUfa92kvDa5GLHQfeAi8PDz5CpZgsbA9g==", null, false, "2a949ad0-d144-402d-9707-bd69d04655d2", false, null },
                    { "cac53a6n-f7cb-4448-baaf-lad431ccbbf", 0, "1f9747ea-c4bb-4a9e-8868-641ff2521026", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@localhost.com", false, "System", "User", false, null, "USER@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEMn4+UU2er4THQO31ZAIoo7zMZEoJAVuBG8atjjYAIsWkwSjRal5uS3FeWy1wqvaxQ==", null, false, "03d1c4b5-6c88-4f31-9220-fad3dd887362", false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cac43a6e-f7bb-4448-baaf-lad431ccbbf", "cac43a6n-f7bb-4448-baaf-lad431ccbbf" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cac44a6e-f7nb-5448-bbaf-lad631ccbbf", "cac53a6n-f7cb-4448-baaf-lad431ccbbf" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cac43a6e-f7bb-4448-baaf-lad431ccbbf", "cac43a6n-f7bb-4448-baaf-lad431ccbbf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cac44a6e-f7nb-5448-bbaf-lad631ccbbf", "cac53a6n-f7cb-4448-baaf-lad431ccbbf" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-lad431ccbbf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac44a6e-f7nb-5448-bbaf-lad631ccbbf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cac43a6n-f7bb-4448-baaf-lad431ccbbf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cac53a6n-f7cb-4448-baaf-lad431ccbbf");

            migrationBuilder.AddColumn<string>(
                name: "TaxId",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
