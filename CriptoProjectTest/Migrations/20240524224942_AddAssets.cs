using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CriptoProjectTest.Migrations
{
    /// <inheritdoc />
    public partial class AddAssets : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateLastUpdate",
                value: new DateTime(2024, 5, 24, 23, 49, 41, 920, DateTimeKind.Local).AddTicks(8827));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateLastUpdate",
                value: new DateTime(2024, 5, 24, 23, 49, 41, 920, DateTimeKind.Local).AddTicks(8820));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AssetId", "DateLastUpdate" },
                values: new object[] { "ETH", new DateTime(2024, 5, 24, 23, 49, 41, 920, DateTimeKind.Local).AddTicks(8822) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AssetId", "DateLastUpdate", "Name" },
                values: new object[] { "BNB", new DateTime(2024, 5, 24, 23, 49, 41, 920, DateTimeKind.Local).AddTicks(8825), "Binance Coin" });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateLastUpdate",
                value: new DateTime(2024, 5, 24, 23, 49, 41, 920, DateTimeKind.Local).AddTicks(8758));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateLastUpdate",
                value: new DateTime(2024, 5, 23, 19, 29, 12, 357, DateTimeKind.Local).AddTicks(3631));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateLastUpdate",
                value: new DateTime(2024, 5, 23, 19, 29, 12, 357, DateTimeKind.Local).AddTicks(3579));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AssetId", "DateLastUpdate" },
                values: new object[] { "Ethereum", new DateTime(2024, 5, 23, 19, 29, 12, 357, DateTimeKind.Local).AddTicks(3625) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AssetId", "DateLastUpdate", "Name" },
                values: new object[] { "TNT", new DateTime(2024, 5, 23, 19, 29, 12, 357, DateTimeKind.Local).AddTicks(3628), "Tierion" });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateLastUpdate",
                value: new DateTime(2024, 5, 23, 19, 29, 12, 357, DateTimeKind.Local).AddTicks(3510));
        }
    }
}
