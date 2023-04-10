using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eShopSolution.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedIdentityUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Order",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 10, 10, 57, 52, 546, DateTimeKind.Local).AddTicks(421),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 10, 10, 50, 19, 121, DateTimeKind.Local).AddTicks(7057));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "e5003e4c-1d4c-4078-a68e-c7c8bca29302");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f51b6d2f-63f4-4b41-8cc4-4bce60c63ac1", "AQAAAAEAACcQAAAAEM2Vk0HGCCCJh9kyukXf6s03wOQYpE8w0N3KERMMK/fmQBfSvmoQbVTgOf1QdgMXIg==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 4, 10, 10, 57, 52, 549, DateTimeKind.Local).AddTicks(7680));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Order",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 10, 10, 50, 19, 121, DateTimeKind.Local).AddTicks(7057),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 10, 10, 57, 52, 546, DateTimeKind.Local).AddTicks(421));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "3874be86-fca4-4c25-bda7-715436bd547f");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "49942997-0149-457c-a38e-4fe21ddac0bb", "AQAAAAEAACcQAAAAEPd14FyLYCvdK7Z6+nFqYeN9cYEkgHEC1q+qZ77RCYaxi/1tnCAqpegLKeElDf3oJw==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 4, 10, 10, 50, 19, 123, DateTimeKind.Local).AddTicks(3548));
        }
    }
}
