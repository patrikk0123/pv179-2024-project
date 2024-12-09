namespace WebMVC.ViewModels.Book;

public class BookViewModel
{
    public required string Name { get; init; }

    public required DateOnly PublishDate { get; init; }

    public required int Pages { get; init; }

    public required double Rating { get; init; }

    public required double Price { get; init; }

    public required string PublisherName { get; init; }
}
