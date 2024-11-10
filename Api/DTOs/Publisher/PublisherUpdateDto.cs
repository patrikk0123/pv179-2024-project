using System.ComponentModel.DataAnnotations;

namespace Api.DTOs.Publisher;

public class PublisherUpdateDto
{
    [Required]
    public required string Name { get; init; }
}
