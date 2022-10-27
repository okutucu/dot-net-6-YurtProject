using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Repository.Migrations
{
    public partial class mig_AddedRecord : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Records",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Records",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RelativeNameSurname",
                table: "Records",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RelativePhone",
                table: "Records",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UniversityName",
                table: "Records",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EntryDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 27, 14, 14, 12, 695, DateTimeKind.Local).AddTicks(1469), new DateTime(2022, 10, 27, 14, 14, 12, 695, DateTimeKind.Local).AddTicks(1375), new DateTime(2022, 10, 27, 14, 14, 12, 695, DateTimeKind.Local).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EntryDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 27, 14, 14, 12, 695, DateTimeKind.Local).AddTicks(1492), new DateTime(2022, 10, 27, 14, 14, 12, 695, DateTimeKind.Local).AddTicks(1489), new DateTime(2022, 10, 27, 14, 14, 12, 695, DateTimeKind.Local).AddTicks(1496) });

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 27, 14, 14, 12, 693, DateTimeKind.Local).AddTicks(1725));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 27, 14, 14, 12, 693, DateTimeKind.Local).AddTicks(1808));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 27, 14, 14, 12, 693, DateTimeKind.Local).AddTicks(1813));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 27, 14, 14, 12, 693, DateTimeKind.Local).AddTicks(1819));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "RelativeNameSurname",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "RelativePhone",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "UniversityName",
                table: "Records");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EntryDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 26, 14, 9, 37, 133, DateTimeKind.Local).AddTicks(324), new DateTime(2022, 10, 26, 14, 9, 37, 133, DateTimeKind.Local).AddTicks(275), new DateTime(2022, 10, 26, 14, 9, 37, 133, DateTimeKind.Local).AddTicks(328) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EntryDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 26, 14, 9, 37, 133, DateTimeKind.Local).AddTicks(341), new DateTime(2022, 10, 26, 14, 9, 37, 133, DateTimeKind.Local).AddTicks(337), new DateTime(2022, 10, 26, 14, 9, 37, 133, DateTimeKind.Local).AddTicks(345) });

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 26, 14, 9, 37, 117, DateTimeKind.Local).AddTicks(2746));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 26, 14, 9, 37, 117, DateTimeKind.Local).AddTicks(2783));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 26, 14, 9, 37, 117, DateTimeKind.Local).AddTicks(2786));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 26, 14, 9, 37, 117, DateTimeKind.Local).AddTicks(2790));
        }
    }
}
