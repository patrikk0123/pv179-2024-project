namespace WebMVC.ViewModels.Book;

public class BookReviewDetailModel
{
    public required int Rating { get; init; }

    public required string Body { get; init; }

    public required string ReviewerName { get; init; }
}
