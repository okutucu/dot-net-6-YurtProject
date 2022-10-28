using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Repository.Migrations
{
	public partial class mig_UpdatedPriceDecimal : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.UpdateData(
				table: "Customers",
				keyColumn: "Id",
				keyValue: 1,
				columns: new[] { "CreatedDate", "EntryDate", "UpdatedDate" },
				values: new object[] { new DateTime(2022, 10, 13, 16, 53, 10, 743, DateTimeKind.Local).AddTicks(6847), new DateTime(2022, 10, 13, 16, 53, 10, 743, DateTimeKind.Local).AddTicks(6835), new DateTime(2022, 10, 13, 16, 53, 10, 743, DateTimeKind.Local).AddTicks(6848) });

			migrationBuilder.UpdateData(
				table: "Customers",
				keyColumn: "Id",
				keyValue: 2,
				columns: new[] { "CreatedDate", "EntryDate", "UpdatedDate" },
				values: new object[] { new DateTime(2022, 10, 13, 16, 53, 10, 743, DateTimeKind.Local).AddTicks(6855), new DateTime(2022, 10, 13, 16, 53, 10, 743, DateTimeKind.Local).AddTicks(6854), new DateTime(2022, 10, 13, 16, 53, 10, 743, DateTimeKind.Local).AddTicks(6856) });

			migrationBuilder.UpdateData(
				table: "ExchangeRates",
				keyColumn: "Id",
				keyValue: 1,
				column: "CreatedDate",
				value: new DateTime(2022, 10, 13, 16, 53, 10, 742, DateTimeKind.Local).AddTicks(9253));

			migrationBuilder.UpdateData(
				table: "ExchangeRates",
				keyColumn: "Id",
				keyValue: 2,
				column: "CreatedDate",
				value: new DateTime(2022, 10, 13, 16, 53, 10, 742, DateTimeKind.Local).AddTicks(9364));

			migrationBuilder.UpdateData(
				table: "ExchangeRates",
				keyColumn: "Id",
				keyValue: 3,
				column: "CreatedDate",
				value: new DateTime(2022, 10, 13, 16, 53, 10, 742, DateTimeKind.Local).AddTicks(9366));

			migrationBuilder.UpdateData(
				table: "ExchangeRates",
				keyColumn: "Id",
				keyValue: 4,
				column: "CreatedDate",
				value: new DateTime(2022, 10, 13, 16, 53, 10, 742, DateTimeKind.Local).AddTicks(9369));
		}

		protected override void Down(MigrationBuilder migrationBuilder)
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

			migrationBuilder.UpdateData(
				table: "ExchangeRates",
				keyColumn: "Id",
				keyValue: 4,
				column: "CreatedDate",
				value: new DateTime(2022, 10, 13, 16, 36, 9, 861, DateTimeKind.Local).AddTicks(4354));
		}
	}
}
