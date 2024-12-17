using BusinessLayer.DTOs.BookReview;
using BusinessLayer.DTOs.Image;

namespace BusinessLayer.DTOs.Book;

public class BookDetailDto : BookDto
{
    public required List<BookReviewDto> Reviews { get; init; } = [];

    public required List<ImageDto> Images { get; init; } = [];
}
