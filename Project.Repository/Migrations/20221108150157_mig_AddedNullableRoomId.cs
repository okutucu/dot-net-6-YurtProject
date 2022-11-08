using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Repository.Migrations
{
    public partial class mig_AddedNullableRoomId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Rooms_RoomId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomIncomes_Rooms_RoomId",
                table: "RoomIncomes");

            migrationBuilder.AlterColumn<int>(
                name: "RoomId",
                table: "RoomIncomes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "RoomId",
                table: "Customers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Rooms_RoomId",
                table: "Customers",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RoomIncomes_Rooms_RoomId",
                table: "RoomIncomes",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Rooms_RoomId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomIncomes_Rooms_RoomId",
                table: "RoomIncomes");

            migrationBuilder.AlterColumn<int>(
                name: "RoomId",
                table: "RoomIncomes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RoomId",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 8, 11, 11, 10, 234, DateTimeKind.Local).AddTicks(9125), "$2a$11$KWiV8D2b9pM.SWLOhD.ZF.KbSpw/RdmTztT6u2TaSyxc.24UTOF1K", new DateTime(2022, 11, 8, 11, 11, 10, 234, DateTimeKind.Local).AddTicks(9192) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 8, 11, 11, 10, 234, DateTimeKind.Local).AddTicks(9203), "$2a$11$bXt0ILWCk28Ki36NI2.Fa.rFBqtjm8kNm/NI.YgCj0qX.l9QhySmS", new DateTime(2022, 11, 8, 11, 11, 10, 234, DateTimeKind.Local).AddTicks(9206) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 8, 11, 11, 10, 234, DateTimeKind.Local).AddTicks(9209), "$2a$11$OHyHkwLdOfVCDxuqDG3Wce2iQYOSRmUBL.clxoywCnlycaJqVXv5K", new DateTime(2022, 11, 8, 11, 11, 10, 234, DateTimeKind.Local).AddTicks(9280) });

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 8, 11, 11, 9, 608, DateTimeKind.Local).AddTicks(5807));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 8, 11, 11, 9, 608, DateTimeKind.Local).AddTicks(5858));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 8, 11, 11, 9, 608, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 8, 11, 11, 9, 608, DateTimeKind.Local).AddTicks(5874));

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Rooms_RoomId",
                table: "Customers",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoomIncomes_Rooms_RoomId",
                table: "RoomIncomes",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
