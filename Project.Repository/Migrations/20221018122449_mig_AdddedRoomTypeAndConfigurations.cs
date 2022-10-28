using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Repository.Migrations
{
	public partial class mig_AdddedRoomTypeAndConfigurations : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropColumn(
				name: "RoomType",
				table: "Rooms");

			migrationBuilder.AddColumn<int>(
				name: "RoomTypeId",
				table: "Rooms",
				type: "int",
				nullable: true);

			migrationBuilder.CreateTable(
				name: "RoomType",
				columns: table => new
				{
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					RoomName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
					IncreasedPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
					Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
					CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
					UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_RoomType", x => x.Id);
				});

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

			migrationBuilder.CreateIndex(
				name: "IX_Rooms_RoomTypeId",
				table: "Rooms",
				column: "RoomTypeId");

			migrationBuilder.AddForeignKey(
				name: "FK_Rooms_RoomType_RoomTypeId",
				table: "Rooms",
				column: "RoomTypeId",
				principalTable: "RoomType",
				principalColumn: "Id");
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropForeignKey(
				name: "FK_Rooms_RoomType_RoomTypeId",
				table: "Rooms");

			migrationBuilder.DropTable(
				name: "RoomType");

			migrationBuilder.DropIndex(
				name: "IX_Rooms_RoomTypeId",
				table: "Rooms");

			migrationBuilder.DropColumn(
				name: "RoomTypeId",
				table: "Rooms");

			migrationBuilder.AddColumn<string>(
				name: "RoomType",
				table: "Rooms",
				type: "nvarchar(20)",
				maxLength: 20,
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

			migrationBuilder.UpdateData(
				table: "Rooms",
				keyColumn: "Id",
				keyValue: 1,
				column: "RoomType",
				value: "Economy");

			migrationBuilder.UpdateData(
				table: "Rooms",
				keyColumn: "Id",
				keyValue: 2,
				column: "RoomType",
				value: "Luxery");
		}
	}
}
