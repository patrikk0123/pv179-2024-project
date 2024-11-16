﻿using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL.Data;

public static class DataInitializer
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        var publishers = PreparePublisherModels();
        var books = PrepareBookModels();
        var authors = PrepareAuthorModels();
        var bookAuthors = PrepareBookAuthorModels();
        var users = PrepareUserModels();
        var genres = PrepareGenreModels();
        var bookGenres = PrepareBookGenreModels();
        var reviews = PrepareReviewModels();
        var bookImages = PrepareBookImageModels();

        modelBuilder.Entity<Publisher>().HasData(publishers);
        modelBuilder.Entity<Book>().HasData(books);
        modelBuilder.Entity<BookImage>().HasData(bookImages);
        modelBuilder.Entity<Author>().HasData(authors);
        modelBuilder.Entity<BookAuthor>().HasData(bookAuthors);
        modelBuilder.Entity<User>().HasData(users);
        modelBuilder.Entity<Genre>().HasData(genres);
        modelBuilder.Entity<BookGenre>().HasData(bookGenres);
        modelBuilder.Entity<Review>().HasData(reviews);
        modelBuilder.Entity<WishListItem>().HasData(PrepareWishListItems());
        modelBuilder.Entity<Order>().HasData(PrepareOrders());
        modelBuilder.Entity<OrderItem>().HasData(PrepareOrdersItem());
    }

    private static List<Publisher> PreparePublisherModels()
    {
        return [new() { Id = 1, Name = "Booklord ABC" }];
    }

    private static List<Book> PrepareBookModels()
    {
        return
        [
            new()
            {
                Id = 1,
                Name = "Cesta do neznáma",
                Description = "",
                ISBN = "0-9742-0105-7",
                PublishDate = new DateOnly(1990, 1, 2),
                Pages = 120,
                Rating = 4.0,
                Price = 10.0,
                PublisherId = 1,
                PreviewImageId = "1849645247",
            },
            new()
            {
                Id = 2,
                Name = "Hadí princezna a 102 psů",
                Description = "",
                ISBN = "0-5613-1830-1",
                PublishDate = new DateOnly(2001, 3, 10),
                Pages = 102,
                Rating = 3.2,
                Price = 30.0,
                PublisherId = 1,
            },
        ];
    }

    private static List<BookImage> PrepareBookImageModels()
    {
        return
        [
            new()
            {
                Id = 1,
                BookId = 1,
                ImageId = "1849645247",
            },
        ];
    }

    private static List<Author> PrepareAuthorModels()
    {
        return
        [
            new()
            {
                Id = 1,
                Name = "Ronald",
                Surname = "Kingson",
            },
            new()
            {
                Id = 2,
                Name = "Richard",
                Surname = "Douchebag",
            },
            new Author()
            {
                Id = 3,
                Name = "William",
                Surname = "Jerk",
            },
        ];
    }

    private static List<BookAuthor> PrepareBookAuthorModels()
    {
        return
        [
            new()
            {
                Id = 1,
                BookId = 1,
                AuthorId = 1,
            },
            new()
            {
                Id = 2,
                BookId = 2,
                AuthorId = 2,
            },
        ];
    }

    private static List<User> PrepareUserModels()
    {
        return
        [
            new()
            {
                Id = 1,
                Username = "johnmotika335",
                Email = "john335@muni.com",
                Role = UserRole.Admin,
            },
            new()
            {
                Id = 2,
                Username = "kvalitnipolevka90",
                Email = "john335@muni.com",
                Role = UserRole.User,
            },
            new()
            {
                Id = 3,
                Username = "flameboi22",
                Email = "john335@muni.com",
                Role = UserRole.User,
            },
        ];
    }

    private static List<Review> PrepareReviewModels()
    {
        return
        [
            new()
            {
                Id = 1,
                UserId = 1,
                BookId = 1,
                Rating = 4,
                Body = "Great book, I loved it!",
            },
            new()
            {
                Id = 2,
                UserId = 1,
                BookId = 2,
                Rating = 2,
                Body = "I didn't like it at all.",
            },
            new()
            {
                Id = 3,
                UserId = 2,
                BookId = 2,
                Rating = 1,
                Body = "I hated it.",
                EditedAt = DateTime.Now - TimeSpan.FromDays(2),
            },
            new()
            {
                Id = 4,
                UserId = 3,
                BookId = 2,
                Rating = 5,
                Body = "Was great!",
                DeletedAt = DateTime.Now - TimeSpan.FromDays(3),
            },
        ];
    }

    private static List<Genre> PrepareGenreModels()
    {
        return
        [
            new() { Id = 1, GenreType = "Fantasy" },
            new() { Id = 2, GenreType = "Horror" },
            new() { Id = 3, GenreType = "Sci-fi" },
        ];
    }

    private static List<BookGenre> PrepareBookGenreModels()
    {
        return
        [
            new()
            {
                Id = 1,
                BookId = 1,
                GenreId = 1,
            },
            new()
            {
                Id = 2,
                BookId = 2,
                GenreId = 2,
            },
            new()
            {
                Id = 3,
                BookId = 2,
                GenreId = 3,
            },
        ];
    }

    private static List<WishListItem> PrepareWishListItems()
    {
        return
        [
            new()
            {
                Id = 1,
                UserId = 1,
                BookId = 1,
            },
            new()
            {
                Id = 2,
                UserId = 1,
                BookId = 2,
            },
            new()
            {
                Id = 3,
                UserId = 2,
                BookId = 2,
            },
        ];
    }

    private static List<Order> PrepareOrders()
    {
        return
        [
            new()
            {
                Id = 1,
                TotalPrice = 40.0,
                UserId = 1,
            },
            new()
            {
                Id = 2,
                TotalPrice = 30.0,
                UserId = 2,
            },
        ];
    }

    private static List<OrderItem> PrepareOrdersItem()
    {
        return
        [
            new()
            {
                Id = 1,
                OrderId = 1,
                BookId = 1,
                Quantity = 4,
                PricePerItem = 10.0,
            },
            new()
            {
                Id = 2,
                OrderId = 2,
                BookId = 2,
                Quantity = 1,
                PricePerItem = 30.0,
            },
        ];
    }
}
