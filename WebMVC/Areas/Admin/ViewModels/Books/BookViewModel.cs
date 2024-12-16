namespace WebMVC.Areas.Admin.ViewModels.Books;

public class BookViewModel
{
    public required int Id { get; init; }

    public required string Name { get; init; }

    public required int Pages { get; init; }

    public required double Rating { get; init; }

    public required double Price { get; init; }

    public byte[] PreviewImage { get; init; }

    public required List<String> Authors { get; init; } = [];

    public required List<String> Genres { get; init; } = [];
}
