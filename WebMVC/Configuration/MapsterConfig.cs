using BusinessLayer.DTOs.Book;
using Mapster;
using WebMVC.ViewModels.Book;

namespace WebMVC.Configuration;

public static class MapsterConfig
{
    public static void Setup()
    {
        TypeAdapterConfig<BookDto, BookViewModel>.NewConfig();
    }
}
