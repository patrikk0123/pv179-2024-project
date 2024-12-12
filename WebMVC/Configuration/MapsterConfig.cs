using BusinessLayer.DTOs.Book;
using BusinessLayer.DTOs.Publisher;
using BusinessLayer.DTOs.WishListItem;
using Mapster;
using WebMVC.Areas.Admin.ViewModels.Publisher;
using WebMVC.ViewModels.Book;
using WebMVC.ViewModels.WishListItem;

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
            .Map(dest => dest.Genres, src => src.Genres.ConvertAll(genre => genre.GenreType))
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
    }

    private static void SetupAdminViewModel()
    {
        TypeAdapterConfig<List<PublisherDto>, PublisherListPageViewModel>
            .NewConfig()
            .Map(
                dest => dest.Publishers,
                src => src.ConvertAll(input => input.Adapt<PublisherDetailViewModel>())
            );
    }
}
