using System.ComponentModel.DataAnnotations;

namespace Api.DTOs.BookReview;

public class BookReviewUpdateDto
{
    [Required]
    public String Body { get; set; }

    [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5.")]
    public Int32 Rating { get; set; }
}
