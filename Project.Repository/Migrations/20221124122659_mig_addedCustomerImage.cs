using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Repository.Migrations
{
    public partial class mig_addedCustomerImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.CreateTable(
                name: "CustomerImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerImages");

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    IncomeDetailId = table.Column<int>(type: "int", nullable: true),
                    PaymentDetailId = table.Column<int>(type: "int", nullable: true),
                    RoomIncomeId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Images_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Images_IncomeDetails_IncomeDetailId",
                        column: x => x.IncomeDetailId,
                        principalTable: "IncomeDetails",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Images_PaymentDetails_PaymentDetailId",
                        column: x => x.PaymentDetailId,
                        principalTable: "PaymentDetails",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Images_RoomIncomes_RoomIncomeId",
                        column: x => x.RoomIncomeId,
                        principalTable: "RoomIncomes",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 18, 15, 21, 0, 865, DateTimeKind.Local).AddTicks(5427), "$2a$11$4aPdFAdtLl3PSfM6/D8HQeb6.dPhtECyTwZpY24ueweCSAuzLic0C", new DateTime(2022, 11, 18, 15, 21, 0, 865, DateTimeKind.Local).AddTicks(5496) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 18, 15, 21, 0, 865, DateTimeKind.Local).AddTicks(5507), "$2a$11$Xdpx/ZAvrc/CCp2rkZrpCuisjdRgWqJaosRaa34lRsryacQzn5FrW", new DateTime(2022, 11, 18, 15, 21, 0, 865, DateTimeKind.Local).AddTicks(5509) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 18, 15, 21, 0, 865, DateTimeKind.Local).AddTicks(5512), "$2a$11$5rXRdPEDA/zq7kC5HxBkru/01dcH7DE0sRrooSk4vHx4hITXKKw42", new DateTime(2022, 11, 18, 15, 21, 0, 865, DateTimeKind.Local).AddTicks(5557) });

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 18, 15, 21, 0, 357, DateTimeKind.Local).AddTicks(9615));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 18, 15, 21, 0, 357, DateTimeKind.Local).AddTicks(9660));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 18, 15, 21, 0, 357, DateTimeKind.Local).AddTicks(9672));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 18, 15, 21, 0, 357, DateTimeKind.Local).AddTicks(9676));

            migrationBuilder.CreateIndex(
                name: "IX_Images_CustomerId",
                table: "Images",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_IncomeDetailId",
                table: "Images",
                column: "IncomeDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_PaymentDetailId",
                table: "Images",
                column: "PaymentDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_RoomIncomeId",
                table: "Images",
                column: "RoomIncomeId");
        }
    }
}
