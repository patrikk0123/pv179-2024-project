using BusinessLayer.DTOs.Interfaces;

namespace BusinessLayer.DTOs.Genre;

public class GenreDto : BaseDto
{
    public required string GenreType { get; init; }
}
