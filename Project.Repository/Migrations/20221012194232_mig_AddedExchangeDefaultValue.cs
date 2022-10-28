using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Repository.Migrations
{
	public partial class mig_AddedExchangeDefaultValue : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropColumn(
				name: "IncomeName",
				table: "IncomeDetails");

			migrationBuilder.AlterColumn<int>(
				name: "PaymentName",
				table: "PaymentDetails",
				type: "int",
				maxLength: 20,
				nullable: false,
				oldClrType: typeof(string),
				oldType: "nvarchar(20)",
				oldMaxLength: 20);

			migrationBuilder.AddColumn<int>(
				name: "PaymentName",
				table: "IncomeDetails",
				type: "int",
				maxLength: 20,
				nullable: false,
				defaultValue: 0);

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

			migrationBuilder.InsertData(
				table: "ExchangeRates",
				columns: new[] { "Id", "CreatedDate", "ExchangeName", "Price", "UpdatedDate" },
				values: new object[,]
				{
					{ 1, new DateTime(2022, 10, 12, 22, 42, 31, 956, DateTimeKind.Local).AddTicks(5629), "Dollar", 10m, null },
					{ 2, new DateTime(2022, 10, 12, 22, 42, 31, 956, DateTimeKind.Local).AddTicks(5642), "Euro", 10m, null },
					{ 3, new DateTime(2022, 10, 12, 22, 42, 31, 956, DateTimeKind.Local).AddTicks(5644), "Sterling", 10m, null }
				});
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DeleteData(
				table: "ExchangeRates",
				keyColumn: "Id",
				keyValue: 1);

			migrationBuilder.DeleteData(
				table: "ExchangeRates",
				keyColumn: "Id",
				keyValue: 2);

			migrationBuilder.DeleteData(
				table: "ExchangeRates",
				keyColumn: "Id",
				keyValue: 3);

			migrationBuilder.DropColumn(
				name: "PaymentName",
				table: "IncomeDetails");

			migrationBuilder.AlterColumn<string>(
				name: "PaymentName",
				table: "PaymentDetails",
				type: "nvarchar(20)",
				maxLength: 20,
				nullable: false,
				oldClrType: typeof(int),
				oldType: "int",
				oldMaxLength: 20);

			migrationBuilder.AddColumn<string>(
				name: "IncomeName",
				table: "IncomeDetails",
				type: "nvarchar(20)",
				maxLength: 20,
				nullable: false,
				defaultValue: "");

			migrationBuilder.UpdateData(
				table: "Customers",
				keyColumn: "Id",
				keyValue: 1,
				columns: new[] { "CreatedDate", "EntryDate", "UpdatedDate" },
				values: new object[] { new DateTime(2022, 10, 12, 21, 53, 39, 726, DateTimeKind.Local).AddTicks(4669), new DateTime(2022, 10, 12, 21, 53, 39, 726, DateTimeKind.Local).AddTicks(4658), new DateTime(2022, 10, 12, 21, 53, 39, 726, DateTimeKind.Local).AddTicks(4670) });

			migrationBuilder.UpdateData(
				table: "Customers",
				keyColumn: "Id",
				keyValue: 2,
				columns: new[] { "CreatedDate", "EntryDate", "UpdatedDate" },
				values: new object[] { new DateTime(2022, 10, 12, 21, 53, 39, 726, DateTimeKind.Local).AddTicks(4676), new DateTime(2022, 10, 12, 21, 53, 39, 726, DateTimeKind.Local).AddTicks(4675), new DateTime(2022, 10, 12, 21, 53, 39, 726, DateTimeKind.Local).AddTicks(4677) });
		}
	}
}
