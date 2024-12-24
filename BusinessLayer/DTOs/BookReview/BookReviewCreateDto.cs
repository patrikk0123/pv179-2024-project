using System.ComponentModel.DataAnnotations;

namespace BusinessLayer.DTOs.BookReview;

public class BookReviewCreateDto
{
    [Required]
    public required string Body { get; init; }

    [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5.")]
    public required int Rating { get; init; }
}
