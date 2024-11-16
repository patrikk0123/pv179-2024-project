using System.ComponentModel.DataAnnotations;

namespace BusinessLayer.DTOs.Publisher;

public class PublisherUpdateDto
{
    [Required]
    public required string Name { get; init; }
}
