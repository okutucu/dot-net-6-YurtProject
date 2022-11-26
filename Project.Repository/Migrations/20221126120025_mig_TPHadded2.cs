using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Repository.Migrations
{
    public partial class mig_TPHadded2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 26, 14, 0, 25, 92, DateTimeKind.Local).AddTicks(6131), "$2a$11$/cH5tZjng/9077WBAimKYuWhQEn9QhkAOGJu/ZZi3nSh5m53Nxle.", new DateTime(2022, 11, 26, 14, 0, 25, 92, DateTimeKind.Local).AddTicks(6201) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 26, 14, 0, 25, 92, DateTimeKind.Local).AddTicks(6213), "$2a$11$/qZFXB9asYeGsO5eQ0EpuOAq7aub6umOjhCEHQfFJyNpRtn/gj9oO", new DateTime(2022, 11, 26, 14, 0, 25, 92, DateTimeKind.Local).AddTicks(6216) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 26, 14, 0, 25, 92, DateTimeKind.Local).AddTicks(6220), "$2a$11$VQlYIr3xWiDkWG4F71f.6.xRpsGzC8aev0Yv/iQQJrQ6hfoirobyO", new DateTime(2022, 11, 26, 14, 0, 25, 92, DateTimeKind.Local).AddTicks(6590) });

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 26, 14, 0, 24, 557, DateTimeKind.Local).AddTicks(3138));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 26, 14, 0, 24, 557, DateTimeKind.Local).AddTicks(3197));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 26, 14, 0, 24, 557, DateTimeKind.Local).AddTicks(3206));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 26, 14, 0, 24, 557, DateTimeKind.Local).AddTicks(3211));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 26, 13, 48, 55, 711, DateTimeKind.Local).AddTicks(4125), "$2a$11$kewjWNPSDAlQ0EPVehBEG..Mm6goQQ9HDh/qbYldS4SeBjShyQk7u", new DateTime(2022, 11, 26, 13, 48, 55, 711, DateTimeKind.Local).AddTicks(4184) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 26, 13, 48, 55, 711, DateTimeKind.Local).AddTicks(4195), "$2a$11$/N3dQvQtBOy8nvL.yUaFfOG7Mr3AAdiI36bQwyOb.au57NxtZtxRC", new DateTime(2022, 11, 26, 13, 48, 55, 711, DateTimeKind.Local).AddTicks(4197) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 26, 13, 48, 55, 711, DateTimeKind.Local).AddTicks(4200), "$2a$11$QD8EjPpDCvBy0SH24.oH3.ggMzc8HG6ryQat1Ap3CmzxFXgA.GNQ.", new DateTime(2022, 11, 26, 13, 48, 55, 711, DateTimeKind.Local).AddTicks(4263) });

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 26, 13, 48, 54, 878, DateTimeKind.Local).AddTicks(8343));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 26, 13, 48, 54, 878, DateTimeKind.Local).AddTicks(8418));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 26, 13, 48, 54, 878, DateTimeKind.Local).AddTicks(8441));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 26, 13, 48, 54, 878, DateTimeKind.Local).AddTicks(8452));
        }
    }
}
