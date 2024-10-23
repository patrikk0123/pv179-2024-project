using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.SQLite.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class AddModelsBooksAuthorsAndBooksGenreToContext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookAuthor_Authors_AuthorId",
                table: "BookAuthor");

            migrationBuilder.DropForeignKey(
                name: "FK_BookAuthor_Books_BookId",
                table: "BookAuthor");

            migrationBuilder.DropForeignKey(
                name: "FK_BookGenre_Books_BookId",
                table: "BookGenre");

            migrationBuilder.DropForeignKey(
                name: "FK_BookGenre_Genres_GenreId",
                table: "BookGenre");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookGenre",
                table: "BookGenre");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookAuthor",
                table: "BookAuthor");

            migrationBuilder.RenameTable(
                name: "BookGenre",
                newName: "BooksGenres");

            migrationBuilder.RenameTable(
                name: "BookAuthor",
                newName: "BookAuthors");

            migrationBuilder.RenameIndex(
                name: "IX_BookGenre_GenreId",
                table: "BooksGenres",
                newName: "IX_BooksGenres_GenreId");

            migrationBuilder.RenameIndex(
                name: "IX_BookGenre_BookId",
                table: "BooksGenres",
                newName: "IX_BooksGenres_BookId");

            migrationBuilder.RenameIndex(
                name: "IX_BookAuthor_BookId",
                table: "BookAuthors",
                newName: "IX_BookAuthors_BookId");

            migrationBuilder.RenameIndex(
                name: "IX_BookAuthor_AuthorId",
                table: "BookAuthors",
                newName: "IX_BookAuthors_AuthorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BooksGenres",
                table: "BooksGenres",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookAuthors",
                table: "BookAuthors",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 16, 54, 7, 922, DateTimeKind.Local).AddTicks(20));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 16, 54, 7, 922, DateTimeKind.Local).AddTicks(20));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 16, 54, 7, 922, DateTimeKind.Local).AddTicks(30));

            migrationBuilder.UpdateData(
                table: "BookAuthors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 16, 54, 7, 922, DateTimeKind.Local).AddTicks(30));

            migrationBuilder.UpdateData(
                table: "BookAuthors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 16, 54, 7, 922, DateTimeKind.Local).AddTicks(40));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 16, 54, 7, 922, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 16, 54, 7, 922, DateTimeKind.Local).AddTicks(10));

            migrationBuilder.UpdateData(
                table: "BooksGenres",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 16, 54, 7, 922, DateTimeKind.Local).AddTicks(70));

            migrationBuilder.UpdateData(
                table: "BooksGenres",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 16, 54, 7, 922, DateTimeKind.Local).AddTicks(70));

            migrationBuilder.UpdateData(
                table: "BooksGenres",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 16, 54, 7, 922, DateTimeKind.Local).AddTicks(70));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 16, 54, 7, 922, DateTimeKind.Local).AddTicks(60));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 16, 54, 7, 922, DateTimeKind.Local).AddTicks(60));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 16, 54, 7, 922, DateTimeKind.Local).AddTicks(60));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 16, 54, 7, 926, DateTimeKind.Local).AddTicks(4880));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 16, 54, 7, 926, DateTimeKind.Local).AddTicks(4910));

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 16, 54, 7, 926, DateTimeKind.Local).AddTicks(4970));

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 16, 54, 7, 926, DateTimeKind.Local).AddTicks(4970));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 16, 54, 7, 921, DateTimeKind.Local).AddTicks(9940));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 16, 54, 7, 922, DateTimeKind.Local).AddTicks(80));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 16, 54, 7, 922, DateTimeKind.Local).AddTicks(90));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EditedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 16, 54, 7, 922, DateTimeKind.Local).AddTicks(90), new DateTime(2024, 10, 21, 16, 54, 7, 922, DateTimeKind.Local).AddTicks(90) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DeletedAt" },
                values: new object[] { new DateTime(2024, 10, 23, 16, 54, 7, 922, DateTimeKind.Local).AddTicks(100), new DateTime(2024, 10, 20, 16, 54, 7, 922, DateTimeKind.Local).AddTicks(100) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 16, 54, 7, 922, DateTimeKind.Local).AddTicks(40));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 16, 54, 7, 922, DateTimeKind.Local).AddTicks(50));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 16, 54, 7, 922, DateTimeKind.Local).AddTicks(50));

            migrationBuilder.UpdateData(
                table: "WishListItem",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 16, 54, 7, 923, DateTimeKind.Local).AddTicks(5640));

            migrationBuilder.UpdateData(
                table: "WishListItem",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 16, 54, 7, 923, DateTimeKind.Local).AddTicks(5660));

            migrationBuilder.UpdateData(
                table: "WishListItem",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 10, 23, 16, 54, 7, 923, DateTimeKind.Local).AddTicks(5660));

            migrationBuilder.AddForeignKey(
                name: "FK_BookAuthors_Authors_AuthorId",
                table: "BookAuthors",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_BookAuthors_Books_BookId",
                table: "BookAuthors",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookAuthors_Authors_AuthorId",
                table: "BookAuthors");

            migrationBuilder.DropForeignKey(
                name: "FK_BookAuthors_Books_BookId",
                table: "BookAuthors");

            migrationBuilder.DropForeignKey(
                name: "FK_BooksGenres_Books_BookId",
                table: "BooksGenres");

            migrationBuilder.DropForeignKey(
                name: "FK_BooksGenres_Genres_GenreId",
                table: "BooksGenres");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BooksGenres",
                table: "BooksGenres");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookAuthors",
                table: "BookAuthors");

            migrationBuilder.RenameTable(
                name: "BooksGenres",
                newName: "BookGenre");

            migrationBuilder.RenameTable(
                name: "BookAuthors",
                newName: "BookAuthor");

            migrationBuilder.RenameIndex(
                name: "IX_BooksGenres_GenreId",
                table: "BookGenre",
                newName: "IX_BookGenre_GenreId");

            migrationBuilder.RenameIndex(
                name: "IX_BooksGenres_BookId",
                table: "BookGenre",
                newName: "IX_BookGenre_BookId");

            migrationBuilder.RenameIndex(
                name: "IX_BookAuthors_BookId",
                table: "BookAuthor",
                newName: "IX_BookAuthor_BookId");

            migrationBuilder.RenameIndex(
                name: "IX_BookAuthors_AuthorId",
                table: "BookAuthor",
                newName: "IX_BookAuthor_AuthorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookGenre",
                table: "BookGenre",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookAuthor",
                table: "BookAuthor",
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
                name: "FK_BookAuthor_Authors_AuthorId",
                table: "BookAuthor",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_BookAuthor_Books_BookId",
                table: "BookAuthor",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_BookGenre_Books_BookId",
                table: "BookGenre",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_BookGenre_Genres_GenreId",
                table: "BookGenre",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
