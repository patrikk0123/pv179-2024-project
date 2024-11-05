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
    [Migration("20241020135744_AddBookAuthorPublisherEntities")]
    partial class AddBookAuthorPublisherEntities
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

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Author");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2024, 10, 20, 15, 57, 44, 38, DateTimeKind.Local).AddTicks(5140),
                            Name = "Ronald",
                            Surname = "Kingson"
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(2024, 10, 20, 15, 57, 44, 38, DateTimeKind.Local).AddTicks(5150),
                            Name = "Richard",
                            Surname = "Douchebag"
                        },
                        new
                        {
                            Id = 3,
                            Created = new DateTime(2024, 10, 20, 15, 57, 44, 38, DateTimeKind.Local).AddTicks(5150),
                            Name = "William",
                            Surname = "Jerk"
                        });
                });

            modelBuilder.Entity("DAL.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
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
                            Created = new DateTime(2024, 10, 20, 15, 57, 44, 38, DateTimeKind.Local).AddTicks(5130),
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
                            Created = new DateTime(2024, 10, 20, 15, 57, 44, 38, DateTimeKind.Local).AddTicks(5140),
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

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("BookId");

                    b.ToTable("BookAuthor");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 1,
                            BookId = 1,
                            Created = new DateTime(2024, 10, 20, 15, 57, 44, 38, DateTimeKind.Local).AddTicks(5150)
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 2,
                            BookId = 2,
                            Created = new DateTime(2024, 10, 20, 15, 57, 44, 38, DateTimeKind.Local).AddTicks(5150)
                        });
                });

            modelBuilder.Entity("DAL.Models.Publisher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Publisher");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2024, 10, 20, 15, 57, 44, 38, DateTimeKind.Local).AddTicks(5090),
                            Name = "Booklord ABC"
                        });
                });

            modelBuilder.Entity("DAL.Models.Book", b =>
                {
                    b.HasOne("DAL.Models.Publisher", "Publisher")
                        .WithMany()
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

            modelBuilder.Entity("DAL.Models.Author", b =>
                {
                    b.Navigation("BookAuthors");
                });

            modelBuilder.Entity("DAL.Models.Book", b =>
                {
                    b.Navigation("BookAuthors");
                });
#pragma warning restore 612, 618
        }
    }
}