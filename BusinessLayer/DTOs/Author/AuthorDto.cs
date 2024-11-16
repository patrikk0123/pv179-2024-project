using BusinessLayer.DTOs.Interfaces;

namespace BusinessLayer.DTOs.Author;

public class AuthorDto : BaseDto
{
    public required string Name { get; init; }

    public required string Surname { get; init; }
}
