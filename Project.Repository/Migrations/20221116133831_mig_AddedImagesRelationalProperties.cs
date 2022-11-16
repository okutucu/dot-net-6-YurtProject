using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Repository.Migrations
{
    public partial class mig_AddedImagesRelationalProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FileName",
                table: "Rooms");

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoomId = table.Column<int>(type: "int", nullable: false),
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
                        name: "FK_Images_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 16, 15, 38, 30, 991, DateTimeKind.Local).AddTicks(8621), "$2a$11$BrVABfdC0IYXSxG.bL8VgeYbt5aAPl65wgfhXcl4fLBad9PTxFVzy", new DateTime(2022, 11, 16, 15, 38, 30, 991, DateTimeKind.Local).AddTicks(8678) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 16, 15, 38, 30, 991, DateTimeKind.Local).AddTicks(8691), "$2a$11$eKn/A8q7mwLJFrCwwOAj.OQ/Ny7AwhRZXVuoAHgk0dNy5OVLBihdm", new DateTime(2022, 11, 16, 15, 38, 30, 991, DateTimeKind.Local).AddTicks(8694) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 11, 16, 15, 38, 30, 991, DateTimeKind.Local).AddTicks(8697), "$2a$11$01ABZIIC2nBBdLpSff8UcO3fuMKIz/sefl2x11F/MVhOvIb0J1WX2", new DateTime(2022, 11, 16, 15, 38, 30, 991, DateTimeKind.Local).AddTicks(8745) });

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 16, 15, 38, 30, 430, DateTimeKind.Local).AddTicks(3812));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 16, 15, 38, 30, 430, DateTimeKind.Local).AddTicks(3874));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 16, 15, 38, 30, 430, DateTimeKind.Local).AddTicks(3885));

            migrationBuilder.UpdateData(
                table: "ExchangeRates",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 16, 15, 38, 30, 430, DateTimeKind.Local).AddTicks(3889));

            migrationBuilder.CreateIndex(
                name: "IX_Images_CustomerId",
                table: "Images",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_RoomId",
                table: "Images",
                column: "RoomId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Images");

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
    }
}
