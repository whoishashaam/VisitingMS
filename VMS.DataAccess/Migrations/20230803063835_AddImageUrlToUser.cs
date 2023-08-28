using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VisitingMS.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddImageUrlToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Visitors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EntryTime", "ImageUrl" },
                values: new object[] { new DateTime(2023, 8, 3, 11, 38, 34, 775, DateTimeKind.Local).AddTicks(5135), "" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EntryTime", "ImageUrl" },
                values: new object[] { new DateTime(2023, 8, 3, 11, 38, 34, 775, DateTimeKind.Local).AddTicks(5175), "" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EntryTime", "ImageUrl" },
                values: new object[] { new DateTime(2023, 8, 3, 11, 38, 34, 775, DateTimeKind.Local).AddTicks(5191), "" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EntryTime", "ImageUrl" },
                values: new object[] { new DateTime(2023, 8, 3, 11, 38, 34, 775, DateTimeKind.Local).AddTicks(5207), "" });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EntryTime", "ImageUrl" },
                values: new object[] { new DateTime(2023, 8, 3, 11, 38, 34, 775, DateTimeKind.Local).AddTicks(5223), "" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Visitors");

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "Id",
                keyValue: 1,
                column: "EntryTime",
                value: new DateTime(2023, 8, 3, 10, 50, 46, 250, DateTimeKind.Local).AddTicks(6199));

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "Id",
                keyValue: 2,
                column: "EntryTime",
                value: new DateTime(2023, 8, 3, 10, 50, 46, 250, DateTimeKind.Local).AddTicks(6247));

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "Id",
                keyValue: 3,
                column: "EntryTime",
                value: new DateTime(2023, 8, 3, 10, 50, 46, 250, DateTimeKind.Local).AddTicks(6262));

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "Id",
                keyValue: 4,
                column: "EntryTime",
                value: new DateTime(2023, 8, 3, 10, 50, 46, 250, DateTimeKind.Local).AddTicks(6279));

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "Id",
                keyValue: 5,
                column: "EntryTime",
                value: new DateTime(2023, 8, 3, 10, 50, 46, 250, DateTimeKind.Local).AddTicks(6296));
        }
    }
}
