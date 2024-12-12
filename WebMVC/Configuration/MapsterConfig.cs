using BusinessLayer.DTOs.Book;
using BusinessLayer.DTOs.Publisher;
using Mapster;
using WebMVC.Areas.Admin.ViewModels.Publisher;
using WebMVC.ViewModels.Book;

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
    }

    private static void SetupAdminViewModel()
    {
        TypeAdapterConfig<List<PublisherDto>, PublisherListPageViewModel>
            .NewConfig()
            .Map(
                dest => dest.Publishers,
                src => src.ConvertAll(input => input.Adapt<PublisherDetailViewModel>())
            );
        TypeAdapterConfig<PublisherDto, PublisherFormViewModel>.NewConfig();
        TypeAdapterConfig<PublisherDto, PublisherUpdatePageViewModel>.NewConfig();
    }
}
