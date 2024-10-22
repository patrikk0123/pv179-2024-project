using Api.DTOs.Interfaces;

namespace Api.DTOs.Author;

public class AuthorDto : BaseDto
{
    public required string Name { get; init; }

    public required string Surname { get; init; }
}
