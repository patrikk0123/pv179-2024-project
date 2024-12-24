using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.SQLite.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class ChangePreviewImageType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookImages_Books_BookId",
                table: "BookImages");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 11, 14, 0, 58, 842, DateTimeKind.Local).AddTicks(9669));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 11, 14, 0, 58, 842, DateTimeKind.Local).AddTicks(9673));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 11, 14, 0, 58, 842, DateTimeKind.Local).AddTicks(9676));

            migrationBuilder.UpdateData(
                table: "BookAuthors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 11, 14, 0, 58, 842, DateTimeKind.Local).AddTicks(9681));

            migrationBuilder.UpdateData(
                table: "BookAuthors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 11, 14, 0, 58, 842, DateTimeKind.Local).AddTicks(9684));

            migrationBuilder.UpdateData(
                table: "BookGenres",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 11, 14, 0, 58, 842, DateTimeKind.Local).AddTicks(9710));

            migrationBuilder.UpdateData(
                table: "BookGenres",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 11, 14, 0, 58, 842, DateTimeKind.Local).AddTicks(9713));

            migrationBuilder.UpdateData(
                table: "BookGenres",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 11, 14, 0, 58, 842, DateTimeKind.Local).AddTicks(9715));

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 11, 14, 0, 58, 842, DateTimeKind.Local).AddTicks(9739));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 11, 14, 0, 58, 842, DateTimeKind.Local).AddTicks(9652));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 11, 14, 0, 58, 842, DateTimeKind.Local).AddTicks(9662));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 11, 14, 0, 58, 842, DateTimeKind.Local).AddTicks(9701));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 11, 14, 0, 58, 842, DateTimeKind.Local).AddTicks(9704));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 11, 14, 0, 58, 842, DateTimeKind.Local).AddTicks(9706));

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 11, 14, 0, 58, 843, DateTimeKind.Local).AddTicks(144));

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 11, 14, 0, 58, 843, DateTimeKind.Local).AddTicks(149));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 11, 14, 0, 58, 843, DateTimeKind.Local).AddTicks(110));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 11, 14, 0, 58, 843, DateTimeKind.Local).AddTicks(113));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 11, 14, 0, 58, 842, DateTimeKind.Local).AddTicks(9601));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 11, 14, 0, 58, 842, DateTimeKind.Local).AddTicks(9720));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 11, 14, 0, 58, 842, DateTimeKind.Local).AddTicks(9724));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EditedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 14, 0, 58, 842, DateTimeKind.Local).AddTicks(9726), new DateTime(2024, 11, 9, 14, 0, 58, 842, DateTimeKind.Local).AddTicks(9728) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DeletedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 14, 0, 58, 842, DateTimeKind.Local).AddTicks(9733), new DateTime(2024, 11, 8, 14, 0, 58, 842, DateTimeKind.Local).AddTicks(9735) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 11, 14, 0, 58, 842, DateTimeKind.Local).AddTicks(9688));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 11, 14, 0, 58, 842, DateTimeKind.Local).AddTicks(9692));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 11, 14, 0, 58, 842, DateTimeKind.Local).AddTicks(9695));

            migrationBuilder.UpdateData(
                table: "WishListItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 11, 14, 0, 58, 843, DateTimeKind.Local).AddTicks(74));

            migrationBuilder.UpdateData(
                table: "WishListItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 11, 14, 0, 58, 843, DateTimeKind.Local).AddTicks(79));

            migrationBuilder.UpdateData(
                table: "WishListItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 11, 14, 0, 58, 843, DateTimeKind.Local).AddTicks(82));

            migrationBuilder.AddForeignKey(
                name: "FK_BookImages_Books_BookId",
                table: "BookImages",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookImages_Books_BookId",
                table: "BookImages");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 10, 22, 29, 32, 815, DateTimeKind.Local).AddTicks(3358));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 10, 22, 29, 32, 815, DateTimeKind.Local).AddTicks(3363));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 10, 22, 29, 32, 815, DateTimeKind.Local).AddTicks(3366));

            migrationBuilder.UpdateData(
                table: "BookAuthors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 10, 22, 29, 32, 815, DateTimeKind.Local).AddTicks(3371));

            migrationBuilder.UpdateData(
                table: "BookAuthors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 10, 22, 29, 32, 815, DateTimeKind.Local).AddTicks(3375));

            migrationBuilder.UpdateData(
                table: "BookGenres",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 10, 22, 29, 32, 815, DateTimeKind.Local).AddTicks(3404));

            migrationBuilder.UpdateData(
                table: "BookGenres",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 10, 22, 29, 32, 815, DateTimeKind.Local).AddTicks(3408));

            migrationBuilder.UpdateData(
                table: "BookGenres",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 10, 22, 29, 32, 815, DateTimeKind.Local).AddTicks(3410));

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 10, 22, 29, 32, 815, DateTimeKind.Local).AddTicks(3439));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 10, 22, 29, 32, 815, DateTimeKind.Local).AddTicks(3339));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 10, 22, 29, 32, 815, DateTimeKind.Local).AddTicks(3350));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 10, 22, 29, 32, 815, DateTimeKind.Local).AddTicks(3392));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 10, 22, 29, 32, 815, DateTimeKind.Local).AddTicks(3396));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 10, 22, 29, 32, 815, DateTimeKind.Local).AddTicks(3399));

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 10, 22, 29, 32, 815, DateTimeKind.Local).AddTicks(3907));

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 10, 22, 29, 32, 815, DateTimeKind.Local).AddTicks(3913));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 10, 22, 29, 32, 815, DateTimeKind.Local).AddTicks(3869));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 10, 22, 29, 32, 815, DateTimeKind.Local).AddTicks(3874));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 10, 22, 29, 32, 815, DateTimeKind.Local).AddTicks(3285));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 10, 22, 29, 32, 815, DateTimeKind.Local).AddTicks(3416));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 10, 22, 29, 32, 815, DateTimeKind.Local).AddTicks(3420));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EditedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 22, 29, 32, 815, DateTimeKind.Local).AddTicks(3423), new DateTime(2024, 11, 8, 22, 29, 32, 815, DateTimeKind.Local).AddTicks(3426) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DeletedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 22, 29, 32, 815, DateTimeKind.Local).AddTicks(3432), new DateTime(2024, 11, 7, 22, 29, 32, 815, DateTimeKind.Local).AddTicks(3434) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 10, 22, 29, 32, 815, DateTimeKind.Local).AddTicks(3380));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 10, 22, 29, 32, 815, DateTimeKind.Local).AddTicks(3385));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 10, 22, 29, 32, 815, DateTimeKind.Local).AddTicks(3388));

            migrationBuilder.UpdateData(
                table: "WishListItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 10, 22, 29, 32, 815, DateTimeKind.Local).AddTicks(3828));

            migrationBuilder.UpdateData(
                table: "WishListItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 10, 22, 29, 32, 815, DateTimeKind.Local).AddTicks(3834));

            migrationBuilder.UpdateData(
                table: "WishListItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 10, 22, 29, 32, 815, DateTimeKind.Local).AddTicks(3837));

            migrationBuilder.AddForeignKey(
                name: "FK_BookImages_Books_BookId",
                table: "BookImages",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
