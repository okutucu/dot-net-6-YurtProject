using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Repository.Migrations
{
    public partial class mig_TPHadded1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FileName",
                table: "Files",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Path",
                table: "Files",
                type: "nvarchar(max)",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FileName",
                table: "Files");

            migrationBuilder.DropColumn(
                name: "Path",
                table: "Files");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 26, 13, 43, 8, 889, DateTimeKind.Local).AddTicks(2434), "$2a$11$LCDL5t4zt8L7tB7d17uuDuTohISEVA6C4qS1H.4JAqwYtktQhwuzm", new DateTime(2022, 11, 26, 13, 43, 8, 889, DateTimeKind.Local).AddTicks(2502) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 26, 13, 43, 8, 889, DateTimeKind.Local).AddTicks(2518), "$2a$11$WM9EudUnbZUYhp6kLn0oS.nGF83mVpfgvJVLiFm7Afcybu6pJNArK", new DateTime(2022, 11, 26, 13, 43, 8, 889, DateTimeKind.Local).AddTicks(2522) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 26, 13, 43, 8, 889, DateTimeKind.Local).AddTicks(2527), "$2a$11$9VV1X5kK36y633bIBBWIVe6ozc1nHbajh5Mc7qGrxErUHDhcQHbZW", new DateTime(2022, 11, 26, 13, 43, 8, 889, DateTimeKind.Local).AddTicks(2688) });

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 26, 13, 43, 8, 127, DateTimeKind.Local).AddTicks(6158));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 26, 13, 43, 8, 127, DateTimeKind.Local).AddTicks(6220));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 26, 13, 43, 8, 127, DateTimeKind.Local).AddTicks(6233));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 26, 13, 43, 8, 127, DateTimeKind.Local).AddTicks(6239));
        }
    }
}
