using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Repository.Migrations
{
	public partial class mig_AddedEnums : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.AlterColumn<int>(
				name: "PaymentMethod",
				table: "RoomIncomes",
				type: "int",
				maxLength: 20,
				nullable: false,
				oldClrType: typeof(string),
				oldType: "nvarchar(20)",
				oldMaxLength: 20);

			migrationBuilder.AlterColumn<int>(
				name: "Exchange",
				table: "RoomIncomes",
				type: "int",
				maxLength: 20,
				nullable: false,
				oldClrType: typeof(string),
				oldType: "nvarchar(20)",
				oldMaxLength: 20);

			migrationBuilder.AlterColumn<int>(
				name: "PaymentMethod",
				table: "PaymentDetails",
				type: "int",
				maxLength: 20,
				nullable: false,
				oldClrType: typeof(string),
				oldType: "nvarchar(20)",
				oldMaxLength: 20);

			migrationBuilder.AlterColumn<int>(
				name: "Exchange",
				table: "PaymentDetails",
				type: "int",
				maxLength: 20,
				nullable: false,
				oldClrType: typeof(string),
				oldType: "nvarchar(20)",
				oldMaxLength: 20);

			migrationBuilder.AlterColumn<int>(
				name: "PaymentMethod",
				table: "IncomeDetails",
				type: "int",
				maxLength: 20,
				nullable: false,
				oldClrType: typeof(string),
				oldType: "nvarchar(20)",
				oldMaxLength: 20);

			migrationBuilder.AlterColumn<int>(
				name: "Exchange",
				table: "IncomeDetails",
				type: "int",
				maxLength: 20,
				nullable: false,
				oldClrType: typeof(string),
				oldType: "nvarchar(20)",
				oldMaxLength: 20);

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

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.AlterColumn<string>(
				name: "PaymentMethod",
				table: "RoomIncomes",
				type: "nvarchar(20)",
				maxLength: 20,
				nullable: false,
				oldClrType: typeof(int),
				oldType: "int",
				oldMaxLength: 20);

			migrationBuilder.AlterColumn<string>(
				name: "Exchange",
				table: "RoomIncomes",
				type: "nvarchar(20)",
				maxLength: 20,
				nullable: false,
				oldClrType: typeof(int),
				oldType: "int",
				oldMaxLength: 20);

			migrationBuilder.AlterColumn<string>(
				name: "PaymentMethod",
				table: "PaymentDetails",
				type: "nvarchar(20)",
				maxLength: 20,
				nullable: false,
				oldClrType: typeof(int),
				oldType: "int",
				oldMaxLength: 20);

			migrationBuilder.AlterColumn<string>(
				name: "Exchange",
				table: "PaymentDetails",
				type: "nvarchar(20)",
				maxLength: 20,
				nullable: false,
				oldClrType: typeof(int),
				oldType: "int",
				oldMaxLength: 20);

			migrationBuilder.AlterColumn<string>(
				name: "PaymentMethod",
				table: "IncomeDetails",
				type: "nvarchar(20)",
				maxLength: 20,
				nullable: false,
				oldClrType: typeof(int),
				oldType: "int",
				oldMaxLength: 20);

			migrationBuilder.AlterColumn<string>(
				name: "Exchange",
				table: "IncomeDetails",
				type: "nvarchar(20)",
				maxLength: 20,
				nullable: false,
				oldClrType: typeof(int),
				oldType: "int",
				oldMaxLength: 20);

			migrationBuilder.UpdateData(
				table: "Customers",
				keyColumn: "Id",
				keyValue: 1,
				columns: new[] { "CreatedDate", "EntryDate", "UpdatedDate" },
				values: new object[] { new DateTime(2022, 10, 8, 20, 48, 11, 922, DateTimeKind.Local).AddTicks(2321), new DateTime(2022, 10, 8, 20, 48, 11, 922, DateTimeKind.Local).AddTicks(2306), new DateTime(2022, 10, 8, 20, 48, 11, 922, DateTimeKind.Local).AddTicks(2322) });

			migrationBuilder.UpdateData(
				table: "Customers",
				keyColumn: "Id",
				keyValue: 2,
				columns: new[] { "CreatedDate", "EntryDate", "UpdatedDate" },
				values: new object[] { new DateTime(2022, 10, 8, 20, 48, 11, 922, DateTimeKind.Local).AddTicks(2332), new DateTime(2022, 10, 8, 20, 48, 11, 922, DateTimeKind.Local).AddTicks(2331), new DateTime(2022, 10, 8, 20, 48, 11, 922, DateTimeKind.Local).AddTicks(2333) });
		}
	}
}
