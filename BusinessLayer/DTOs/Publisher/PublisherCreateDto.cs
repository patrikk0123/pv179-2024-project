using System.ComponentModel.DataAnnotations;

namespace BusinessLayer.DTOs.Publisher;

public class PublisherCreateDto
{
    [Required]
    public required string Name { get; init; }
}
