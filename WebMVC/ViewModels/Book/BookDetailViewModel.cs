using BusinessLayer.DTOs.BookReview;

namespace WebMVC.ViewModels.Book;

public class BookDetailViewModel
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

    public byte[] PreviewImage { get; init; }

    public required List<String> Genres { get; init; } = [];

    public required List<BookReviewDto> Reviews { get; init; } = [];

    public required List<String> Authors { get; init; } = [];
}
