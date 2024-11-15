using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.SQLite.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class ChangeImageIdType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PreviewImageId",
                table: "Books",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "ImageId",
                table: "BookImages",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 14, 23, 53, 33, 837, DateTimeKind.Local).AddTicks(9664));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 14, 23, 53, 33, 837, DateTimeKind.Local).AddTicks(9666));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 14, 23, 53, 33, 837, DateTimeKind.Local).AddTicks(9669));

            migrationBuilder.UpdateData(
                table: "BookAuthors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 14, 23, 53, 33, 837, DateTimeKind.Local).AddTicks(9674));

            migrationBuilder.UpdateData(
                table: "BookAuthors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 14, 23, 53, 33, 837, DateTimeKind.Local).AddTicks(9676));

            migrationBuilder.UpdateData(
                table: "BookGenres",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 14, 23, 53, 33, 837, DateTimeKind.Local).AddTicks(9705));

            migrationBuilder.UpdateData(
                table: "BookGenres",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 14, 23, 53, 33, 837, DateTimeKind.Local).AddTicks(9707));

            migrationBuilder.UpdateData(
                table: "BookGenres",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 14, 23, 53, 33, 837, DateTimeKind.Local).AddTicks(9709));

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ImageId" },
                values: new object[] { new DateTime(2024, 11, 14, 23, 53, 33, 837, DateTimeKind.Local).AddTicks(9739), "1849645247" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PreviewImageId" },
                values: new object[] { new DateTime(2024, 11, 14, 23, 53, 33, 837, DateTimeKind.Local).AddTicks(9645), "1849645247" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PreviewImageId" },
                values: new object[] { new DateTime(2024, 11, 14, 23, 53, 33, 837, DateTimeKind.Local).AddTicks(9655), "0" });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 14, 23, 53, 33, 837, DateTimeKind.Local).AddTicks(9695));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 14, 23, 53, 33, 837, DateTimeKind.Local).AddTicks(9697));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 14, 23, 53, 33, 837, DateTimeKind.Local).AddTicks(9699));

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 14, 23, 53, 33, 838, DateTimeKind.Local).AddTicks(92));

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 14, 23, 53, 33, 838, DateTimeKind.Local).AddTicks(96));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 14, 23, 53, 33, 838, DateTimeKind.Local).AddTicks(57));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 14, 23, 53, 33, 838, DateTimeKind.Local).AddTicks(60));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 14, 23, 53, 33, 837, DateTimeKind.Local).AddTicks(9588));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 14, 23, 53, 33, 837, DateTimeKind.Local).AddTicks(9715));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 14, 23, 53, 33, 837, DateTimeKind.Local).AddTicks(9719));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EditedAt" },
                values: new object[] { new DateTime(2024, 11, 14, 23, 53, 33, 837, DateTimeKind.Local).AddTicks(9721), new DateTime(2024, 11, 12, 23, 53, 33, 837, DateTimeKind.Local).AddTicks(9723) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DeletedAt" },
                values: new object[] { new DateTime(2024, 11, 14, 23, 53, 33, 837, DateTimeKind.Local).AddTicks(9729), new DateTime(2024, 11, 11, 23, 53, 33, 837, DateTimeKind.Local).AddTicks(9731) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 14, 23, 53, 33, 837, DateTimeKind.Local).AddTicks(9684));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 14, 23, 53, 33, 837, DateTimeKind.Local).AddTicks(9687));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 14, 23, 53, 33, 837, DateTimeKind.Local).AddTicks(9689));

            migrationBuilder.UpdateData(
                table: "WishListItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 14, 23, 53, 33, 838, DateTimeKind.Local).AddTicks(24));

            migrationBuilder.UpdateData(
                table: "WishListItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 14, 23, 53, 33, 838, DateTimeKind.Local).AddTicks(28));

            migrationBuilder.UpdateData(
                table: "WishListItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 14, 23, 53, 33, 838, DateTimeKind.Local).AddTicks(30));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PreviewImageId",
                table: "Books",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "ImageId",
                table: "BookImages",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

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
                columns: new[] { "CreatedAt", "ImageId" },
                values: new object[] { new DateTime(2024, 11, 11, 14, 0, 58, 842, DateTimeKind.Local).AddTicks(9739), 1849645247 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PreviewImageId" },
                values: new object[] { new DateTime(2024, 11, 11, 14, 0, 58, 842, DateTimeKind.Local).AddTicks(9652), 1849645247 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PreviewImageId" },
                values: new object[] { new DateTime(2024, 11, 11, 14, 0, 58, 842, DateTimeKind.Local).AddTicks(9662), 0 });

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
        }
    }
}
