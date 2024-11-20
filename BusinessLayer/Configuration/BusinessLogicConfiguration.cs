using BusinessLayer.Facades.BookFacades;
using BusinessLayer.Facades.BookFacades.Interfaces;
using BusinessLayer.Mappers;
using BusinessLayer.Mappers.Interfaces;
using BusinessLayer.Services.Author;
using BusinessLayer.Services.Author.Interfaces;
using BusinessLayer.Services.Book;
using BusinessLayer.Services.Book.Interfaces;
using BusinessLayer.Services.BookReview;
using BusinessLayer.Services.BookReview.Interfaces;
using BusinessLayer.Services.Genre;
using BusinessLayer.Services.Genre.Interfaces;
using BusinessLayer.Services.Image;
using BusinessLayer.Services.Image.Interfaces;
using BusinessLayer.Services.Order;
using BusinessLayer.Services.Order.Interfaces;
using BusinessLayer.Services.Publisher;
using BusinessLayer.Services.Publisher.Interfaces;
using BusinessLayer.Services.User;
using BusinessLayer.Services.User.Interfaces;
using BusinessLayer.Services.WishList;
using BusinessLayer.Services.WishList.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace BusinessLayer.Configuration;

public static class BusinessLogicConfiguration
{
    public static IServiceCollection RegisterBusinessLogicServices(this IServiceCollection services)
    {
        services.AddScoped<IWishlistService, WishlistService>();
        services.AddScoped<IGenreService, GenreService>();
        services.AddScoped<IPublisherService, PublisherService>();
        services.AddScoped<IUserService, UserService>();
        services.AddScoped<IAuthorService, AuthorService>();
        services.AddScoped<IOrderService, OrderService>();
        services.AddScoped<IBookService, BookService>();
        services.AddScoped<IBookReviewService, BookReviewService>();
        services.AddScoped<IImageService, ImageService>();
        services.AddScoped<IBookFacade, BookFacade>();

        services.RegisterBusinessLogicMappers();

        return services;
    }

    private static void RegisterBusinessLogicMappers(this IServiceCollection services)
    {
        services.AddSingleton<IBookMapper, BookMapper>();
        services.AddSingleton<IGenreMapper, GenreMapper>();
        services.AddSingleton<IAuthorMapper, AuthorMapper>();
        services.AddSingleton<IPublisherMapper, PublisherMapper>();
        services.AddSingleton<IUserMapper, UserMapper>();
        services.AddSingleton<IWishListItemMapper, WishListItemMapper>();
        services.AddSingleton<IOrderMapper, OrderMapper>();
        services.AddSingleton<IBookReviewMapper, BookReviewMapper>();
        services.AddSingleton<IImageMapper, ImageMapper>();
    }
}
