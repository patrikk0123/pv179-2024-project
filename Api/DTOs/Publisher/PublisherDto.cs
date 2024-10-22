using Api.DTOs.Interfaces;

namespace Api.DTOs.Publisher;

public class PublisherDto : BaseDto
{
    public required string Name { get; init; }
}
