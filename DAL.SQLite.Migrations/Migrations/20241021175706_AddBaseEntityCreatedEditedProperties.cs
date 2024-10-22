using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.SQLite.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class AddBaseEntityCreatedEditedProperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Created",
                table: "WishListItem",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "Created",
                table: "Users",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "Created",
                table: "Reviews",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "Created",
                table: "Publishers",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "Created",
                table: "OrderItem",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "Created",
                table: "Order",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "Created",
                table: "Genres",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "Created",
                table: "Books",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "Created",
                table: "BookGenre",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "Created",
                table: "BookAuthor",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "Created",
                table: "Authors",
                newName: "CreatedAt");

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "WishListItem",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EditedAt",
                table: "WishListItem",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Users",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EditedAt",
                table: "Users",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Reviews",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EditedAt",
                table: "Reviews",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Publishers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EditedAt",
                table: "Publishers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "OrderItem",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EditedAt",
                table: "OrderItem",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Order",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EditedAt",
                table: "Order",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Genres",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EditedAt",
                table: "Genres",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Books",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EditedAt",
                table: "Books",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "BookGenre",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EditedAt",
                table: "BookGenre",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "BookAuthor",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EditedAt",
                table: "BookAuthor",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Authors",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EditedAt",
                table: "Authors",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "EditedAt" },
                values: new object[] { new DateTime(2024, 10, 21, 19, 57, 5, 509, DateTimeKind.Local).AddTicks(7428), null, null });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "EditedAt" },
                values: new object[] { new DateTime(2024, 10, 21, 19, 57, 5, 509, DateTimeKind.Local).AddTicks(7432), null, null });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DeletedAt", "EditedAt" },
                values: new object[] { new DateTime(2024, 10, 21, 19, 57, 5, 509, DateTimeKind.Local).AddTicks(7434), null, null });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "EditedAt" },
                values: new object[] { new DateTime(2024, 10, 21, 19, 57, 5, 509, DateTimeKind.Local).AddTicks(7442), null, null });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "EditedAt" },
                values: new object[] { new DateTime(2024, 10, 21, 19, 57, 5, 509, DateTimeKind.Local).AddTicks(7446), null, null });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "EditedAt" },
                values: new object[] { new DateTime(2024, 10, 21, 19, 57, 5, 509, DateTimeKind.Local).AddTicks(7472), null, null });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "EditedAt" },
                values: new object[] { new DateTime(2024, 10, 21, 19, 57, 5, 509, DateTimeKind.Local).AddTicks(7474), null, null });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DeletedAt", "EditedAt" },
                values: new object[] { new DateTime(2024, 10, 21, 19, 57, 5, 509, DateTimeKind.Local).AddTicks(7477), null, null });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "EditedAt" },
                values: new object[] { new DateTime(2024, 10, 21, 19, 57, 5, 509, DateTimeKind.Local).AddTicks(7413), null, null });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "EditedAt" },
                values: new object[] { new DateTime(2024, 10, 21, 19, 57, 5, 509, DateTimeKind.Local).AddTicks(7422), null, null });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "EditedAt" },
                values: new object[] { new DateTime(2024, 10, 21, 19, 57, 5, 509, DateTimeKind.Local).AddTicks(7462), null, null });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "EditedAt" },
                values: new object[] { new DateTime(2024, 10, 21, 19, 57, 5, 509, DateTimeKind.Local).AddTicks(7465), null, null });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DeletedAt", "EditedAt" },
                values: new object[] { new DateTime(2024, 10, 21, 19, 57, 5, 509, DateTimeKind.Local).AddTicks(7467), null, null });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "EditedAt" },
                values: new object[] { new DateTime(2024, 10, 21, 19, 57, 5, 519, DateTimeKind.Local).AddTicks(3383), null, null });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "EditedAt" },
                values: new object[] { new DateTime(2024, 10, 21, 19, 57, 5, 519, DateTimeKind.Local).AddTicks(3433), null, null });

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "EditedAt" },
                values: new object[] { new DateTime(2024, 10, 21, 19, 57, 5, 519, DateTimeKind.Local).AddTicks(3523), null, null });

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "EditedAt" },
                values: new object[] { new DateTime(2024, 10, 21, 19, 57, 5, 519, DateTimeKind.Local).AddTicks(3528), null, null });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "EditedAt" },
                values: new object[] { new DateTime(2024, 10, 21, 19, 57, 5, 509, DateTimeKind.Local).AddTicks(7357), null, null });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "EditedAt" },
                values: new object[] { new DateTime(2024, 10, 21, 19, 57, 5, 509, DateTimeKind.Local).AddTicks(7480), null, null });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "EditedAt" },
                values: new object[] { new DateTime(2024, 10, 21, 19, 57, 5, 509, DateTimeKind.Local).AddTicks(7484), null, null });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DeletedAt", "EditedAt" },
                values: new object[] { new DateTime(2024, 10, 21, 19, 57, 5, 509, DateTimeKind.Local).AddTicks(7486), null, new DateTime(2024, 10, 19, 19, 57, 5, 509, DateTimeKind.Local).AddTicks(7488) });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Body", "BookId", "CreatedAt", "DeletedAt", "EditedAt", "Rating", "UserId" },
                values: new object[] { 4, "Was great!", 2, new DateTime(2024, 10, 21, 19, 57, 5, 509, DateTimeKind.Local).AddTicks(7495), new DateTime(2024, 10, 18, 19, 57, 5, 509, DateTimeKind.Local).AddTicks(7497), null, 5, 3 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "EditedAt" },
                values: new object[] { new DateTime(2024, 10, 21, 19, 57, 5, 509, DateTimeKind.Local).AddTicks(7450), null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "EditedAt" },
                values: new object[] { new DateTime(2024, 10, 21, 19, 57, 5, 509, DateTimeKind.Local).AddTicks(7454), null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DeletedAt", "EditedAt" },
                values: new object[] { new DateTime(2024, 10, 21, 19, 57, 5, 509, DateTimeKind.Local).AddTicks(7457), null, null });

            migrationBuilder.UpdateData(
                table: "WishListItem",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "EditedAt" },
                values: new object[] { new DateTime(2024, 10, 21, 19, 57, 5, 512, DateTimeKind.Local).AddTicks(6033), null, null });

            migrationBuilder.UpdateData(
                table: "WishListItem",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "EditedAt" },
                values: new object[] { new DateTime(2024, 10, 21, 19, 57, 5, 512, DateTimeKind.Local).AddTicks(6083), null, null });

            migrationBuilder.UpdateData(
                table: "WishListItem",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DeletedAt", "EditedAt" },
                values: new object[] { new DateTime(2024, 10, 21, 19, 57, 5, 512, DateTimeKind.Local).AddTicks(6085), null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "WishListItem");

            migrationBuilder.DropColumn(
                name: "EditedAt",
                table: "WishListItem");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "EditedAt",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "EditedAt",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Publishers");

            migrationBuilder.DropColumn(
                name: "EditedAt",
                table: "Publishers");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "OrderItem");

            migrationBuilder.DropColumn(
                name: "EditedAt",
                table: "OrderItem");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "EditedAt",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Genres");

            migrationBuilder.DropColumn(
                name: "EditedAt",
                table: "Genres");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "EditedAt",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "BookGenre");

            migrationBuilder.DropColumn(
                name: "EditedAt",
                table: "BookGenre");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "BookAuthor");

            migrationBuilder.DropColumn(
                name: "EditedAt",
                table: "BookAuthor");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "EditedAt",
                table: "Authors");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "WishListItem",
                newName: "Created");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Users",
                newName: "Created");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Reviews",
                newName: "Created");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Publishers",
                newName: "Created");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "OrderItem",
                newName: "Created");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Order",
                newName: "Created");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Genres",
                newName: "Created");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Books",
                newName: "Created");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "BookGenre",
                newName: "Created");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "BookAuthor",
                newName: "Created");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Authors",
                newName: "Created");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 10, 21, 18, 53, 48, 145, DateTimeKind.Local).AddTicks(2030));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 10, 21, 18, 53, 48, 145, DateTimeKind.Local).AddTicks(2040));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 10, 21, 18, 53, 48, 145, DateTimeKind.Local).AddTicks(2040));

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 10, 21, 18, 53, 48, 145, DateTimeKind.Local).AddTicks(2040));

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 10, 21, 18, 53, 48, 145, DateTimeKind.Local).AddTicks(2050));

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 10, 21, 18, 53, 48, 145, DateTimeKind.Local).AddTicks(2070));

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 10, 21, 18, 53, 48, 145, DateTimeKind.Local).AddTicks(2070));

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 10, 21, 18, 53, 48, 145, DateTimeKind.Local).AddTicks(2070));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 10, 21, 18, 53, 48, 145, DateTimeKind.Local).AddTicks(2010));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 10, 21, 18, 53, 48, 145, DateTimeKind.Local).AddTicks(2030));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 10, 21, 18, 53, 48, 145, DateTimeKind.Local).AddTicks(2060));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 10, 21, 18, 53, 48, 145, DateTimeKind.Local).AddTicks(2060));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 10, 21, 18, 53, 48, 145, DateTimeKind.Local).AddTicks(2060));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 10, 21, 18, 53, 48, 148, DateTimeKind.Local).AddTicks(640));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 10, 21, 18, 53, 48, 148, DateTimeKind.Local).AddTicks(650));

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 10, 21, 18, 53, 48, 148, DateTimeKind.Local).AddTicks(690));

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 10, 21, 18, 53, 48, 148, DateTimeKind.Local).AddTicks(690));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 10, 21, 18, 53, 48, 145, DateTimeKind.Local).AddTicks(1950));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 10, 21, 18, 53, 48, 145, DateTimeKind.Local).AddTicks(2070));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 10, 21, 18, 53, 48, 145, DateTimeKind.Local).AddTicks(2080));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 10, 21, 18, 53, 48, 145, DateTimeKind.Local).AddTicks(2080));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 10, 21, 18, 53, 48, 145, DateTimeKind.Local).AddTicks(2050));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 10, 21, 18, 53, 48, 145, DateTimeKind.Local).AddTicks(2050));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 10, 21, 18, 53, 48, 145, DateTimeKind.Local).AddTicks(2060));

            migrationBuilder.UpdateData(
                table: "WishListItem",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 10, 21, 18, 53, 48, 146, DateTimeKind.Local).AddTicks(2150));

            migrationBuilder.UpdateData(
                table: "WishListItem",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 10, 21, 18, 53, 48, 146, DateTimeKind.Local).AddTicks(2160));

            migrationBuilder.UpdateData(
                table: "WishListItem",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 10, 21, 18, 53, 48, 146, DateTimeKind.Local).AddTicks(2160));
        }
    }
}
