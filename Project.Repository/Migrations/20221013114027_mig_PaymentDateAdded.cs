using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Repository.Migrations
{
	public partial class mig_PaymentDateAdded : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.AddColumn<DateTime>(
				name: "PaymentDate",
				table: "RoomIncomes",
				type: "date",
				nullable: false,
				defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

			migrationBuilder.AddColumn<DateTime>(
				name: "PaymentDate",
				table: "PaymentDetails",
				type: "date",
				nullable: false,
				defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

			migrationBuilder.AddColumn<DateTime>(
				name: "PaymentDate",
				table: "IncomeDetails",
				type: "date",
				nullable: false,
				defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

			migrationBuilder.UpdateData(
				table: "Customers",
				keyColumn: "Id",
				keyValue: 1,
				columns: new[] { "CreatedDate", "EntryDate", "UpdatedDate" },
				values: new object[] { new DateTime(2022, 10, 13, 14, 40, 27, 168, DateTimeKind.Local).AddTicks(4293), new DateTime(2022, 10, 13, 14, 40, 27, 168, DateTimeKind.Local).AddTicks(4284), new DateTime(2022, 10, 13, 14, 40, 27, 168, DateTimeKind.Local).AddTicks(4294) });

			migrationBuilder.UpdateData(
				table: "Customers",
				keyColumn: "Id",
				keyValue: 2,
				columns: new[] { "CreatedDate", "EntryDate", "UpdatedDate" },
				values: new object[] { new DateTime(2022, 10, 13, 14, 40, 27, 168, DateTimeKind.Local).AddTicks(4302), new DateTime(2022, 10, 13, 14, 40, 27, 168, DateTimeKind.Local).AddTicks(4301), new DateTime(2022, 10, 13, 14, 40, 27, 168, DateTimeKind.Local).AddTicks(4303) });

			migrationBuilder.UpdateData(
				table: "ExchangeRates",
				keyColumn: "Id",
				keyValue: 1,
				column: "CreatedDate",
				value: new DateTime(2022, 10, 13, 14, 40, 27, 167, DateTimeKind.Local).AddTicks(6902));

			migrationBuilder.UpdateData(
				table: "ExchangeRates",
				keyColumn: "Id",
				keyValue: 2,
				column: "CreatedDate",
				value: new DateTime(2022, 10, 13, 14, 40, 27, 167, DateTimeKind.Local).AddTicks(6915));

			migrationBuilder.UpdateData(
				table: "ExchangeRates",
				keyColumn: "Id",
				keyValue: 3,
				column: "CreatedDate",
				value: new DateTime(2022, 10, 13, 14, 40, 27, 167, DateTimeKind.Local).AddTicks(6917));
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropColumn(
				name: "PaymentDate",
				table: "RoomIncomes");

			migrationBuilder.DropColumn(
				name: "PaymentDate",
				table: "PaymentDetails");

			migrationBuilder.DropColumn(
				name: "PaymentDate",
				table: "IncomeDetails");

			migrationBuilder.UpdateData(
				table: "Customers",
				keyColumn: "Id",
				keyValue: 1,
				columns: new[] { "CreatedDate", "EntryDate", "UpdatedDate" },
				values: new object[] { new DateTime(2022, 10, 12, 22, 42, 31, 958, DateTimeKind.Local).AddTicks(3481), new DateTime(2022, 10, 12, 22, 42, 31, 958, DateTimeKind.Local).AddTicks(3465), new DateTime(2022, 10, 12, 22, 42, 31, 958, DateTimeKind.Local).AddTicks(3485) });

			migrationBuilder.UpdateData(
				table: "Customers",
				keyColumn: "Id",
				keyValue: 2,
				columns: new[] { "CreatedDate", "EntryDate", "UpdatedDate" },
				values: new object[] { new DateTime(2022, 10, 12, 22, 42, 31, 958, DateTimeKind.Local).AddTicks(3502), new DateTime(2022, 10, 12, 22, 42, 31, 958, DateTimeKind.Local).AddTicks(3498), new DateTime(2022, 10, 12, 22, 42, 31, 958, DateTimeKind.Local).AddTicks(3503) });

			migrationBuilder.UpdateData(
				table: "ExchangeRates",
				keyColumn: "Id",
				keyValue: 1,
				column: "CreatedDate",
				value: new DateTime(2022, 10, 12, 22, 42, 31, 956, DateTimeKind.Local).AddTicks(5629));

			migrationBuilder.UpdateData(
				table: "ExchangeRates",
				keyColumn: "Id",
				keyValue: 2,
				column: "CreatedDate",
				value: new DateTime(2022, 10, 12, 22, 42, 31, 956, DateTimeKind.Local).AddTicks(5642));

			migrationBuilder.UpdateData(
				table: "ExchangeRates",
				keyColumn: "Id",
				keyValue: 3,
				column: "CreatedDate",
				value: new DateTime(2022, 10, 12, 22, 42, 31, 956, DateTimeKind.Local).AddTicks(5644));
		}
	}
}
