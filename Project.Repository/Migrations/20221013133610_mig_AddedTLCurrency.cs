using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Repository.Migrations
{
	public partial class mig_AddedTLCurrency : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.UpdateData(
				table: "Customers",
				keyColumn: "Id",
				keyValue: 1,
				columns: new[] { "CreatedDate", "EntryDate", "UpdatedDate" },
				values: new object[] { new DateTime(2022, 10, 13, 16, 36, 9, 862, DateTimeKind.Local).AddTicks(836), new DateTime(2022, 10, 13, 16, 36, 9, 862, DateTimeKind.Local).AddTicks(830), new DateTime(2022, 10, 13, 16, 36, 9, 862, DateTimeKind.Local).AddTicks(837) });

			migrationBuilder.UpdateData(
				table: "Customers",
				keyColumn: "Id",
				keyValue: 2,
				columns: new[] { "CreatedDate", "EntryDate", "UpdatedDate" },
				values: new object[] { new DateTime(2022, 10, 13, 16, 36, 9, 862, DateTimeKind.Local).AddTicks(848), new DateTime(2022, 10, 13, 16, 36, 9, 862, DateTimeKind.Local).AddTicks(847), new DateTime(2022, 10, 13, 16, 36, 9, 862, DateTimeKind.Local).AddTicks(849) });

			migrationBuilder.UpdateData(
				table: "ExchangeRates",
				keyColumn: "Id",
				keyValue: 1,
				column: "CreatedDate",
				value: new DateTime(2022, 10, 13, 16, 36, 9, 861, DateTimeKind.Local).AddTicks(4338));

			migrationBuilder.UpdateData(
				table: "ExchangeRates",
				keyColumn: "Id",
				keyValue: 2,
				column: "CreatedDate",
				value: new DateTime(2022, 10, 13, 16, 36, 9, 861, DateTimeKind.Local).AddTicks(4350));

			migrationBuilder.UpdateData(
				table: "ExchangeRates",
				keyColumn: "Id",
				keyValue: 3,
				column: "CreatedDate",
				value: new DateTime(2022, 10, 13, 16, 36, 9, 861, DateTimeKind.Local).AddTicks(4351));

			migrationBuilder.InsertData(
				table: "ExchangeRates",
				columns: new[] { "Id", "CreatedDate", "ExchangeName", "Price", "UpdatedDate" },
				values: new object[] { 4, new DateTime(2022, 10, 13, 16, 36, 9, 861, DateTimeKind.Local).AddTicks(4354), "Tl", 1m, null });
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DeleteData(
				table: "ExchangeRates",
				keyColumn: "Id",
				keyValue: 4);

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
	}
}
