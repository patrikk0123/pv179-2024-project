using Api.DTOs.Book;

namespace Api.DTOs.Author;

public class AuthorDetailDto : AuthorDto
{
    public required List<BookDetailDto> Books { get; init; } = [];
}
