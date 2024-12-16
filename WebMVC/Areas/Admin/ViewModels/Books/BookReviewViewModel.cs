namespace WebMVC.Areas.Admin.ViewModels.Books;

public class BookReviewViewModel
{
    public required int Rating { get; init; }

    public required string Body { get; init; }

    public required string ReviewerName { get; init; }
}
