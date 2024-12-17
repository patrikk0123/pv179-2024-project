using BusinessLayer.DTOs.Book;
using BusinessLayer.DTOs.Genre;
using BusinessLayer.DTOs.Order;
using BusinessLayer.DTOs.Publisher;
using BusinessLayer.DTOs.User;
using BusinessLayer.DTOs.WishListItem;
using Mapster;
using WebMVC.Areas.Admin.ViewModels.Books;
using WebMVC.Areas.Admin.ViewModels.Genres;
using WebMVC.Areas.Admin.ViewModels.Publisher;
using WebMVC.Areas.Admin.ViewModels.Users;
using WebMVC.ViewModels.Book;
using WebMVC.ViewModels.Order;
using WebMVC.ViewModels.User;
using WebMVC.ViewModels.WishListItem;
using BookViewModel = WebMVC.ViewModels.Book.BookViewModel;

namespace WebMVC.Configuration;

public static class MapsterConfig
{
    public static void Setup()
    {
        SetupAdminViewModel();

        TypeAdapterConfig<BookDto, BookViewModel>
            .NewConfig()
            .Map(
                dest => dest.Authors,
                src => src.Authors.ConvertAll(author => $"{author.Name} {author.Surname}")
            )
            .Map(dest => dest.PreviewImage, src => src.PreviewImage.Data);

        TypeAdapterConfig<BookDetailDto, BookDetailViewModel>
            .NewConfig()
            .Map(
                dest => dest.Authors,
                src => src.Authors.ConvertAll(author => $"{author.Name} {author.Surname}")
            )
            .Map(dest => dest.PrimaryGenre, src => src.PrimaryGenre.GenreType)
            .Map(
                dest => dest.SecondaryGenres,
                src =>
                    src.Genres.Where(genre => genre.Id != src.PrimaryGenre.Id)
                        .Select(genre => genre.GenreType)
                        .ToList()
            )
            .Map(dest => dest.PreviewImage, src => src.PreviewImage.Data);

        TypeAdapterConfig<List<WishListItemDetailDto>, WishListViewModel>
            .NewConfig()
            .Map(
                dest => dest.WishListItems,
                src =>
                    src.ConvertAll(wishListItem =>
                        wishListItem.Adapt<WishListItemDetailViewModel>()
                    )
            );

        TypeAdapterConfig<List<OrderDto>, OrderListViewModel>
            .NewConfig()
            .Map(
                dest => dest.Orders,
                src => src.ConvertAll(order => order.Adapt<OrderViewModel>())
            );
    }

    private static void SetupAdminViewModel()
    {
        TypeAdapterConfig<List<PublisherDto>, PublisherListPageViewModel>
            .NewConfig()
            .Map(
                dest => dest.Publishers,
                src => src.ConvertAll(input => input.Adapt<PublisherDetailViewModel>())
            );
        TypeAdapterConfig<List<GenreDto>, GenreListPageViewModel>
            .NewConfig()
            .Map(
                dest => dest.Genres,
                src => src.ConvertAll(input => input.Adapt<GenreDetailViewModel>())
            );
        TypeAdapterConfig<List<UserDto>, UserListViewModel>
            .NewConfig()
            .Map(dest => dest.Users, src => src.ConvertAll(input => input.Adapt<UserViewModel>()));

        TypeAdapterConfig<BookDto, Areas.Admin.ViewModels.Books.BookViewModel>
            .NewConfig()
            .Map(
                dest => dest.Authors,
                src => src.Authors.ConvertAll(author => $"{author.Name} {author.Surname}")
            )
            .Map(dest => dest.Genres, src => src.Genres.ConvertAll(genre => genre.GenreType))
            .Map(dest => dest.PreviewImage, src => src.PreviewImage.Data);

        TypeAdapterConfig<BookDetailDto, BookDetailPageViewModel>
            .NewConfig()
            .Map(
                dest => dest.Authors,
                src => src.Authors.ConvertAll(author => $"{author.Name} {author.Surname}")
            )
            .Map(dest => dest.PrimaryGenre, src => src.PrimaryGenre.GenreType)
            .Map(
                dest => dest.SecondaryGenres,
                src =>
                    src.Genres.Where(genre => genre.Id != src.PrimaryGenre.Id)
                        .Select(genre => genre.GenreType)
                        .ToList()
            )
            .Map(dest => dest.PreviewImage, src => src.PreviewImage.Data);

        TypeAdapterConfig<BookDetailDto, BookFormViewModel>
            .NewConfig()
#pragma warning disable CA1305

            .Map(dest => dest.AuthorIds, src => src.Authors.Select(author => author.Id))
            .Map(
                dest => dest.GenreIds,
                src =>
                    src.Genres.Where(genre => genre.Id != src.PrimaryGenre.Id)
                        .Select(genre => genre.Id)
                        .ToList()
            )
            .Map(dest => dest.PublishDate, src => src.PublishDate.ToString("yyyy-MM-dd"));
#pragma warning restore CA1305
    }
}
