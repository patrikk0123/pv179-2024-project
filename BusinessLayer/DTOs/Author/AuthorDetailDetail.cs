using BusinessLayer.DTOs.Book;

namespace BusinessLayer.DTOs.Author;

public class AuthorDetailDto : AuthorDto
{
    public required List<BookDetailDto> Books { get; init; } = [];
}
