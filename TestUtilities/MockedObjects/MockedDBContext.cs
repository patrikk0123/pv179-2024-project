using DAL.Data;
using EntityFrameworkCore.Testing.NSubstitute.Helpers;
using TestUtilities.Data;

namespace TestUtilities.MockedObjects;

public static class MockedDBContext
{
    public static string RandomDBName => Guid.NewGuid().ToString();

    public static DbContextOptions<BookHubDBContext> GenerateNewInMemoryDBContextOptons()
    {
        var dbContextOptions = new DbContextOptionsBuilder<BookHubDBContext>()
            .UseInMemoryDatabase(RandomDBName)
            .Options;

        return dbContextOptions;
    }

    public static BookHubDBContext CreateFromOptions(DbContextOptions<BookHubDBContext> options)
    {
        var dbContextToMock = new BookHubDBContext(options);

        var dbContext = new MockedDbContextBuilder<BookHubDBContext>()
            .UseDbContext(dbContextToMock)
            .UseConstructorWithParameters(options)
            .MockedDbContext;

        PrepareData(dbContext);

        return dbContext;
    }

    public static void PrepareData(BookHubDBContext dbContext)
    {
        AddData(dbContext);
        dbContext.SaveChanges();
    }

    public static async Task PrepareDataAsync(BookHubDBContext dbContext)
    {
        AddData(dbContext);
        await dbContext.SaveChangesAsync();
    }

    private static void AddData(BookHubDBContext dbContext)
    {
        dbContext.Authors.AddRange(TestDataHelper.GetFakeAuthors());
        dbContext.Publishers.AddRange(TestDataHelper.GetFakePublishers());
        dbContext.BookAuthors.AddRange(TestDataHelper.GetFakeBookAuthors());
        dbContext.Books.AddRange(TestDataHelper.GetFakeBooks());
        dbContext.BookImages.AddRange(TestDataHelper.GetFakeBookImage());
        dbContext.Genres.AddRange(TestDataHelper.GetFakeGenres());
        dbContext.BookGenres.AddRange(TestDataHelper.GetFakeBookGenres());
        /*dbContext.Users.AddRange(TestDataHelper.GetFakeUsers());
        dbContext.Reviews.AddRange(TestDataHelper.GetFakeBookReviews());
        dbContext.WishListItems.AddRange(TestDataHelper.GetFakeWishListItems());
        dbContext.Orders.AddRange(TestDataHelper.GetFakeOrders());
        dbContext.OrdersItems.AddRange(TestDataHelper.GetFakeOrderItems());*/
    }
}
