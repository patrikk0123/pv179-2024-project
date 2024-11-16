using BusinessLayer.DTOs.Book;

namespace BusinessLayer.DTOs.Genre;

public class GenreDetailDto : GenreDto
{
    public required IEnumerable<BookDto> Books { get; init; } = [];
}
