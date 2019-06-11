using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DontRot.DAL.Migrations
{
    public partial class food_genval_added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                column: "ExpiryDateTime",
                value: new DateTime(2019, 6, 16, 21, 32, 49, 821, DateTimeKind.Local).AddTicks(735));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                column: "ExpiryDateTime",
                value: new DateTime(2019, 6, 14, 21, 32, 49, 823, DateTimeKind.Local).AddTicks(9482));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 3,
                column: "ExpiryDateTime",
                value: new DateTime(2019, 6, 22, 21, 32, 49, 823, DateTimeKind.Local).AddTicks(9541));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 4,
                column: "ExpiryDateTime",
                value: new DateTime(2019, 8, 22, 21, 32, 49, 823, DateTimeKind.Local).AddTicks(9575));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 5,
                column: "ExpiryDateTime",
                value: new DateTime(2019, 6, 15, 21, 32, 49, 823, DateTimeKind.Local).AddTicks(9614));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 6,
                column: "ExpiryDateTime",
                value: new DateTime(2021, 4, 7, 21, 32, 49, 823, DateTimeKind.Local).AddTicks(9653));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
