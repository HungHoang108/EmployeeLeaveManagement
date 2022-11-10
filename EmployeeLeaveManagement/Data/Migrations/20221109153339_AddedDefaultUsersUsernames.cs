using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeLeaveManagement.Data.Migrations
{
    public partial class AddedDefaultUsersUsernames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TaxId",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-lad431ccbbf",
                column: "ConcurrencyStamp",
                value: "aa4ff949-565b-4d6e-9b21-3575f072d668");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac44a6e-f7nb-5448-bbaf-lad631ccbbf",
                column: "ConcurrencyStamp",
                value: "f22906c9-8529-48de-ae6e-31beadf31dda");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cac43a6n-f7bb-4448-baaf-lad431ccbbf",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "653c86c4-ed10-4a2f-8110-f114152a24ec", true, "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEB3E5Psa9mG5FJK7vV0fGEh5I7CwcYW6MNdncbzyQM4UUEBEz/6UiHmopU6G9Pbu9g==", "7f8b3bfd-339d-426b-a542-48f68ebc18c3", "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cac53a6n-f7cb-4448-baaf-lad431ccbbf",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "4ed731e5-73c0-492f-826e-e48f3a62ce51", true, "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAENen65tquqPzy5GPzk2gK72I0c6aoQbkCCk1fbBYE/O3WQmqAN/kShxUBta+0B6WPQ==", "e2007eaa-e7ca-4ff3-b47b-643767c432ac", "user@localhost.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TaxId",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-lad431ccbbf",
                column: "ConcurrencyStamp",
                value: "a0fba762-0f25-4b19-9b08-fc32a8e1d879");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac44a6e-f7nb-5448-bbaf-lad631ccbbf",
                column: "ConcurrencyStamp",
                value: "992a7d7a-074f-403c-b640-63f6cd0b5339");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cac43a6n-f7bb-4448-baaf-lad431ccbbf",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "85b008d2-a9db-47fb-85d1-e85ccfd6bf42", false, null, "AQAAAAEAACcQAAAAEGwRhJRQjYjTn58bVCv24aQ1+wVnYel6eKUfa92kvDa5GLHQfeAi8PDz5CpZgsbA9g==", "2a949ad0-d144-402d-9707-bd69d04655d2", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cac53a6n-f7cb-4448-baaf-lad431ccbbf",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "1f9747ea-c4bb-4a9e-8868-641ff2521026", false, null, "AQAAAAEAACcQAAAAEMn4+UU2er4THQO31ZAIoo7zMZEoJAVuBG8atjjYAIsWkwSjRal5uS3FeWy1wqvaxQ==", "03d1c4b5-6c88-4f31-9220-fad3dd887362", null });
        }
    }
}
