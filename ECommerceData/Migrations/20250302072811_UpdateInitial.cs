using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ECommerce.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateInitial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "CreateDate", "Email", "IsActive", "IsAdmin", "Name", "Password", "Phone", "SurName", "UserGuid", "UserName" },
                values: new object[] { 1, new DateTime(2025, 3, 2, 10, 21, 47, 604, DateTimeKind.Local).AddTicks(5539), "admin@ecommerce.io", true, true, "Test", "123456", null, "Test", new Guid("08e06dfc-358a-4bbe-af57-5e678c1c701d"), "Admin" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CreateDate", "Descripton", "Image", "IsActive", "IsTopMenu", "Name", "OrderNo", "ParentId" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 3, 2, 10, 21, 47, 605, DateTimeKind.Local).AddTicks(7479), null, null, true, true, "Electronics", 1, 0 },
                    { 2, new DateTime(2025, 3, 2, 10, 21, 47, 605, DateTimeKind.Local).AddTicks(8589), null, null, true, true, "Clothes", 2, 0 }
                });
        }
    }
}
