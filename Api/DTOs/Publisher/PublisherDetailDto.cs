using Api.DTOs.Book;

namespace Api.DTOs.Publisher;

public class PublisherDetailDto : PublisherDto
{
    public required IEnumerable<BookDto> Books { get; init; } = [];
}
