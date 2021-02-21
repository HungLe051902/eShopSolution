using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class ChangeFileLengthType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "FileSize",
                table: "ProductImages",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("c843c1b3-1d86-4206-9dab-ce1ae95a2c52"),
                column: "ConcurrencyStamp",
                value: "3b6a3dae-f978-4561-9a18-a0fca397754f");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("9c824d6a-1d71-4eb3-b56e-c0bd62f28a5e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "928a160d-b3da-4f24-a171-c1c70c9a2562", "AQAAAAEAACcQAAAAEC9FHuTE3eXcam75ZA7CbBEvOVi/LF1ZWQRBrsaMo7Rg1dPbLma07JGCn8w44+csWA==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 2, 21, 22, 12, 52, 936, DateTimeKind.Local).AddTicks(8184));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "FileSize",
                table: "ProductImages",
                type: "int",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("c843c1b3-1d86-4206-9dab-ce1ae95a2c52"),
                column: "ConcurrencyStamp",
                value: "d037bfad-d74d-4516-81c8-f1ab07ab6089");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("9c824d6a-1d71-4eb3-b56e-c0bd62f28a5e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b2bc4147-abc7-498a-af3d-6cc81efd02ae", "AQAAAAEAACcQAAAAEM6spk02OdaTLeFBXk+sN7DQ/ObBXwyaYiDzXuEhsD2YuXQHnj0aoXOG5k20nDhldQ==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 2, 20, 15, 14, 52, 658, DateTimeKind.Local).AddTicks(1284));
        }
    }
}
