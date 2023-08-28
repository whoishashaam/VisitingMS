using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VisitingMS.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddUserTableToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Visitors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CNIC = table.Column<long>(type: "bigint", nullable: false),
                    PhoneNo = table.Column<long>(type: "bigint", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EntryTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VisitorBelongings = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VisitingPurpose = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visitors", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Visitors",
                columns: new[] { "Id", "CNIC", "EntryTime", "FullName", "PhoneNo", "VisitingPurpose", "VisitorBelongings" },
                values: new object[,]
                {
                    { 1, 1234567890123L, new DateTime(2023, 8, 3, 10, 44, 55, 701, DateTimeKind.Local).AddTicks(430), "John Doe", 98765432101L, "Meeting", "Laptop, Bag" },
                    { 2, 9876543210987L, new DateTime(2023, 8, 3, 10, 44, 55, 701, DateTimeKind.Local).AddTicks(472), "Jane Smith", 12345678901L, "Interview", "Mobile Phone" },
                    { 3, 5555555555555L, new DateTime(2023, 8, 3, 10, 44, 55, 701, DateTimeKind.Local).AddTicks(488), "Michael Johnson", 11111111111L, "Training", "Backpack" },
                    { 4, 9999999999999L, new DateTime(2023, 8, 3, 10, 44, 55, 701, DateTimeKind.Local).AddTicks(504), "Emily Wilson", 22222222222L, "Delivery", "None" },
                    { 5, 4444444444444L, new DateTime(2023, 8, 3, 10, 44, 55, 701, DateTimeKind.Local).AddTicks(520), "David Lee", 33333333333L, "Maintenance", "Keys" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Visitors");
        }
    }
}
