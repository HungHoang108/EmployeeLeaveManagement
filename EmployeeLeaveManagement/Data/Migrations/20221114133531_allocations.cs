using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeLeaveManagement.Data.Migrations
{
    public partial class allocations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-lad431ccbbf",
                column: "ConcurrencyStamp",
                value: "3851da46-73b9-492d-b25f-b41f8be76a70");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac44a6e-f7nb-5448-bbaf-lad631ccbbf",
                column: "ConcurrencyStamp",
                value: "63e760cb-21ef-46e5-a025-c36ad25f00db");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cac43a6n-f7bb-4448-baaf-lad431ccbbf",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d1522edf-a23d-49cc-87f0-141d701c97f3", "AQAAAAEAACcQAAAAECD/L+6I/1XvW2bLA79G1DTAk5yIA2TLUzmh+WRReUzWd5V7Oj6XHYPN0QlkD960bA==", "e6358e8f-5dfc-4520-be8a-147fc5e474b8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cac53a6n-f7cb-4448-baaf-lad431ccbbf",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5bd24285-1336-4ad3-9c4c-6164b669719b", "AQAAAAEAACcQAAAAEJ4DeP4u0LaB5ZkHrjalueNTYkCfLgsLks4O8qPSnqrWW4omW7CshwSfbW73qkO42Q==", "6834d057-9ee8-432c-8124-c242f78e97f1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
