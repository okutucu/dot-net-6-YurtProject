using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Repository.Migrations
{
	public partial class mig_DeletedRoomName : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropColumn(
				name: "RoomName",
				table: "IncomeDetails");

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
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.AddColumn<string>(
				name: "RoomName",
				table: "IncomeDetails",
				type: "nvarchar(10)",
				maxLength: 10,
				nullable: false,
				defaultValue: "");

			migrationBuilder.UpdateData(
				table: "Customers",
				keyColumn: "Id",
				keyValue: 1,
				columns: new[] { "CreatedDate", "EntryDate", "UpdatedDate" },
				values: new object[] { new DateTime(2022, 10, 24, 13, 8, 55, 926, DateTimeKind.Local).AddTicks(6361), new DateTime(2022, 10, 24, 13, 8, 55, 926, DateTimeKind.Local).AddTicks(6332), new DateTime(2022, 10, 24, 13, 8, 55, 926, DateTimeKind.Local).AddTicks(6365) });

			migrationBuilder.UpdateData(
				table: "Customers",
				keyColumn: "Id",
				keyValue: 2,
				columns: new[] { "CreatedDate", "EntryDate", "UpdatedDate" },
				values: new object[] { new DateTime(2022, 10, 24, 13, 8, 55, 926, DateTimeKind.Local).AddTicks(6378), new DateTime(2022, 10, 24, 13, 8, 55, 926, DateTimeKind.Local).AddTicks(6374), new DateTime(2022, 10, 24, 13, 8, 55, 926, DateTimeKind.Local).AddTicks(6382) });

			migrationBuilder.UpdateData(
				table: "ExchangeRates",
				keyColumn: "Id",
				keyValue: 1,
				column: "CreatedDate",
				value: new DateTime(2022, 10, 24, 13, 8, 55, 925, DateTimeKind.Local).AddTicks(5239));

			migrationBuilder.UpdateData(
				table: "ExchangeRates",
				keyColumn: "Id",
				keyValue: 2,
				column: "CreatedDate",
				value: new DateTime(2022, 10, 24, 13, 8, 55, 925, DateTimeKind.Local).AddTicks(5291));

			migrationBuilder.UpdateData(
				table: "ExchangeRates",
				keyColumn: "Id",
				keyValue: 3,
				column: "CreatedDate",
				value: new DateTime(2022, 10, 24, 13, 8, 55, 925, DateTimeKind.Local).AddTicks(5297));

			migrationBuilder.UpdateData(
				table: "ExchangeRates",
				keyColumn: "Id",
				keyValue: 4,
				column: "CreatedDate",
				value: new DateTime(2022, 10, 24, 13, 8, 55, 925, DateTimeKind.Local).AddTicks(5303));
		}
	}
}
