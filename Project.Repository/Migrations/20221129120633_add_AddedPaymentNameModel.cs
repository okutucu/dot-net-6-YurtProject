using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Repository.Migrations
{
    public partial class add_AddedPaymentNameModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PaymentName",
                table: "PaymentDetails");

            migrationBuilder.DropColumn(
                name: "PaymentName",
                table: "IncomeDetails");

            migrationBuilder.AddColumn<int>(
                name: "PaymentNameId",
                table: "PaymentDetails",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PaymentNameId",
                table: "IncomeDetails",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PaymentNames",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentNames", x => x.Id);
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
                name: "IX_PaymentDetails_PaymentNameId",
                table: "PaymentDetails",
                column: "PaymentNameId");

            migrationBuilder.CreateIndex(
                name: "IX_IncomeDetails_PaymentNameId",
                table: "IncomeDetails",
                column: "PaymentNameId");

            migrationBuilder.AddForeignKey(
                name: "FK_IncomeDetails_PaymentNames_PaymentNameId",
                table: "IncomeDetails",
                column: "PaymentNameId",
                principalTable: "PaymentNames",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentDetails_PaymentNames_PaymentNameId",
                table: "PaymentDetails",
                column: "PaymentNameId",
                principalTable: "PaymentNames",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IncomeDetails_PaymentNames_PaymentNameId",
                table: "IncomeDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentDetails_PaymentNames_PaymentNameId",
                table: "PaymentDetails");

            migrationBuilder.DropTable(
                name: "PaymentNames");

            migrationBuilder.DropIndex(
                name: "IX_PaymentDetails_PaymentNameId",
                table: "PaymentDetails");

            migrationBuilder.DropIndex(
                name: "IX_IncomeDetails_PaymentNameId",
                table: "IncomeDetails");

            migrationBuilder.DropColumn(
                name: "PaymentNameId",
                table: "PaymentDetails");

            migrationBuilder.DropColumn(
                name: "PaymentNameId",
                table: "IncomeDetails");

            migrationBuilder.AddColumn<int>(
                name: "PaymentName",
                table: "PaymentDetails",
                type: "int",
                maxLength: 20,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PaymentName",
                table: "IncomeDetails",
                type: "int",
                maxLength: 20,
                nullable: false,
                defaultValue: 0);

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
        }
    }
}
