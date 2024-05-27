using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CriptoProjectTest.Migrations
{
    /// <inheritdoc />
    public partial class FixPrise : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "PriceUsd",
                table: "Assets",
                type: "decimal(18,10)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateLastUpdate",
                value: new DateTime(2024, 5, 25, 0, 9, 17, 814, DateTimeKind.Local).AddTicks(1476));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateLastUpdate",
                value: new DateTime(2024, 5, 25, 0, 9, 17, 814, DateTimeKind.Local).AddTicks(1470));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateLastUpdate",
                value: new DateTime(2024, 5, 25, 0, 9, 17, 814, DateTimeKind.Local).AddTicks(1472));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateLastUpdate",
                value: new DateTime(2024, 5, 25, 0, 9, 17, 814, DateTimeKind.Local).AddTicks(1474));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateLastUpdate",
                value: new DateTime(2024, 5, 25, 0, 9, 17, 814, DateTimeKind.Local).AddTicks(1425));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "PriceUsd",
                table: "Assets",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,10)",
                oldNullable: true);

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
                column: "DateLastUpdate",
                value: new DateTime(2024, 5, 24, 23, 49, 41, 920, DateTimeKind.Local).AddTicks(8822));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateLastUpdate",
                value: new DateTime(2024, 5, 24, 23, 49, 41, 920, DateTimeKind.Local).AddTicks(8825));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateLastUpdate",
                value: new DateTime(2024, 5, 24, 23, 49, 41, 920, DateTimeKind.Local).AddTicks(8758));
        }
    }
}
