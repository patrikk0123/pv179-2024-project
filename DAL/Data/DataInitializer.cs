using Bogus;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL.Data;

public static class DataInitializer
{
    private const int PublisherCount = 2;
    private const int BookCount = 5;
    private const int AuthorCount = 3;
    private const int GenreCount = 3;
    private const int UserCount = 3;
    private const int ReviewCount = 5;
    private const int WishListItemCount = 3;
    private const int OrderCount = 2;

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
        var wishListItems = PrepareWishListItems();
        var orderItems = PrepareOrdersItem(books);
        var orders = PrepareOrders(orderItems);

        modelBuilder.Entity<Publisher>().HasData(publishers);
        modelBuilder.Entity<Book>().HasData(books);
        modelBuilder.Entity<BookImage>().HasData(bookImages);
        modelBuilder.Entity<Author>().HasData(authors);
        modelBuilder.Entity<BookAuthor>().HasData(bookAuthors);
        modelBuilder.Entity<User>().HasData(users);
        modelBuilder.Entity<Genre>().HasData(genres);
        modelBuilder.Entity<BookGenre>().HasData(bookGenres);
        modelBuilder.Entity<Review>().HasData(reviews);
        modelBuilder.Entity<WishListItem>().HasData(wishListItems);
        modelBuilder.Entity<Order>().HasData(orders);
        modelBuilder.Entity<OrderItem>().HasData(orderItems);
    }

    private static List<Publisher> PreparePublisherModels()
    {
        var publisherIds = 1;
        var testPublisher = new Faker<Publisher>()
            .StrictMode(true)
            .RuleFor(o => o.Id, _ => publisherIds++)
            .RuleFor(o => o.Name, f => f.Company.CompanyName())
            .RuleFor(o => o.Books, _ => [])
            .RuleFor(o => o.CreatedAt, _ => DateTime.Now)
            .RuleFor(o => o.EditedAt, _ => null)
            .RuleFor(o => o.DeletedAt, _ => null);

        return testPublisher.Generate(PublisherCount);
    }

    private static List<Book> PrepareBookModels()
    {
        var bookId = 1;
        var testBooks = new Faker<Book>()
            .StrictMode(true)
            .RuleFor(o => o.Id, _ => bookId++)
            .RuleFor(o => o.Name, f => f.Random.Words(1))
            .RuleFor(o => o.Description, f => f.Lorem.Sentences(4))
            .RuleFor(o => o.ISBN, f => f.Random.AlphaNumeric(10))
            .RuleFor(o => o.PublishDate, f => f.Date.PastDateOnly())
            .RuleFor(o => o.Pages, f => f.Random.Int(50, 500))
            .RuleFor(o => o.Rating, f => f.Random.Double(1, 5))
            .RuleFor(o => o.Price, f => f.Random.Double(1, 100))
            .RuleFor(o => o.PublisherId, f => f.Random.Int(1, 2))
            .RuleFor(o => o.PreviewImageId, (_, _) => "1849645247")
            .RuleFor(o => o.Publisher, _ => null)
            .RuleFor(o => o.BookAuthors, _ => [])
            .RuleFor(o => o.BookGenres, _ => [])
            .RuleFor(o => o.Reviews, _ => [])
            .RuleFor(o => o.Images, _ => [])
            .RuleFor(o => o.CreatedAt, _ => DateTime.Now)
            .RuleFor(o => o.EditedAt, _ => null)
            .RuleFor(o => o.DeletedAt, _ => null);

        return testBooks.Generate(BookCount);
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
        var authorId = 1;
        var testAuthors = new Faker<Author>()
            .StrictMode(true)
            .RuleFor(o => o.Id, _ => authorId++)
            .RuleFor(o => o.Name, f => f.Name.FirstName())
            .RuleFor(o => o.Surname, f => f.Name.LastName())
            .RuleFor(o => o.BookAuthors, _ => [])
            .RuleFor(o => o.CreatedAt, _ => DateTime.Now)
            .RuleFor(o => o.EditedAt, _ => null)
            .RuleFor(o => o.DeletedAt, _ => null);

        return testAuthors.Generate(AuthorCount);
    }

    private static List<BookAuthor> PrepareBookAuthorModels()
    {
        var bookAuthorId = 1;
        var bookId = 1;
        var testsBookAuthors = new Faker<BookAuthor>()
            .StrictMode(true)
            .RuleFor(o => o.Id, _ => bookAuthorId++)
            .RuleFor(o => o.BookId, _ => bookId++)
            .RuleFor(o => o.AuthorId, f => f.Random.Int(1, AuthorCount))
            .RuleFor(o => o.Book, _ => null)
            .RuleFor(o => o.Author, _ => null)
            .RuleFor(o => o.CreatedAt, _ => DateTime.Now)
            .RuleFor(o => o.EditedAt, _ => null)
            .RuleFor(o => o.DeletedAt, _ => null);

        return testsBookAuthors.Generate(BookCount);
    }

    private static List<User> PrepareUserModels()
    {
        var userId = 1;
        var testUsers = new Faker<User>()
            .StrictMode(true)
            .RuleFor(o => o.Id, _ => userId++)
            .RuleFor(o => o.Username, f => f.Internet.UserName())
            .RuleFor(o => o.Password, _ => "heslo123")
            .RuleFor(o => o.Email, f => f.Internet.Email())
            .RuleFor(o => o.Role, f => f.PickRandom<UserRole>())
            .RuleFor(o => o.WishListItems, _ => [])
            .RuleFor(o => o.Orders, _ => [])
            .RuleFor(o => o.Reviews, _ => [])
            .RuleFor(o => o.CreatedAt, _ => DateTime.Now)
            .RuleFor(o => o.EditedAt, _ => null)
            .RuleFor(o => o.DeletedAt, _ => null);

        return testUsers.Generate(UserCount);
    }

    private static List<Review> PrepareReviewModels()
    {
        var reviewId = 1;
        var testReviews = new Faker<Review>()
            .StrictMode(true)
            .RuleFor(o => o.Id, _ => reviewId++)
            .RuleFor(o => o.UserId, f => f.Random.Int(1, UserCount))
            .RuleFor(o => o.BookId, f => f.Random.Int(1, BookCount))
            .RuleFor(o => o.Rating, f => f.Random.Int(1, 5))
            .RuleFor(o => o.Body, f => f.Lorem.Random.String2(10, 100))
            .RuleFor(o => o.User, _ => null)
            .RuleFor(o => o.Book, _ => null)
            .RuleFor(o => o.CreatedAt, _ => DateTime.Now)
            .RuleFor(o => o.EditedAt, _ => null)
            .RuleFor(o => o.DeletedAt, _ => null);

        return testReviews.Generate(ReviewCount);
    }

    private static List<Genre> PrepareGenreModels()
    {
        var genreId = 1;
        var testGenres = new Faker<Genre>()
            .StrictMode(true)
            .RuleFor(o => o.Id, _ => genreId++)
            .RuleFor(o => o.GenreType, f => f.PickRandom("Fantasy", "Horror", "Sci-fi", "Romance"))
            .RuleFor(o => o.BookGenres, _ => [])
            .RuleFor(o => o.CreatedAt, _ => DateTime.Now)
            .RuleFor(o => o.EditedAt, _ => null)
            .RuleFor(o => o.DeletedAt, _ => null);

        return testGenres.Generate(GenreCount);
    }

    private static List<BookGenre> PrepareBookGenreModels()
    {
        var bookGenreId = 1;
        var bookId = 1;
        var testBookGenres = new Faker<BookGenre>()
            .StrictMode(true)
            .RuleFor(o => o.Id, _ => bookGenreId++)
            .RuleFor(o => o.BookId, _ => bookId++)
            .RuleFor(o => o.GenreId, f => f.Random.Int(1, GenreCount))
            .RuleFor(o => o.Book, _ => null)
            .RuleFor(o => o.Genre, _ => null)
            .RuleFor(o => o.CreatedAt, _ => DateTime.Now)
            .RuleFor(o => o.EditedAt, _ => null)
            .RuleFor(o => o.DeletedAt, _ => null);

        return testBookGenres.Generate(BookCount);
    }

    private static List<WishListItem> PrepareWishListItems()
    {
        var wishListItemId = 1;
        var testWishListItems = new Faker<WishListItem>()
            .StrictMode(true)
            .RuleFor(o => o.Id, _ => wishListItemId++)
            .RuleFor(o => o.UserId, f => f.Random.Int(1, UserCount))
            .RuleFor(o => o.BookId, f => f.Random.Int(1, BookCount))
            .RuleFor(o => o.Book, _ => null!)
            .RuleFor(o => o.User, _ => null)
            .RuleFor(o => o.CreatedAt, _ => DateTime.Now)
            .RuleFor(o => o.EditedAt, _ => null)
            .RuleFor(o => o.DeletedAt, _ => null);

        return testWishListItems.Generate(WishListItemCount);
    }

    private static List<Order> PrepareOrders(List<OrderItem> orderItems)
    {
        var orderId = 1;
        var testOrders = new Faker<Order>()
            .StrictMode(true)
            .RuleFor(o => o.Id, _ => orderId++)
            .RuleFor(
                o => o.TotalPrice,
                (_, o) =>
                    orderItems
                        .Where(oi => oi.OrderId == o.Id)
                        .Sum(oi => oi.PricePerItem * oi.Quantity)
            )
            .RuleFor(o => o.UserId, f => f.Random.Int(1, UserCount))
            .RuleFor(o => o.User, _ => null!)
            .RuleFor(o => o.OrderItems, _ => null!)
            .RuleFor(o => o.CreatedAt, _ => DateTime.Now)
            .RuleFor(o => o.EditedAt, _ => null)
            .RuleFor(o => o.DeletedAt, _ => null);

        return testOrders.Generate(OrderCount);
    }

    private static List<OrderItem> PrepareOrdersItem(List<Book> books)
    {
        var orderItemId = 1;

        List<OrderItem> orderItems = [];

        for (int i = 0; i < OrderCount; i++)
        {
            var testOrdersItems = new Faker<OrderItem>()
                .RuleFor(o => o.Id, _ => orderItemId++)
                .RuleFor(o => o.OrderId, _ => i + 1)
                .RuleFor(o => o.BookId, f => f.Random.Int(1, BookCount))
                .RuleFor(o => o.Quantity, f => f.Random.Int(1, 5))
                .RuleFor(
                    o => o.PricePerItem,
                    (_, o) => books.Find(b => b.Id == o.BookId)?.Price ?? 0.0
                )
                .RuleFor(o => o.CreatedAt, _ => DateTime.Now)
                .RuleFor(o => o.EditedAt, _ => null)
                .RuleFor(o => o.DeletedAt, _ => null);

            orderItems.AddRange(testOrdersItems.Generate(2));
        }

        return orderItems;
    }
}
