using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.SQLite.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class changeseedingusingbogusv2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_Orders_OrderId",
                table: "OrderItem");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Users_UserId",
                table: "Orders");

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
                column: "CreatedAt",
                value: new DateTime(2024, 11, 15, 17, 34, 49, 557, DateTimeKind.Local).AddTicks(4940));

            migrationBuilder.UpdateData(
                table: "BookGenres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "GenreId" },
                values: new object[] { new DateTime(2024, 11, 15, 17, 34, 49, 557, DateTimeKind.Local).AddTicks(4950), 1 });

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
                columns: new[] { "CreatedAt", "Description", "ISBN", "Name", "Pages", "Price", "PublishDate", "PublisherId", "Rating" },
                values: new object[] { new DateTime(2024, 11, 15, 17, 34, 49, 551, DateTimeKind.Local).AddTicks(980), "Sint quae ratione fugiat hic doloribus.\nCum voluptate quidem repellat.\nEarum a dolores corrupti quam nisi.\nAccusantium nobis porro eum.", "0rolc6ndjd", "wireless", 166, 9.8192532026417858, new DateOnly(2024, 10, 2), 1, 2.86921968637072 });

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
                columns: new[] { "CreatedAt", "Description", "ISBN", "Name", "Pages", "Price", "PublishDate", "PublisherId", "Rating" },
                values: new object[] { new DateTime(2024, 11, 15, 17, 34, 49, 551, DateTimeKind.Local).AddTicks(3600), "Nisi sequi doloribus nihil.\nHarum itaque numquam qui.\nSed molestiae fugit assumenda explicabo sunt aliquam aut.\nError sequi ullam.", "aw9919xk55", "Music & Books", 441, 49.756056920747163, new DateOnly(2024, 5, 28), 2, 1.9788754638987403 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Description", "ISBN", "Name", "Pages", "Price", "PublishDate", "PublisherId", "Rating" },
                values: new object[] { new DateTime(2024, 11, 15, 17, 34, 49, 551, DateTimeKind.Local).AddTicks(4080), "Omnis ab consequatur alias quaerat sed dolorum aspernatur nam et.\nPerspiciatis dolorem ut ullam minus nobis rerum voluptatem qui.\nOfficia eum temporibus ea delectus odit quo.\nEt non et.", "kvhax7z4po", "Austria", 153, 56.504760007589987, new DateOnly(2023, 11, 15), 2, 3.9769670995536153 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Description", "ISBN", "Name", "Pages", "Price", "PublishDate", "Rating" },
                values: new object[] { new DateTime(2024, 11, 15, 17, 34, 49, 551, DateTimeKind.Local).AddTicks(4610), "Hic ut ut et doloremque.\nPerspiciatis voluptatum quas fuga recusandae ab et repudiandae.\nQuia id rerum.\nNon ipsum aut qui minima.", "cvqu84i3nn", "copy", 476, 92.827373741534487, new DateOnly(2024, 1, 22), 1.2300774738946658 });

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
                columns: new[] { "CreatedAt", "GenreType" },
                values: new object[] { new DateTime(2024, 11, 15, 17, 34, 49, 556, DateTimeKind.Local).AddTicks(3550), "Horror" });

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
                columns: new[] { "CreatedAt", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 11, 15, 17, 34, 49, 563, DateTimeKind.Local).AddTicks(5930), 238.30124049355578, 1 });

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
                columns: new[] { "Body", "BookId", "CreatedAt", "Rating", "UserId" },
                values: new object[] { "fkmkqcowugmlb", 1, new DateTime(2024, 11, 15, 17, 34, 49, 558, DateTimeKind.Local).AddTicks(7690), 2, 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Body", "BookId", "CreatedAt", "Rating", "UserId" },
                values: new object[] { "irpsagkzblu", 3, new DateTime(2024, 11, 15, 17, 34, 49, 558, DateTimeKind.Local).AddTicks(7780), 2, 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Body", "BookId", "CreatedAt", "UserId" },
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
                columns: new[] { "Body", "BookId", "CreatedAt", "Rating", "UserId" },
                values: new object[] { "enctvnqthpbrisdvxbzosrjsqcxbdpmgouctrwkkmhahoyzqumgfchnksycfleijubbqxajrr", 5, new DateTime(2024, 11, 15, 17, 34, 49, 558, DateTimeKind.Local).AddTicks(7840), 5, 2 });

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
                columns: new[] { "CreatedAt", "Email", "Role", "Username" },
                values: new object[] { new DateTime(2024, 11, 15, 17, 34, 49, 555, DateTimeKind.Local).AddTicks(1460), "Ned.Gorczany@gmail.com", 1, "Samir52" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Email", "Username" },
                values: new object[] { new DateTime(2024, 11, 15, 17, 34, 49, 555, DateTimeKind.Local).AddTicks(1570), "Felton_Hilpert@hotmail.com", "Anne_Shanahan" });

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
                columns: new[] { "BookId", "CreatedAt" },
                values: new object[] { 1, new DateTime(2024, 11, 15, 17, 34, 49, 560, DateTimeKind.Local).AddTicks(1160) });

            migrationBuilder.UpdateData(
                table: "WishListItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BookId", "CreatedAt" },
                values: new object[] { 3, new DateTime(2024, 11, 15, 17, 34, 49, 560, DateTimeKind.Local).AddTicks(1170) });

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_Orders_OrderId",
                table: "OrderItem",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Users_UserId",
                table: "Orders",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_Orders_OrderId",
                table: "OrderItem");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Users_UserId",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Name", "Surname" },
                values: new object[] { new DateTime(2024, 11, 15, 17, 4, 37, 945, DateTimeKind.Local).AddTicks(5110), "Dana", "Wiegand" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Name", "Surname" },
                values: new object[] { new DateTime(2024, 11, 15, 17, 4, 37, 945, DateTimeKind.Local).AddTicks(5180), "Melyssa", "Mills" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Name", "Surname" },
                values: new object[] { new DateTime(2024, 11, 15, 17, 4, 37, 945, DateTimeKind.Local).AddTicks(5200), "Davon", "Kshlerin" });

            migrationBuilder.UpdateData(
                table: "BookAuthors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "CreatedAt" },
                values: new object[] { 1, new DateTime(2024, 11, 15, 17, 4, 37, 946, DateTimeKind.Local).AddTicks(5340) });

            migrationBuilder.UpdateData(
                table: "BookAuthors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "CreatedAt" },
                values: new object[] { 3, new DateTime(2024, 11, 15, 17, 4, 37, 946, DateTimeKind.Local).AddTicks(5380) });

            migrationBuilder.UpdateData(
                table: "BookAuthors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "CreatedAt" },
                values: new object[] { 2, new DateTime(2024, 11, 15, 17, 4, 37, 946, DateTimeKind.Local).AddTicks(5390) });

            migrationBuilder.UpdateData(
                table: "BookAuthors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorId", "CreatedAt" },
                values: new object[] { 1, new DateTime(2024, 11, 15, 17, 4, 37, 946, DateTimeKind.Local).AddTicks(5400) });

            migrationBuilder.UpdateData(
                table: "BookAuthors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorId", "CreatedAt" },
                values: new object[] { 3, new DateTime(2024, 11, 15, 17, 4, 37, 946, DateTimeKind.Local).AddTicks(5400) });

            migrationBuilder.UpdateData(
                table: "BookGenres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "GenreId" },
                values: new object[] { new DateTime(2024, 11, 15, 17, 4, 37, 949, DateTimeKind.Local).AddTicks(8770), 3 });

            migrationBuilder.UpdateData(
                table: "BookGenres",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 15, 17, 4, 37, 949, DateTimeKind.Local).AddTicks(8820));

            migrationBuilder.UpdateData(
                table: "BookGenres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "GenreId" },
                values: new object[] { new DateTime(2024, 11, 15, 17, 4, 37, 949, DateTimeKind.Local).AddTicks(8830), 3 });

            migrationBuilder.UpdateData(
                table: "BookGenres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "GenreId" },
                values: new object[] { new DateTime(2024, 11, 15, 17, 4, 37, 949, DateTimeKind.Local).AddTicks(8830), 1 });

            migrationBuilder.UpdateData(
                table: "BookGenres",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "GenreId" },
                values: new object[] { new DateTime(2024, 11, 15, 17, 4, 37, 949, DateTimeKind.Local).AddTicks(8840), 1 });

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 15, 17, 4, 37, 950, DateTimeKind.Local).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description", "ISBN", "Name", "Pages", "Price", "PublishDate", "PublisherId", "Rating" },
                values: new object[] { new DateTime(2024, 11, 15, 17, 4, 37, 944, DateTimeKind.Local).AddTicks(4410), "卒䆏㡓휼巻ᡵᤘ찴糧蟂톽䣷凿춓䷉냧䝟㰊䓍׈ꯐ鷸疩㫭䪳ｽꇧ翈윟綘俰", "ᬭ舟䥖㮕�訮랞죔긋", "묄览愵䬗Ꭵ뀅䚴棎旔柶걢臹ȑ䦻⹆瀘ஜ龡媖乨蔡蟹輮⏏쎻冃㿴潬�붳", 229, 64.037123422362953, new DateOnly(2023, 12, 2), 2, 2.4109048360168535 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description", "ISBN", "Name", "Pages", "Price", "PublishDate", "Rating" },
                values: new object[] { new DateTime(2024, 11, 15, 17, 4, 37, 944, DateTimeKind.Local).AddTicks(4510), "菟趵埧䜏䀺ふ✜䝎㾞̦", "蓅﹧㏛졆�ႎ녕䛯ç", "샱ꗑá広曶䕷탗딤鿃轙䊱ۚᦧ绂媔撄", 468, 38.166874590007453, new DateOnly(2023, 12, 4), 3.9624567662645847 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Description", "ISBN", "Name", "Pages", "Price", "PublishDate", "PublisherId", "Rating" },
                values: new object[] { new DateTime(2024, 11, 15, 17, 4, 37, 944, DateTimeKind.Local).AddTicks(4530), "쇽䗿阭㉌柮ધ��ᡕïಟ", "锓㐙㨇摼俅㸋닽啛", "੃钦⺸खࡳ鄘ṋ櫍⚼뮻笮鶃䥐礛�", 313, 27.241800476822036, new DateOnly(2024, 9, 26), 1, 2.4625310904366549 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Description", "ISBN", "Name", "Pages", "Price", "PublishDate", "PublisherId", "Rating" },
                values: new object[] { new DateTime(2024, 11, 15, 17, 4, 37, 944, DateTimeKind.Local).AddTicks(4560), "辎�﫦ᴇ퀞秞⹩㻏⒊ढ懤ў쿤酸ヸኰ�﫷苔咎蚎롄嶶춹ꠗ䠮篣谗⎼㽢椳᠖맰嘟젭㚌쒴헀킅佑횁ᒓ憚묈븹低ߜ垓喖ㄘ삐힉錻鱕ꮇㄻ呃鞤ⴴ帮", "뇁�榙↛睬僐ݽੰ䯤", "洷즘飮揔굅둓荂⇦�♨嫱ූ暀ޔ֑㉃禿퉈徴㷂", 138, 38.729846111609511, new DateOnly(2024, 9, 27), 1, 3.8773468299359175 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Description", "ISBN", "Name", "Pages", "Price", "PublishDate", "Rating" },
                values: new object[] { new DateTime(2024, 11, 15, 17, 4, 37, 944, DateTimeKind.Local).AddTicks(4590), "圷늷	釆酪ꇨ䘤턾ₐ㊅䕻摥탅ᣜ扵䡕ᄭ閲ㅉ㺾욡졡ຩꍧ艡Ⰺﱕ퍨ҫ튼ᜩĎ섿؎괅䠧龆䆢㊯棵潵蹡抵ᙰꅴ毳ᾖ䭶꙳ﾑ憒㊹⌬侊闂埗䔗說놑", "詌ﰟ탫郍◝䱙땸㢦", "룯ଭ홳ﱜ휢ቄ렗ݑ蘗殒猪츓᧷ਘ覬䳍㏖㧌汰嫷단儞택訰ﵻ攑�苣ꩊ뎿㫞꞉", 93, 97.299318992521449, new DateOnly(2024, 1, 12), 1.1782937004726741 });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 15, 17, 4, 37, 948, DateTimeKind.Local).AddTicks(8250));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "GenreType" },
                values: new object[] { new DateTime(2024, 11, 15, 17, 4, 37, 948, DateTimeKind.Local).AddTicks(8310), "Romance" });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "GenreType" },
                values: new object[] { new DateTime(2024, 11, 15, 17, 4, 37, 948, DateTimeKind.Local).AddTicks(8320), "Romance" });

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BookId", "CreatedAt", "PricePerItem", "Quantity" },
                values: new object[] { 2, new DateTime(2024, 11, 15, 17, 4, 37, 953, DateTimeKind.Local).AddTicks(20), 38.166874590007453, 5 });

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BookId", "CreatedAt", "PricePerItem", "Quantity" },
                values: new object[] { 5, new DateTime(2024, 11, 15, 17, 4, 37, 953, DateTimeKind.Local).AddTicks(60), 97.299318992521449, 4 });

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BookId", "CreatedAt", "PricePerItem", "Quantity" },
                values: new object[] { 4, new DateTime(2024, 11, 15, 17, 4, 37, 954, DateTimeKind.Local).AddTicks(480), 38.729846111609511, 1 });

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BookId", "CreatedAt", "PricePerItem", "Quantity" },
                values: new object[] { 5, new DateTime(2024, 11, 15, 17, 4, 37, 954, DateTimeKind.Local).AddTicks(530), 97.299318992521449, 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 11, 15, 17, 4, 37, 955, DateTimeKind.Local).AddTicks(1550), 580.03164892012308, 3 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 11, 15, 17, 4, 37, 955, DateTimeKind.Local).AddTicks(1630), 136.02916510413095, 2 });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2024, 11, 15, 17, 4, 37, 943, DateTimeKind.Local).AddTicks(1810), "Brekke, Schamberger and Harber" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2024, 11, 15, 17, 4, 37, 943, DateTimeKind.Local).AddTicks(2090), "McClure, Ledner and Olson" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Body", "BookId", "CreatedAt", "Rating", "UserId" },
                values: new object[] { "ྒྷ㶏朖꺎멀ὅ悑뒓ℍ놦휿㯎럡투腸㆔䏻泖塑謎䄂", 5, new DateTime(2024, 11, 15, 17, 4, 37, 950, DateTimeKind.Local).AddTicks(9450), 5, 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Body", "BookId", "CreatedAt", "Rating", "UserId" },
                values: new object[] { "밆얕솚ᅇ铷䅰᱄⿨岪ꃨ袏镚輻ﻀ�졮儻슭", 1, new DateTime(2024, 11, 15, 17, 4, 37, 950, DateTimeKind.Local).AddTicks(9520), 4, 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Body", "BookId", "CreatedAt", "UserId" },
                values: new object[] { "ㆡɌ蒿愤쥢밉➿궲ꌚ戂裹蚎툷쁇螂�펼ஂ搩ធ轛쩸掸ꃲ砡�灾礢祯滥涙渍㤞ᰁ贗뱪峍ᔨຠꤦ嘇ꛭ敃㱴ᎂ兊₲Д澹䵸յஉ뜴貢", 1, new DateTime(2024, 11, 15, 17, 4, 37, 950, DateTimeKind.Local).AddTicks(9540), 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Body", "BookId", "CreatedAt", "Rating", "UserId" },
                values: new object[] { "椂캪륝ㆯዡ燚ݨ꧘㔞渵掘竟㿮ﶇ流谽痷丁☝೵굓ᗬ湶凃悄⧠ຑ굠覚螻Ᲊ갂켩撄�", 4, new DateTime(2024, 11, 15, 17, 4, 37, 950, DateTimeKind.Local).AddTicks(9560), 5, 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Body", "BookId", "CreatedAt", "Rating", "UserId" },
                values: new object[] { "఑鲤ꊗ成뗬皎掅衶髗㧖በꔉ饩䶮౟꘵뗺繮�⬻痐쳧㣎綡䮴꧎ᾧ됓治份䐴㪎䪸墱㊑鿁⪾꒹䆞鶵킖췌襖迄鞈⋍逋데冩헓灁Ỳ﷝ﮣ桧ꖀ", 3, new DateTime(2024, 11, 15, 17, 4, 37, 950, DateTimeKind.Local).AddTicks(9570), 3, 3 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Email", "Username" },
                values: new object[] { new DateTime(2024, 11, 15, 17, 4, 37, 947, DateTimeKind.Local).AddTicks(7120), "Ramiro_Collins@gmail.com", "Jailyn46" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Email", "Role", "Username" },
                values: new object[] { new DateTime(2024, 11, 15, 17, 4, 37, 947, DateTimeKind.Local).AddTicks(7330), "Madelynn_Wolf9@yahoo.com", 0, "Santiago43" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Email", "Username" },
                values: new object[] { new DateTime(2024, 11, 15, 17, 4, 37, 947, DateTimeKind.Local).AddTicks(7480), "Cornelius_Nitzsche@yahoo.com", "Rita83" });

            migrationBuilder.UpdateData(
                table: "WishListItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BookId", "CreatedAt", "UserId" },
                values: new object[] { 3, new DateTime(2024, 11, 15, 17, 4, 37, 951, DateTimeKind.Local).AddTicks(9760), 2 });

            migrationBuilder.UpdateData(
                table: "WishListItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BookId", "CreatedAt" },
                values: new object[] { 4, new DateTime(2024, 11, 15, 17, 4, 37, 951, DateTimeKind.Local).AddTicks(9810) });

            migrationBuilder.UpdateData(
                table: "WishListItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BookId", "CreatedAt" },
                values: new object[] { 5, new DateTime(2024, 11, 15, 17, 4, 37, 951, DateTimeKind.Local).AddTicks(9820) });

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_Orders_OrderId",
                table: "OrderItem",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Users_UserId",
                table: "Orders",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
