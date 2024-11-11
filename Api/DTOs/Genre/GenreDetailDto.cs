using Api.DTOs.Book;

namespace Api.DTOs.Genre;

public class GenreDetailDto : GenreDto
{
    public required IEnumerable<BookDto> Books { get; init; } = [];
}
