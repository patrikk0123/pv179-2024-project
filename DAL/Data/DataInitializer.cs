using DAL.Models;
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

        modelBuilder.Entity<Publisher>().HasData(publishers);
        modelBuilder.Entity<Book>().HasData(books);
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
        return new List<Publisher>()
        {
            new Publisher() { Id = 1, Name = "Booklord ABC" },
        };
    }

    private static List<Book> PrepareBookModels()
    {
        return new List<Book>()
        {
            new Book()
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
            },
            new Book()
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
        };
    }

    private static List<Author> PrepareAuthorModels()
    {
        return new List<Author>()
        {
            new Author()
            {
                Id = 1,
                Name = "Ronald",
                Surname = "Kingson",
            },
            new Author()
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
        };
    }

    private static List<BookAuthor> PrepareBookAuthorModels()
    {
        return new List<BookAuthor>()
        {
            new BookAuthor()
            {
                Id = 1,
                BookId = 1,
                AuthorId = 1,
            },
            new BookAuthor()
            {
                Id = 2,
                BookId = 2,
                AuthorId = 2,
            },
        };
    }

    private static List<User> PrepareUserModels()
    {
        return new List<User>()
        {
            new User()
            {
                Id = 1,
                Username = "johnmotika335",
                Password = "123456",
                Email = "john335@muni.com",
                Role = UserRole.Admin,
            },
            new User()
            {
                Id = 2,
                Username = "kvalitnipolevka90",
                Password = "212121",
                Email = "john335@muni.com",
                Role = UserRole.User,
            },
            new User()
            {
                Id = 3,
                Username = "flameboi22",
                Password = "432343",
                Email = "john335@muni.com",
                Role = UserRole.User,
            },
        };
    }

    private static List<Review> PrepareReviewModels()
    {
        return new List<Review>()
        {
            new Review()
            {
                Id = 1,
                UserId = 1,
                BookId = 1,
                Rating = 4,
                Body = "Great book, I loved it!",
            },
            new Review()
            {
                Id = 2,
                UserId = 1,
                BookId = 2,
                Rating = 2,
                Body = "I didn't like it at all.",
            },
            new Review()
            {
                Id = 3,
                UserId = 2,
                BookId = 2,
                Rating = 1,
                Body = "I hated it.",
            },
        };
    }

    private static List<Genre> PrepareGenreModels()
    {
        return new List<Genre>()
        {
            new Genre() { Id = 1, GenreType = "Fantasy" },
            new Genre() { Id = 2, GenreType = "Horror" },
            new Genre() { Id = 3, GenreType = "Sci-fi" },
        };
    }

    private static List<BookGenre> PrepareBookGenreModels()
    {
        return new List<BookGenre>()
        {
            new BookGenre()
            {
                Id = 1,
                BookId = 1,
                GenreId = 1,
            },
            new BookGenre()
            {
                Id = 2,
                BookId = 2,
                GenreId = 2,
            },
            new BookGenre()
            {
                Id = 3,
                BookId = 2,
                GenreId = 3,
            },
        };
    }

    private static List<WishListItem> PrepareWishListItems()
    {
        return new List<WishListItem>()
        {
            new WishListItem()
            {
                Id = 1,
                UserId = 1,
                BookId = 1,
            },
            new WishListItem()
            {
                Id = 2,
                UserId = 1,
                BookId = 2,
            },
            new WishListItem()
            {
                Id = 3,
                UserId = 2,
                BookId = 2,
            },
        };
    }

    private static List<Order> PrepareOrders()
    {
        return new List<Order>()
        {
            new Order()
            {
                Id = 1,
                TotalPrice = 40.0,
                UserId = 1,
            },
            new Order()
            {
                Id = 2,
                TotalPrice = 30.0,
                UserId = 2,
            },
        };
    }

    private static List<OrderItem> PrepareOrdersItem()
    {
        return new List<OrderItem>()
        {
            new OrderItem()
            {
                Id = 1,
                OrderId = 1,
                BookId = 1,
                Quantity = 4,
                PricePerItem = 10.0,
            },
            new OrderItem()
            {
                Id = 2,
                OrderId = 2,
                BookId = 2,
                Quantity = 1,
                PricePerItem = 30.0,
            },
        };
    }
}
