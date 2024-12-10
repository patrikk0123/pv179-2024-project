using BusinessLayer.DTOs.Common;

namespace BusinessLayer.DTOs.Publisher;

public class PublisherDto : BaseDto
{
    public required string Name { get; init; }
}
