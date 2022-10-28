using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Repository.Migrations
{
	public partial class mig_RoomPrice : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DeleteData(
				table: "Rooms",
				keyColumn: "Id",
				keyValue: 1);

			migrationBuilder.DeleteData(
				table: "Rooms",
				keyColumn: "Id",
				keyValue: 2);

			migrationBuilder.DropColumn(
				name: "Price",
				table: "Rooms");

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

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.AddColumn<decimal>(
				name: "Price",
				table: "Rooms",
				type: "decimal(18,2)",
				nullable: false,
				defaultValue: 0m);

			migrationBuilder.UpdateData(
				table: "Customers",
				keyColumn: "Id",
				keyValue: 1,
				columns: new[] { "CreatedDate", "EntryDate", "UpdatedDate" },
				values: new object[] { new DateTime(2022, 10, 18, 15, 24, 48, 475, DateTimeKind.Local).AddTicks(7099), new DateTime(2022, 10, 18, 15, 24, 48, 475, DateTimeKind.Local).AddTicks(7081), new DateTime(2022, 10, 18, 15, 24, 48, 475, DateTimeKind.Local).AddTicks(7102) });

			migrationBuilder.UpdateData(
				table: "Customers",
				keyColumn: "Id",
				keyValue: 2,
				columns: new[] { "CreatedDate", "EntryDate", "UpdatedDate" },
				values: new object[] { new DateTime(2022, 10, 18, 15, 24, 48, 475, DateTimeKind.Local).AddTicks(7113), new DateTime(2022, 10, 18, 15, 24, 48, 475, DateTimeKind.Local).AddTicks(7110), new DateTime(2022, 10, 18, 15, 24, 48, 475, DateTimeKind.Local).AddTicks(7116) });

			migrationBuilder.UpdateData(
				table: "ExchangeRates",
				keyColumn: "Id",
				keyValue: 1,
				column: "CreatedDate",
				value: new DateTime(2022, 10, 18, 15, 24, 48, 474, DateTimeKind.Local).AddTicks(8823));

			migrationBuilder.UpdateData(
				table: "ExchangeRates",
				keyColumn: "Id",
				keyValue: 2,
				column: "CreatedDate",
				value: new DateTime(2022, 10, 18, 15, 24, 48, 474, DateTimeKind.Local).AddTicks(8863));

			migrationBuilder.UpdateData(
				table: "ExchangeRates",
				keyColumn: "Id",
				keyValue: 3,
				column: "CreatedDate",
				value: new DateTime(2022, 10, 18, 15, 24, 48, 474, DateTimeKind.Local).AddTicks(8866));

			migrationBuilder.UpdateData(
				table: "ExchangeRates",
				keyColumn: "Id",
				keyValue: 4,
				column: "CreatedDate",
				value: new DateTime(2022, 10, 18, 15, 24, 48, 474, DateTimeKind.Local).AddTicks(8871));

			migrationBuilder.InsertData(
				table: "Rooms",
				columns: new[] { "Id", "Capacity", "CreatedDate", "CurrentCapacity", "Debt", "Lack", "LackDetail", "Price", "RoomName", "RoomTypeId", "UpdatedDate" },
				values: new object[,]
				{
					{ 1, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0m, true, "TV is broken", 1300m, "1000", null, null },
					{ 2, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 0m, false, null, 1500m, "1001", null, null }
				});
		}
	}
}
