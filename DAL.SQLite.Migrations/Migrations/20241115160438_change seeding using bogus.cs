using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DAL.SQLite.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class changeseedingusingbogus : Migration
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
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2024, 11, 15, 17, 4, 37, 943, DateTimeKind.Local).AddTicks(1810), "Brekke, Schamberger and Harber" });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "EditedAt", "Name" },
                values: new object[] { 2, new DateTime(2024, 11, 15, 17, 4, 37, 943, DateTimeKind.Local).AddTicks(2090), null, null, "McClure, Ledner and Olson" });

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
                columns: new[] { "CreatedAt", "Description", "ISBN", "Name", "Pages", "PreviewImageId", "Price", "PublishDate", "Rating" },
                values: new object[] { new DateTime(2024, 11, 15, 17, 4, 37, 944, DateTimeKind.Local).AddTicks(4510), "菟趵埧䜏䀺ふ✜䝎㾞̦", "蓅﹧㏛졆�ႎ녕䛯ç", "샱ꗑá広曶䕷탗딤鿃轙䊱ۚᦧ绂媔撄", 468, "1849645247", 38.166874590007453, new DateOnly(2023, 12, 4), 3.9624567662645847 });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Description", "EditedAt", "ISBN", "Name", "Pages", "PreviewImageId", "Price", "PublishDate", "PublisherId", "Rating" },
                values: new object[,]
                {
                    { 3, new DateTime(2024, 11, 15, 17, 4, 37, 944, DateTimeKind.Local).AddTicks(4530), null, "쇽䗿阭㉌柮ધ��ᡕïಟ", null, "锓㐙㨇摼俅㸋닽啛", "੃钦⺸खࡳ鄘ṋ櫍⚼뮻笮鶃䥐礛�", 313, "1849645247", 27.241800476822036, new DateOnly(2024, 9, 26), 1, 2.4625310904366549 },
                    { 4, new DateTime(2024, 11, 15, 17, 4, 37, 944, DateTimeKind.Local).AddTicks(4560), null, "辎�﫦ᴇ퀞秞⹩㻏⒊ढ懤ў쿤酸ヸኰ�﫷苔咎蚎롄嶶춹ꠗ䠮篣谗⎼㽢椳᠖맰嘟젭㚌쒴헀킅佑횁ᒓ憚묈븹低ߜ垓喖ㄘ삐힉錻鱕ꮇㄻ呃鞤ⴴ帮", null, "뇁�榙↛睬僐ݽੰ䯤", "洷즘飮揔굅둓荂⇦�♨嫱ූ暀ޔ֑㉃禿퉈徴㷂", 138, "1849645247", 38.729846111609511, new DateOnly(2024, 9, 27), 1, 3.8773468299359175 },
                    { 5, new DateTime(2024, 11, 15, 17, 4, 37, 944, DateTimeKind.Local).AddTicks(4590), null, "圷늷	釆酪ꇨ䘤턾ₐ㊅䕻摥탅ᣜ扵䡕ᄭ閲ㅉ㺾욡졡ຩꍧ艡Ⰺﱕ퍨ҫ튼ᜩĎ섿؎괅䠧龆䆢㊯棵潵蹡抵ᙰꅴ毳ᾖ䭶꙳ﾑ憒㊹⌬侊闂埗䔗說놑", null, "詌ﰟ탫郍◝䱙땸㢦", "룯ଭ홳ﱜ휢ቄ렗ݑ蘗殒猪츓᧷ਘ覬䳍㏖㧌汰嫷단儞택訰ﵻ攑�苣ꩊ뎿㫞꞉", 93, "1849645247", 97.299318992521449, new DateOnly(2024, 1, 12), 1, 1.1782937004726741 }
                });

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
                column: "CreatedAt",
                value: new DateTime(2024, 11, 15, 17, 4, 37, 946, DateTimeKind.Local).AddTicks(5340));

            migrationBuilder.UpdateData(
                table: "BookAuthors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "CreatedAt" },
                values: new object[] { 3, new DateTime(2024, 11, 15, 17, 4, 37, 946, DateTimeKind.Local).AddTicks(5380) });

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
                columns: new[] { "BookId", "CreatedAt" },
                values: new object[] { 3, new DateTime(2024, 11, 15, 17, 4, 37, 949, DateTimeKind.Local).AddTicks(8830) });

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 15, 17, 4, 37, 950, DateTimeKind.Local).AddTicks(9580));

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
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 11, 15, 17, 4, 37, 955, DateTimeKind.Local).AddTicks(1550), 580.03164892012308, 3 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "TotalPrice" },
                values: new object[] { new DateTime(2024, 11, 15, 17, 4, 37, 955, DateTimeKind.Local).AddTicks(1630), 136.02916510413095 });

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
                columns: new[] { "Body", "BookId", "CreatedAt", "Rating" },
                values: new object[] { "밆얕솚ᅇ铷䅰᱄⿨岪ꃨ袏镚輻ﻀ�졮儻슭", 1, new DateTime(2024, 11, 15, 17, 4, 37, 950, DateTimeKind.Local).AddTicks(9520), 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Body", "BookId", "CreatedAt", "EditedAt" },
                values: new object[] { "ㆡɌ蒿愤쥢밉➿궲ꌚ戂裹蚎툷쁇螂�펼ஂ搩ធ轛쩸掸ꃲ砡�灾礢祯滥涙渍㤞ᰁ贗뱪峍ᔨຠꤦ嘇ꛭ敃㱴ᎂ兊₲Д澹䵸յஉ뜴貢", 1, new DateTime(2024, 11, 15, 17, 4, 37, 950, DateTimeKind.Local).AddTicks(9540), null });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Body", "BookId", "CreatedAt", "DeletedAt", "UserId" },
                values: new object[] { "椂캪륝ㆯዡ燚ݨ꧘㔞渵掘竟㿮ﶇ流谽痷丁☝೵굓ᗬ湶凃悄⧠ຑ굠覚螻Ᲊ갂켩撄�", 4, new DateTime(2024, 11, 15, 17, 4, 37, 950, DateTimeKind.Local).AddTicks(9560), null, 2 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Email", "Password", "Username" },
                values: new object[] { new DateTime(2024, 11, 15, 17, 4, 37, 947, DateTimeKind.Local).AddTicks(7120), "Ramiro_Collins@gmail.com", "heslo123", "Jailyn46" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Email", "Password", "Role", "Username" },
                values: new object[] { new DateTime(2024, 11, 15, 17, 4, 37, 947, DateTimeKind.Local).AddTicks(7330), "Madelynn_Wolf9@yahoo.com", "heslo123", 0, "Santiago43" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Email", "Password", "Role", "Username" },
                values: new object[] { new DateTime(2024, 11, 15, 17, 4, 37, 947, DateTimeKind.Local).AddTicks(7480), "Cornelius_Nitzsche@yahoo.com", "heslo123", 0, "Rita83" });

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
                columns: new[] { "BookId", "CreatedAt", "UserId" },
                values: new object[] { 5, new DateTime(2024, 11, 15, 17, 4, 37, 951, DateTimeKind.Local).AddTicks(9820), 3 });

            migrationBuilder.InsertData(
                table: "BookAuthors",
                columns: new[] { "Id", "AuthorId", "BookId", "CreatedAt", "DeletedAt", "EditedAt" },
                values: new object[,]
                {
                    { 3, 2, 3, new DateTime(2024, 11, 15, 17, 4, 37, 946, DateTimeKind.Local).AddTicks(5390), null, null },
                    { 4, 1, 4, new DateTime(2024, 11, 15, 17, 4, 37, 946, DateTimeKind.Local).AddTicks(5400), null, null },
                    { 5, 3, 5, new DateTime(2024, 11, 15, 17, 4, 37, 946, DateTimeKind.Local).AddTicks(5400), null, null }
                });

            migrationBuilder.InsertData(
                table: "BookGenres",
                columns: new[] { "Id", "BookId", "CreatedAt", "DeletedAt", "EditedAt", "GenreId" },
                values: new object[,]
                {
                    { 4, 4, new DateTime(2024, 11, 15, 17, 4, 37, 949, DateTimeKind.Local).AddTicks(8830), null, null, 1 },
                    { 5, 5, new DateTime(2024, 11, 15, 17, 4, 37, 949, DateTimeKind.Local).AddTicks(8840), null, null, 1 }
                });
            
            
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
                columns: new[] { "BookId", "CreatedAt", "OrderId", "PricePerItem", "Quantity" },
                values: new object[] { 5, new DateTime(2024, 11, 15, 17, 4, 37, 953, DateTimeKind.Local).AddTicks(60), 1, 97.299318992521449, 4 });


            migrationBuilder.InsertData(
                table: "OrderItem",
                columns: new[] { "Id", "BookId", "CreatedAt", "DeletedAt", "EditedAt", "OrderId", "PricePerItem", "Quantity" },
                values: new object[,]
                {
                    { 3, 4, new DateTime(2024, 11, 15, 17, 4, 37, 954, DateTimeKind.Local).AddTicks(480), null, null, 2, 38.729846111609511, 1 },
                    { 4, 5, new DateTime(2024, 11, 15, 17, 4, 37, 954, DateTimeKind.Local).AddTicks(530), null, null, 2, 97.299318992521449, 1 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Body", "BookId", "CreatedAt", "DeletedAt", "EditedAt", "Rating", "UserId" },
                values: new object[] { 5, "఑鲤ꊗ成뗬皎掅衶髗㧖በꔉ饩䶮౟꘵뗺繮�⬻痐쳧㣎綡䮴꧎ᾧ됓治份䐴㪎䪸墱㊑鿁⪾꒹䆞鶵킖췌襖迄鞈⋍逋데冩헓灁Ỳ﷝ﮣ桧ꖀ", 3, new DateTime(2024, 11, 15, 17, 4, 37, 950, DateTimeKind.Local).AddTicks(9570), null, null, 3, 3 });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_Orders_OrderId",
                table: "OrderItem");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Users_UserId",
                table: "Orders");

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Name", "Surname" },
                values: new object[] { new DateTime(2024, 11, 14, 23, 53, 33, 837, DateTimeKind.Local).AddTicks(9664), "Ronald", "Kingson" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Name", "Surname" },
                values: new object[] { new DateTime(2024, 11, 14, 23, 53, 33, 837, DateTimeKind.Local).AddTicks(9666), "Richard", "Douchebag" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Name", "Surname" },
                values: new object[] { new DateTime(2024, 11, 14, 23, 53, 33, 837, DateTimeKind.Local).AddTicks(9669), "William", "Jerk" });

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
                columns: new[] { "AuthorId", "CreatedAt" },
                values: new object[] { 2, new DateTime(2024, 11, 14, 23, 53, 33, 837, DateTimeKind.Local).AddTicks(9676) });

            migrationBuilder.UpdateData(
                table: "BookGenres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "GenreId" },
                values: new object[] { new DateTime(2024, 11, 14, 23, 53, 33, 837, DateTimeKind.Local).AddTicks(9705), 1 });

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
                columns: new[] { "BookId", "CreatedAt" },
                values: new object[] { 2, new DateTime(2024, 11, 14, 23, 53, 33, 837, DateTimeKind.Local).AddTicks(9709) });

            migrationBuilder.UpdateData(
                table: "BookImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 14, 23, 53, 33, 837, DateTimeKind.Local).AddTicks(9739));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description", "ISBN", "Name", "Pages", "Price", "PublishDate", "PublisherId", "Rating" },
                values: new object[] { new DateTime(2024, 11, 14, 23, 53, 33, 837, DateTimeKind.Local).AddTicks(9645), "", "0-9742-0105-7", "Cesta do neznáma", 120, 10.0, new DateOnly(1990, 1, 2), 1, 4.0 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description", "ISBN", "Name", "Pages", "PreviewImageId", "Price", "PublishDate", "Rating" },
                values: new object[] { new DateTime(2024, 11, 14, 23, 53, 33, 837, DateTimeKind.Local).AddTicks(9655), "", "0-5613-1830-1", "Hadí princezna a 102 psů", 102, "0", 30.0, new DateOnly(2001, 3, 10), 3.2000000000000002 });

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
                columns: new[] { "CreatedAt", "GenreType" },
                values: new object[] { new DateTime(2024, 11, 14, 23, 53, 33, 837, DateTimeKind.Local).AddTicks(9697), "Horror" });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "GenreType" },
                values: new object[] { new DateTime(2024, 11, 14, 23, 53, 33, 837, DateTimeKind.Local).AddTicks(9699), "Sci-fi" });

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BookId", "CreatedAt", "PricePerItem", "Quantity" },
                values: new object[] { 1, new DateTime(2024, 11, 14, 23, 53, 33, 838, DateTimeKind.Local).AddTicks(92), 10.0, 4 });

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BookId", "CreatedAt", "OrderId", "PricePerItem", "Quantity" },
                values: new object[] { 2, new DateTime(2024, 11, 14, 23, 53, 33, 838, DateTimeKind.Local).AddTicks(96), 2, 30.0, 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "TotalPrice", "UserId" },
                values: new object[] { new DateTime(2024, 11, 14, 23, 53, 33, 838, DateTimeKind.Local).AddTicks(57), 40.0, 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "TotalPrice" },
                values: new object[] { new DateTime(2024, 11, 14, 23, 53, 33, 838, DateTimeKind.Local).AddTicks(60), 30.0 });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2024, 11, 14, 23, 53, 33, 837, DateTimeKind.Local).AddTicks(9588), "Booklord ABC" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Body", "BookId", "CreatedAt", "Rating", "UserId" },
                values: new object[] { "Great book, I loved it!", 1, new DateTime(2024, 11, 14, 23, 53, 33, 837, DateTimeKind.Local).AddTicks(9715), 4, 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Body", "BookId", "CreatedAt", "Rating" },
                values: new object[] { "I didn't like it at all.", 2, new DateTime(2024, 11, 14, 23, 53, 33, 837, DateTimeKind.Local).AddTicks(9719), 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Body", "BookId", "CreatedAt", "EditedAt" },
                values: new object[] { "I hated it.", 2, new DateTime(2024, 11, 14, 23, 53, 33, 837, DateTimeKind.Local).AddTicks(9721), new DateTime(2024, 11, 12, 23, 53, 33, 837, DateTimeKind.Local).AddTicks(9723) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Body", "BookId", "CreatedAt", "DeletedAt", "UserId" },
                values: new object[] { "Was great!", 2, new DateTime(2024, 11, 14, 23, 53, 33, 837, DateTimeKind.Local).AddTicks(9729), new DateTime(2024, 11, 11, 23, 53, 33, 837, DateTimeKind.Local).AddTicks(9731), 3 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Email", "Password", "Username" },
                values: new object[] { new DateTime(2024, 11, 14, 23, 53, 33, 837, DateTimeKind.Local).AddTicks(9684), "john335@muni.com", "123456", "johnmotika335" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Email", "Password", "Role", "Username" },
                values: new object[] { new DateTime(2024, 11, 14, 23, 53, 33, 837, DateTimeKind.Local).AddTicks(9687), "john335@muni.com", "212121", 1, "kvalitnipolevka90" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Email", "Password", "Role", "Username" },
                values: new object[] { new DateTime(2024, 11, 14, 23, 53, 33, 837, DateTimeKind.Local).AddTicks(9689), "john335@muni.com", "432343", 1, "flameboi22" });

            migrationBuilder.UpdateData(
                table: "WishListItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BookId", "CreatedAt", "UserId" },
                values: new object[] { 1, new DateTime(2024, 11, 14, 23, 53, 33, 838, DateTimeKind.Local).AddTicks(24), 1 });

            migrationBuilder.UpdateData(
                table: "WishListItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BookId", "CreatedAt" },
                values: new object[] { 2, new DateTime(2024, 11, 14, 23, 53, 33, 838, DateTimeKind.Local).AddTicks(28) });

            migrationBuilder.UpdateData(
                table: "WishListItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BookId", "CreatedAt", "UserId" },
                values: new object[] { 2, new DateTime(2024, 11, 14, 23, 53, 33, 838, DateTimeKind.Local).AddTicks(30), 2 });

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
    }
}
