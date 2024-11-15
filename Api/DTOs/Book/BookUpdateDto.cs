using System.ComponentModel.DataAnnotations;

namespace Api.DTOs.Book;

public class BookUpdateDto
{
    [Required]
    public required string Name { get; init; }

    [Required]
    public required string ISBN { get; init; }

    [Required]
    public required string Description { get; init; }

    [Required]
    public required string PublishDate { get; init; }

    [Required]
    public required int Pages { get; init; }

    [Required]
    [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5.")]
    public required double Rating { get; init; }

    [Required]
    public required double Price { get; init; }

    [Required]
    public required int PublisherId { get; init; }

    public string PreviewImageId { get; init; }

    public required List<int> GenreIds { get; init; } = [];

    public required List<int> AuthorIds { get; init; } = [];
}
