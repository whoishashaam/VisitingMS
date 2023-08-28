using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VisitingMS.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddImageUrlToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Visitors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "Id",
                keyValue: 1,
                column: "EntryTime",
                value: new DateTime(2023, 8, 8, 16, 6, 13, 78, DateTimeKind.Local).AddTicks(5058));

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "Id",
                keyValue: 2,
                column: "EntryTime",
                value: new DateTime(2023, 8, 8, 16, 6, 13, 78, DateTimeKind.Local).AddTicks(5099));

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "Id",
                keyValue: 3,
                column: "EntryTime",
                value: new DateTime(2023, 8, 8, 16, 6, 13, 78, DateTimeKind.Local).AddTicks(5115));

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "Id",
                keyValue: 4,
                column: "EntryTime",
                value: new DateTime(2023, 8, 8, 16, 6, 13, 78, DateTimeKind.Local).AddTicks(5132));

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "Id",
                keyValue: 5,
                column: "EntryTime",
                value: new DateTime(2023, 8, 8, 16, 6, 13, 78, DateTimeKind.Local).AddTicks(5148));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Visitors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "Id",
                keyValue: 1,
                column: "EntryTime",
                value: new DateTime(2023, 8, 3, 11, 38, 34, 775, DateTimeKind.Local).AddTicks(5135));

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "Id",
                keyValue: 2,
                column: "EntryTime",
                value: new DateTime(2023, 8, 3, 11, 38, 34, 775, DateTimeKind.Local).AddTicks(5175));

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "Id",
                keyValue: 3,
                column: "EntryTime",
                value: new DateTime(2023, 8, 3, 11, 38, 34, 775, DateTimeKind.Local).AddTicks(5191));

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "Id",
                keyValue: 4,
                column: "EntryTime",
                value: new DateTime(2023, 8, 3, 11, 38, 34, 775, DateTimeKind.Local).AddTicks(5207));

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "Id",
                keyValue: 5,
                column: "EntryTime",
                value: new DateTime(2023, 8, 3, 11, 38, 34, 775, DateTimeKind.Local).AddTicks(5223));
        }
    }
}
