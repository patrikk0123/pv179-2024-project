using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.SQLite.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class Addlinkfrompublishertobook : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 21, 19, 57, 5, 509, DateTimeKind.Local).AddTicks(7428));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 21, 19, 57, 5, 509, DateTimeKind.Local).AddTicks(7432));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 21, 19, 57, 5, 509, DateTimeKind.Local).AddTicks(7434));

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 21, 19, 57, 5, 509, DateTimeKind.Local).AddTicks(7442));

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 21, 19, 57, 5, 509, DateTimeKind.Local).AddTicks(7446));

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 21, 19, 57, 5, 509, DateTimeKind.Local).AddTicks(7472));

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 21, 19, 57, 5, 509, DateTimeKind.Local).AddTicks(7474));

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 21, 19, 57, 5, 509, DateTimeKind.Local).AddTicks(7477));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 21, 19, 57, 5, 509, DateTimeKind.Local).AddTicks(7413));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 21, 19, 57, 5, 509, DateTimeKind.Local).AddTicks(7422));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 21, 19, 57, 5, 509, DateTimeKind.Local).AddTicks(7462));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 21, 19, 57, 5, 509, DateTimeKind.Local).AddTicks(7465));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 21, 19, 57, 5, 509, DateTimeKind.Local).AddTicks(7467));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 21, 19, 57, 5, 519, DateTimeKind.Local).AddTicks(3383));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 21, 19, 57, 5, 519, DateTimeKind.Local).AddTicks(3433));

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 21, 19, 57, 5, 519, DateTimeKind.Local).AddTicks(3523));

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 21, 19, 57, 5, 519, DateTimeKind.Local).AddTicks(3528));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 21, 19, 57, 5, 509, DateTimeKind.Local).AddTicks(7357));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 21, 19, 57, 5, 509, DateTimeKind.Local).AddTicks(7480));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 21, 19, 57, 5, 509, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EditedAt" },
                values: new object[] { new DateTime(2024, 10, 21, 19, 57, 5, 509, DateTimeKind.Local).AddTicks(7486), new DateTime(2024, 10, 19, 19, 57, 5, 509, DateTimeKind.Local).AddTicks(7488) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DeletedAt" },
                values: new object[] { new DateTime(2024, 10, 21, 19, 57, 5, 509, DateTimeKind.Local).AddTicks(7495), new DateTime(2024, 10, 18, 19, 57, 5, 509, DateTimeKind.Local).AddTicks(7497) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 21, 19, 57, 5, 509, DateTimeKind.Local).AddTicks(7450));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 21, 19, 57, 5, 509, DateTimeKind.Local).AddTicks(7454));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 21, 19, 57, 5, 509, DateTimeKind.Local).AddTicks(7457));

            migrationBuilder.UpdateData(
                table: "WishListItem",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 21, 19, 57, 5, 512, DateTimeKind.Local).AddTicks(6033));

            migrationBuilder.UpdateData(
                table: "WishListItem",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 21, 19, 57, 5, 512, DateTimeKind.Local).AddTicks(6083));

            migrationBuilder.UpdateData(
                table: "WishListItem",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 21, 19, 57, 5, 512, DateTimeKind.Local).AddTicks(6085));
        }
    }
}
