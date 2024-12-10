using BusinessLayer.DTOs.Common;

namespace BusinessLayer.DTOs.Genre;

public class GenreDto : BaseDto
{
    public required string GenreType { get; init; }
}
