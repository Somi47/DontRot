using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DontRot.DAL.Migrations
{
    public partial class food_key_added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                column: "ExpiryDateTime",
                value: new DateTime(2019, 6, 16, 21, 26, 19, 788, DateTimeKind.Local).AddTicks(1500));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                column: "ExpiryDateTime",
                value: new DateTime(2019, 6, 14, 21, 26, 19, 791, DateTimeKind.Local).AddTicks(506));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 3,
                column: "ExpiryDateTime",
                value: new DateTime(2019, 6, 22, 21, 26, 19, 791, DateTimeKind.Local).AddTicks(559));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 4,
                column: "ExpiryDateTime",
                value: new DateTime(2019, 8, 22, 21, 26, 19, 791, DateTimeKind.Local).AddTicks(598));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 5,
                column: "ExpiryDateTime",
                value: new DateTime(2019, 6, 15, 21, 26, 19, 791, DateTimeKind.Local).AddTicks(638));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 6,
                column: "ExpiryDateTime",
                value: new DateTime(2021, 4, 7, 21, 26, 19, 791, DateTimeKind.Local).AddTicks(682));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
