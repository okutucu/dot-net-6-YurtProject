using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Repository.Migrations
{
    public partial class mig_AddedrelationalcustomerCrossTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Storage",
                table: "Files");

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
                values: new object[] { new DateTime(2022, 11, 28, 12, 49, 10, 729, DateTimeKind.Local).AddTicks(4860), "$2a$11$6.1NhhQ.IJLM.geodBTAper6qewZ/MzzykZaLPFRoy3z6.Oh8gMCS", new DateTime(2022, 11, 28, 12, 49, 10, 729, DateTimeKind.Local).AddTicks(4914) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 28, 12, 49, 10, 729, DateTimeKind.Local).AddTicks(4924), "$2a$11$BJXiFsn8LdEs3MskFa66c.Ml7iuLfbwc3r6kGvS.JOu0JxBVrOr.u", new DateTime(2022, 11, 28, 12, 49, 10, 729, DateTimeKind.Local).AddTicks(4930) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 28, 12, 49, 10, 729, DateTimeKind.Local).AddTicks(4933), "$2a$11$Qfd52wt4Q.MVv7N1LapJ5uEWNQir60d.Q/h0saUA.RMIYLyVjeoOi", new DateTime(2022, 11, 28, 12, 49, 10, 729, DateTimeKind.Local).AddTicks(4984) });

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 28, 12, 49, 10, 180, DateTimeKind.Local).AddTicks(3603));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 28, 12, 49, 10, 180, DateTimeKind.Local).AddTicks(3667));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 28, 12, 49, 10, 180, DateTimeKind.Local).AddTicks(3678));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 28, 12, 49, 10, 180, DateTimeKind.Local).AddTicks(3683));

            migrationBuilder.CreateIndex(
                name: "IX_CustomerCustomerImageFile_CustomersId",
                table: "CustomerCustomerImageFile",
                column: "CustomersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerCustomerImageFile");

            migrationBuilder.AddColumn<string>(
                name: "Storage",
                table: "Files",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 28, 12, 43, 3, 57, DateTimeKind.Local).AddTicks(9267), "$2a$11$mppsQkqSZfkTGRDOgFR7uuhCHs9ZmVNpTE4g8OnqyYEQm8vi1Uadm", new DateTime(2022, 11, 28, 12, 43, 3, 57, DateTimeKind.Local).AddTicks(9321) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 28, 12, 43, 3, 57, DateTimeKind.Local).AddTicks(9336), "$2a$11$fdnuVP5o.15dEinla0Ogl.W5Tr3lrhI4ksj.SDFgNhglUZeLA4ri.", new DateTime(2022, 11, 28, 12, 43, 3, 57, DateTimeKind.Local).AddTicks(9339) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 28, 12, 43, 3, 57, DateTimeKind.Local).AddTicks(9343), "$2a$11$mnglthGlZQ4GQmZmP4WlxeNZ49Axu09Md3KkwI75M/ikF7sH5fR.m", new DateTime(2022, 11, 28, 12, 43, 3, 57, DateTimeKind.Local).AddTicks(9416) });

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 28, 12, 43, 2, 437, DateTimeKind.Local).AddTicks(9277));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 28, 12, 43, 2, 437, DateTimeKind.Local).AddTicks(9332));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 28, 12, 43, 2, 437, DateTimeKind.Local).AddTicks(9343));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 28, 12, 43, 2, 437, DateTimeKind.Local).AddTicks(9349));
        }
    }
}
