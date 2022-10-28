using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Repository.Migrations
{
	public partial class mig_DeletedCurrecyname : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropColumn(
				name: "CurrencyName",
				table: "RoomIncomes");

			migrationBuilder.DropColumn(
				name: "CurrencyName",
				table: "PaymentDetails");

			migrationBuilder.UpdateData(
				table: "Customers",
				keyColumn: "Id",
				keyValue: 1,
				columns: new[] { "CreatedDate", "EntryDate", "UpdatedDate" },
				values: new object[] { new DateTime(2022, 10, 22, 11, 40, 19, 425, DateTimeKind.Local).AddTicks(8483), new DateTime(2022, 10, 22, 11, 40, 19, 425, DateTimeKind.Local).AddTicks(8435), new DateTime(2022, 10, 22, 11, 40, 19, 425, DateTimeKind.Local).AddTicks(8485) });

			migrationBuilder.UpdateData(
				table: "Customers",
				keyColumn: "Id",
				keyValue: 2,
				columns: new[] { "CreatedDate", "EntryDate", "UpdatedDate" },
				values: new object[] { new DateTime(2022, 10, 22, 11, 40, 19, 425, DateTimeKind.Local).AddTicks(8494), new DateTime(2022, 10, 22, 11, 40, 19, 425, DateTimeKind.Local).AddTicks(8492), new DateTime(2022, 10, 22, 11, 40, 19, 425, DateTimeKind.Local).AddTicks(8496) });

			migrationBuilder.UpdateData(
				table: "ExchangeRates",
				keyColumn: "Id",
				keyValue: 1,
				column: "CreatedDate",
				value: new DateTime(2022, 10, 22, 11, 40, 19, 425, DateTimeKind.Local).AddTicks(1537));

			migrationBuilder.UpdateData(
				table: "ExchangeRates",
				keyColumn: "Id",
				keyValue: 2,
				column: "CreatedDate",
				value: new DateTime(2022, 10, 22, 11, 40, 19, 425, DateTimeKind.Local).AddTicks(1588));

			migrationBuilder.UpdateData(
				table: "ExchangeRates",
				keyColumn: "Id",
				keyValue: 3,
				column: "CreatedDate",
				value: new DateTime(2022, 10, 22, 11, 40, 19, 425, DateTimeKind.Local).AddTicks(1591));

			migrationBuilder.UpdateData(
				table: "ExchangeRates",
				keyColumn: "Id",
				keyValue: 4,
				column: "CreatedDate",
				value: new DateTime(2022, 10, 22, 11, 40, 19, 425, DateTimeKind.Local).AddTicks(1595));
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.AddColumn<string>(
				name: "CurrencyName",
				table: "RoomIncomes",
				type: "nvarchar(max)",
				nullable: true);

			migrationBuilder.AddColumn<string>(
				name: "CurrencyName",
				table: "PaymentDetails",
				type: "nvarchar(max)",
				nullable: true);

			migrationBuilder.UpdateData(
				table: "Customers",
				keyColumn: "Id",
				keyValue: 1,
				columns: new[] { "CreatedDate", "EntryDate", "UpdatedDate" },
				values: new object[] { new DateTime(2022, 10, 19, 13, 57, 52, 404, DateTimeKind.Local).AddTicks(611), new DateTime(2022, 10, 19, 13, 57, 52, 404, DateTimeKind.Local).AddTicks(568), new DateTime(2022, 10, 19, 13, 57, 52, 404, DateTimeKind.Local).AddTicks(615) });

			migrationBuilder.UpdateData(
				table: "Customers",
				keyColumn: "Id",
				keyValue: 2,
				columns: new[] { "CreatedDate", "EntryDate", "UpdatedDate" },
				values: new object[] { new DateTime(2022, 10, 19, 13, 57, 52, 404, DateTimeKind.Local).AddTicks(625), new DateTime(2022, 10, 19, 13, 57, 52, 404, DateTimeKind.Local).AddTicks(623), new DateTime(2022, 10, 19, 13, 57, 52, 404, DateTimeKind.Local).AddTicks(627) });

			migrationBuilder.UpdateData(
				table: "ExchangeRates",
				keyColumn: "Id",
				keyValue: 1,
				column: "CreatedDate",
				value: new DateTime(2022, 10, 19, 13, 57, 52, 403, DateTimeKind.Local).AddTicks(3909));

			migrationBuilder.UpdateData(
				table: "ExchangeRates",
				keyColumn: "Id",
				keyValue: 2,
				column: "CreatedDate",
				value: new DateTime(2022, 10, 19, 13, 57, 52, 403, DateTimeKind.Local).AddTicks(3957));

			migrationBuilder.UpdateData(
				table: "ExchangeRates",
				keyColumn: "Id",
				keyValue: 3,
				column: "CreatedDate",
				value: new DateTime(2022, 10, 19, 13, 57, 52, 403, DateTimeKind.Local).AddTicks(3959));

			migrationBuilder.UpdateData(
				table: "ExchangeRates",
				keyColumn: "Id",
				keyValue: 4,
				column: "CreatedDate",
				value: new DateTime(2022, 10, 19, 13, 57, 52, 403, DateTimeKind.Local).AddTicks(3963));
		}
	}
}
