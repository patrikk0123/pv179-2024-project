using BusinessLayer.Mappers;
using BusinessLayer.Mappers.Interfaces;
using BusinessLayer.Services.Publisher;
using BusinessLayer.Services.Publisher.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace BusinessLayer.Configuration;

public static class BusinessLogicConfiguration
{
    public static IServiceCollection RegisterBusinessLogicServices(this IServiceCollection services)
    {
        services.AddScoped<IPublisherService, PublisherService>();

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
    }
}
