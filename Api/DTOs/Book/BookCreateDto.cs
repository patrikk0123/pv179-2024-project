namespace Api.DTOs.Book;

public class BookCreateDto
{
    public required string Name { get; init; }

    public required string ISBN { get; init; }

    public required string Description { get; init; }

    public required string PublishDate { get; init; }

    public required int Pages { get; init; }

    public required double Rating { get; init; }

    public required double Price { get; init; }
    public required int PublisherId { get; init; }

    public required List<int> GenreIds { get; init; } = [];

    public required List<int> AuthorIds { get; init; } = [];
}
