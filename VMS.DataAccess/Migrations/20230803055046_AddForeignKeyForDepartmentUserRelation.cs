using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VisitingMS.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddForeignKeyForDepartmentUserRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartmentID",
                table: "Visitors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DepartmentID", "EntryTime" },
                values: new object[] { 10, new DateTime(2023, 8, 3, 10, 50, 46, 250, DateTimeKind.Local).AddTicks(6199) });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DepartmentID", "EntryTime" },
                values: new object[] { 11, new DateTime(2023, 8, 3, 10, 50, 46, 250, DateTimeKind.Local).AddTicks(6247) });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DepartmentID", "EntryTime" },
                values: new object[] { 12, new DateTime(2023, 8, 3, 10, 50, 46, 250, DateTimeKind.Local).AddTicks(6262) });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DepartmentID", "EntryTime" },
                values: new object[] { 12, new DateTime(2023, 8, 3, 10, 50, 46, 250, DateTimeKind.Local).AddTicks(6279) });

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DepartmentID", "EntryTime" },
                values: new object[] { 12, new DateTime(2023, 8, 3, 10, 50, 46, 250, DateTimeKind.Local).AddTicks(6296) });

            migrationBuilder.CreateIndex(
                name: "IX_Visitors_DepartmentID",
                table: "Visitors",
                column: "DepartmentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Visitors_Departments_DepartmentID",
                table: "Visitors",
                column: "DepartmentID",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Visitors_Departments_DepartmentID",
                table: "Visitors");

            migrationBuilder.DropIndex(
                name: "IX_Visitors_DepartmentID",
                table: "Visitors");

            migrationBuilder.DropColumn(
                name: "DepartmentID",
                table: "Visitors");

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "Id",
                keyValue: 1,
                column: "EntryTime",
                value: new DateTime(2023, 8, 3, 10, 44, 55, 701, DateTimeKind.Local).AddTicks(430));

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "Id",
                keyValue: 2,
                column: "EntryTime",
                value: new DateTime(2023, 8, 3, 10, 44, 55, 701, DateTimeKind.Local).AddTicks(472));

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "Id",
                keyValue: 3,
                column: "EntryTime",
                value: new DateTime(2023, 8, 3, 10, 44, 55, 701, DateTimeKind.Local).AddTicks(488));

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "Id",
                keyValue: 4,
                column: "EntryTime",
                value: new DateTime(2023, 8, 3, 10, 44, 55, 701, DateTimeKind.Local).AddTicks(504));

            migrationBuilder.UpdateData(
                table: "Visitors",
                keyColumn: "Id",
                keyValue: 5,
                column: "EntryTime",
                value: new DateTime(2023, 8, 3, 10, 44, 55, 701, DateTimeKind.Local).AddTicks(520));
        }
    }
}
