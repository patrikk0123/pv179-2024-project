using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.SQLite.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class ChangeWishListItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WishListItem_Books_BookId",
                table: "WishListItem");

            migrationBuilder.DropForeignKey(
                name: "FK_WishListItem_Users_UserId",
                table: "WishListItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WishListItem",
                table: "WishListItem");

            migrationBuilder.RenameTable(
                name: "WishListItem",
                newName: "WishListItems");

            migrationBuilder.RenameIndex(
                name: "IX_WishListItem_UserId",
                table: "WishListItems",
                newName: "IX_WishListItems_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_WishListItem_BookId",
                table: "WishListItems",
                newName: "IX_WishListItems_BookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WishListItems",
                table: "WishListItems",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 20, 45, 13, 561, DateTimeKind.Local).AddTicks(7729));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 20, 45, 13, 561, DateTimeKind.Local).AddTicks(7731));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 20, 45, 13, 561, DateTimeKind.Local).AddTicks(7733));

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 20, 45, 13, 561, DateTimeKind.Local).AddTicks(7738));

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 20, 45, 13, 561, DateTimeKind.Local).AddTicks(7741));

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 20, 45, 13, 561, DateTimeKind.Local).AddTicks(7768));

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 20, 45, 13, 561, DateTimeKind.Local).AddTicks(7771));

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 20, 45, 13, 561, DateTimeKind.Local).AddTicks(7773));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 20, 45, 13, 561, DateTimeKind.Local).AddTicks(7708));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 20, 45, 13, 561, DateTimeKind.Local).AddTicks(7720));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 20, 45, 13, 561, DateTimeKind.Local).AddTicks(7758));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 20, 45, 13, 561, DateTimeKind.Local).AddTicks(7761));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 20, 45, 13, 561, DateTimeKind.Local).AddTicks(7763));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 20, 45, 13, 567, DateTimeKind.Local).AddTicks(2149));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 20, 45, 13, 567, DateTimeKind.Local).AddTicks(2198));

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 20, 45, 13, 567, DateTimeKind.Local).AddTicks(2289));

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 20, 45, 13, 567, DateTimeKind.Local).AddTicks(2294));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 20, 45, 13, 561, DateTimeKind.Local).AddTicks(7649));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 20, 45, 13, 561, DateTimeKind.Local).AddTicks(7777));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 20, 45, 13, 561, DateTimeKind.Local).AddTicks(7780));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EditedAt" },
                values: new object[] { new DateTime(2024, 10, 22, 20, 45, 13, 561, DateTimeKind.Local).AddTicks(7783), new DateTime(2024, 10, 20, 20, 45, 13, 561, DateTimeKind.Local).AddTicks(7785) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DeletedAt" },
                values: new object[] { new DateTime(2024, 10, 22, 20, 45, 13, 561, DateTimeKind.Local).AddTicks(7790), new DateTime(2024, 10, 19, 20, 45, 13, 561, DateTimeKind.Local).AddTicks(7792) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 20, 45, 13, 561, DateTimeKind.Local).AddTicks(7747));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 20, 45, 13, 561, DateTimeKind.Local).AddTicks(7751));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 20, 45, 13, 561, DateTimeKind.Local).AddTicks(7754));

            migrationBuilder.UpdateData(
                table: "WishListItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 20, 45, 13, 561, DateTimeKind.Local).AddTicks(8096));

            migrationBuilder.UpdateData(
                table: "WishListItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 20, 45, 13, 561, DateTimeKind.Local).AddTicks(8138));

            migrationBuilder.UpdateData(
                table: "WishListItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 20, 45, 13, 561, DateTimeKind.Local).AddTicks(8141));

            migrationBuilder.AddForeignKey(
                name: "FK_WishListItems_Books_BookId",
                table: "WishListItems",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_WishListItems_Users_UserId",
                table: "WishListItems",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WishListItems_Books_BookId",
                table: "WishListItems");

            migrationBuilder.DropForeignKey(
                name: "FK_WishListItems_Users_UserId",
                table: "WishListItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WishListItems",
                table: "WishListItems");

            migrationBuilder.RenameTable(
                name: "WishListItems",
                newName: "WishListItem");

            migrationBuilder.RenameIndex(
                name: "IX_WishListItems_UserId",
                table: "WishListItem",
                newName: "IX_WishListItem_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_WishListItems_BookId",
                table: "WishListItem",
                newName: "IX_WishListItem_BookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WishListItem",
                table: "WishListItem",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 16, 21, 55, 983, DateTimeKind.Local).AddTicks(1000));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 16, 21, 55, 983, DateTimeKind.Local).AddTicks(1000));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 16, 21, 55, 983, DateTimeKind.Local).AddTicks(1010));

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 16, 21, 55, 983, DateTimeKind.Local).AddTicks(1010));

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 16, 21, 55, 983, DateTimeKind.Local).AddTicks(1010));

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 16, 21, 55, 983, DateTimeKind.Local).AddTicks(1030));

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 16, 21, 55, 983, DateTimeKind.Local).AddTicks(1030));

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 16, 21, 55, 983, DateTimeKind.Local).AddTicks(1040));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 16, 21, 55, 983, DateTimeKind.Local).AddTicks(980));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 16, 21, 55, 983, DateTimeKind.Local).AddTicks(990));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 16, 21, 55, 983, DateTimeKind.Local).AddTicks(1020));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 16, 21, 55, 983, DateTimeKind.Local).AddTicks(1030));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 16, 21, 55, 983, DateTimeKind.Local).AddTicks(1030));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 16, 21, 55, 987, DateTimeKind.Local).AddTicks(4040));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 16, 21, 55, 987, DateTimeKind.Local).AddTicks(4090));

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 16, 21, 55, 987, DateTimeKind.Local).AddTicks(4150));

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 16, 21, 55, 987, DateTimeKind.Local).AddTicks(4160));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 16, 21, 55, 983, DateTimeKind.Local).AddTicks(920));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 16, 21, 55, 983, DateTimeKind.Local).AddTicks(1040));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 16, 21, 55, 983, DateTimeKind.Local).AddTicks(1040));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EditedAt" },
                values: new object[] { new DateTime(2024, 10, 22, 16, 21, 55, 983, DateTimeKind.Local).AddTicks(1050), new DateTime(2024, 10, 20, 16, 21, 55, 983, DateTimeKind.Local).AddTicks(1050) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DeletedAt" },
                values: new object[] { new DateTime(2024, 10, 22, 16, 21, 55, 983, DateTimeKind.Local).AddTicks(1060), new DateTime(2024, 10, 19, 16, 21, 55, 983, DateTimeKind.Local).AddTicks(1060) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 16, 21, 55, 983, DateTimeKind.Local).AddTicks(1010));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 16, 21, 55, 983, DateTimeKind.Local).AddTicks(1020));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 16, 21, 55, 983, DateTimeKind.Local).AddTicks(1020));

            migrationBuilder.UpdateData(
                table: "WishListItem",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 16, 21, 55, 984, DateTimeKind.Local).AddTicks(6740));

            migrationBuilder.UpdateData(
                table: "WishListItem",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 16, 21, 55, 984, DateTimeKind.Local).AddTicks(6790));

            migrationBuilder.UpdateData(
                table: "WishListItem",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 22, 16, 21, 55, 984, DateTimeKind.Local).AddTicks(6790));

            migrationBuilder.AddForeignKey(
                name: "FK_WishListItem_Books_BookId",
                table: "WishListItem",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WishListItem_Users_UserId",
                table: "WishListItem",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
