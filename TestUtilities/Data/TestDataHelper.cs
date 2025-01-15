using DAL.Models;

namespace TestUtilities.Data;

public static class TestDataHelper
{
    public static List<Author> GetFakeAuthors()
    {
        return
        [
            new Author()
            {
                Id = 1,
                Name = "John",
                Surname = "Doe",
            },
            new Author()
            {
                Id = 2,
                Name = "Jane",
                Surname = "Doe",
            },
            new Author()
            {
                Id = 3,
                Name = "John",
                Surname = "Smith",
            },
        ];
    }

    public static List<Publisher> GetFakePublishers()
    {
        return
        [
            new Publisher { Id = 1, Name = "Penguin s.r.o" },
            new Publisher { Id = 2, Name = "Panta Rhei Books" },
        ];
    }

    public static List<Book> GetFakeBooks()
    {
        return
        [
            new Book
            {
                Name = "Book1",
                ISBN = "1234567890123",
                PublisherId = 1,
                Pages = 111,
                Description = "lorem ipsum",
                Price = 20.5,
                PublishDate = new DateOnly(2021, 1, 1),
                PreviewImageId = "1849645247",
                PrimaryGenreId = 1,
                Rating = 3,
            },
            new Book
            {
                Name = "Book2",
                ISBN = "1234567890124",
                PublisherId = 2,
                Pages = 222,
                Description = "lorem ipsum",
                Price = 25.5,
                PublishDate = new DateOnly(2021, 2, 2),
                PreviewImageId = "1849645247",
                PrimaryGenreId = 2,
                Rating = 4,
            },
            new Book
            {
                Name = "Book3",
                ISBN = "1234567890125",
                PublisherId = 1,
                Pages = 333,
                Description = "lorem ipsum",
                Price = 30.5,
                PublishDate = new DateOnly(2021, 3, 3),
                PreviewImageId = "1849645247",
                PrimaryGenreId = 2,
                Rating = 5.0,
            },
        ];
    }

    public static List<BookImage> GetFakeBookImage()
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

    public static List<Genre> GetFakeGenres()
    {
        return
        [
            new Genre { Id = 1, GenreType = "Fantasy" },
            new Genre { Id = 2, GenreType = "Science Fiction" },
            new Genre { Id = 3, GenreType = "Horror" },
        ];
    }

    public static List<BookGenre> GetFakeBookGenres()
    {
        return
        [
            new BookGenre { BookId = 1, GenreId = 1 },
            new BookGenre { BookId = 2, GenreId = 2 },
            new BookGenre { BookId = 3, GenreId = 3 },
        ];
    }

    public static List<BookAuthor> GetFakeBookAuthors()
    {
        return
        [
            new BookAuthor { BookId = 1, AuthorId = 1 },
            new BookAuthor { BookId = 2, AuthorId = 2 },
            new BookAuthor { BookId = 3, AuthorId = 3 },
        ];
    }

    public static List<User> GetFakeUsers()
    {
        return
        [
            new User
            {
                Id = 1,
                Username = "user1",
                Email = "admin@aaa.cz",
                Role = UserRole.Admin,
            },
            new User
            {
                Id = 2,
                Username = "user2",
                Email = "user@aaa.cz",
                Role = UserRole.User,
            },
        ];
    }

    public static List<WishListItem> GetFakeWishListItems()
    {
        return [new WishListItem { UserId = 2, BookId = 3 }];
    }

    public static List<Order> GetFakeOrders()
    {
        return
        [
            new Order
            {
                Id = 1,
                UserId = 2,
                TotalPrice = 20.5,
                OrderStatus = OrderStatus.Shipped,
            },
        ];
    }

    public static List<OrderItem> GetFakeOrderItems()
    {
        return
        [
            new OrderItem
            {
                OrderId = 1,
                BookId = 1,
                Quantity = 1,
            },
        ];
    }

    public static List<Review> GetFakeBookReviews()
    {
        return
        [
            new Review
            {
                BookId = 1,
                UserId = 2,
                Rating = 3,
                Body = "Bad book",
            },
            new Review
            {
                BookId = 2,
                UserId = 2,
                Rating = 4,
                Body = "Good book",
            },
            new Review
            {
                BookId = 3,
                UserId = 2,
                Rating = 5,
                Body = "Perfect book",
            },
        ];
    }
}
