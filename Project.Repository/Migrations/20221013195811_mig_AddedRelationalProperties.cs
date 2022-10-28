using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Repository.Migrations
{
	public partial class mig_AddedRelationalProperties : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.AddColumn<int>(
				name: "RoomId",
				table: "IncomeDetails",
				type: "int",
				nullable: true);

			migrationBuilder.UpdateData(
				table: "Customers",
				keyColumn: "Id",
				keyValue: 1,
				columns: new[] { "CreatedDate", "EntryDate", "UpdatedDate" },
				values: new object[] { new DateTime(2022, 10, 13, 22, 58, 11, 15, DateTimeKind.Local).AddTicks(4007), new DateTime(2022, 10, 13, 22, 58, 11, 15, DateTimeKind.Local).AddTicks(4000), new DateTime(2022, 10, 13, 22, 58, 11, 15, DateTimeKind.Local).AddTicks(4009) });

			migrationBuilder.UpdateData(
				table: "Customers",
				keyColumn: "Id",
				keyValue: 2,
				columns: new[] { "CreatedDate", "EntryDate", "UpdatedDate" },
				values: new object[] { new DateTime(2022, 10, 13, 22, 58, 11, 15, DateTimeKind.Local).AddTicks(4016), new DateTime(2022, 10, 13, 22, 58, 11, 15, DateTimeKind.Local).AddTicks(4015), new DateTime(2022, 10, 13, 22, 58, 11, 15, DateTimeKind.Local).AddTicks(4017) });

			migrationBuilder.UpdateData(
				table: "ExchangeRates",
				keyColumn: "Id",
				keyValue: 1,
				column: "CreatedDate",
				value: new DateTime(2022, 10, 13, 22, 58, 11, 14, DateTimeKind.Local).AddTicks(8055));

			migrationBuilder.UpdateData(
				table: "ExchangeRates",
				keyColumn: "Id",
				keyValue: 2,
				column: "CreatedDate",
				value: new DateTime(2022, 10, 13, 22, 58, 11, 14, DateTimeKind.Local).AddTicks(8066));

			migrationBuilder.UpdateData(
				table: "ExchangeRates",
				keyColumn: "Id",
				keyValue: 3,
				column: "CreatedDate",
				value: new DateTime(2022, 10, 13, 22, 58, 11, 14, DateTimeKind.Local).AddTicks(8067));

			migrationBuilder.UpdateData(
				table: "ExchangeRates",
				keyColumn: "Id",
				keyValue: 4,
				column: "CreatedDate",
				value: new DateTime(2022, 10, 13, 22, 58, 11, 14, DateTimeKind.Local).AddTicks(8069));

			migrationBuilder.CreateIndex(
				name: "IX_IncomeDetails_RoomId",
				table: "IncomeDetails",
				column: "RoomId");

			migrationBuilder.AddForeignKey(
				name: "FK_IncomeDetails_Rooms_RoomId",
				table: "IncomeDetails",
				column: "RoomId",
				principalTable: "Rooms",
				principalColumn: "Id");
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropForeignKey(
				name: "FK_IncomeDetails_Rooms_RoomId",
				table: "IncomeDetails");

			migrationBuilder.DropIndex(
				name: "IX_IncomeDetails_RoomId",
				table: "IncomeDetails");

			migrationBuilder.DropColumn(
				name: "RoomId",
				table: "IncomeDetails");

			migrationBuilder.UpdateData(
				table: "Customers",
				keyColumn: "Id",
				keyValue: 1,
				columns: new[] { "CreatedDate", "EntryDate", "UpdatedDate" },
				values: new object[] { new DateTime(2022, 10, 13, 17, 13, 47, 496, DateTimeKind.Local).AddTicks(114), new DateTime(2022, 10, 13, 17, 13, 47, 496, DateTimeKind.Local).AddTicks(108), new DateTime(2022, 10, 13, 17, 13, 47, 496, DateTimeKind.Local).AddTicks(115) });

			migrationBuilder.UpdateData(
				table: "Customers",
				keyColumn: "Id",
				keyValue: 2,
				columns: new[] { "CreatedDate", "EntryDate", "UpdatedDate" },
				values: new object[] { new DateTime(2022, 10, 13, 17, 13, 47, 496, DateTimeKind.Local).AddTicks(125), new DateTime(2022, 10, 13, 17, 13, 47, 496, DateTimeKind.Local).AddTicks(124), new DateTime(2022, 10, 13, 17, 13, 47, 496, DateTimeKind.Local).AddTicks(126) });

			migrationBuilder.UpdateData(
				table: "ExchangeRates",
				keyColumn: "Id",
				keyValue: 1,
				column: "CreatedDate",
				value: new DateTime(2022, 10, 13, 17, 13, 47, 495, DateTimeKind.Local).AddTicks(508));

			migrationBuilder.UpdateData(
				table: "ExchangeRates",
				keyColumn: "Id",
				keyValue: 2,
				column: "CreatedDate",
				value: new DateTime(2022, 10, 13, 17, 13, 47, 495, DateTimeKind.Local).AddTicks(518));

			migrationBuilder.UpdateData(
				table: "ExchangeRates",
				keyColumn: "Id",
				keyValue: 3,
				column: "CreatedDate",
				value: new DateTime(2022, 10, 13, 17, 13, 47, 495, DateTimeKind.Local).AddTicks(519));

			migrationBuilder.UpdateData(
				table: "ExchangeRates",
				keyColumn: "Id",
				keyValue: 4,
				column: "CreatedDate",
				value: new DateTime(2022, 10, 13, 17, 13, 47, 495, DateTimeKind.Local).AddTicks(522));
		}
	}
}
