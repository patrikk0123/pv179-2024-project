using Api.DTOs.Interfaces;

namespace Api.DTOs.BookReview;

public class BookReviewDto : BaseDto
{
    public required String BookName { get; init; }

    public required String ReviewerName { get; init; }

    public required String Body { get; init; }

    public required Int32 Rating { get; init; }

    public required DateTime CreatedAt { get; init; }
}
