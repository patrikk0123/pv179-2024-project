using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DAL.SQLite.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class AddGiftCards : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CouponId",
                table: "Orders",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "GiftCards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PriceReduction = table.Column<double>(type: "REAL", nullable: false),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EditedAt = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiftCards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Coupons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Code = table.Column<string>(type: "TEXT", nullable: false),
                    GiftCardId = table.Column<int>(type: "INTEGER", nullable: false),
                    OrderdId = table.Column<int>(type: "INTEGER", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EditedAt = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coupons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Coupons_GiftCards_GiftCardId",
                        column: x => x.GiftCardId,
                        principalTable: "GiftCards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Coupons_Orders_OrderdId",
                        column: x => x.OrderdId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishDate",
                value: new DateOnly(2024, 8, 1));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublishDate",
                value: new DateOnly(2024, 6, 29));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublishDate",
                value: new DateOnly(2024, 9, 25));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublishDate",
                value: new DateOnly(2024, 10, 20));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                column: "PublishDate",
                value: new DateOnly(2024, 1, 23));

            migrationBuilder.InsertData(
                table: "GiftCards",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "EditedAt", "ExpiryDate", "PriceReduction", "StartDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 3.1600000000000001, new DateTime(2024, 12, 9, 19, 31, 57, 665, DateTimeKind.Utc).AddTicks(1830) },
                    { 2, new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 3.3399999999999999, new DateTime(2024, 12, 9, 19, 31, 57, 665, DateTimeKind.Utc).AddTicks(2957) }
                });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CouponId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CouponId",
                value: null);

            migrationBuilder.InsertData(
                table: "Coupons",
                columns: new[] { "Id", "Code", "CreatedAt", "DeletedAt", "EditedAt", "GiftCardId", "OrderdId" },
                values: new object[,]
                {
                    { 1, "umwymgg403", new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1, null },
                    { 2, "vam0x6dsc8", new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1, null },
                    { 3, "8zt2ptvjn8", new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1, null },
                    { 4, "j4ld2vyvsu", new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CouponId",
                table: "Orders",
                column: "CouponId");

            migrationBuilder.CreateIndex(
                name: "IX_Coupons_GiftCardId",
                table: "Coupons",
                column: "GiftCardId");

            migrationBuilder.CreateIndex(
                name: "IX_Coupons_OrderdId",
                table: "Coupons",
                column: "OrderdId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Coupons_CouponId",
                table: "Orders",
                column: "CouponId",
                principalTable: "Coupons",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Coupons_CouponId",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "Coupons");

            migrationBuilder.DropTable(
                name: "GiftCards");

            migrationBuilder.DropIndex(
                name: "IX_Orders_CouponId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "CouponId",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishDate",
                value: new DateOnly(2024, 7, 11));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublishDate",
                value: new DateOnly(2024, 6, 8));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublishDate",
                value: new DateOnly(2024, 9, 4));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublishDate",
                value: new DateOnly(2024, 9, 29));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                column: "PublishDate",
                value: new DateOnly(2024, 1, 2));
        }
    }
}
