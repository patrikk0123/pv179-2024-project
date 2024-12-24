using System.ComponentModel.DataAnnotations;

namespace BusinessLayer.DTOs.Genre;

public class GenreCreateDto
{
    [Required]
    public required string GenreType { get; init; }
}
