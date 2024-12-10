using BusinessLayer.DTOs.Author;
using BusinessLayer.DTOs.Image;
using BusinessLayer.DTOs.Interfaces;

namespace BusinessLayer.DTOs.Book;

public class BookDto : BaseDto
{
    public required string Name { get; init; }

    public required string ISBN { get; init; }

    public required string Description { get; init; }

    public required DateOnly PublishDate { get; init; }

    public required int Pages { get; init; }

    public required double Rating { get; init; }

    public required double Price { get; init; }

    public required string PublisherName { get; init; }

    public ImageDto PreviewImage { get; init; }

    public required List<AuthorDto> Authors { get; init; } = [];
}
