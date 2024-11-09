using System.ComponentModel.DataAnnotations;

namespace Api.DTOs.Genre;

public class GenreCreateDto
{
    [Required]
    public required string GenreType { get; init; }
}
