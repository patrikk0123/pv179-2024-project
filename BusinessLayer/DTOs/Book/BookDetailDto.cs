using BusinessLayer.DTOs.BookReview;
using BusinessLayer.DTOs.Genre;
using BusinessLayer.DTOs.Image;

namespace BusinessLayer.DTOs.Book;

public class BookDetailDto : BookDto
{
    public required List<GenreDto> Genres { get; init; } = [];

    public required List<BookReviewDto> Reviews { get; init; } = [];

    public required List<ImageDto> Images { get; init; } = [];
}
