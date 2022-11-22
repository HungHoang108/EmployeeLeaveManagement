using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeLeaveManagement.Data.Migrations
{
    public partial class AddingPeriodToAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-lad431ccbbf",
                column: "ConcurrencyStamp",
                value: "273a176c-cbad-43bc-9e46-466d27b24637");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac44a6e-f7nb-5448-bbaf-lad631ccbbf",
                column: "ConcurrencyStamp",
                value: "c69d8ee8-5d5f-4c62-9c3c-d5147976b82d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cac43a6n-f7bb-4448-baaf-lad431ccbbf",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c0ff5bcc-1821-4124-bf97-35da68f82116", "AQAAAAEAACcQAAAAECAT8ckGGVpTDyh5muWmFQC8PLEUaGwXmD+Iy93P0Lt+nEmKQ7BgLIKeuBFiGZDdwg==", "74b9a52b-575f-4d5d-9cbd-d8264bc0fba7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cac53a6n-f7cb-4448-baaf-lad431ccbbf",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e3d7020b-2b30-48ef-8746-c37054a3ce08", "AQAAAAEAACcQAAAAED42BSGeIp0JBM0dvTjXcnsEFFnkMHlL6Fd1Gfxd4jXZ9Bryd6aMy9J4XckChQ1o/g==", "7572ee92-a934-4dea-ab95-f756a7f962e1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "653c86c4-ed10-4a2f-8110-f114152a24ec", "AQAAAAEAACcQAAAAEB3E5Psa9mG5FJK7vV0fGEh5I7CwcYW6MNdncbzyQM4UUEBEz/6UiHmopU6G9Pbu9g==", "7f8b3bfd-339d-426b-a542-48f68ebc18c3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cac53a6n-f7cb-4448-baaf-lad431ccbbf",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4ed731e5-73c0-492f-826e-e48f3a62ce51", "AQAAAAEAACcQAAAAENen65tquqPzy5GPzk2gK72I0c6aoQbkCCk1fbBYE/O3WQmqAN/kShxUBta+0B6WPQ==", "e2007eaa-e7ca-4ff3-b47b-643767c432ac" });
        }
    }
}
