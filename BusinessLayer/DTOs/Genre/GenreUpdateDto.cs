using System.ComponentModel.DataAnnotations;

namespace BusinessLayer.DTOs.Genre;

public class GenreUpdateDto
{
    [Required]
    public required string GenreType { get; init; }
}
