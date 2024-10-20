using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DAL.SQLite.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class AddUserGenreReviewEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GenreType = table.Column<string>(type: "TEXT", nullable: false),
                    Created = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Username = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    IsAdmin = table.Column<bool>(type: "INTEGER", nullable: false),
                    Created = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BookGenre",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BookId = table.Column<int>(type: "INTEGER", nullable: false),
                    GenreId = table.Column<int>(type: "INTEGER", nullable: false),
                    Created = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookGenre", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookGenre_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_BookGenre_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    BookId = table.Column<int>(type: "INTEGER", nullable: false),
                    Rating = table.Column<int>(type: "INTEGER", nullable: false),
                    Body = table.Column<string>(type: "TEXT", maxLength: 2000, nullable: false),
                    Created = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Reviews_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 10, 20, 19, 8, 2, 702, DateTimeKind.Local).AddTicks(3375));

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 10, 20, 19, 8, 2, 702, DateTimeKind.Local).AddTicks(3379));

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 10, 20, 19, 8, 2, 702, DateTimeKind.Local).AddTicks(3381));

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 10, 20, 19, 8, 2, 702, DateTimeKind.Local).AddTicks(3385));

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 10, 20, 19, 8, 2, 702, DateTimeKind.Local).AddTicks(3388));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 10, 20, 19, 8, 2, 702, DateTimeKind.Local).AddTicks(3359));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 10, 20, 19, 8, 2, 702, DateTimeKind.Local).AddTicks(3369));

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Created", "GenreType" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 20, 19, 8, 2, 702, DateTimeKind.Local).AddTicks(3407), "Fantasy" },
                    { 2, new DateTime(2024, 10, 20, 19, 8, 2, 702, DateTimeKind.Local).AddTicks(3410), "Horror" },
                    { 3, new DateTime(2024, 10, 20, 19, 8, 2, 702, DateTimeKind.Local).AddTicks(3412), "Sci-fi" }
                });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 10, 20, 19, 8, 2, 702, DateTimeKind.Local).AddTicks(3309));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Created", "Email", "IsAdmin", "Password", "Username" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 20, 19, 8, 2, 702, DateTimeKind.Local).AddTicks(3394), "john335@muni.com", true, "123456", "johnmotika335" },
                    { 2, new DateTime(2024, 10, 20, 19, 8, 2, 702, DateTimeKind.Local).AddTicks(3400), "john335@muni.com", false, "212121", "kvalitnipolevka90" },
                    { 3, new DateTime(2024, 10, 20, 19, 8, 2, 702, DateTimeKind.Local).AddTicks(3402), "john335@muni.com", false, "432343", "flameboi22" }
                });

            migrationBuilder.InsertData(
                table: "BookGenre",
                columns: new[] { "Id", "BookId", "Created", "GenreId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 10, 20, 19, 8, 2, 702, DateTimeKind.Local).AddTicks(3415), 1 },
                    { 2, 2, new DateTime(2024, 10, 20, 19, 8, 2, 702, DateTimeKind.Local).AddTicks(3419), 2 },
                    { 3, 2, new DateTime(2024, 10, 20, 19, 8, 2, 702, DateTimeKind.Local).AddTicks(3421), 3 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Body", "BookId", "Created", "Rating", "UserId" },
                values: new object[,]
                {
                    { 1, "Great book, I loved it!", 1, new DateTime(2024, 10, 20, 19, 8, 2, 702, DateTimeKind.Local).AddTicks(3425), 4, 1 },
                    { 2, "I didn't like it at all.", 2, new DateTime(2024, 10, 20, 19, 8, 2, 702, DateTimeKind.Local).AddTicks(3428), 2, 1 },
                    { 3, "I hated it.", 2, new DateTime(2024, 10, 20, 19, 8, 2, 702, DateTimeKind.Local).AddTicks(3431), 1, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookGenre_BookId",
                table: "BookGenre",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookGenre_GenreId",
                table: "BookGenre",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_BookId",
                table: "Reviews",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_UserId",
                table: "Reviews",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookGenre");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 10, 20, 15, 57, 44, 38, DateTimeKind.Local).AddTicks(5140));

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 10, 20, 15, 57, 44, 38, DateTimeKind.Local).AddTicks(5150));

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 10, 20, 15, 57, 44, 38, DateTimeKind.Local).AddTicks(5150));

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 10, 20, 15, 57, 44, 38, DateTimeKind.Local).AddTicks(5150));

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 10, 20, 15, 57, 44, 38, DateTimeKind.Local).AddTicks(5150));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 10, 20, 15, 57, 44, 38, DateTimeKind.Local).AddTicks(5130));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 10, 20, 15, 57, 44, 38, DateTimeKind.Local).AddTicks(5140));

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 10, 20, 15, 57, 44, 38, DateTimeKind.Local).AddTicks(5090));
        }
    }
}
