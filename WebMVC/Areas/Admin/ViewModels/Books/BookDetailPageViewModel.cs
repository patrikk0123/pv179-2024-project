namespace WebMVC.Areas.Admin.ViewModels.Books;

public class BookDetailPageViewModel
{
    public required int Id { get; init; }

    public required string Name { get; init; }

    public required string Description { get; init; }

    public required int Pages { get; init; }

    public required string ISBN { get; init; }

    public required DateOnly PublishDate { get; init; }

    public required string PublisherName { get; init; }

    public required double Rating { get; init; }

    public required double Price { get; init; }

    public required string PrimaryGenre { get; init; }

    public byte[] PreviewImage { get; init; }

    public required List<string> SecondaryGenres { get; init; } = [];

    public required List<BookReviewViewModel> Reviews { get; init; } = [];

    public required List<string> Authors { get; init; } = [];
}
