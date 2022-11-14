using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Repository.Migrations
{
    public partial class mig_AddedDownPaymentAndDiscountOnCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Discount",
                table: "Customers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<decimal>(
                name: "DiscountPrice",
                table: "Customers",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<bool>(
                name: "DownPayment",
                table: "Customers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<decimal>(
                name: "DownPaymentPrice",
                table: "Customers",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 14, 16, 36, 17, 906, DateTimeKind.Local).AddTicks(416), "$2a$11$nDw8Ci8o9isdvgpWV84nxuepOz8uxxVnefIVYLZApayty335uvJuK", new DateTime(2022, 11, 14, 16, 36, 17, 906, DateTimeKind.Local).AddTicks(477) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 14, 16, 36, 17, 906, DateTimeKind.Local).AddTicks(489), "$2a$11$N4SP/dVPxpicHmp/Hom14.qXx0kWF6oMQjkFMT3MIVdfhcDeo7IKC", new DateTime(2022, 11, 14, 16, 36, 17, 906, DateTimeKind.Local).AddTicks(492) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 14, 16, 36, 17, 906, DateTimeKind.Local).AddTicks(495), "$2a$11$Sw1yw/98zaBoYrCGaT29r.VaRbKVQXS9w9YXx.Fta1GWJ/xUYB5j2", new DateTime(2022, 11, 14, 16, 36, 17, 906, DateTimeKind.Local).AddTicks(602) });

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 14, 16, 36, 17, 351, DateTimeKind.Local).AddTicks(5395));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 14, 16, 36, 17, 351, DateTimeKind.Local).AddTicks(5441));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 14, 16, 36, 17, 351, DateTimeKind.Local).AddTicks(5452));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 14, 16, 36, 17, 351, DateTimeKind.Local).AddTicks(5457));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discount",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "DiscountPrice",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "DownPayment",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "DownPaymentPrice",
                table: "Customers");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 8, 21, 55, 11, 620, DateTimeKind.Local).AddTicks(1486), "$2a$11$w8U5nOUqXucr6dj90SoQoew2wloHN18bTxOfRvxUVrti8T37UZYN.", new DateTime(2022, 11, 8, 21, 55, 11, 620, DateTimeKind.Local).AddTicks(1585) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 8, 21, 55, 11, 620, DateTimeKind.Local).AddTicks(1604), "$2a$11$ggeMTvmOqRwedrrWN7T/bu2VXRbGaV8evTKvnP5VcwxaIQpLdfPuO", new DateTime(2022, 11, 8, 21, 55, 11, 620, DateTimeKind.Local).AddTicks(1606) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 8, 21, 55, 11, 620, DateTimeKind.Local).AddTicks(1609), "$2a$11$x23.K2VUpLAjc/zhHUT1WOa89ZL0HFu8pmuw1yyargPx.NGAsL4wy", new DateTime(2022, 11, 8, 21, 55, 11, 620, DateTimeKind.Local).AddTicks(1800) });

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 8, 21, 55, 11, 79, DateTimeKind.Local).AddTicks(9153));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 8, 21, 55, 11, 79, DateTimeKind.Local).AddTicks(9205));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 8, 21, 55, 11, 79, DateTimeKind.Local).AddTicks(9216));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 8, 21, 55, 11, 79, DateTimeKind.Local).AddTicks(9220));
        }
    }
}
