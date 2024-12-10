using BusinessLayer.DTOs.Book;
using Mapster;
using WebMVC.ViewModels.Book;

namespace WebMVC.Configuration;

public static class MapsterConfig
{
    public static void Setup()
    {
        TypeAdapterConfig<BookDto, BookViewModel>
            .NewConfig()
            .Map(
                dest => dest.Authors,
                src => src.Authors.ConvertAll(author => $"{author.Name} {author.Surname}")
            )
            .Map(dest => dest.PreviewImage, src => src.PreviewImage.Data);
    }
}
