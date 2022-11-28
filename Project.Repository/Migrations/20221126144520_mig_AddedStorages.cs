using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Repository.Migrations
{
    public partial class mig_AddedStorages : Migration
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
                values: new object[] { new DateTime(2022, 11, 26, 16, 45, 19, 591, DateTimeKind.Local).AddTicks(2468), "$2a$11$liQ9LsmElIjrCyQbsDbiBerfvI48bJyQzG9Tef/JR6M5AtpHHrsJu", new DateTime(2022, 11, 26, 16, 45, 19, 591, DateTimeKind.Local).AddTicks(2531) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 26, 16, 45, 19, 591, DateTimeKind.Local).AddTicks(2549), "$2a$11$gBxOOE1fijo/GCJ/arFNEOUwmtbiuvV92RsJov64ezTODPKjewqy2", new DateTime(2022, 11, 26, 16, 45, 19, 591, DateTimeKind.Local).AddTicks(2551) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 26, 16, 45, 19, 591, DateTimeKind.Local).AddTicks(2555), "$2a$11$n7aLtlkclbCWfLqbtvC6suh5WIENg6r7iVsFqzK4NNt0Is/6LsHii", new DateTime(2022, 11, 26, 16, 45, 19, 591, DateTimeKind.Local).AddTicks(2704) });

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 26, 16, 45, 18, 860, DateTimeKind.Local).AddTicks(9994));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 26, 16, 45, 18, 861, DateTimeKind.Local).AddTicks(39));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 26, 16, 45, 18, 861, DateTimeKind.Local).AddTicks(50));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 26, 16, 45, 18, 861, DateTimeKind.Local).AddTicks(54));
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
