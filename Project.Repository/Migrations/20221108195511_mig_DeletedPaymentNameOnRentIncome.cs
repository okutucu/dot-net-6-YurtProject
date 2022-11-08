using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Repository.Migrations
{
    public partial class mig_DeletedPaymentNameOnRentIncome : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PaymentName",
                table: "RoomIncomes");

            migrationBuilder.AlterColumn<string>(
                name: "RoomName",
                table: "Rooms",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RoomName",
                table: "Rooms",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AddColumn<int>(
                name: "PaymentName",
                table: "RoomIncomes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 8, 17, 1, 56, 807, DateTimeKind.Local).AddTicks(1684), "$2a$11$j8t9HDdJIJUZH47GbU1ybOFSrCDhVucs9WlUSJCQa0IIylxIxs.Gi", new DateTime(2022, 11, 8, 17, 1, 56, 807, DateTimeKind.Local).AddTicks(1758) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 8, 17, 1, 56, 807, DateTimeKind.Local).AddTicks(1773), "$2a$11$eXBLGKPZuYUbLzPjcbr.9.5ab4eYU0Zm9aX8LU8IT0e8D8cIIFfcO", new DateTime(2022, 11, 8, 17, 1, 56, 807, DateTimeKind.Local).AddTicks(1777) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 8, 17, 1, 56, 807, DateTimeKind.Local).AddTicks(1783), "$2a$11$yN3i54Ru33a9Njk8jiwEbO7tQekRVvnEucY4abeSe71llM3I3Q2/6", new DateTime(2022, 11, 8, 17, 1, 56, 807, DateTimeKind.Local).AddTicks(1864) });

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 8, 17, 1, 56, 222, DateTimeKind.Local).AddTicks(6980));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 8, 17, 1, 56, 222, DateTimeKind.Local).AddTicks(7032));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 8, 17, 1, 56, 222, DateTimeKind.Local).AddTicks(7049));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 8, 17, 1, 56, 222, DateTimeKind.Local).AddTicks(7055));
        }
    }
}
