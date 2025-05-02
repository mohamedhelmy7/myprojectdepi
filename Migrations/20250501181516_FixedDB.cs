using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DEPI_Library.Migrations
{
    /// <inheritdoc />
    public partial class FixedDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Borrows",
                keyColumn: "BorrowId",
                keyValue: 1L,
                column: "BorrowDate",
                value: new DateTimeOffset(new DateTime(2025, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Borrows",
                keyColumn: "BorrowId",
                keyValue: 2L,
                column: "BorrowDate",
                value: new DateTimeOffset(new DateTime(2025, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Borrows",
                keyColumn: "BorrowId",
                keyValue: 3L,
                column: "BorrowDate",
                value: new DateTimeOffset(new DateTime(2025, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Borrows",
                keyColumn: "BorrowId",
                keyValue: 4L,
                column: "BorrowDate",
                value: new DateTimeOffset(new DateTime(2025, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Borrows",
                keyColumn: "BorrowId",
                keyValue: 5L,
                column: "BorrowDate",
                value: new DateTimeOffset(new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Borrows",
                keyColumn: "BorrowId",
                keyValue: 1L,
                column: "BorrowDate",
                value: new DateTimeOffset(new DateTime(2025, 4, 21, 21, 7, 26, 671, DateTimeKind.Unspecified).AddTicks(1723), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Borrows",
                keyColumn: "BorrowId",
                keyValue: 2L,
                column: "BorrowDate",
                value: new DateTimeOffset(new DateTime(2025, 4, 26, 21, 7, 26, 678, DateTimeKind.Unspecified).AddTicks(6385), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Borrows",
                keyColumn: "BorrowId",
                keyValue: 3L,
                column: "BorrowDate",
                value: new DateTimeOffset(new DateTime(2025, 4, 29, 21, 7, 26, 678, DateTimeKind.Unspecified).AddTicks(6407), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Borrows",
                keyColumn: "BorrowId",
                keyValue: 4L,
                column: "BorrowDate",
                value: new DateTimeOffset(new DateTime(2025, 4, 30, 21, 7, 26, 678, DateTimeKind.Unspecified).AddTicks(6412), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Borrows",
                keyColumn: "BorrowId",
                keyValue: 5L,
                column: "BorrowDate",
                value: new DateTimeOffset(new DateTime(2025, 5, 1, 21, 7, 26, 678, DateTimeKind.Unspecified).AddTicks(6414), new TimeSpan(0, 3, 0, 0, 0)));
        }
    }
}
