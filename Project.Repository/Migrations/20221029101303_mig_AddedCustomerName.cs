using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Repository.Migrations
{
    public partial class mig_AddedCustomerName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CustomerName",
                table: "RoomIncomes",
                type: "nvarchar(max)",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerName",
                table: "RoomIncomes");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 28, 12, 15, 6, 150, DateTimeKind.Local).AddTicks(6547), "$2a$11$EYVpXn7qtjk4UDnn7TIHEuHknbljAf61mSfuH0U13tln1K//FcLuq", new DateTime(2022, 10, 28, 12, 15, 6, 150, DateTimeKind.Local).AddTicks(6613) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 28, 12, 15, 6, 150, DateTimeKind.Local).AddTicks(6628), "$2a$11$s1ZtpWrzDmuVYvIqZVQ/rujVMiSFBK9gcCIng8XSCyZxFKEoFQfjK", new DateTime(2022, 10, 28, 12, 15, 6, 150, DateTimeKind.Local).AddTicks(6632) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 28, 12, 15, 6, 150, DateTimeKind.Local).AddTicks(6638), "$2a$11$XNb0P4J.zMiI00d6uxOsI.b6IPRFJS7pG2pxmsIqQoqXROib26sn6", new DateTime(2022, 10, 28, 12, 15, 6, 150, DateTimeKind.Local).AddTicks(6704) });

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 28, 12, 15, 5, 521, DateTimeKind.Local).AddTicks(635));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 28, 12, 15, 5, 521, DateTimeKind.Local).AddTicks(690));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 28, 12, 15, 5, 521, DateTimeKind.Local).AddTicks(695));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 28, 12, 15, 5, 521, DateTimeKind.Local).AddTicks(701));
        }
    }
}
