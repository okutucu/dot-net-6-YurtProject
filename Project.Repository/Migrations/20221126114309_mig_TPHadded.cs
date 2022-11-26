using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Repository.Migrations
{
    public partial class mig_TPHadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerImages");

            migrationBuilder.CreateTable(
                name: "Files",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Files", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 26, 13, 43, 8, 889, DateTimeKind.Local).AddTicks(2434), "$2a$11$LCDL5t4zt8L7tB7d17uuDuTohISEVA6C4qS1H.4JAqwYtktQhwuzm", new DateTime(2022, 11, 26, 13, 43, 8, 889, DateTimeKind.Local).AddTicks(2502) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 26, 13, 43, 8, 889, DateTimeKind.Local).AddTicks(2518), "$2a$11$WM9EudUnbZUYhp6kLn0oS.nGF83mVpfgvJVLiFm7Afcybu6pJNArK", new DateTime(2022, 11, 26, 13, 43, 8, 889, DateTimeKind.Local).AddTicks(2522) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 26, 13, 43, 8, 889, DateTimeKind.Local).AddTicks(2527), "$2a$11$9VV1X5kK36y633bIBBWIVe6ozc1nHbajh5Mc7qGrxErUHDhcQHbZW", new DateTime(2022, 11, 26, 13, 43, 8, 889, DateTimeKind.Local).AddTicks(2688) });

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 26, 13, 43, 8, 127, DateTimeKind.Local).AddTicks(6158));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 26, 13, 43, 8, 127, DateTimeKind.Local).AddTicks(6220));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 26, 13, 43, 8, 127, DateTimeKind.Local).AddTicks(6233));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 26, 13, 43, 8, 127, DateTimeKind.Local).AddTicks(6239));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Files");

            migrationBuilder.CreateTable(
                name: "CustomerImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerImages_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 24, 14, 26, 58, 667, DateTimeKind.Local).AddTicks(824), "$2a$11$670DeEepdxgCCQQzTZbs0udvFi6GfEkkqWEewXGxSTrz3p00NhVAq", new DateTime(2022, 11, 24, 14, 26, 58, 667, DateTimeKind.Local).AddTicks(879) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 24, 14, 26, 58, 667, DateTimeKind.Local).AddTicks(888), "$2a$11$7Q7NrcKjXQNrZC/McxSXbugTYFp7wKa2aBDmcJo55lSMVM2EOImUm", new DateTime(2022, 11, 24, 14, 26, 58, 667, DateTimeKind.Local).AddTicks(890) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 24, 14, 26, 58, 667, DateTimeKind.Local).AddTicks(893), "$2a$11$Lv.hab8ys8teYUgcuc6DeOe.MPLTv2MITt0ffynBZnRGekv31XH5m", new DateTime(2022, 11, 24, 14, 26, 58, 667, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 24, 14, 26, 57, 989, DateTimeKind.Local).AddTicks(2297));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 24, 14, 26, 57, 989, DateTimeKind.Local).AddTicks(2365));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 24, 14, 26, 57, 989, DateTimeKind.Local).AddTicks(2382));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 24, 14, 26, 57, 989, DateTimeKind.Local).AddTicks(2389));

            migrationBuilder.CreateIndex(
                name: "IX_CustomerImages_CustomerId",
                table: "CustomerImages",
                column: "CustomerId");
        }
    }
}
