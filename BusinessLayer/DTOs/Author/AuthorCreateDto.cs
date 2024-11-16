using System.ComponentModel.DataAnnotations;

namespace BusinessLayer.DTOs.Author;

public class AuthorCreateDto
{
    [Required]
    public required string Name { get; init; }

    [Required]
    public required string Surname { get; init; }
}
