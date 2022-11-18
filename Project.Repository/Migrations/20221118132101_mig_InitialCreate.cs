using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Repository.Migrations
{
    public partial class mig_InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<int>(type: "int", maxLength: 15, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExchangeRates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExchangeName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExchangeRates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Records",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RoomName = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    IdentityNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    EntryDate = table.Column<DateTime>(type: "date", nullable: false),
                    Depart = table.Column<DateTime>(type: "date", nullable: false),
                    RelativeNameSurname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RelativePhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UniversityName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Records", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "AppUserDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Identity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppUserDetail_AppUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Capacity = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    CurrentCapacity = table.Column<int>(type: "int", nullable: false),
                    Debt = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Lack = table.Column<bool>(type: "bit", nullable: false),
                    LackDetail = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    RoomTypeId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rooms_RoomType_RoomTypeId",
                        column: x => x.RoomTypeId,
                        principalTable: "RoomType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IdentityNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    EntryDate = table.Column<DateTime>(type: "date", nullable: false),
                    Depart = table.Column<DateTime>(type: "date", nullable: false),
                    RelativeNameSurname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RelativePhone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    UniversityName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    DownPayment = table.Column<bool>(type: "bit", nullable: false),
                    DownPaymentPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discount = table.Column<bool>(type: "bit", nullable: false),
                    DiscountPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RoomId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "date", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "IncomeDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentName = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    RoomId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Exchange = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "date", nullable: false),
                    MoneyOfTheDay = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentMethod = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncomeDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IncomeDetails_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PaymentDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentName = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    RoomId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Exchange = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "date", nullable: false),
                    MoneyOfTheDay = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentMethod = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentDetails_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RoomIncomes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Exchange = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "date", nullable: false),
                    MoneyOfTheDay = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentMethod = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomIncomes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoomIncomes_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoomIncomeId = table.Column<int>(type: "int", nullable: true),
                    IncomeDetailId = table.Column<int>(type: "int", nullable: true),
                    PaymentDetailId = table.Column<int>(type: "int", nullable: true),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
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

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "CreatedDate", "Password", "Role", "UpdatedDate", "UserName" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 11, 18, 15, 21, 0, 865, DateTimeKind.Local).AddTicks(5427), "$2a$11$4aPdFAdtLl3PSfM6/D8HQeb6.dPhtECyTwZpY24ueweCSAuzLic0C", 1, new DateTime(2022, 11, 18, 15, 21, 0, 865, DateTimeKind.Local).AddTicks(5496), "superadmin" },
                    { 2, new DateTime(2022, 11, 18, 15, 21, 0, 865, DateTimeKind.Local).AddTicks(5507), "$2a$11$Xdpx/ZAvrc/CCp2rkZrpCuisjdRgWqJaosRaa34lRsryacQzn5FrW", 2, new DateTime(2022, 11, 18, 15, 21, 0, 865, DateTimeKind.Local).AddTicks(5509), "admin" },
                    { 3, new DateTime(2022, 11, 18, 15, 21, 0, 865, DateTimeKind.Local).AddTicks(5512), "$2a$11$5rXRdPEDA/zq7kC5HxBkru/01dcH7DE0sRrooSk4vHx4hITXKKw42", 3, new DateTime(2022, 11, 18, 15, 21, 0, 865, DateTimeKind.Local).AddTicks(5557), "user" }
                });

            migrationBuilder.InsertData(
                table: "ExchangeRates",
                columns: new[] { "Id", "CreatedDate", "ExchangeName", "Price", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 11, 18, 15, 21, 0, 357, DateTimeKind.Local).AddTicks(9615), "Dollar", 10m, null },
                    { 2, new DateTime(2022, 11, 18, 15, 21, 0, 357, DateTimeKind.Local).AddTicks(9660), "Euro", 10m, null },
                    { 3, new DateTime(2022, 11, 18, 15, 21, 0, 357, DateTimeKind.Local).AddTicks(9672), "Sterling", 10m, null },
                    { 4, new DateTime(2022, 11, 18, 15, 21, 0, 357, DateTimeKind.Local).AddTicks(9676), "Tl", 1m, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppUserDetail_AppUserId",
                table: "AppUserDetail",
                column: "AppUserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_RoomId",
                table: "Customers",
                column: "RoomId");

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

            migrationBuilder.CreateIndex(
                name: "IX_IncomeDetails_RoomId",
                table: "IncomeDetails",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentDetails_RoomId",
                table: "PaymentDetails",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomIncomes_RoomId",
                table: "RoomIncomes",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_RoomTypeId",
                table: "Rooms",
                column: "RoomTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppUserDetail");

            migrationBuilder.DropTable(
                name: "ExchangeRates");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "Records");

            migrationBuilder.DropTable(
                name: "AppUsers");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "IncomeDetails");

            migrationBuilder.DropTable(
                name: "PaymentDetails");

            migrationBuilder.DropTable(
                name: "RoomIncomes");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "RoomType");
        }
    }
}
