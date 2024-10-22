using Api.DTOs.Book;

namespace Api.DTOs.Genre;

public class GenreDetailDto : GenreDto
{
    public IEnumerable<BookDto> Books { get; init; } = [];
}
