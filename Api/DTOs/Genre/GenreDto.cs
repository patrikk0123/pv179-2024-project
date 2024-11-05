using Api.DTOs.Interfaces;

namespace Api.DTOs.Genre;

public class GenreDto : BaseDto
{
    public required string GenreType { get; init; }
}
