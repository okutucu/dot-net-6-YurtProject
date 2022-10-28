using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Repository.Migrations
{
	public partial class mig_AddedAppUserSeedData : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropForeignKey(
				name: "FK_AppUserDetail_Users_AppUserId",
				table: "AppUserDetail");

			migrationBuilder.DropPrimaryKey(
				name: "PK_Users",
				table: "Users");

			migrationBuilder.DeleteData(
				table: "Customers",
				keyColumn: "Id",
				keyValue: 1);

			migrationBuilder.DeleteData(
				table: "Customers",
				keyColumn: "Id",
				keyValue: 2);

			migrationBuilder.RenameTable(
				name: "Users",
				newName: "AppUsers");

			migrationBuilder.AlterColumn<string>(
				name: "Password",
				table: "AppUsers",
				type: "nvarchar(max)",
				nullable: false,
				oldClrType: typeof(string),
				oldType: "nvarchar(20)",
				oldMaxLength: 20);

			migrationBuilder.AddPrimaryKey(
				name: "PK_AppUsers",
				table: "AppUsers",
				column: "Id");

			migrationBuilder.InsertData(
				table: "AppUsers",
				columns: new[] { "Id", "CreatedDate", "Password", "Role", "UpdatedDate", "UserName" },
				values: new object[,]
				{
					{ 1, new DateTime(2022, 10, 28, 12, 15, 6, 150, DateTimeKind.Local).AddTicks(6547), "$2a$11$EYVpXn7qtjk4UDnn7TIHEuHknbljAf61mSfuH0U13tln1K//FcLuq", 1, new DateTime(2022, 10, 28, 12, 15, 6, 150, DateTimeKind.Local).AddTicks(6613), "superadmin" },
					{ 2, new DateTime(2022, 10, 28, 12, 15, 6, 150, DateTimeKind.Local).AddTicks(6628), "$2a$11$s1ZtpWrzDmuVYvIqZVQ/rujVMiSFBK9gcCIng8XSCyZxFKEoFQfjK", 2, new DateTime(2022, 10, 28, 12, 15, 6, 150, DateTimeKind.Local).AddTicks(6632), "admin" },
					{ 3, new DateTime(2022, 10, 28, 12, 15, 6, 150, DateTimeKind.Local).AddTicks(6638), "$2a$11$XNb0P4J.zMiI00d6uxOsI.b6IPRFJS7pG2pxmsIqQoqXROib26sn6", 3, new DateTime(2022, 10, 28, 12, 15, 6, 150, DateTimeKind.Local).AddTicks(6704), "user" }
				});

			migrationBuilder.UpdateData(
				table: "ExchangeRates",
				keyColumn: "Id",
				keyValue: 1,
				column: "CreatedDate",
				value: new DateTime(2022, 10, 28, 12, 15, 5, 521, DateTimeKind.Local).AddTicks(635));

			migrationBuilder.UpdateData(
				table: "ExchangeRates",
				keyColumn: "Id",
				keyValue: 2,
				column: "CreatedDate",
				value: new DateTime(2022, 10, 28, 12, 15, 5, 521, DateTimeKind.Local).AddTicks(690));

			migrationBuilder.UpdateData(
				table: "ExchangeRates",
				keyColumn: "Id",
				keyValue: 3,
				column: "CreatedDate",
				value: new DateTime(2022, 10, 28, 12, 15, 5, 521, DateTimeKind.Local).AddTicks(695));

			migrationBuilder.UpdateData(
				table: "ExchangeRates",
				keyColumn: "Id",
				keyValue: 4,
				column: "CreatedDate",
				value: new DateTime(2022, 10, 28, 12, 15, 5, 521, DateTimeKind.Local).AddTicks(701));

			migrationBuilder.AddForeignKey(
				name: "FK_AppUserDetail_AppUsers_AppUserId",
				table: "AppUserDetail",
				column: "AppUserId",
				principalTable: "AppUsers",
				principalColumn: "Id",
				onDelete: ReferentialAction.Cascade);
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropForeignKey(
				name: "FK_AppUserDetail_AppUsers_AppUserId",
				table: "AppUserDetail");

			migrationBuilder.DropPrimaryKey(
				name: "PK_AppUsers",
				table: "AppUsers");

			migrationBuilder.DeleteData(
				table: "AppUsers",
				keyColumn: "Id",
				keyValue: 1);

			migrationBuilder.DeleteData(
				table: "AppUsers",
				keyColumn: "Id",
				keyValue: 2);

			migrationBuilder.DeleteData(
				table: "AppUsers",
				keyColumn: "Id",
				keyValue: 3);

			migrationBuilder.RenameTable(
				name: "AppUsers",
				newName: "Users");

			migrationBuilder.AlterColumn<string>(
				name: "Password",
				table: "Users",
				type: "nvarchar(20)",
				maxLength: 20,
				nullable: false,
				oldClrType: typeof(string),
				oldType: "nvarchar(max)");

			migrationBuilder.AddPrimaryKey(
				name: "PK_Users",
				table: "Users",
				column: "Id");

			migrationBuilder.InsertData(
				table: "Customers",
				columns: new[] { "Id", "CreatedDate", "Depart", "Description", "Email", "EntryDate", "FullName", "IdentityNo", "Phone", "RelativeNameSurname", "RelativePhone", "RoomId", "UniversityName", "UpdatedDate" },
				values: new object[,]
				{
					{ 1, new DateTime(2022, 10, 27, 17, 21, 21, 661, DateTimeKind.Local).AddTicks(9207), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UK", "o@kutucu.com", new DateTime(2022, 10, 27, 17, 21, 21, 661, DateTimeKind.Local).AddTicks(9153), "Oğuzhan Kutucu", "1234567", "05353073235", "Kaan Kutucu", "5555555", 1, null, new DateTime(2022, 10, 27, 17, 21, 21, 661, DateTimeKind.Local).AddTicks(9209) },
					{ 2, new DateTime(2022, 10, 27, 17, 21, 21, 661, DateTimeKind.Local).AddTicks(9220), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UK", "k@kutucu.com", new DateTime(2022, 10, 27, 17, 21, 21, 661, DateTimeKind.Local).AddTicks(9217), "Kaan Kutucu", "12345267", "5555555", "Oğuzhan Kutucu", "05353073235", 1, null, new DateTime(2022, 10, 27, 17, 21, 21, 661, DateTimeKind.Local).AddTicks(9222) }
				});

			migrationBuilder.UpdateData(
				table: "ExchangeRates",
				keyColumn: "Id",
				keyValue: 1,
				column: "CreatedDate",
				value: new DateTime(2022, 10, 27, 17, 21, 21, 660, DateTimeKind.Local).AddTicks(8723));

			migrationBuilder.UpdateData(
				table: "ExchangeRates",
				keyColumn: "Id",
				keyValue: 2,
				column: "CreatedDate",
				value: new DateTime(2022, 10, 27, 17, 21, 21, 660, DateTimeKind.Local).AddTicks(8782));

			migrationBuilder.UpdateData(
				table: "ExchangeRates",
				keyColumn: "Id",
				keyValue: 3,
				column: "CreatedDate",
				value: new DateTime(2022, 10, 27, 17, 21, 21, 660, DateTimeKind.Local).AddTicks(8786));

			migrationBuilder.UpdateData(
				table: "ExchangeRates",
				keyColumn: "Id",
				keyValue: 4,
				column: "CreatedDate",
				value: new DateTime(2022, 10, 27, 17, 21, 21, 660, DateTimeKind.Local).AddTicks(8792));

			migrationBuilder.AddForeignKey(
				name: "FK_AppUserDetail_Users_AppUserId",
				table: "AppUserDetail",
				column: "AppUserId",
				principalTable: "Users",
				principalColumn: "Id",
				onDelete: ReferentialAction.Cascade);
		}
	}
}
