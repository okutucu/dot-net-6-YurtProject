using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Repository.Migrations
{
    public partial class mig_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerCustomerImageFile");

            migrationBuilder.DropTable(
                name: "Files");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 8, 14, 50, 9, 805, DateTimeKind.Local).AddTicks(1603), "$2a$11$MzV5/ISIe1z4ChaIpifU1ek6hqwK9Av.OONCutlNNfEVe8uteLPou", new DateTime(2022, 12, 8, 14, 50, 9, 805, DateTimeKind.Local).AddTicks(1688) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 8, 14, 50, 9, 805, DateTimeKind.Local).AddTicks(1706), "$2a$11$hQzQY8CY9QwhGgH.YwYlBOVtGlGAK0LjFCjOTizr.qhq1nOoDKFui", new DateTime(2022, 12, 8, 14, 50, 9, 805, DateTimeKind.Local).AddTicks(1712) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 12, 8, 14, 50, 9, 805, DateTimeKind.Local).AddTicks(1719), "$2a$11$bT.enlnvoZ3Vb5vICpnTHOc.DV9k5XMWcH0iaRYVvqx4Yy52iDwLy", new DateTime(2022, 12, 8, 14, 50, 9, 805, DateTimeKind.Local).AddTicks(2085) });

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 8, 14, 50, 8, 335, DateTimeKind.Local).AddTicks(7643));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 8, 14, 50, 8, 335, DateTimeKind.Local).AddTicks(7701));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 8, 14, 50, 8, 335, DateTimeKind.Local).AddTicks(7720));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 8, 14, 50, 8, 335, DateTimeKind.Local).AddTicks(7728));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Files",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Files", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomerCustomerImageFile",
                columns: table => new
                {
                    CustomerImageFilesId = table.Column<int>(type: "int", nullable: false),
                    CustomersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerCustomerImageFile", x => new { x.CustomerImageFilesId, x.CustomersId });
                    table.ForeignKey(
                        name: "FK_CustomerCustomerImageFile_Customers_CustomersId",
                        column: x => x.CustomersId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerCustomerImageFile_Files_CustomerImageFilesId",
                        column: x => x.CustomerImageFilesId,
                        principalTable: "Files",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 29, 14, 6, 32, 700, DateTimeKind.Local).AddTicks(5605), "$2a$11$cj/kQz7CSOGppjCXWkAnw.njspQ7kOTqX5kjfNAuWHUtAXY/9lGYC", new DateTime(2022, 11, 29, 14, 6, 32, 700, DateTimeKind.Local).AddTicks(5658) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 29, 14, 6, 32, 700, DateTimeKind.Local).AddTicks(5670), "$2a$11$3ZvcZGThMXn31YH/W33ts.D/ZFw6CPm6BZvEZ0qVGxb3XDOomw2Je", new DateTime(2022, 11, 29, 14, 6, 32, 700, DateTimeKind.Local).AddTicks(5673) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 29, 14, 6, 32, 700, DateTimeKind.Local).AddTicks(5677), "$2a$11$2XTtGJ5pjuVnDRYx4IISFOgPIao9O5KpACL/1FilOPeewQOv984W2", new DateTime(2022, 11, 29, 14, 6, 32, 700, DateTimeKind.Local).AddTicks(5818) });

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 29, 14, 6, 32, 63, DateTimeKind.Local).AddTicks(2510));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 29, 14, 6, 32, 63, DateTimeKind.Local).AddTicks(2566));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 29, 14, 6, 32, 63, DateTimeKind.Local).AddTicks(2582));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 29, 14, 6, 32, 63, DateTimeKind.Local).AddTicks(2589));

            migrationBuilder.CreateIndex(
                name: "IX_CustomerCustomerImageFile_CustomersId",
                table: "CustomerCustomerImageFile",
                column: "CustomersId");
        }
    }
}
