using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class SeedIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2021, 2, 17, 22, 27, 3, 122, DateTimeKind.Local).AddTicks(4685),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 2, 17, 21, 57, 6, 63, DateTimeKind.Local).AddTicks(6190));

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("c843c1b3-1d86-4206-9dab-ce1ae95a2c52"), "a19f7215-c5e4-4afa-accf-3097515d3d20", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("9c824d6a-1d71-4eb3-b56e-c0bd62f28a5e"), new Guid("c843c1b3-1d86-4206-9dab-ce1ae95a2c52") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DOB", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("9c824d6a-1d71-4eb3-b56e-c0bd62f28a5e"), 0, "3ec56e09-f701-4eb8-9d26-c2cee286af98", new DateTime(2018, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "abc@gmail.com", true, "Toan", "Bach", false, null, "123@gmail.com", "admin", "AQAAAAEAACcQAAAAEE7h15gC1j1Q7WCdYTcAaM8PrOnoEn6Hbn962QC6jxYKDtoYEGwyeMWSsMBpzsk9gQ==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 2, 17, 22, 27, 3, 153, DateTimeKind.Local).AddTicks(3449));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("c843c1b3-1d86-4206-9dab-ce1ae95a2c52"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("9c824d6a-1d71-4eb3-b56e-c0bd62f28a5e"), new Guid("c843c1b3-1d86-4206-9dab-ce1ae95a2c52") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("9c824d6a-1d71-4eb3-b56e-c0bd62f28a5e"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 2, 17, 21, 57, 6, 63, DateTimeKind.Local).AddTicks(6190),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 2, 17, 22, 27, 3, 122, DateTimeKind.Local).AddTicks(4685));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 2, 17, 21, 57, 6, 89, DateTimeKind.Local).AddTicks(5944));
        }
    }
}
