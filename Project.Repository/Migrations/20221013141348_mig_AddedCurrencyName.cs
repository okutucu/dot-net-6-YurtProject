using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Repository.Migrations
{
    public partial class mig_AddedCurrencyName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CurrencyName",
                table: "RoomIncomes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CurrencyName",
                table: "PaymentDetails",
                type: "nvarchar(max)",
                nullable: true);

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
                values: new object[] { new DateTime(2022, 10, 13, 17, 13, 47, 496, DateTimeKind.Local).AddTicks(114), new DateTime(2022, 10, 13, 17, 13, 47, 496, DateTimeKind.Local).AddTicks(108), new DateTime(2022, 10, 13, 17, 13, 47, 496, DateTimeKind.Local).AddTicks(115) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EntryDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 13, 17, 13, 47, 496, DateTimeKind.Local).AddTicks(125), new DateTime(2022, 10, 13, 17, 13, 47, 496, DateTimeKind.Local).AddTicks(124), new DateTime(2022, 10, 13, 17, 13, 47, 496, DateTimeKind.Local).AddTicks(126) });

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 13, 17, 13, 47, 495, DateTimeKind.Local).AddTicks(508));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 13, 17, 13, 47, 495, DateTimeKind.Local).AddTicks(518));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 13, 17, 13, 47, 495, DateTimeKind.Local).AddTicks(519));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 13, 17, 13, 47, 495, DateTimeKind.Local).AddTicks(522));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurrencyName",
                table: "RoomIncomes");

            migrationBuilder.DropColumn(
                name: "CurrencyName",
                table: "PaymentDetails");

            migrationBuilder.DropColumn(
                name: "CurrencyName",
                table: "IncomeDetails");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EntryDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 13, 16, 53, 10, 743, DateTimeKind.Local).AddTicks(6847), new DateTime(2022, 10, 13, 16, 53, 10, 743, DateTimeKind.Local).AddTicks(6835), new DateTime(2022, 10, 13, 16, 53, 10, 743, DateTimeKind.Local).AddTicks(6848) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EntryDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 13, 16, 53, 10, 743, DateTimeKind.Local).AddTicks(6855), new DateTime(2022, 10, 13, 16, 53, 10, 743, DateTimeKind.Local).AddTicks(6854), new DateTime(2022, 10, 13, 16, 53, 10, 743, DateTimeKind.Local).AddTicks(6856) });

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 13, 16, 53, 10, 742, DateTimeKind.Local).AddTicks(9253));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 13, 16, 53, 10, 742, DateTimeKind.Local).AddTicks(9364));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 13, 16, 53, 10, 742, DateTimeKind.Local).AddTicks(9366));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 13, 16, 53, 10, 742, DateTimeKind.Local).AddTicks(9369));
        }
    }
}
