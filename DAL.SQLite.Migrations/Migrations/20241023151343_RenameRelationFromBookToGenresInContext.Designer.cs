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
    [Migration("20241023151343_RenameRelationFromBookToGenresInContext")]
    partial class RenameRelationFromBookToGenresInContext
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
                            CreatedAt = new DateTime(2024, 10, 23, 17, 13, 43, 575, DateTimeKind.Local).AddTicks(3240),
                            Name = "Ronald",
                            Surname = "Kingson"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 10, 23, 17, 13, 43, 575, DateTimeKind.Local).AddTicks(3240),
                            Name = "Richard",
                            Surname = "Douchebag"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 10, 23, 17, 13, 43, 575, DateTimeKind.Local).AddTicks(3250),
                            Name = "William",
                            Surname = "Jerk"
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
                            CreatedAt = new DateTime(2024, 10, 23, 17, 13, 43, 575, DateTimeKind.Local).AddTicks(3220),
                            Description = "",
                            ISBN = "0-9742-0105-7",
                            Name = "Cesta do neznáma",
                            Pages = 120,
                            Price = 10.0,
                            PublishDate = new DateOnly(1990, 1, 2),
                            PublisherId = 1,
                            Rating = 4.0
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 10, 23, 17, 13, 43, 575, DateTimeKind.Local).AddTicks(3230),
                            Description = "",
                            ISBN = "0-5613-1830-1",
                            Name = "Hadí princezna a 102 psů",
                            Pages = 102,
                            Price = 30.0,
                            PublishDate = new DateOnly(2001, 3, 10),
                            PublisherId = 1,
                            Rating = 3.2000000000000002
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
                            AuthorId = 1,
                            BookId = 1,
                            CreatedAt = new DateTime(2024, 10, 23, 17, 13, 43, 575, DateTimeKind.Local).AddTicks(3250)
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 2,
                            BookId = 2,
                            CreatedAt = new DateTime(2024, 10, 23, 17, 13, 43, 575, DateTimeKind.Local).AddTicks(3250)
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
                            CreatedAt = new DateTime(2024, 10, 23, 17, 13, 43, 575, DateTimeKind.Local).AddTicks(3280),
                            GenreId = 1
                        },
                        new
                        {
                            Id = 2,
                            BookId = 2,
                            CreatedAt = new DateTime(2024, 10, 23, 17, 13, 43, 575, DateTimeKind.Local).AddTicks(3280),
                            GenreId = 2
                        },
                        new
                        {
                            Id = 3,
                            BookId = 2,
                            CreatedAt = new DateTime(2024, 10, 23, 17, 13, 43, 575, DateTimeKind.Local).AddTicks(3280),
                            GenreId = 3
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
                            CreatedAt = new DateTime(2024, 10, 23, 17, 13, 43, 575, DateTimeKind.Local).AddTicks(3270),
                            GenreType = "Fantasy"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 10, 23, 17, 13, 43, 575, DateTimeKind.Local).AddTicks(3270),
                            GenreType = "Horror"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 10, 23, 17, 13, 43, 575, DateTimeKind.Local).AddTicks(3270),
                            GenreType = "Sci-fi"
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
                            CreatedAt = new DateTime(2024, 10, 23, 17, 13, 43, 575, DateTimeKind.Local).AddTicks(3550),
                            TotalPrice = 40.0,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 10, 23, 17, 13, 43, 575, DateTimeKind.Local).AddTicks(3550),
                            TotalPrice = 30.0,
                            UserId = 2
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
                            BookId = 1,
                            CreatedAt = new DateTime(2024, 10, 23, 17, 13, 43, 575, DateTimeKind.Local).AddTicks(3570),
                            OrderId = 1,
                            PricePerItem = 10.0,
                            Quantity = 4
                        },
                        new
                        {
                            Id = 2,
                            BookId = 2,
                            CreatedAt = new DateTime(2024, 10, 23, 17, 13, 43, 575, DateTimeKind.Local).AddTicks(3570),
                            OrderId = 2,
                            PricePerItem = 30.0,
                            Quantity = 1
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
                            CreatedAt = new DateTime(2024, 10, 23, 17, 13, 43, 575, DateTimeKind.Local).AddTicks(3180),
                            Name = "Booklord ABC"
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
                            Body = "Great book, I loved it!",
                            BookId = 1,
                            CreatedAt = new DateTime(2024, 10, 23, 17, 13, 43, 575, DateTimeKind.Local).AddTicks(3290),
                            Rating = 4,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            Body = "I didn't like it at all.",
                            BookId = 2,
                            CreatedAt = new DateTime(2024, 10, 23, 17, 13, 43, 575, DateTimeKind.Local).AddTicks(3290),
                            Rating = 2,
                            UserId = 1
                        },
                        new
                        {
                            Id = 3,
                            Body = "I hated it.",
                            BookId = 2,
                            CreatedAt = new DateTime(2024, 10, 23, 17, 13, 43, 575, DateTimeKind.Local).AddTicks(3290),
                            EditedAt = new DateTime(2024, 10, 21, 17, 13, 43, 575, DateTimeKind.Local).AddTicks(3300),
                            Rating = 1,
                            UserId = 2
                        },
                        new
                        {
                            Id = 4,
                            Body = "Was great!",
                            BookId = 2,
                            CreatedAt = new DateTime(2024, 10, 23, 17, 13, 43, 575, DateTimeKind.Local).AddTicks(3300),
                            DeletedAt = new DateTime(2024, 10, 20, 17, 13, 43, 575, DateTimeKind.Local).AddTicks(3300),
                            Rating = 5,
                            UserId = 3
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
                            CreatedAt = new DateTime(2024, 10, 23, 17, 13, 43, 575, DateTimeKind.Local).AddTicks(3260),
                            Email = "john335@muni.com",
                            Password = "123456",
                            Role = 0,
                            Username = "johnmotika335"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 10, 23, 17, 13, 43, 575, DateTimeKind.Local).AddTicks(3260),
                            Email = "john335@muni.com",
                            Password = "212121",
                            Role = 1,
                            Username = "kvalitnipolevka90"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 10, 23, 17, 13, 43, 575, DateTimeKind.Local).AddTicks(3270),
                            Email = "john335@muni.com",
                            Password = "432343",
                            Role = 1,
                            Username = "flameboi22"
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
                            BookId = 1,
                            CreatedAt = new DateTime(2024, 10, 23, 17, 13, 43, 575, DateTimeKind.Local).AddTicks(3530),
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            BookId = 2,
                            CreatedAt = new DateTime(2024, 10, 23, 17, 13, 43, 575, DateTimeKind.Local).AddTicks(3530),
                            UserId = 1
                        },
                        new
                        {
                            Id = 3,
                            BookId = 2,
                            CreatedAt = new DateTime(2024, 10, 23, 17, 13, 43, 575, DateTimeKind.Local).AddTicks(3530),
                            UserId = 2
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

            modelBuilder.Entity("DAL.Models.Order", b =>
                {
                    b.HasOne("DAL.Models.User", "user")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.Navigation("user");
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
