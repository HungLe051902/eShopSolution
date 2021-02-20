using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class AddProductImageTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 2, 17, 22, 27, 3, 122, DateTimeKind.Local).AddTicks(4685));

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    ImagePath = table.Column<string>(maxLength: 200, nullable: false),
                    Caption = table.Column<string>(maxLength: 200, nullable: true),
                    IsDefault = table.Column<bool>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    SortOrder = table.Column<int>(nullable: false),
                    FileSize = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 2, 17, 22, 27, 3, 122, DateTimeKind.Local).AddTicks(4685),
                oldClrType: typeof(DateTime));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("c843c1b3-1d86-4206-9dab-ce1ae95a2c52"),
                column: "ConcurrencyStamp",
                value: "a19f7215-c5e4-4afa-accf-3097515d3d20");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("9c824d6a-1d71-4eb3-b56e-c0bd62f28a5e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3ec56e09-f701-4eb8-9d26-c2cee286af98", "AQAAAAEAACcQAAAAEE7h15gC1j1Q7WCdYTcAaM8PrOnoEn6Hbn962QC6jxYKDtoYEGwyeMWSsMBpzsk9gQ==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 2, 17, 22, 27, 3, 153, DateTimeKind.Local).AddTicks(3449));
        }
    }
}
