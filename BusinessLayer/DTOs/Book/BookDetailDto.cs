using BusinessLayer.DTOs.Author;
using BusinessLayer.DTOs.BookReview;
using BusinessLayer.DTOs.Genre;
using Infrastructure.Models;

namespace BusinessLayer.DTOs.Book;

public class BookDetailDto : BookDto
{
    public required List<AuthorDto> Authors { get; init; } = [];

    public required List<GenreDto> Genres { get; init; } = [];

    public required List<BookReviewDto> Reviews { get; init; } = [];

    public required List<RepositoryImage> Images { get; init; } = [];
}
