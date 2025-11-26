using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "6194351e-375f-4e33-b755-62c105614911", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEIDuk/3ZP06UmzvTzV51rcqvaM5VDUac5oDZmymr9hLRTZkCtiK3P92OwT/0lHhlTw==", null, false, "a0139233-5ef9-4635-b5ed-64b9ae9b90e9", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 23, 23, 24, 67, DateTimeKind.Local).AddTicks(5185), new DateTime(2025, 11, 26, 23, 23, 24, 67, DateTimeKind.Local).AddTicks(5190) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 23, 23, 24, 67, DateTimeKind.Local).AddTicks(5194), new DateTime(2025, 11, 26, 23, 23, 24, 67, DateTimeKind.Local).AddTicks(5194) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 23, 23, 24, 67, DateTimeKind.Local).AddTicks(4457), new DateTime(2025, 11, 26, 23, 23, 24, 67, DateTimeKind.Local).AddTicks(4498) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 23, 23, 24, 67, DateTimeKind.Local).AddTicks(4505), new DateTime(2025, 11, 26, 23, 23, 24, 67, DateTimeKind.Local).AddTicks(4506) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 23, 23, 24, 67, DateTimeKind.Local).AddTicks(5473), new DateTime(2025, 11, 26, 23, 23, 24, 67, DateTimeKind.Local).AddTicks(5474) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 23, 23, 24, 67, DateTimeKind.Local).AddTicks(5476), new DateTime(2025, 11, 26, 23, 23, 24, 67, DateTimeKind.Local).AddTicks(5477) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 23, 23, 24, 67, DateTimeKind.Local).AddTicks(5479), new DateTime(2025, 11, 26, 23, 23, 24, 67, DateTimeKind.Local).AddTicks(5480) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 23, 23, 24, 67, DateTimeKind.Local).AddTicks(5482), new DateTime(2025, 11, 26, 23, 23, 24, 67, DateTimeKind.Local).AddTicks(5484) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 23, 7, 13, 898, DateTimeKind.Local).AddTicks(2531), new DateTime(2025, 11, 26, 23, 7, 13, 898, DateTimeKind.Local).AddTicks(2532) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 23, 7, 13, 898, DateTimeKind.Local).AddTicks(2534), new DateTime(2025, 11, 26, 23, 7, 13, 898, DateTimeKind.Local).AddTicks(2535) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 23, 7, 13, 898, DateTimeKind.Local).AddTicks(1811), new DateTime(2025, 11, 26, 23, 7, 13, 898, DateTimeKind.Local).AddTicks(1848) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 23, 7, 13, 898, DateTimeKind.Local).AddTicks(1855), new DateTime(2025, 11, 26, 23, 7, 13, 898, DateTimeKind.Local).AddTicks(1856) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 23, 7, 13, 898, DateTimeKind.Local).AddTicks(2739), new DateTime(2025, 11, 26, 23, 7, 13, 898, DateTimeKind.Local).AddTicks(2740) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 23, 7, 13, 898, DateTimeKind.Local).AddTicks(2743), new DateTime(2025, 11, 26, 23, 7, 13, 898, DateTimeKind.Local).AddTicks(2743) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 23, 7, 13, 898, DateTimeKind.Local).AddTicks(2745), new DateTime(2025, 11, 26, 23, 7, 13, 898, DateTimeKind.Local).AddTicks(2746) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 23, 7, 13, 898, DateTimeKind.Local).AddTicks(2748), new DateTime(2025, 11, 26, 23, 7, 13, 898, DateTimeKind.Local).AddTicks(2749) });
        }
    }
}
