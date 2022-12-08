using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Repository.Migrations
{
    public partial class mig_6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discount",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "DiscountPrice",
                table: "Customers");

            migrationBuilder.AddColumn<bool>(
                name: "Discount",
                table: "Rooms",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<decimal>(
                name: "DiscountPrice",
                table: "Rooms",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 8, 17, 0, 44, 568, DateTimeKind.Local).AddTicks(4845), "$2a$11$3eBkOLxXAKDsBhytYKgTzOvhB31bmtm0uBrH5N3aleU3G5T1y4Pbi", new DateTime(2022, 12, 8, 17, 0, 44, 568, DateTimeKind.Local).AddTicks(4896) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 8, 17, 0, 44, 568, DateTimeKind.Local).AddTicks(4907), "$2a$11$Rh.bLZD.EFtkm4dl8Yopw.htZlu3LdDd/0WqdUl4PkF9IlL6Y2JN2", new DateTime(2022, 12, 8, 17, 0, 44, 568, DateTimeKind.Local).AddTicks(4910) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 8, 17, 0, 44, 568, DateTimeKind.Local).AddTicks(4913), "$2a$11$uXD3HZqRgFcq/cFKN2tSzO3WQMoiEyLmzBCmDEQy31c/x2G2JpAeO", new DateTime(2022, 12, 8, 17, 0, 44, 568, DateTimeKind.Local).AddTicks(4953) });

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 8, 17, 0, 44, 37, DateTimeKind.Local).AddTicks(3359));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 8, 17, 0, 44, 37, DateTimeKind.Local).AddTicks(3409));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 8, 17, 0, 44, 37, DateTimeKind.Local).AddTicks(3420));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 8, 17, 0, 44, 37, DateTimeKind.Local).AddTicks(3426));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discount",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "DiscountPrice",
                table: "Rooms");

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

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 8, 15, 6, 24, 255, DateTimeKind.Local).AddTicks(9480), "$2a$11$yihShfbBWp6DI954/vOVNO.qrRwCMf5cQzB9EszThjQeYRDIuKaTC", new DateTime(2022, 12, 8, 15, 6, 24, 255, DateTimeKind.Local).AddTicks(9542) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 8, 15, 6, 24, 255, DateTimeKind.Local).AddTicks(9554), "$2a$11$ez6Upb923A7z.fzZKgh8xumeVwFi.ChRALv8O7VteO6z.qx8ZVRSW", new DateTime(2022, 12, 8, 15, 6, 24, 255, DateTimeKind.Local).AddTicks(9557) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 8, 15, 6, 24, 255, DateTimeKind.Local).AddTicks(9561), "$2a$11$8cBnwPRuZcIQz/aK28QFrOZjqgW3SjDH5VzskIsAyTI9q4AcQ.G8K", new DateTime(2022, 12, 8, 15, 6, 24, 255, DateTimeKind.Local).AddTicks(9620) });

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 8, 15, 6, 23, 612, DateTimeKind.Local).AddTicks(4984));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 8, 15, 6, 23, 612, DateTimeKind.Local).AddTicks(5037));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 8, 15, 6, 23, 612, DateTimeKind.Local).AddTicks(5051));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 8, 15, 6, 23, 612, DateTimeKind.Local).AddTicks(5057));
        }
    }
}
