using System.ComponentModel.DataAnnotations;

namespace BusinessLayer.DTOs.BookReview;

public class BookReviewUpdateDto
{
    [Required]
    public required String Body { get; init; }

    [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5.")]
    public required Int32 Rating { get; init; }
}
