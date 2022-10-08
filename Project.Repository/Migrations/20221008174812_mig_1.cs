using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Repository.Migrations
{
    public partial class mig_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EntryDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 8, 20, 48, 11, 922, DateTimeKind.Local).AddTicks(2321), new DateTime(2022, 10, 8, 20, 48, 11, 922, DateTimeKind.Local).AddTicks(2306), new DateTime(2022, 10, 8, 20, 48, 11, 922, DateTimeKind.Local).AddTicks(2322) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EntryDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 8, 20, 48, 11, 922, DateTimeKind.Local).AddTicks(2332), new DateTime(2022, 10, 8, 20, 48, 11, 922, DateTimeKind.Local).AddTicks(2331), new DateTime(2022, 10, 8, 20, 48, 11, 922, DateTimeKind.Local).AddTicks(2333) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EntryDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 4, 22, 18, 42, 899, DateTimeKind.Local).AddTicks(1426), new DateTime(2022, 10, 4, 22, 18, 42, 899, DateTimeKind.Local).AddTicks(1409), new DateTime(2022, 10, 4, 22, 18, 42, 899, DateTimeKind.Local).AddTicks(1428) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EntryDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 4, 22, 18, 42, 899, DateTimeKind.Local).AddTicks(1440), new DateTime(2022, 10, 4, 22, 18, 42, 899, DateTimeKind.Local).AddTicks(1437), new DateTime(2022, 10, 4, 22, 18, 42, 899, DateTimeKind.Local).AddTicks(1441) });
        }
    }
}
