using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Repository.Migrations
{
    public partial class mig_AddedPaymentIncomeModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PaymentName",
                table: "RoomIncomes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CustomerName",
                table: "IncomeDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 8, 11, 11, 10, 234, DateTimeKind.Local).AddTicks(9125), "$2a$11$KWiV8D2b9pM.SWLOhD.ZF.KbSpw/RdmTztT6u2TaSyxc.24UTOF1K", new DateTime(2022, 11, 8, 11, 11, 10, 234, DateTimeKind.Local).AddTicks(9192) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 8, 11, 11, 10, 234, DateTimeKind.Local).AddTicks(9203), "$2a$11$bXt0ILWCk28Ki36NI2.Fa.rFBqtjm8kNm/NI.YgCj0qX.l9QhySmS", new DateTime(2022, 11, 8, 11, 11, 10, 234, DateTimeKind.Local).AddTicks(9206) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 8, 11, 11, 10, 234, DateTimeKind.Local).AddTicks(9209), "$2a$11$OHyHkwLdOfVCDxuqDG3Wce2iQYOSRmUBL.clxoywCnlycaJqVXv5K", new DateTime(2022, 11, 8, 11, 11, 10, 234, DateTimeKind.Local).AddTicks(9280) });

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 8, 11, 11, 9, 608, DateTimeKind.Local).AddTicks(5807));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 8, 11, 11, 9, 608, DateTimeKind.Local).AddTicks(5858));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 8, 11, 11, 9, 608, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 8, 11, 11, 9, 608, DateTimeKind.Local).AddTicks(5874));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PaymentName",
                table: "RoomIncomes");

            migrationBuilder.DropColumn(
                name: "CustomerName",
                table: "IncomeDetails");

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
    }
}
