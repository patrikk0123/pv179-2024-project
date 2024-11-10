using System.ComponentModel.DataAnnotations;

namespace Api.DTOs.Author;

public class AuthorUpdateDto
{
    [Required]
    public required string Name { get; init; }

    [Required]
    public required string Surname { get; init; }
}
