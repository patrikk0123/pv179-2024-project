using Api.DTOs.Interfaces;

namespace Api.DTOs.BookReview;

public class BookReviewDto : BaseDto
{
    public String BookName { get; set; }

    public String ReviewerName { get; set; }

    public String Body { get; set; }

    public Int32 Rating { get; set; }

    public DateTime CreatedAt { get; set; }
}
