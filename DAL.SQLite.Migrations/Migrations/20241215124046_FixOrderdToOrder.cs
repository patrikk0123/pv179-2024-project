using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.SQLite.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class FixOrderdToOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Coupons_Orders_OrderdId",
                table: "Coupons");

            migrationBuilder.DropIndex(
                name: "IX_Coupons_OrderdId",
                table: "Coupons");

            migrationBuilder.RenameColumn(
                name: "OrderdId",
                table: "Coupons",
                newName: "OrderId");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishDate",
                value: new DateOnly(2024, 8, 7));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublishDate",
                value: new DateOnly(2024, 7, 5));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublishDate",
                value: new DateOnly(2024, 10, 1));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublishDate",
                value: new DateOnly(2024, 10, 26));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                column: "PublishDate",
                value: new DateOnly(2024, 1, 29));

            migrationBuilder.UpdateData(
                table: "GiftCards",
                keyColumn: "Id",
                keyValue: 1,
                column: "StartDate",
                value: new DateTime(2024, 12, 15, 12, 40, 45, 191, DateTimeKind.Utc).AddTicks(2896));

            migrationBuilder.UpdateData(
                table: "GiftCards",
                keyColumn: "Id",
                keyValue: 2,
                column: "StartDate",
                value: new DateTime(2024, 12, 15, 12, 40, 45, 191, DateTimeKind.Utc).AddTicks(4255));

            migrationBuilder.CreateIndex(
                name: "IX_Coupons_OrderId",
                table: "Coupons",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Coupons_Orders_OrderId",
                table: "Coupons",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Coupons_Orders_OrderId",
                table: "Coupons");

            migrationBuilder.DropIndex(
                name: "IX_Coupons_OrderId",
                table: "Coupons");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "Coupons",
                newName: "OrderdId");

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

            migrationBuilder.UpdateData(
                table: "GiftCards",
                keyColumn: "Id",
                keyValue: 1,
                column: "StartDate",
                value: new DateTime(2024, 12, 9, 19, 31, 57, 665, DateTimeKind.Utc).AddTicks(1830));

            migrationBuilder.UpdateData(
                table: "GiftCards",
                keyColumn: "Id",
                keyValue: 2,
                column: "StartDate",
                value: new DateTime(2024, 12, 9, 19, 31, 57, 665, DateTimeKind.Utc).AddTicks(2957));

            migrationBuilder.CreateIndex(
                name: "IX_Coupons_OrderdId",
                table: "Coupons",
                column: "OrderdId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Coupons_Orders_OrderdId",
                table: "Coupons",
                column: "OrderdId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
