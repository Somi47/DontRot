using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DontRot.DAL.Migrations
{
    public partial class food_identity_added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                column: "ExpiryDateTime",
                value: new DateTime(2019, 6, 16, 21, 13, 26, 363, DateTimeKind.Local).AddTicks(8828));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                column: "ExpiryDateTime",
                value: new DateTime(2019, 6, 14, 21, 13, 26, 366, DateTimeKind.Local).AddTicks(7320));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 3,
                column: "ExpiryDateTime",
                value: new DateTime(2019, 6, 22, 21, 13, 26, 366, DateTimeKind.Local).AddTicks(7379));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 4,
                column: "ExpiryDateTime",
                value: new DateTime(2019, 8, 22, 21, 13, 26, 366, DateTimeKind.Local).AddTicks(7418));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 5,
                column: "ExpiryDateTime",
                value: new DateTime(2019, 6, 15, 21, 13, 26, 366, DateTimeKind.Local).AddTicks(7457));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 6,
                column: "ExpiryDateTime",
                value: new DateTime(2021, 4, 7, 21, 13, 26, 366, DateTimeKind.Local).AddTicks(7501));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                column: "ExpiryDateTime",
                value: new DateTime(2019, 6, 16, 20, 35, 13, 893, DateTimeKind.Local).AddTicks(1022));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                column: "ExpiryDateTime",
                value: new DateTime(2019, 6, 14, 20, 35, 13, 896, DateTimeKind.Local).AddTicks(199));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 3,
                column: "ExpiryDateTime",
                value: new DateTime(2019, 6, 22, 20, 35, 13, 896, DateTimeKind.Local).AddTicks(253));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 4,
                column: "ExpiryDateTime",
                value: new DateTime(2019, 8, 22, 20, 35, 13, 896, DateTimeKind.Local).AddTicks(292));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 5,
                column: "ExpiryDateTime",
                value: new DateTime(2019, 6, 15, 20, 35, 13, 896, DateTimeKind.Local).AddTicks(327));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 6,
                column: "ExpiryDateTime",
                value: new DateTime(2021, 4, 7, 20, 35, 13, 896, DateTimeKind.Local).AddTicks(395));
        }
    }
}
