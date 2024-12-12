namespace WebMVC.ViewModels.Book;

public class BookReviewDetailViewModel
{
    public required int Rating { get; init; }

    public required string Body { get; init; }

    public required string ReviewerName { get; init; }
}
