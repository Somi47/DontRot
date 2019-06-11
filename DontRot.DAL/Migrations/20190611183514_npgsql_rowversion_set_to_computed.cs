using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DontRot.DAL.Migrations
{
    public partial class npgsql_rowversion_set_to_computed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                column: "ExpiryDateTime",
                value: new DateTime(2019, 6, 16, 20, 25, 59, 752, DateTimeKind.Local).AddTicks(9907));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                column: "ExpiryDateTime",
                value: new DateTime(2019, 6, 14, 20, 25, 59, 756, DateTimeKind.Local).AddTicks(1221));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 3,
                column: "ExpiryDateTime",
                value: new DateTime(2019, 6, 22, 20, 25, 59, 756, DateTimeKind.Local).AddTicks(1275));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 4,
                column: "ExpiryDateTime",
                value: new DateTime(2019, 8, 22, 20, 25, 59, 756, DateTimeKind.Local).AddTicks(1314));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 5,
                column: "ExpiryDateTime",
                value: new DateTime(2019, 6, 15, 20, 25, 59, 756, DateTimeKind.Local).AddTicks(1353));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 6,
                column: "ExpiryDateTime",
                value: new DateTime(2021, 4, 7, 20, 25, 59, 756, DateTimeKind.Local).AddTicks(1392));
        }
    }
}
