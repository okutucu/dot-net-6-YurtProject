using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Repository.Migrations
{
	public partial class mig_DeletedRoomIdNullable : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
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

			migrationBuilder.UpdateData(
				table: "Customers",
				keyColumn: "Id",
				keyValue: 1,
				columns: new[] { "CreatedDate", "EntryDate", "UpdatedDate" },
				values: new object[] { new DateTime(2022, 10, 26, 14, 9, 37, 133, DateTimeKind.Local).AddTicks(324), new DateTime(2022, 10, 26, 14, 9, 37, 133, DateTimeKind.Local).AddTicks(275), new DateTime(2022, 10, 26, 14, 9, 37, 133, DateTimeKind.Local).AddTicks(328) });

			migrationBuilder.UpdateData(
				table: "Customers",
				keyColumn: "Id",
				keyValue: 2,
				columns: new[] { "CreatedDate", "EntryDate", "UpdatedDate" },
				values: new object[] { new DateTime(2022, 10, 26, 14, 9, 37, 133, DateTimeKind.Local).AddTicks(341), new DateTime(2022, 10, 26, 14, 9, 37, 133, DateTimeKind.Local).AddTicks(337), new DateTime(2022, 10, 26, 14, 9, 37, 133, DateTimeKind.Local).AddTicks(345) });

			migrationBuilder.UpdateData(
				table: "ExchangeRates",
				keyColumn: "Id",
				keyValue: 1,
				column: "CreatedDate",
				value: new DateTime(2022, 10, 26, 14, 9, 37, 117, DateTimeKind.Local).AddTicks(2746));

			migrationBuilder.UpdateData(
				table: "ExchangeRates",
				keyColumn: "Id",
				keyValue: 2,
				column: "CreatedDate",
				value: new DateTime(2022, 10, 26, 14, 9, 37, 117, DateTimeKind.Local).AddTicks(2783));

			migrationBuilder.UpdateData(
				table: "ExchangeRates",
				keyColumn: "Id",
				keyValue: 3,
				column: "CreatedDate",
				value: new DateTime(2022, 10, 26, 14, 9, 37, 117, DateTimeKind.Local).AddTicks(2786));

			migrationBuilder.UpdateData(
				table: "ExchangeRates",
				keyColumn: "Id",
				keyValue: 4,
				column: "CreatedDate",
				value: new DateTime(2022, 10, 26, 14, 9, 37, 117, DateTimeKind.Local).AddTicks(2790));

			migrationBuilder.AddForeignKey(
				name: "FK_RoomIncomes_Rooms_RoomId",
				table: "RoomIncomes",
				column: "RoomId",
				principalTable: "Rooms",
				principalColumn: "Id",
				onDelete: ReferentialAction.Cascade);
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
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

			migrationBuilder.UpdateData(
				table: "Customers",
				keyColumn: "Id",
				keyValue: 1,
				columns: new[] { "CreatedDate", "EntryDate", "UpdatedDate" },
				values: new object[] { new DateTime(2022, 10, 24, 13, 41, 47, 332, DateTimeKind.Local).AddTicks(9822), new DateTime(2022, 10, 24, 13, 41, 47, 332, DateTimeKind.Local).AddTicks(9808), new DateTime(2022, 10, 24, 13, 41, 47, 332, DateTimeKind.Local).AddTicks(9824) });

			migrationBuilder.UpdateData(
				table: "Customers",
				keyColumn: "Id",
				keyValue: 2,
				columns: new[] { "CreatedDate", "EntryDate", "UpdatedDate" },
				values: new object[] { new DateTime(2022, 10, 24, 13, 41, 47, 332, DateTimeKind.Local).AddTicks(9834), new DateTime(2022, 10, 24, 13, 41, 47, 332, DateTimeKind.Local).AddTicks(9832), new DateTime(2022, 10, 24, 13, 41, 47, 332, DateTimeKind.Local).AddTicks(9836) });

			migrationBuilder.UpdateData(
				table: "ExchangeRates",
				keyColumn: "Id",
				keyValue: 1,
				column: "CreatedDate",
				value: new DateTime(2022, 10, 24, 13, 41, 47, 332, DateTimeKind.Local).AddTicks(2874));

			migrationBuilder.UpdateData(
				table: "ExchangeRates",
				keyColumn: "Id",
				keyValue: 2,
				column: "CreatedDate",
				value: new DateTime(2022, 10, 24, 13, 41, 47, 332, DateTimeKind.Local).AddTicks(2913));

			migrationBuilder.UpdateData(
				table: "ExchangeRates",
				keyColumn: "Id",
				keyValue: 3,
				column: "CreatedDate",
				value: new DateTime(2022, 10, 24, 13, 41, 47, 332, DateTimeKind.Local).AddTicks(2916));

			migrationBuilder.UpdateData(
				table: "ExchangeRates",
				keyColumn: "Id",
				keyValue: 4,
				column: "CreatedDate",
				value: new DateTime(2022, 10, 24, 13, 41, 47, 332, DateTimeKind.Local).AddTicks(2919));

			migrationBuilder.AddForeignKey(
				name: "FK_RoomIncomes_Rooms_RoomId",
				table: "RoomIncomes",
				column: "RoomId",
				principalTable: "Rooms",
				principalColumn: "Id");
		}
	}
}
