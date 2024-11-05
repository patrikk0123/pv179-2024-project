using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.SQLite.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class RenameRelationFromBookToGenresInContext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BooksGenres_Books_BookId",
                table: "BooksGenres");

            migrationBuilder.DropForeignKey(
                name: "FK_BooksGenres_Genres_GenreId",
                table: "BooksGenres");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BooksGenres",
                table: "BooksGenres");

            migrationBuilder.RenameTable(
                name: "BooksGenres",
                newName: "BookGenres");

            migrationBuilder.RenameIndex(
                name: "IX_BooksGenres_GenreId",
                table: "BookGenres",
                newName: "IX_BookGenres_GenreId");

            migrationBuilder.RenameIndex(
                name: "IX_BooksGenres_BookId",
                table: "BookGenres",
                newName: "IX_BookGenres_BookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookGenres",
                table: "BookGenres",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 17, 13, 43, 575, DateTimeKind.Local).AddTicks(3240));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 17, 13, 43, 575, DateTimeKind.Local).AddTicks(3240));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 17, 13, 43, 575, DateTimeKind.Local).AddTicks(3250));

            migrationBuilder.UpdateData(
                table: "BookAuthors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 17, 13, 43, 575, DateTimeKind.Local).AddTicks(3250));

            migrationBuilder.UpdateData(
                table: "BookAuthors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 17, 13, 43, 575, DateTimeKind.Local).AddTicks(3250));

            migrationBuilder.UpdateData(
                table: "BookGenres",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 17, 13, 43, 575, DateTimeKind.Local).AddTicks(3280));

            migrationBuilder.UpdateData(
                table: "BookGenres",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 17, 13, 43, 575, DateTimeKind.Local).AddTicks(3280));

            migrationBuilder.UpdateData(
                table: "BookGenres",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 17, 13, 43, 575, DateTimeKind.Local).AddTicks(3280));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 17, 13, 43, 575, DateTimeKind.Local).AddTicks(3220));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 17, 13, 43, 575, DateTimeKind.Local).AddTicks(3230));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 17, 13, 43, 575, DateTimeKind.Local).AddTicks(3270));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 17, 13, 43, 575, DateTimeKind.Local).AddTicks(3270));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 17, 13, 43, 575, DateTimeKind.Local).AddTicks(3270));

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 17, 13, 43, 575, DateTimeKind.Local).AddTicks(3570));

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 17, 13, 43, 575, DateTimeKind.Local).AddTicks(3570));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 17, 13, 43, 575, DateTimeKind.Local).AddTicks(3550));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 17, 13, 43, 575, DateTimeKind.Local).AddTicks(3550));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 17, 13, 43, 575, DateTimeKind.Local).AddTicks(3180));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 17, 13, 43, 575, DateTimeKind.Local).AddTicks(3290));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 17, 13, 43, 575, DateTimeKind.Local).AddTicks(3290));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EditedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 17, 13, 43, 575, DateTimeKind.Local).AddTicks(3290), new DateTime(2024, 10, 21, 17, 13, 43, 575, DateTimeKind.Local).AddTicks(3300) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DeletedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 17, 13, 43, 575, DateTimeKind.Local).AddTicks(3300), new DateTime(2024, 10, 20, 17, 13, 43, 575, DateTimeKind.Local).AddTicks(3300) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 17, 13, 43, 575, DateTimeKind.Local).AddTicks(3260));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 17, 13, 43, 575, DateTimeKind.Local).AddTicks(3260));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 17, 13, 43, 575, DateTimeKind.Local).AddTicks(3270));

            migrationBuilder.UpdateData(
                table: "WishListItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 17, 13, 43, 575, DateTimeKind.Local).AddTicks(3530));

            migrationBuilder.UpdateData(
                table: "WishListItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 17, 13, 43, 575, DateTimeKind.Local).AddTicks(3530));

            migrationBuilder.UpdateData(
                table: "WishListItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 17, 13, 43, 575, DateTimeKind.Local).AddTicks(3530));

            migrationBuilder.AddForeignKey(
                name: "FK_BookGenres_Books_BookId",
                table: "BookGenres",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_BookGenres_Genres_GenreId",
                table: "BookGenres",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookGenres_Books_BookId",
                table: "BookGenres");

            migrationBuilder.DropForeignKey(
                name: "FK_BookGenres_Genres_GenreId",
                table: "BookGenres");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookGenres",
                table: "BookGenres");

            migrationBuilder.RenameTable(
                name: "BookGenres",
                newName: "BooksGenres");

            migrationBuilder.RenameIndex(
                name: "IX_BookGenres_GenreId",
                table: "BooksGenres",
                newName: "IX_BooksGenres_GenreId");

            migrationBuilder.RenameIndex(
                name: "IX_BookGenres_BookId",
                table: "BooksGenres",
                newName: "IX_BooksGenres_BookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BooksGenres",
                table: "BooksGenres",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 17, 10, 57, 626, DateTimeKind.Local).AddTicks(4070));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 17, 10, 57, 626, DateTimeKind.Local).AddTicks(4080));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 17, 10, 57, 626, DateTimeKind.Local).AddTicks(4080));

            migrationBuilder.UpdateData(
                table: "BookAuthors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 17, 10, 57, 626, DateTimeKind.Local).AddTicks(4080));

            migrationBuilder.UpdateData(
                table: "BookAuthors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 17, 10, 57, 626, DateTimeKind.Local).AddTicks(4090));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 17, 10, 57, 626, DateTimeKind.Local).AddTicks(4060));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 17, 10, 57, 626, DateTimeKind.Local).AddTicks(4070));

            migrationBuilder.UpdateData(
                table: "BooksGenres",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 17, 10, 57, 626, DateTimeKind.Local).AddTicks(4120));

            migrationBuilder.UpdateData(
                table: "BooksGenres",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 17, 10, 57, 626, DateTimeKind.Local).AddTicks(4120));

            migrationBuilder.UpdateData(
                table: "BooksGenres",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 17, 10, 57, 626, DateTimeKind.Local).AddTicks(4120));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 17, 10, 57, 626, DateTimeKind.Local).AddTicks(4100));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 17, 10, 57, 626, DateTimeKind.Local).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 17, 10, 57, 626, DateTimeKind.Local).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 17, 10, 57, 626, DateTimeKind.Local).AddTicks(4360));

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 17, 10, 57, 626, DateTimeKind.Local).AddTicks(4370));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 17, 10, 57, 626, DateTimeKind.Local).AddTicks(4340));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 17, 10, 57, 626, DateTimeKind.Local).AddTicks(4340));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 17, 10, 57, 626, DateTimeKind.Local).AddTicks(3990));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 17, 10, 57, 626, DateTimeKind.Local).AddTicks(4120));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 17, 10, 57, 626, DateTimeKind.Local).AddTicks(4130));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EditedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 17, 10, 57, 626, DateTimeKind.Local).AddTicks(4130), new DateTime(2024, 10, 21, 17, 10, 57, 626, DateTimeKind.Local).AddTicks(4130) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DeletedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 17, 10, 57, 626, DateTimeKind.Local).AddTicks(4140), new DateTime(2024, 10, 20, 17, 10, 57, 626, DateTimeKind.Local).AddTicks(4140) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 17, 10, 57, 626, DateTimeKind.Local).AddTicks(4090));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 17, 10, 57, 626, DateTimeKind.Local).AddTicks(4100));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 17, 10, 57, 626, DateTimeKind.Local).AddTicks(4100));

            migrationBuilder.UpdateData(
                table: "WishListItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 17, 10, 57, 626, DateTimeKind.Local).AddTicks(4320));

            migrationBuilder.UpdateData(
                table: "WishListItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 17, 10, 57, 626, DateTimeKind.Local).AddTicks(4320));

            migrationBuilder.UpdateData(
                table: "WishListItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 17, 10, 57, 626, DateTimeKind.Local).AddTicks(4320));

            migrationBuilder.AddForeignKey(
                name: "FK_BooksGenres_Books_BookId",
                table: "BooksGenres",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_BooksGenres_Genres_GenreId",
                table: "BooksGenres",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
