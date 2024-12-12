using BusinessLayer.DTOs.Genre;

namespace BusinessLayer.Services.Genre.Interfaces;

public interface IGenreService
{
    public Task<List<GenreDto>> GetAllGenresAsync(string? genreType);

    public Task<GenreDetailDto?> GetSingleGenreAsync(int genreId);

    public Task<GenreDto?> CreateSingleGenreAsync(GenreCreateDto genreCreateDto);

    public Task<GenreDto?> UpdateSingleGenreAsync(int genreId, GenreUpdateDto genreUpdateDto);

    public Task<GenreDto?> DeleteSingleGenreAsync(int genreId);

    public Task<bool> DoGenresExistAsync(IEnumerable<int> genreIds);
}
