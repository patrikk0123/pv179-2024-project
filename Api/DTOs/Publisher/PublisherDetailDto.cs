using Api.DTOs.Book;

namespace Api.DTOs.Publisher;

public class PublisherDetailDto : PublisherDto
{
    public IEnumerable<BookDto> Books { get; init; }
}
