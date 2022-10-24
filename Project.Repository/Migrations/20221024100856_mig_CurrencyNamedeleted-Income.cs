using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Repository.Migrations
{
    public partial class mig_CurrencyNamedeletedIncome : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurrencyName",
                table: "IncomeDetails");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EntryDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 24, 13, 8, 55, 926, DateTimeKind.Local).AddTicks(6361), new DateTime(2022, 10, 24, 13, 8, 55, 926, DateTimeKind.Local).AddTicks(6332), new DateTime(2022, 10, 24, 13, 8, 55, 926, DateTimeKind.Local).AddTicks(6365) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EntryDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 24, 13, 8, 55, 926, DateTimeKind.Local).AddTicks(6378), new DateTime(2022, 10, 24, 13, 8, 55, 926, DateTimeKind.Local).AddTicks(6374), new DateTime(2022, 10, 24, 13, 8, 55, 926, DateTimeKind.Local).AddTicks(6382) });

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 24, 13, 8, 55, 925, DateTimeKind.Local).AddTicks(5239));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 24, 13, 8, 55, 925, DateTimeKind.Local).AddTicks(5291));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 24, 13, 8, 55, 925, DateTimeKind.Local).AddTicks(5297));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 24, 13, 8, 55, 925, DateTimeKind.Local).AddTicks(5303));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CurrencyName",
                table: "IncomeDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EntryDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 22, 11, 40, 19, 425, DateTimeKind.Local).AddTicks(8483), new DateTime(2022, 10, 22, 11, 40, 19, 425, DateTimeKind.Local).AddTicks(8435), new DateTime(2022, 10, 22, 11, 40, 19, 425, DateTimeKind.Local).AddTicks(8485) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EntryDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 22, 11, 40, 19, 425, DateTimeKind.Local).AddTicks(8494), new DateTime(2022, 10, 22, 11, 40, 19, 425, DateTimeKind.Local).AddTicks(8492), new DateTime(2022, 10, 22, 11, 40, 19, 425, DateTimeKind.Local).AddTicks(8496) });

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 22, 11, 40, 19, 425, DateTimeKind.Local).AddTicks(1537));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 22, 11, 40, 19, 425, DateTimeKind.Local).AddTicks(1588));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 22, 11, 40, 19, 425, DateTimeKind.Local).AddTicks(1591));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 22, 11, 40, 19, 425, DateTimeKind.Local).AddTicks(1595));
        }
    }
}
