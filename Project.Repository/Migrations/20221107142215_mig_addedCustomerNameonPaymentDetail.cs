using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Repository.Migrations
{
    public partial class mig_addedCustomerNameonPaymentDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CustomerName",
                table: "PaymentDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 7, 16, 22, 14, 608, DateTimeKind.Local).AddTicks(1830), "$2a$11$kTJz2WcpAl1GCoZZMEcYb.ktAh/ClZlW47rJa6fQzu8Nw4qU37Os6", new DateTime(2022, 11, 7, 16, 22, 14, 608, DateTimeKind.Local).AddTicks(1887) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 7, 16, 22, 14, 608, DateTimeKind.Local).AddTicks(1903), "$2a$11$1n5To.ItBCVjcHQJoXoF1u3/h1lGEyzRI7opeGx529Sl1qDhHeyPK", new DateTime(2022, 11, 7, 16, 22, 14, 608, DateTimeKind.Local).AddTicks(1905) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 7, 16, 22, 14, 608, DateTimeKind.Local).AddTicks(1908), "$2a$11$V3GGW04H4mUZaiFVzUMhge0qfvn/w5sfxjzeEwyRe8.d13C5eKF9W", new DateTime(2022, 11, 7, 16, 22, 14, 608, DateTimeKind.Local).AddTicks(2032) });

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 7, 16, 22, 14, 14, DateTimeKind.Local).AddTicks(9195));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 7, 16, 22, 14, 14, DateTimeKind.Local).AddTicks(9243));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 7, 16, 22, 14, 14, DateTimeKind.Local).AddTicks(9255));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 7, 16, 22, 14, 14, DateTimeKind.Local).AddTicks(9261));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerName",
                table: "PaymentDetails");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 7, 16, 18, 23, 148, DateTimeKind.Local).AddTicks(413), "$2a$11$v/r6CYGgCBEKaf4Q1Rjm6ORyo3xMcgwihwJPc5rx/qEw3fJ8R0Xau", new DateTime(2022, 11, 7, 16, 18, 23, 148, DateTimeKind.Local).AddTicks(467) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 7, 16, 18, 23, 148, DateTimeKind.Local).AddTicks(480), "$2a$11$7fKCNFwSDKI6jcdxic.qhe3wFb3ayzduUXzJ80qB8t6.UB9/Lk8ae", new DateTime(2022, 11, 7, 16, 18, 23, 148, DateTimeKind.Local).AddTicks(482) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 7, 16, 18, 23, 148, DateTimeKind.Local).AddTicks(486), "$2a$11$f6aMV7Pl6vOVAQij3zMNWeyfdo6/Vs2O0IvxXhfCDaLlNIQY9MK4W", new DateTime(2022, 11, 7, 16, 18, 23, 148, DateTimeKind.Local).AddTicks(529) });

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 7, 16, 18, 22, 565, DateTimeKind.Local).AddTicks(4725));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 7, 16, 18, 22, 565, DateTimeKind.Local).AddTicks(4781));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 7, 16, 18, 22, 565, DateTimeKind.Local).AddTicks(4793));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 7, 16, 18, 22, 565, DateTimeKind.Local).AddTicks(4799));
        }
    }
}
