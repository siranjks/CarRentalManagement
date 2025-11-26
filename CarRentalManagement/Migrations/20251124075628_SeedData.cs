using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 24, 15, 56, 27, 364, DateTimeKind.Local).AddTicks(6606), new DateTime(2025, 11, 24, 15, 56, 27, 364, DateTimeKind.Local).AddTicks(6607), "Black", "System" },
                    { 2, "System", new DateTime(2025, 11, 24, 15, 56, 27, 364, DateTimeKind.Local).AddTicks(6609), new DateTime(2025, 11, 24, 15, 56, 27, 364, DateTimeKind.Local).AddTicks(6609), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 24, 15, 56, 27, 364, DateTimeKind.Local).AddTicks(6364), new DateTime(2025, 11, 24, 15, 56, 27, 364, DateTimeKind.Local).AddTicks(6378), "BMW", "System" },
                    { 2, "System", new DateTime(2025, 11, 24, 15, 56, 27, 364, DateTimeKind.Local).AddTicks(6381), new DateTime(2025, 11, 24, 15, 56, 27, 364, DateTimeKind.Local).AddTicks(6382), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 24, 15, 56, 27, 364, DateTimeKind.Local).AddTicks(6691), new DateTime(2025, 11, 24, 15, 56, 27, 364, DateTimeKind.Local).AddTicks(6691), "i4", "System" },
                    { 2, "System", new DateTime(2025, 11, 24, 15, 56, 27, 364, DateTimeKind.Local).AddTicks(6693), new DateTime(2025, 11, 24, 15, 56, 27, 364, DateTimeKind.Local).AddTicks(6694), "X5", "System" },
                    { 3, "System", new DateTime(2025, 11, 24, 15, 56, 27, 364, DateTimeKind.Local).AddTicks(6695), new DateTime(2025, 11, 24, 15, 56, 27, 364, DateTimeKind.Local).AddTicks(6696), "Prius", "System" },
                    { 4, "System", new DateTime(2025, 11, 24, 15, 56, 27, 364, DateTimeKind.Local).AddTicks(6697), new DateTime(2025, 11, 24, 15, 56, 27, 364, DateTimeKind.Local).AddTicks(6698), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
