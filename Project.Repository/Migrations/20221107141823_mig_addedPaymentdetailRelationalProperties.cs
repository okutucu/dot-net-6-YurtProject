using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Repository.Migrations
{
    public partial class mig_addedPaymentdetailRelationalProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RoomId",
                table: "PaymentDetails",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 7, 16, 18, 23, 148, DateTimeKind.Local).AddTicks(413), "$2a$11$v/r6CYGgCBEKaf4Q1Rjm6ORyo3xMcgwihwJPc5rx/qEw3fJ8R0Xau", new DateTime(2022, 11, 7, 16, 18, 23, 148, DateTimeKind.Local).AddTicks(467) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 7, 16, 18, 23, 148, DateTimeKind.Local).AddTicks(480), "$2a$11$7fKCNFwSDKI6jcdxic.qhe3wFb3ayzduUXzJ80qB8t6.UB9/Lk8ae", new DateTime(2022, 11, 7, 16, 18, 23, 148, DateTimeKind.Local).AddTicks(482) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 7, 16, 18, 23, 148, DateTimeKind.Local).AddTicks(486), "$2a$11$f6aMV7Pl6vOVAQij3zMNWeyfdo6/Vs2O0IvxXhfCDaLlNIQY9MK4W", new DateTime(2022, 11, 7, 16, 18, 23, 148, DateTimeKind.Local).AddTicks(529) });

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 7, 16, 18, 22, 565, DateTimeKind.Local).AddTicks(4725));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 7, 16, 18, 22, 565, DateTimeKind.Local).AddTicks(4781));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 7, 16, 18, 22, 565, DateTimeKind.Local).AddTicks(4793));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 7, 16, 18, 22, 565, DateTimeKind.Local).AddTicks(4799));

            migrationBuilder.CreateIndex(
                name: "IX_PaymentDetails_RoomId",
                table: "PaymentDetails",
                column: "RoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentDetails_Rooms_RoomId",
                table: "PaymentDetails",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PaymentDetails_Rooms_RoomId",
                table: "PaymentDetails");

            migrationBuilder.DropIndex(
                name: "IX_PaymentDetails_RoomId",
                table: "PaymentDetails");

            migrationBuilder.DropColumn(
                name: "RoomId",
                table: "PaymentDetails");

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
