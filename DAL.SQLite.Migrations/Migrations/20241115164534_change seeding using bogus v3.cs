using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.SQLite.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class changeseedingusingbogusv3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Name", "Surname" },
                values: new object[] { new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), "Ricky", "Franecki" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Name", "Surname" },
                values: new object[] { new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), "Rubie", "Wisozk" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Name", "Surname" },
                values: new object[] { new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), "Tom", "Abbott" });

            migrationBuilder.UpdateData(
                table: "BookAuthors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "CreatedAt" },
                values: new object[] { 3, new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "BookAuthors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "CreatedAt" },
                values: new object[] { 2, new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "BookAuthors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "CreatedAt" },
                values: new object[] { 2, new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "BookAuthors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorId", "CreatedAt" },
                values: new object[] { 2, new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "BookAuthors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorId", "CreatedAt" },
                values: new object[] { 1, new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "BookGenres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "GenreId" },
                values: new object[] { new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "BookGenres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "GenreId" },
                values: new object[] { new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "BookGenres",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "BookGenres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "GenreId" },
                values: new object[] { new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "BookGenres",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "GenreId" },
                values: new object[] { new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 15, 17, 45, 34, 160, DateTimeKind.Local).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description", "ISBN", "Name", "Pages", "Price", "PublishDate", "Rating" },
                values: new object[] { new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), "Iure numquam voluptatem dolores.\nAdipisci rerum eos ea aut non ea impedit.\nDolorum minus placeat qui dolore nobis non.\nAtque magnam assumenda alias atque ducimus corrupti.", "pg9amadu6u", "Handmade Concrete Hat", 327, 52.189999999999998, new DateOnly(2024, 7, 8), 2.7660833419142676 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description", "ISBN", "Name", "Pages", "Price", "PublishDate", "Rating" },
                values: new object[] { new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), "Non dolor explicabo.\nLaboriosam perferendis qui sit accusamus qui.\nCommodi id quo odio autem est et quaerat architecto.\nQuis magnam aut.", "kjl2r0gp2x", "Oklahoma", 172, 32.880000000000003, new DateOnly(2024, 6, 5), 2.5665950689309254 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Description", "ISBN", "Name", "Pages", "Price", "PublishDate", "Rating" },
                values: new object[] { new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), "Nihil rerum dicta vel fugit recusandae dolor.\nPariatur vel minima.\nAsperiores facilis molestiae numquam nulla quibusdam esse placeat.\nPariatur ad illo corporis et.", "56zcj0mgum", "high-level", 393, 68.430000000000007, new DateOnly(2024, 9, 1), 2.720410956870956 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Description", "ISBN", "Name", "Pages", "Price", "PublishDate", "Rating" },
                values: new object[] { new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), "Odio nihil earum.\nNisi quia ducimus ipsam voluptas quo commodi in commodi aperiam.\nEnim omnis aut vitae dolores quo enim.\nUt repellendus ipsam.", "f3dqujo7mv", "Colombian Peso", 162, 81.599999999999994, new DateOnly(2024, 9, 26), 4.2919113483707942 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Description", "ISBN", "Name", "Pages", "Price", "PublishDate", "PublisherId", "Rating" },
                values: new object[] { new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), "Sunt veniam dolore omnis aliquam sed saepe rerum et cum.\nDolorem in ea quia.\nPossimus commodi hic.\nVero illum eveniet.", "5fmgi69ll3", "De-engineered", 251, 11.220000000000001, new DateOnly(2023, 12, 30), 2, 3.0013645393780268 });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "GenreType" },
                values: new object[] { new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), "Romance" });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BookId", "CreatedAt", "PricePerItem", "Quantity" },
                values: new object[] { 5, new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 11.220000000000001, 5 });

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BookId", "CreatedAt", "PricePerItem", "Quantity" },
                values: new object[] { 1, new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 52.189999999999998, 5 });

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BookId", "CreatedAt", "PricePerItem", "Quantity" },
                values: new object[] { 5, new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 11.220000000000001, 5 });

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BookId", "CreatedAt", "PricePerItem", "Quantity" },
                values: new object[] { 4, new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 81.599999999999994, 5 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 317.05000000000001, 3 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "TotalPrice" },
                values: new object[] { new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 464.10000000000002 });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), "Bernier Group" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), "Schmeler - Shields" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Body", "CreatedAt", "Rating", "UserId" },
                values: new object[] { "ifomhpxikfnnvyaovdkmwjmrzhcbhaeunzuidtqhzwoymxohatfyuqcysxnzmwajaszverlbncnzuofbtvanugawwwpggqvcwfy", new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Body", "BookId", "CreatedAt", "Rating" },
                values: new object[] { "jidkrdddeslfqwmotscz", 5, new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Body", "BookId", "CreatedAt", "Rating" },
                values: new object[] { "whkdpqleasrfrwittsloulegjqebutugchnksznoghfyfhxxkjfpqrblceuzlkjgxkcjixauewhnfgabsgqlnf", 1, new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Body", "BookId", "CreatedAt", "Rating", "UserId" },
                values: new object[] { "iofocwxyavenpmi", 3, new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 2, 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Body", "BookId", "CreatedAt", "Rating" },
                values: new object[] { "ogvdsgftyssurdgpmpqtkpggfxereccuvbrvmlmhxdzgh", 3, new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Email", "Username" },
                values: new object[] { new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), "Alivia.Gorczany@gmail.com", "Pauline.Beatty" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Email", "Username" },
                values: new object[] { new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), "Asa27@yahoo.com", "Lizeth_Osinski" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Email", "Role", "Username" },
                values: new object[] { new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), "Dayna_Towne20@hotmail.com", 1, "Lincoln53" });

            migrationBuilder.UpdateData(
                table: "WishListItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BookId", "CreatedAt", "UserId" },
                values: new object[] { 3, new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "WishListItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BookId", "CreatedAt", "UserId" },
                values: new object[] { 2, new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "WishListItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BookId", "CreatedAt" },
                values: new object[] { 5, new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Name", "Surname" },
                values: new object[] { new DateTime(2024, 11, 15, 17, 34, 49, 552, DateTimeKind.Local).AddTicks(6560), "Sonia", "Volkman" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Name", "Surname" },
                values: new object[] { new DateTime(2024, 11, 15, 17, 34, 49, 552, DateTimeKind.Local).AddTicks(6650), "Israel", "Jaskolski" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Name", "Surname" },
                values: new object[] { new DateTime(2024, 11, 15, 17, 34, 49, 552, DateTimeKind.Local).AddTicks(6670), "Rasheed", "Little" });

            migrationBuilder.UpdateData(
                table: "BookAuthors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "CreatedAt" },
                values: new object[] { 2, new DateTime(2024, 11, 15, 17, 34, 49, 553, DateTimeKind.Local).AddTicks(8440) });

            migrationBuilder.UpdateData(
                table: "BookAuthors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "CreatedAt" },
                values: new object[] { 1, new DateTime(2024, 11, 15, 17, 34, 49, 553, DateTimeKind.Local).AddTicks(8510) });

            migrationBuilder.UpdateData(
                table: "BookAuthors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "CreatedAt" },
                values: new object[] { 1, new DateTime(2024, 11, 15, 17, 34, 49, 553, DateTimeKind.Local).AddTicks(8520) });

            migrationBuilder.UpdateData(
                table: "BookAuthors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorId", "CreatedAt" },
                values: new object[] { 3, new DateTime(2024, 11, 15, 17, 34, 49, 553, DateTimeKind.Local).AddTicks(8530) });

            migrationBuilder.UpdateData(
                table: "BookAuthors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorId", "CreatedAt" },
                values: new object[] { 2, new DateTime(2024, 11, 15, 17, 34, 49, 553, DateTimeKind.Local).AddTicks(8540) });

            migrationBuilder.UpdateData(
                table: "BookGenres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "GenreId" },
                values: new object[] { new DateTime(2024, 11, 15, 17, 34, 49, 557, DateTimeKind.Local).AddTicks(4870), 1 });

            migrationBuilder.UpdateData(
                table: "BookGenres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "GenreId" },
                values: new object[] { new DateTime(2024, 11, 15, 17, 34, 49, 557, DateTimeKind.Local).AddTicks(4940), 2 });

            migrationBuilder.UpdateData(
                table: "BookGenres",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 15, 17, 34, 49, 557, DateTimeKind.Local).AddTicks(4950));

            migrationBuilder.UpdateData(
                table: "BookGenres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "GenreId" },
                values: new object[] { new DateTime(2024, 11, 15, 17, 34, 49, 557, DateTimeKind.Local).AddTicks(4950), 3 });

            migrationBuilder.UpdateData(
                table: "BookGenres",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "GenreId" },
                values: new object[] { new DateTime(2024, 11, 15, 17, 34, 49, 557, DateTimeKind.Local).AddTicks(4960), 3 });

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 15, 17, 34, 49, 558, DateTimeKind.Local).AddTicks(7850));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description", "ISBN", "Name", "Pages", "Price", "PublishDate", "Rating" },
                values: new object[] { new DateTime(2024, 11, 15, 17, 34, 49, 551, DateTimeKind.Local).AddTicks(980), "Sint quae ratione fugiat hic doloribus.\nCum voluptate quidem repellat.\nEarum a dolores corrupti quam nisi.\nAccusantium nobis porro eum.", "0rolc6ndjd", "wireless", 166, 9.8192532026417858, new DateOnly(2024, 10, 2), 2.86921968637072 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description", "ISBN", "Name", "Pages", "Price", "PublishDate", "Rating" },
                values: new object[] { new DateTime(2024, 11, 15, 17, 34, 49, 551, DateTimeKind.Local).AddTicks(1240), "Possimus necessitatibus dolor sequi.\nQuidem quod rerum aliquam qui et possimus vitae expedita.\nQuas odio eum voluptates necessitatibus nihil dolores.\nDolore nulla est explicabo atque excepturi.", "sqhqqfu5la", "Metal", 286, 56.389817976947292, new DateOnly(2024, 3, 24), 2.520821135358025 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Description", "ISBN", "Name", "Pages", "Price", "PublishDate", "Rating" },
                values: new object[] { new DateTime(2024, 11, 15, 17, 34, 49, 551, DateTimeKind.Local).AddTicks(3600), "Nisi sequi doloribus nihil.\nHarum itaque numquam qui.\nSed molestiae fugit assumenda explicabo sunt aliquam aut.\nError sequi ullam.", "aw9919xk55", "Music & Books", 441, 49.756056920747163, new DateOnly(2024, 5, 28), 1.9788754638987403 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Description", "ISBN", "Name", "Pages", "Price", "PublishDate", "Rating" },
                values: new object[] { new DateTime(2024, 11, 15, 17, 34, 49, 551, DateTimeKind.Local).AddTicks(4080), "Omnis ab consequatur alias quaerat sed dolorum aspernatur nam et.\nPerspiciatis dolorem ut ullam minus nobis rerum voluptatem qui.\nOfficia eum temporibus ea delectus odit quo.\nEt non et.", "kvhax7z4po", "Austria", 153, 56.504760007589987, new DateOnly(2023, 11, 15), 3.9769670995536153 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Description", "ISBN", "Name", "Pages", "Price", "PublishDate", "PublisherId", "Rating" },
                values: new object[] { new DateTime(2024, 11, 15, 17, 34, 49, 551, DateTimeKind.Local).AddTicks(4610), "Hic ut ut et doloremque.\nPerspiciatis voluptatum quas fuga recusandae ab et repudiandae.\nQuia id rerum.\nNon ipsum aut qui minima.", "cvqu84i3nn", "copy", 476, 92.827373741534487, new DateOnly(2024, 1, 22), 1, 1.2300774738946658 });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 15, 17, 34, 49, 556, DateTimeKind.Local).AddTicks(3480));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "GenreType" },
                values: new object[] { new DateTime(2024, 11, 15, 17, 34, 49, 556, DateTimeKind.Local).AddTicks(3540), "Horror" });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 15, 17, 34, 49, 556, DateTimeKind.Local).AddTicks(3550));

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BookId", "CreatedAt", "PricePerItem", "Quantity" },
                values: new object[] { 4, new DateTime(2024, 11, 15, 17, 34, 49, 561, DateTimeKind.Local).AddTicks(3430), 56.504760007589987, 2 });

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BookId", "CreatedAt", "PricePerItem", "Quantity" },
                values: new object[] { 4, new DateTime(2024, 11, 15, 17, 34, 49, 561, DateTimeKind.Local).AddTicks(3480), 56.504760007589987, 2 });

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BookId", "CreatedAt", "PricePerItem", "Quantity" },
                values: new object[] { 3, new DateTime(2024, 11, 15, 17, 34, 49, 562, DateTimeKind.Local).AddTicks(4320), 49.756056920747163, 4 });

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BookId", "CreatedAt", "PricePerItem", "Quantity" },
                values: new object[] { 1, new DateTime(2024, 11, 15, 17, 34, 49, 562, DateTimeKind.Local).AddTicks(4370), 9.8192532026417858, 4 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 11, 15, 17, 34, 49, 563, DateTimeKind.Local).AddTicks(5850), 226.01904003035995, 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "TotalPrice" },
                values: new object[] { new DateTime(2024, 11, 15, 17, 34, 49, 563, DateTimeKind.Local).AddTicks(5930), 238.30124049355578 });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2024, 11, 15, 17, 34, 49, 549, DateTimeKind.Local).AddTicks(5210), "Christiansen - Carter" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2024, 11, 15, 17, 34, 49, 549, DateTimeKind.Local).AddTicks(5420), "Kris - Ortiz" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Body", "CreatedAt", "Rating", "UserId" },
                values: new object[] { "fkmkqcowugmlb", new DateTime(2024, 11, 15, 17, 34, 49, 558, DateTimeKind.Local).AddTicks(7690), 2, 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Body", "BookId", "CreatedAt", "Rating" },
                values: new object[] { "irpsagkzblu", 3, new DateTime(2024, 11, 15, 17, 34, 49, 558, DateTimeKind.Local).AddTicks(7780), 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Body", "BookId", "CreatedAt", "Rating" },
                values: new object[] { "urvgmkzrhivlthzfuydapehoxikznintgqfijojgqsippfkwffx", 4, new DateTime(2024, 11, 15, 17, 34, 49, 558, DateTimeKind.Local).AddTicks(7800), 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Body", "BookId", "CreatedAt", "Rating", "UserId" },
                values: new object[] { "znyyusekxterhtlibfifmdedqlyhkwjbwnibjdgxqrzaggrf", 2, new DateTime(2024, 11, 15, 17, 34, 49, 558, DateTimeKind.Local).AddTicks(7820), 4, 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Body", "BookId", "CreatedAt", "Rating" },
                values: new object[] { "enctvnqthpbrisdvxbzosrjsqcxbdpmgouctrwkkmhahoyzqumgfchnksycfleijubbqxajrr", 5, new DateTime(2024, 11, 15, 17, 34, 49, 558, DateTimeKind.Local).AddTicks(7840), 5 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Email", "Username" },
                values: new object[] { new DateTime(2024, 11, 15, 17, 34, 49, 555, DateTimeKind.Local).AddTicks(1300), "Adalberto_Kling45@hotmail.com", "Giovanni.Renner" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Email", "Username" },
                values: new object[] { new DateTime(2024, 11, 15, 17, 34, 49, 555, DateTimeKind.Local).AddTicks(1460), "Ned.Gorczany@gmail.com", "Samir52" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Email", "Role", "Username" },
                values: new object[] { new DateTime(2024, 11, 15, 17, 34, 49, 555, DateTimeKind.Local).AddTicks(1570), "Felton_Hilpert@hotmail.com", 0, "Anne_Shanahan" });

            migrationBuilder.UpdateData(
                table: "WishListItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BookId", "CreatedAt", "UserId" },
                values: new object[] { 5, new DateTime(2024, 11, 15, 17, 34, 49, 560, DateTimeKind.Local).AddTicks(1080), 3 });

            migrationBuilder.UpdateData(
                table: "WishListItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BookId", "CreatedAt", "UserId" },
                values: new object[] { 1, new DateTime(2024, 11, 15, 17, 34, 49, 560, DateTimeKind.Local).AddTicks(1160), 1 });

            migrationBuilder.UpdateData(
                table: "WishListItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BookId", "CreatedAt" },
                values: new object[] { 3, new DateTime(2024, 11, 15, 17, 34, 49, 560, DateTimeKind.Local).AddTicks(1170) });
        }
    }
}
