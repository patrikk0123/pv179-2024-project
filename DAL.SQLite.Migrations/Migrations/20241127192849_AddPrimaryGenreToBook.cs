using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.SQLite.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class AddPrimaryGenreToBook : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PrimaryGenreId",
                table: "Books",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "Surname" },
                values: new object[] { "Lizeth", "Osinski" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "Surname" },
                values: new object[] { "Frederique", "Price" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "Surname" },
                values: new object[] { "Evalyn", "Bogan" });

            migrationBuilder.UpdateData(
                table: "BookAuthors",
                keyColumn: "Id",
                keyValue: 1,
                column: "AuthorId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "BookAuthors",
                keyColumn: "Id",
                keyValue: 2,
                column: "AuthorId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookAuthors",
                keyColumn: "Id",
                keyValue: 3,
                column: "AuthorId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookAuthors",
                keyColumn: "Id",
                keyValue: 4,
                column: "AuthorId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "BookAuthors",
                keyColumn: "Id",
                keyValue: 5,
                column: "AuthorId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "BookGenres",
                keyColumn: "Id",
                keyValue: 1,
                column: "GenreId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "BookGenres",
                keyColumn: "Id",
                keyValue: 3,
                column: "GenreId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "BookGenres",
                keyColumn: "Id",
                keyValue: 4,
                column: "GenreId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PrimaryGenreId", "PublishDate" },
                values: new object[] { 2, new DateOnly(2024, 7, 20) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "ISBN", "Name", "Pages", "Price", "PrimaryGenreId", "PublishDate", "Rating" },
                values: new object[] { "Dolor explicabo quam laboriosam perferendis qui sit accusamus qui assumenda.\nId quo odio autem est.\nQuaerat architecto quasi quis magnam aut sunt perspiciatis.\nQuasi assumenda voluptatem blanditiis porro inventore recusandae.", "j9ea49gmfn", "Barbados Dollar", 416, 93.650000000000006, 1, new DateOnly(2023, 12, 28), 1.4557910545057575 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "ISBN", "Name", "Pages", "Price", "PrimaryGenreId", "PublishDate", "PublisherId", "Rating" },
                values: new object[] { "Quidem asperiores facilis molestiae numquam.\nQuibusdam esse placeat magnam pariatur ad illo corporis et.\nDolorem voluptatibus ex ut.\nLaborum blanditiis eos.", "msrfowp62f", "navigating", 474, 37.780000000000001, 2, new DateOnly(2024, 4, 30), 1, 4.6331177054127295 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "ISBN", "Name", "Pages", "Price", "PrimaryGenreId", "PublishDate", "Rating" },
                values: new object[] { "Commodi in commodi aperiam molestias enim omnis aut.\nDolores quo enim.\nUt repellendus ipsam.\nDicta consequatur maxime at unde cum.", "7mvv8ttw85", "software", 91, 28.600000000000001, 1, new DateOnly(2024, 10, 21), 2.136426879622241 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "ISBN", "Name", "Pages", "Price", "PrimaryGenreId", "PublishDate", "PublisherId", "Rating" },
                values: new object[] { "Et cum et dolorem in ea quia doloremque possimus commodi.\nExplicabo vero illum eveniet dolorem quam fuga ducimus cupiditate amet.\nOfficia laborum aut consequuntur ducimus.\nEt expedita fugiat dolore at ut non.", "0yghg4s1j9", "Fresh", 67, 41.579999999999998, 2, new DateOnly(2023, 12, 22), 1, 2.1027372763970575 });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                column: "GenreType",
                value: "Sci-fi");

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                column: "GenreType",
                value: "Sci-fi");

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                column: "GenreType",
                value: "Romance");

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 1,
                column: "PricePerItem",
                value: 41.579999999999998);

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BookId", "PricePerItem" },
                values: new object[] { 5, 41.579999999999998 });

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BookId", "PricePerItem" },
                values: new object[] { 1, 52.189999999999998 });

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BookId", "PricePerItem" },
                values: new object[] { 5, 41.579999999999998 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "TotalPrice", "UserId" },
                values: new object[] { 415.79999999999995, 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "TotalPrice", "UserId" },
                values: new object[] { 468.84999999999997, 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Body", "BookId", "Rating", "UserId" },
                values: new object[] { "mrzhcbhaeunzuidtqhzwoymxohatfyuqcysxnzmwajas", 3, 5, 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Body", "Rating" },
                values: new object[] { "lbncnzuofbtvanugawwwpggqvcwfytxsdjidkrdddeslfqwmotsczicfvwhkdpqleasrfrwi", 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Body", "BookId", "Rating", "UserId" },
                values: new object[] { "oulegjqebutugchnksznoghfyfhxxkjfpqrblceuzlkjgxkc", 4, 4, 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Body", "BookId", "Rating" },
                values: new object[] { "uewhnfgabsgq", 2, 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Body", "Rating" },
                values: new object[] { "lgbiofocwxyavenpmilkukogvdsgftyssurdgpmpqtkpggfxereccuvbrvmlmhxdz", 2 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "Username" },
                values: new object[] { "Shyanne.Torphy96@gmail.com", "Virginia_Bradtke" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Email", "Role", "Username" },
                values: new object[] { "Etha17@gmail.com", 0, "Xzavier.Jacobs" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Email", "Role", "Username" },
                values: new object[] { "Donato.McKenzie39@yahoo.com", 0, "Willy57" });

            migrationBuilder.UpdateData(
                table: "WishListItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "BookId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "WishListItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BookId", "UserId" },
                values: new object[] { 3, 1 });

            migrationBuilder.UpdateData(
                table: "WishListItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BookId", "UserId" },
                values: new object[] { 2, 2 });

            migrationBuilder.CreateIndex(
                name: "IX_Books_PrimaryGenreId",
                table: "Books",
                column: "PrimaryGenreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Genres_PrimaryGenreId",
                table: "Books",
                column: "PrimaryGenreId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Genres_PrimaryGenreId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_PrimaryGenreId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "PrimaryGenreId",
                table: "Books");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "Surname" },
                values: new object[] { "Ricky", "Franecki" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "Surname" },
                values: new object[] { "Rubie", "Wisozk" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "Surname" },
                values: new object[] { "Tom", "Abbott" });

            migrationBuilder.UpdateData(
                table: "BookAuthors",
                keyColumn: "Id",
                keyValue: 1,
                column: "AuthorId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "BookAuthors",
                keyColumn: "Id",
                keyValue: 2,
                column: "AuthorId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "BookAuthors",
                keyColumn: "Id",
                keyValue: 3,
                column: "AuthorId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "BookAuthors",
                keyColumn: "Id",
                keyValue: 4,
                column: "AuthorId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "BookAuthors",
                keyColumn: "Id",
                keyValue: 5,
                column: "AuthorId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookGenres",
                keyColumn: "Id",
                keyValue: 1,
                column: "GenreId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "BookGenres",
                keyColumn: "Id",
                keyValue: 3,
                column: "GenreId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookGenres",
                keyColumn: "Id",
                keyValue: 4,
                column: "GenreId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishDate",
                value: new DateOnly(2024, 7, 11));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "ISBN", "Name", "Pages", "Price", "PublishDate", "Rating" },
                values: new object[] { "Non dolor explicabo.\nLaboriosam perferendis qui sit accusamus qui.\nCommodi id quo odio autem est et quaerat architecto.\nQuis magnam aut.", "kjl2r0gp2x", "Oklahoma", 172, 32.880000000000003, new DateOnly(2024, 6, 8), 2.5665950689309254 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "ISBN", "Name", "Pages", "Price", "PublishDate", "PublisherId", "Rating" },
                values: new object[] { "Nihil rerum dicta vel fugit recusandae dolor.\nPariatur vel minima.\nAsperiores facilis molestiae numquam nulla quibusdam esse placeat.\nPariatur ad illo corporis et.", "56zcj0mgum", "high-level", 393, 68.430000000000007, new DateOnly(2024, 9, 4), 2, 2.720410956870956 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "ISBN", "Name", "Pages", "Price", "PublishDate", "Rating" },
                values: new object[] { "Odio nihil earum.\nNisi quia ducimus ipsam voluptas quo commodi in commodi aperiam.\nEnim omnis aut vitae dolores quo enim.\nUt repellendus ipsam.", "f3dqujo7mv", "Colombian Peso", 162, 81.599999999999994, new DateOnly(2024, 9, 29), 4.2919113483707942 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "ISBN", "Name", "Pages", "Price", "PublishDate", "PublisherId", "Rating" },
                values: new object[] { "Sunt veniam dolore omnis aliquam sed saepe rerum et cum.\nDolorem in ea quia.\nPossimus commodi hic.\nVero illum eveniet.", "5fmgi69ll3", "De-engineered", 251, 11.220000000000001, new DateOnly(2024, 1, 2), 2, 3.0013645393780268 });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                column: "GenreType",
                value: "Fantasy");

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                column: "GenreType",
                value: "Romance");

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                column: "GenreType",
                value: "Horror");

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 1,
                column: "PricePerItem",
                value: 11.220000000000001);

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BookId", "PricePerItem" },
                values: new object[] { 1, 52.189999999999998 });

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BookId", "PricePerItem" },
                values: new object[] { 5, 11.220000000000001 });

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BookId", "PricePerItem" },
                values: new object[] { 4, 81.599999999999994 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "TotalPrice", "UserId" },
                values: new object[] { 317.05000000000001, 3 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "TotalPrice", "UserId" },
                values: new object[] { 464.10000000000002, 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Body", "BookId", "Rating", "UserId" },
                values: new object[] { "ifomhpxikfnnvyaovdkmwjmrzhcbhaeunzuidtqhzwoymxohatfyuqcysxnzmwajaszverlbncnzuofbtvanugawwwpggqvcwfy", 1, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Body", "Rating" },
                values: new object[] { "jidkrdddeslfqwmotscz", 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Body", "BookId", "Rating", "UserId" },
                values: new object[] { "whkdpqleasrfrwittsloulegjqebutugchnksznoghfyfhxxkjfpqrblceuzlkjgxkcjixauewhnfgabsgqlnf", 1, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Body", "BookId", "Rating" },
                values: new object[] { "iofocwxyavenpmi", 3, 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Body", "Rating" },
                values: new object[] { "ogvdsgftyssurdgpmpqtkpggfxereccuvbrvmlmhxdzgh", 4 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "Username" },
                values: new object[] { "Alivia.Gorczany@gmail.com", "Pauline.Beatty" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Email", "Role", "Username" },
                values: new object[] { "Asa27@yahoo.com", 1, "Lizeth_Osinski" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Email", "Role", "Username" },
                values: new object[] { "Dayna_Towne20@hotmail.com", 1, "Lincoln53" });

            migrationBuilder.UpdateData(
                table: "WishListItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "BookId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "WishListItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BookId", "UserId" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "WishListItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BookId", "UserId" },
                values: new object[] { 5, 3 });
        }
    }
}
