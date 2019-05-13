using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DontRot.DAL.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Storages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Storages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Slots",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    StorageId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slots", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Slots_Storages_StorageId",
                        column: x => x.StorageId,
                        principalTable: "Storages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    ExpiryDateTime = table.Column<DateTime>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    SlotId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Foods_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Foods_Slots_SlotId",
                        column: x => x.SlotId,
                        principalTable: "Slots",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Tej" },
                    { 2, "Felvágott" },
                    { 3, "Konzerv" },
                    { 4, "Banán" }
                });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Hűtő" },
                    { 2, "Konyhaszekrény" }
                });

            migrationBuilder.InsertData(
                table: "Slots",
                columns: new[] { "Id", "Name", "StorageId" },
                values: new object[,]
                {
                    { 1, "Felső polc", 1 },
                    { 2, "Alsó polc", 1 },
                    { 3, "Bal fiók", 2 },
                    { 4, "Jobb fiók", 2 }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "CategoryId", "ExpiryDateTime", "Name", "Quantity", "SlotId" },
                values: new object[,]
                {
                    { 3, 2, new DateTime(2019, 5, 24, 17, 16, 34, 475, DateTimeKind.Local).AddTicks(2198), "Pick szeletelt téliszalámi", 5, 1 },
                    { 4, 2, new DateTime(2019, 7, 24, 17, 16, 34, 475, DateTimeKind.Local).AddTicks(2237), "CBA páros kolbász", 1, 1 },
                    { 1, 1, new DateTime(2019, 5, 18, 17, 16, 34, 472, DateTimeKind.Local).AddTicks(2497), "Mizo dobozos tej", 1, 2 },
                    { 2, 1, new DateTime(2019, 5, 16, 17, 16, 34, 475, DateTimeKind.Local).AddTicks(2144), "Alföldi zacskós tej", 1, 2 },
                    { 5, 4, new DateTime(2019, 5, 17, 17, 16, 34, 475, DateTimeKind.Local).AddTicks(2271), "Spanyol banán", 3, 3 },
                    { 6, 3, new DateTime(2021, 3, 9, 17, 16, 34, 475, DateTimeKind.Local).AddTicks(2315), "Bab konzerv", 2, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Foods_CategoryId",
                table: "Foods",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Foods_SlotId",
                table: "Foods",
                column: "SlotId");

            migrationBuilder.CreateIndex(
                name: "IX_Slots_StorageId",
                table: "Slots",
                column: "StorageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Slots");

            migrationBuilder.DropTable(
                name: "Storages");
        }
    }
}
