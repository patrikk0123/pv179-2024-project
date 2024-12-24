using BusinessLayer.DTOs.Interfaces;

namespace BusinessLayer.DTOs.Publisher;

public class PublisherDto : BaseDto
{
    public required string Name { get; init; }
}
