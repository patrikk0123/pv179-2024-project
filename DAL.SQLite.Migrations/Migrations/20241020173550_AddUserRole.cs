using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.SQLite.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class AddUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsAdmin",
                table: "Users",
                newName: "Role");

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 10, 20, 19, 35, 50, 87, DateTimeKind.Local).AddTicks(2704));

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 10, 20, 19, 35, 50, 87, DateTimeKind.Local).AddTicks(2708));

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 10, 20, 19, 35, 50, 87, DateTimeKind.Local).AddTicks(2711));

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 10, 20, 19, 35, 50, 87, DateTimeKind.Local).AddTicks(2716));

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 10, 20, 19, 35, 50, 87, DateTimeKind.Local).AddTicks(2719));

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 10, 20, 19, 35, 50, 87, DateTimeKind.Local).AddTicks(2745));

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 10, 20, 19, 35, 50, 87, DateTimeKind.Local).AddTicks(2749));

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 10, 20, 19, 35, 50, 87, DateTimeKind.Local).AddTicks(2751));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 10, 20, 19, 35, 50, 87, DateTimeKind.Local).AddTicks(2687));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 10, 20, 19, 35, 50, 87, DateTimeKind.Local).AddTicks(2697));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 10, 20, 19, 35, 50, 87, DateTimeKind.Local).AddTicks(2735));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 10, 20, 19, 35, 50, 87, DateTimeKind.Local).AddTicks(2738));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 10, 20, 19, 35, 50, 87, DateTimeKind.Local).AddTicks(2741));

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 10, 20, 19, 35, 50, 87, DateTimeKind.Local).AddTicks(2633));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 10, 20, 19, 35, 50, 87, DateTimeKind.Local).AddTicks(2755));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 10, 20, 19, 35, 50, 87, DateTimeKind.Local).AddTicks(2759));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 10, 20, 19, 35, 50, 87, DateTimeKind.Local).AddTicks(2762));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Role" },
                values: new object[] { new DateTime(2024, 10, 20, 19, 35, 50, 87, DateTimeKind.Local).AddTicks(2723), 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Role" },
                values: new object[] { new DateTime(2024, 10, 20, 19, 35, 50, 87, DateTimeKind.Local).AddTicks(2728), 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Role" },
                values: new object[] { new DateTime(2024, 10, 20, 19, 35, 50, 87, DateTimeKind.Local).AddTicks(2730), 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Role",
                table: "Users",
                newName: "IsAdmin");

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
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 10, 20, 19, 8, 2, 702, DateTimeKind.Local).AddTicks(3415));

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 10, 20, 19, 8, 2, 702, DateTimeKind.Local).AddTicks(3419));

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 10, 20, 19, 8, 2, 702, DateTimeKind.Local).AddTicks(3421));

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

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 10, 20, 19, 8, 2, 702, DateTimeKind.Local).AddTicks(3407));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 10, 20, 19, 8, 2, 702, DateTimeKind.Local).AddTicks(3410));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 10, 20, 19, 8, 2, 702, DateTimeKind.Local).AddTicks(3412));

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 10, 20, 19, 8, 2, 702, DateTimeKind.Local).AddTicks(3309));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 10, 20, 19, 8, 2, 702, DateTimeKind.Local).AddTicks(3425));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 10, 20, 19, 8, 2, 702, DateTimeKind.Local).AddTicks(3428));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 10, 20, 19, 8, 2, 702, DateTimeKind.Local).AddTicks(3431));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "IsAdmin" },
                values: new object[] { new DateTime(2024, 10, 20, 19, 8, 2, 702, DateTimeKind.Local).AddTicks(3394), true });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "IsAdmin" },
                values: new object[] { new DateTime(2024, 10, 20, 19, 8, 2, 702, DateTimeKind.Local).AddTicks(3400), false });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "IsAdmin" },
                values: new object[] { new DateTime(2024, 10, 20, 19, 8, 2, 702, DateTimeKind.Local).AddTicks(3402), false });
        }
    }
}
