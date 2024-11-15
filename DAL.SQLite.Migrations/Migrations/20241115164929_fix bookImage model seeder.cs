using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.SQLite.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class fixbookImagemodelseeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 15, 17, 45, 34, 160, DateTimeKind.Local).AddTicks(4180));
        }
    }
}
