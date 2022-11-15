using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Repository.Migrations
{
    public partial class mig_AddpicturesListonRoom : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FileName",
                table: "Rooms",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 15, 17, 7, 44, 447, DateTimeKind.Local).AddTicks(4224), "$2a$11$svfOK50bDG3VNFDtQO4P7.s1PmvhNeiuhwAtoLRh48CrWkkVOHEQO", new DateTime(2022, 11, 15, 17, 7, 44, 447, DateTimeKind.Local).AddTicks(4287) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 15, 17, 7, 44, 447, DateTimeKind.Local).AddTicks(4299), "$2a$11$bQOwtX/u5.8CL04Mi7sncuVbNXYpDgyA0DxXwdxpgmXAscVWkHGwG", new DateTime(2022, 11, 15, 17, 7, 44, 447, DateTimeKind.Local).AddTicks(4301) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 15, 17, 7, 44, 447, DateTimeKind.Local).AddTicks(4304), "$2a$11$6mQDMyWbFZX5YHIDn94K4udjd2n.kRWXiZlyiX8hfE5YkXkiNoDiO", new DateTime(2022, 11, 15, 17, 7, 44, 447, DateTimeKind.Local).AddTicks(4429) });

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 15, 17, 7, 43, 843, DateTimeKind.Local).AddTicks(4506));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 15, 17, 7, 43, 843, DateTimeKind.Local).AddTicks(4571));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 15, 17, 7, 43, 843, DateTimeKind.Local).AddTicks(4585));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 15, 17, 7, 43, 843, DateTimeKind.Local).AddTicks(4594));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FileName",
                table: "Rooms");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 14, 16, 36, 17, 906, DateTimeKind.Local).AddTicks(416), "$2a$11$nDw8Ci8o9isdvgpWV84nxuepOz8uxxVnefIVYLZApayty335uvJuK", new DateTime(2022, 11, 14, 16, 36, 17, 906, DateTimeKind.Local).AddTicks(477) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 14, 16, 36, 17, 906, DateTimeKind.Local).AddTicks(489), "$2a$11$N4SP/dVPxpicHmp/Hom14.qXx0kWF6oMQjkFMT3MIVdfhcDeo7IKC", new DateTime(2022, 11, 14, 16, 36, 17, 906, DateTimeKind.Local).AddTicks(492) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 14, 16, 36, 17, 906, DateTimeKind.Local).AddTicks(495), "$2a$11$Sw1yw/98zaBoYrCGaT29r.VaRbKVQXS9w9YXx.Fta1GWJ/xUYB5j2", new DateTime(2022, 11, 14, 16, 36, 17, 906, DateTimeKind.Local).AddTicks(602) });

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 14, 16, 36, 17, 351, DateTimeKind.Local).AddTicks(5395));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 14, 16, 36, 17, 351, DateTimeKind.Local).AddTicks(5441));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 14, 16, 36, 17, 351, DateTimeKind.Local).AddTicks(5452));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 14, 16, 36, 17, 351, DateTimeKind.Local).AddTicks(5457));
        }
    }
}
