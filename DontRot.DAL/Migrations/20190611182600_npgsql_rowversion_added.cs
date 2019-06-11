using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DontRot.DAL.Migrations
{
    public partial class npgsql_rowversion_added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Storages",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Slots",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Foods",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AddColumn<uint>(
                name: "xmin",
                table: "Foods",
                type: "xid",
                nullable: false,
                defaultValue: 0u);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Categories",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "xmin",
                table: "Foods");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Storages",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Slots",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Foods",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Categories",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                column: "ExpiryDateTime",
                value: new DateTime(2019, 5, 18, 17, 16, 34, 472, DateTimeKind.Local).AddTicks(2497));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                column: "ExpiryDateTime",
                value: new DateTime(2019, 5, 16, 17, 16, 34, 475, DateTimeKind.Local).AddTicks(2144));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 3,
                column: "ExpiryDateTime",
                value: new DateTime(2019, 5, 24, 17, 16, 34, 475, DateTimeKind.Local).AddTicks(2198));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 4,
                column: "ExpiryDateTime",
                value: new DateTime(2019, 7, 24, 17, 16, 34, 475, DateTimeKind.Local).AddTicks(2237));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 5,
                column: "ExpiryDateTime",
                value: new DateTime(2019, 5, 17, 17, 16, 34, 475, DateTimeKind.Local).AddTicks(2271));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 6,
                column: "ExpiryDateTime",
                value: new DateTime(2021, 3, 9, 17, 16, 34, 475, DateTimeKind.Local).AddTicks(2315));
        }
    }
}
