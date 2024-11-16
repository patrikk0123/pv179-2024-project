using BusinessLayer.DTOs.Book;

namespace BusinessLayer.DTOs.Publisher;

public class PublisherDetailDto : PublisherDto
{
    public required IEnumerable<BookDto> Books { get; init; } = [];
}
