using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Repository.Migrations
{
    public partial class mig_DiscountandDiscountAmountAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Discount",
                table: "Rooms",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<decimal>(
                name: "DiscountAmount",
                table: "Rooms",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 6, 21, 45, 49, 828, DateTimeKind.Local).AddTicks(9756), "$2a$11$YIRc/6FHYw6E8ou6x8F3ceiXZ9Ihty4uwU.p2KgF/ulVr9.2QwGjS", new DateTime(2022, 11, 6, 21, 45, 49, 828, DateTimeKind.Local).AddTicks(9816) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 6, 21, 45, 49, 828, DateTimeKind.Local).AddTicks(9827), "$2a$11$AMxSGVRx8jiuBIi4UWHyVubwSBoo.paWeuR.S/2j9NZi2xYIZiCTG", new DateTime(2022, 11, 6, 21, 45, 49, 828, DateTimeKind.Local).AddTicks(9830) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 6, 21, 45, 49, 828, DateTimeKind.Local).AddTicks(9834), "$2a$11$uUBUXwFWAmIWu8xFl45OyO1bM669/JnDJIIM6TmbLjvEBz0Rwg0BK", new DateTime(2022, 11, 6, 21, 45, 49, 828, DateTimeKind.Local).AddTicks(9875) });

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 6, 21, 45, 49, 277, DateTimeKind.Local).AddTicks(4257));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 6, 21, 45, 49, 277, DateTimeKind.Local).AddTicks(4308));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 6, 21, 45, 49, 277, DateTimeKind.Local).AddTicks(4318));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 6, 21, 45, 49, 277, DateTimeKind.Local).AddTicks(4322));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discount",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "DiscountAmount",
                table: "Rooms");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 29, 13, 13, 2, 857, DateTimeKind.Local).AddTicks(2537), "$2a$11$pF35/mr2weM.SMPhsygoF.fuA24Dsafz5emMWiUnQWxUy2tHTqIOq", new DateTime(2022, 10, 29, 13, 13, 2, 857, DateTimeKind.Local).AddTicks(2594) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 29, 13, 13, 2, 857, DateTimeKind.Local).AddTicks(2605), "$2a$11$xFfpUkAx4GeedDfQ7.eGtOqaYD4XsRfKmsJnX3.R1Hf0g9nzAWGeO", new DateTime(2022, 10, 29, 13, 13, 2, 857, DateTimeKind.Local).AddTicks(2607) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 29, 13, 13, 2, 857, DateTimeKind.Local).AddTicks(2611), "$2a$11$i.iDKrZynlwXjKjPc9/AhOjDnmpoJyAESxmmocmWSp1gKpbeaInCq", new DateTime(2022, 10, 29, 13, 13, 2, 857, DateTimeKind.Local).AddTicks(2649) });

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 29, 13, 13, 2, 265, DateTimeKind.Local).AddTicks(3856));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 29, 13, 13, 2, 265, DateTimeKind.Local).AddTicks(3918));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 29, 13, 13, 2, 265, DateTimeKind.Local).AddTicks(3923));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 29, 13, 13, 2, 265, DateTimeKind.Local).AddTicks(3930));
        }
    }
}
