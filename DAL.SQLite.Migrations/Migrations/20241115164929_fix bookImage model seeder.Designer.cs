﻿// <auto-generated />
using System;
using DAL.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DAL.SQLite.Migrations.Migrations
{
    [DbContext(typeof(BookHubDBContext))]
    [Migration("20241115164929_fix bookImage model seeder")]
    partial class fixbookImagemodelseeder
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true);

            modelBuilder.Entity("DAL.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("EditedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Ricky",
                            Surname = "Franecki"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Rubie",
                            Surname = "Wisozk"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Tom",
                            Surname = "Abbott"
                        });
                });

            modelBuilder.Entity("DAL.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("EditedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Pages")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PreviewImageId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<DateOnly>("PublishDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("PublisherId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Rating")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("PublisherId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Iure numquam voluptatem dolores.\nAdipisci rerum eos ea aut non ea impedit.\nDolorum minus placeat qui dolore nobis non.\nAtque magnam assumenda alias atque ducimus corrupti.",
                            ISBN = "pg9amadu6u",
                            Name = "Handmade Concrete Hat",
                            Pages = 327,
                            PreviewImageId = "1849645247",
                            Price = 52.189999999999998,
                            PublishDate = new DateOnly(2024, 7, 8),
                            PublisherId = 1,
                            Rating = 2.7660833419142676
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Non dolor explicabo.\nLaboriosam perferendis qui sit accusamus qui.\nCommodi id quo odio autem est et quaerat architecto.\nQuis magnam aut.",
                            ISBN = "kjl2r0gp2x",
                            Name = "Oklahoma",
                            Pages = 172,
                            PreviewImageId = "1849645247",
                            Price = 32.880000000000003,
                            PublishDate = new DateOnly(2024, 6, 5),
                            PublisherId = 1,
                            Rating = 2.5665950689309254
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Nihil rerum dicta vel fugit recusandae dolor.\nPariatur vel minima.\nAsperiores facilis molestiae numquam nulla quibusdam esse placeat.\nPariatur ad illo corporis et.",
                            ISBN = "56zcj0mgum",
                            Name = "high-level",
                            Pages = 393,
                            PreviewImageId = "1849645247",
                            Price = 68.430000000000007,
                            PublishDate = new DateOnly(2024, 9, 1),
                            PublisherId = 2,
                            Rating = 2.720410956870956
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Odio nihil earum.\nNisi quia ducimus ipsam voluptas quo commodi in commodi aperiam.\nEnim omnis aut vitae dolores quo enim.\nUt repellendus ipsam.",
                            ISBN = "f3dqujo7mv",
                            Name = "Colombian Peso",
                            Pages = 162,
                            PreviewImageId = "1849645247",
                            Price = 81.599999999999994,
                            PublishDate = new DateOnly(2024, 9, 26),
                            PublisherId = 2,
                            Rating = 4.2919113483707942
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Sunt veniam dolore omnis aliquam sed saepe rerum et cum.\nDolorem in ea quia.\nPossimus commodi hic.\nVero illum eveniet.",
                            ISBN = "5fmgi69ll3",
                            Name = "De-engineered",
                            Pages = 251,
                            PreviewImageId = "1849645247",
                            Price = 11.220000000000001,
                            PublishDate = new DateOnly(2023, 12, 30),
                            PublisherId = 2,
                            Rating = 3.0013645393780268
                        });
                });

            modelBuilder.Entity("DAL.Models.BookAuthor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AuthorId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("BookId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("EditedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("BookId");

                    b.ToTable("BookAuthors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 3,
                            BookId = 1,
                            CreatedAt = new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 2,
                            BookId = 2,
                            CreatedAt = new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            AuthorId = 2,
                            BookId = 3,
                            CreatedAt = new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            AuthorId = 2,
                            BookId = 4,
                            CreatedAt = new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            AuthorId = 1,
                            BookId = 5,
                            CreatedAt = new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("DAL.Models.BookGenre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BookId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("EditedAt")
                        .HasColumnType("TEXT");

                    b.Property<int>("GenreId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("GenreId");

                    b.ToTable("BookGenres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BookId = 1,
                            CreatedAt = new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            GenreId = 2
                        },
                        new
                        {
                            Id = 2,
                            BookId = 2,
                            CreatedAt = new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            GenreId = 1
                        },
                        new
                        {
                            Id = 3,
                            BookId = 3,
                            CreatedAt = new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            GenreId = 1
                        },
                        new
                        {
                            Id = 4,
                            BookId = 4,
                            CreatedAt = new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            GenreId = 2
                        },
                        new
                        {
                            Id = 5,
                            BookId = 5,
                            CreatedAt = new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            GenreId = 1
                        });
                });

            modelBuilder.Entity("DAL.Models.BookImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BookId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("EditedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.ToTable("BookImages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BookId = 1,
                            CreatedAt = new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageId = "1849645247"
                        });
                });

            modelBuilder.Entity("DAL.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("EditedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("GenreType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            GenreType = "Fantasy"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            GenreType = "Romance"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            GenreType = "Horror"
                        });
                });

            modelBuilder.Entity("DAL.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("EditedAt")
                        .HasColumnType("TEXT");

                    b.Property<double>("TotalPrice")
                        .HasColumnType("REAL");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            TotalPrice = 317.05000000000001,
                            UserId = 3
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            TotalPrice = 464.10000000000002,
                            UserId = 1
                        });
                });

            modelBuilder.Entity("DAL.Models.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BookId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("EditedAt")
                        .HasColumnType("TEXT");

                    b.Property<int>("OrderId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("PricePerItem")
                        .HasColumnType("REAL");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderItem");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BookId = 5,
                            CreatedAt = new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            OrderId = 1,
                            PricePerItem = 11.220000000000001,
                            Quantity = 5
                        },
                        new
                        {
                            Id = 2,
                            BookId = 1,
                            CreatedAt = new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            OrderId = 1,
                            PricePerItem = 52.189999999999998,
                            Quantity = 5
                        },
                        new
                        {
                            Id = 3,
                            BookId = 5,
                            CreatedAt = new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            OrderId = 2,
                            PricePerItem = 11.220000000000001,
                            Quantity = 5
                        },
                        new
                        {
                            Id = 4,
                            BookId = 4,
                            CreatedAt = new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            OrderId = 2,
                            PricePerItem = 81.599999999999994,
                            Quantity = 5
                        });
                });

            modelBuilder.Entity("DAL.Models.Publisher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("EditedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Publishers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Bernier Group"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Schmeler - Shields"
                        });
                });

            modelBuilder.Entity("DAL.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("TEXT");

                    b.Property<int>("BookId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("EditedAt")
                        .HasColumnType("TEXT");

                    b.Property<int>("Rating")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("UserId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Body = "ifomhpxikfnnvyaovdkmwjmrzhcbhaeunzuidtqhzwoymxohatfyuqcysxnzmwajaszverlbncnzuofbtvanugawwwpggqvcwfy",
                            BookId = 1,
                            CreatedAt = new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            Rating = 1,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            Body = "jidkrdddeslfqwmotscz",
                            BookId = 5,
                            CreatedAt = new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            Rating = 4,
                            UserId = 3
                        },
                        new
                        {
                            Id = 3,
                            Body = "whkdpqleasrfrwittsloulegjqebutugchnksznoghfyfhxxkjfpqrblceuzlkjgxkcjixauewhnfgabsgqlnf",
                            BookId = 1,
                            CreatedAt = new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            Rating = 2,
                            UserId = 1
                        },
                        new
                        {
                            Id = 4,
                            Body = "iofocwxyavenpmi",
                            BookId = 3,
                            CreatedAt = new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            Rating = 2,
                            UserId = 2
                        },
                        new
                        {
                            Id = 5,
                            Body = "ogvdsgftyssurdgpmpqtkpggfxereccuvbrvmlmhxdzgh",
                            BookId = 3,
                            CreatedAt = new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            Rating = 4,
                            UserId = 2
                        });
                });

            modelBuilder.Entity("DAL.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("EditedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Role")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Alivia.Gorczany@gmail.com",
                            Password = "heslo123",
                            Role = 0,
                            Username = "Pauline.Beatty"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Asa27@yahoo.com",
                            Password = "heslo123",
                            Role = 1,
                            Username = "Lizeth_Osinski"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Dayna_Towne20@hotmail.com",
                            Password = "heslo123",
                            Role = 1,
                            Username = "Lincoln53"
                        });
                });

            modelBuilder.Entity("DAL.Models.WishListItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BookId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("EditedAt")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("UserId");

                    b.ToTable("WishListItems");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BookId = 3,
                            CreatedAt = new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            BookId = 2,
                            CreatedAt = new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 2
                        },
                        new
                        {
                            Id = 3,
                            BookId = 5,
                            CreatedAt = new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 3
                        });
                });

            modelBuilder.Entity("DAL.Models.Book", b =>
                {
                    b.HasOne("DAL.Models.Publisher", "Publisher")
                        .WithMany("Books")
                        .HasForeignKey("PublisherId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.Navigation("Publisher");
                });

            modelBuilder.Entity("DAL.Models.BookAuthor", b =>
                {
                    b.HasOne("DAL.Models.Author", "Author")
                        .WithMany("BookAuthors")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.HasOne("DAL.Models.Book", "Book")
                        .WithMany("BookAuthors")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Book");
                });

            modelBuilder.Entity("DAL.Models.BookGenre", b =>
                {
                    b.HasOne("DAL.Models.Book", "Book")
                        .WithMany("BookGenres")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.HasOne("DAL.Models.Genre", "Genre")
                        .WithMany("BookGenres")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("DAL.Models.BookImage", b =>
                {
                    b.HasOne("DAL.Models.Book", "Book")
                        .WithMany("Images")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");
                });

            modelBuilder.Entity("DAL.Models.Order", b =>
                {
                    b.HasOne("DAL.Models.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("DAL.Models.OrderItem", b =>
                {
                    b.HasOne("DAL.Models.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.HasOne("DAL.Models.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("DAL.Models.Review", b =>
                {
                    b.HasOne("DAL.Models.Book", "Book")
                        .WithMany("Reviews")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.HasOne("DAL.Models.User", "User")
                        .WithMany("Reviews")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DAL.Models.WishListItem", b =>
                {
                    b.HasOne("DAL.Models.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.HasOne("DAL.Models.User", "User")
                        .WithMany("WishListItems")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DAL.Models.Author", b =>
                {
                    b.Navigation("BookAuthors");
                });

            modelBuilder.Entity("DAL.Models.Book", b =>
                {
                    b.Navigation("BookAuthors");

                    b.Navigation("BookGenres");

                    b.Navigation("Images");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("DAL.Models.Genre", b =>
                {
                    b.Navigation("BookGenres");
                });

            modelBuilder.Entity("DAL.Models.Order", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("DAL.Models.Publisher", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("DAL.Models.User", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("Reviews");

                    b.Navigation("WishListItems");
                });
#pragma warning restore 612, 618
        }
    }
}
