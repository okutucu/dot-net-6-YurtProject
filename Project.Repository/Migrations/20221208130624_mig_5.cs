using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Repository.Migrations
{
    public partial class mig_5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "MonthlyRisingPrice",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MonthlyRisingPrice",
                table: "Customers");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 8, 14, 50, 9, 805, DateTimeKind.Local).AddTicks(1603), "$2a$11$MzV5/ISIe1z4ChaIpifU1ek6hqwK9Av.OONCutlNNfEVe8uteLPou", new DateTime(2022, 12, 8, 14, 50, 9, 805, DateTimeKind.Local).AddTicks(1688) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 8, 14, 50, 9, 805, DateTimeKind.Local).AddTicks(1706), "$2a$11$hQzQY8CY9QwhGgH.YwYlBOVtGlGAK0LjFCjOTizr.qhq1nOoDKFui", new DateTime(2022, 12, 8, 14, 50, 9, 805, DateTimeKind.Local).AddTicks(1712) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 8, 14, 50, 9, 805, DateTimeKind.Local).AddTicks(1719), "$2a$11$bT.enlnvoZ3Vb5vICpnTHOc.DV9k5XMWcH0iaRYVvqx4Yy52iDwLy", new DateTime(2022, 12, 8, 14, 50, 9, 805, DateTimeKind.Local).AddTicks(2085) });

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 8, 14, 50, 8, 335, DateTimeKind.Local).AddTicks(7643));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 8, 14, 50, 8, 335, DateTimeKind.Local).AddTicks(7701));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 8, 14, 50, 8, 335, DateTimeKind.Local).AddTicks(7720));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 8, 14, 50, 8, 335, DateTimeKind.Local).AddTicks(7728));
        }
    }
}
