using System.ComponentModel.DataAnnotations;

namespace Api.DTOs.Publisher;

public class PublisherCreateDto
{
    [Required]
    public required string Name { get; init; }
}
