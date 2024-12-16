using System.ComponentModel.DataAnnotations;

namespace WebMVC.Areas.Admin.ViewModels.Books;

public class BookFormViewModel
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

    [Required]
    public required int PrimaryGenreId { get; init; }

    public required List<int> GenreIds { get; init; } = [];

    public required List<int> AuthorIds { get; init; } = [];

    public required List<IFormFile> Images { get; init; } = [];
}
