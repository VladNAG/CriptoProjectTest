
using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CriptoProjectTest.Migrations
{
    /// <inheritdoc />
    public partial class Second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExchangeRate",
                table: "Assets");

            migrationBuilder.AddColumn<decimal>(
                name: "PriceUsd",
                table: "Assets",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AssetId", "DateLastUpdate", "Name", "PriceUsd" },
                values: new object[] { "USD", new DateTime(2024, 5, 23, 19, 29, 12, 357, DateTimeKind.Local).AddTicks(3631), "US Dollar", null });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AssetId", "DateLastUpdate", "Name", "PriceUsd" },
                values: new object[] { "BTC", new DateTime(2024, 5, 23, 19, 29, 12, 357, DateTimeKind.Local).AddTicks(3579), "Bitcoin", null });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "Id", "AssetId", "DateLastUpdate", "Name", "PriceUsd" },
                values: new object[,]
                {
                    { 3, "Ethereum", new DateTime(2024, 5, 23, 19, 29, 12, 357, DateTimeKind.Local).AddTicks(3625), "Ethereum", null },
                    { 4, "TNT", new DateTime(2024, 5, 23, 19, 29, 12, 357, DateTimeKind.Local).AddTicks(3628), "Tierion", null },
                    { 5, "PEPE", new DateTime(2024, 5, 23, 19, 29, 12, 357, DateTimeKind.Local).AddTicks(3510), "PepeCoin", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "PriceUsd",
                table: "Assets");

            migrationBuilder.AddColumn<decimal>(
                name: "ExchangeRate",
                table: "Assets",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AssetId", "DateLastUpdate", "ExchangeRate", "Name" },
                values: new object[] { "BTC", new DateTime(2024, 5, 22, 18, 6, 34, 539, DateTimeKind.Local).AddTicks(7445), 10m, "Test" });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AssetId", "DateLastUpdate", "ExchangeRate", "Name" },
                values: new object[] { "USD", new DateTime(2024, 5, 22, 18, 6, 34, 539, DateTimeKind.Local).AddTicks(7505), 102m, "Test2" });
        }
    }
}
