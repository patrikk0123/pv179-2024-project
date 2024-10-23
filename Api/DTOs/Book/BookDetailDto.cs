using Api.DTOs.Author;
using Api.DTOs.BookReview;
using Api.DTOs.Genre;

namespace Api.DTOs.Book;

public class BookDetailDto : BookDto
{
    public required List<AuthorDto> Authors { get; init; } = [];

    public required List<GenreDto> Genres { get; init; } = [];

    public required List<BookReviewDto> Reviews { get; init; } = [];
}
