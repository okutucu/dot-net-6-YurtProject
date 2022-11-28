using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Repository.Migrations
{
    public partial class mig_Addedrelationalcustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Storage",
                table: "Files",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 28, 12, 43, 3, 57, DateTimeKind.Local).AddTicks(9267), "$2a$11$mppsQkqSZfkTGRDOgFR7uuhCHs9ZmVNpTE4g8OnqyYEQm8vi1Uadm", new DateTime(2022, 11, 28, 12, 43, 3, 57, DateTimeKind.Local).AddTicks(9321) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 28, 12, 43, 3, 57, DateTimeKind.Local).AddTicks(9336), "$2a$11$fdnuVP5o.15dEinla0Ogl.W5Tr3lrhI4ksj.SDFgNhglUZeLA4ri.", new DateTime(2022, 11, 28, 12, 43, 3, 57, DateTimeKind.Local).AddTicks(9339) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 28, 12, 43, 3, 57, DateTimeKind.Local).AddTicks(9343), "$2a$11$mnglthGlZQ4GQmZmP4WlxeNZ49Axu09Md3KkwI75M/ikF7sH5fR.m", new DateTime(2022, 11, 28, 12, 43, 3, 57, DateTimeKind.Local).AddTicks(9416) });

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 28, 12, 43, 2, 437, DateTimeKind.Local).AddTicks(9277));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 28, 12, 43, 2, 437, DateTimeKind.Local).AddTicks(9332));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 28, 12, 43, 2, 437, DateTimeKind.Local).AddTicks(9343));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 28, 12, 43, 2, 437, DateTimeKind.Local).AddTicks(9349));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Storage",
                table: "Files");

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
    }
}
