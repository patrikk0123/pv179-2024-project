using BusinessLayer.DTOs.Genre;
using BusinessLayer.Mappers.Interfaces;
using BusinessLayer.Services.Genre.Interfaces;
using DAL.Data;
using DAL.Extensions;
using Microsoft.EntityFrameworkCore;

namespace BusinessLayer.Services.Genre;

public class GenreService(BookHubDBContext dBContext, IGenreMapper genreMapper)
    : BaseService(dBContext),
        IGenreService
{
    public async Task<List<GenreDto>> GetAllGenresAsync(string? genreType)
    {
        var genres = await dBContext
            .Genres.WhereIf(
                !string.IsNullOrEmpty(genreType),
                genre => EF.Functions.Like(genre.GenreType, $"%{genreType}%")
            )
            .ToListAsync();

        if (genres == null)
        {
            return [];
        }

        return genres.ConvertAll(genreMapper.ToDto);
    }

    public async Task<GenreDetailDto?> GetSingleGenreAsync(int genreId)
    {
        var genre = await dBContext.Genres.FindAsync(genreId);
        if (genre == null)
        {
            return null;
        }

        return genreMapper.ToDetailDto(genre);
    }

    public async Task<GenreDto?> CreateSingleGenreAsync(GenreCreateDto genreCreateDto)
    {
        var createdGenre = await dBContext.Genres.AddAsync(genreMapper.ToModel(genreCreateDto));

        await SaveAsync(true);

        return genreMapper.ToDto(createdGenre.Entity);
    }

    public async Task<GenreDto?> UpdateSingleGenreAsync(int genreId, GenreUpdateDto genreUpdateDto)
    {
        var genreToUpdate = await dBContext.Genres.FindAsync(genreId);
        if (genreToUpdate == null)
        {
            return null;
        }

        genreMapper.UpdateModel(genreToUpdate, genreUpdateDto);
        dBContext.Genres.Update(genreToUpdate);

        await SaveAsync(true);

        return genreMapper.ToDto(genreToUpdate);
    }

    public async Task<GenreDto?> DeleteSingleGenreAsync(int genreId)
    {
        var genre = await dBContext.Genres.FindAsync(genreId);
        if (genre == null)
        {
            return null;
        }

        genre.DeletedAt = DateTime.Now;

        await SaveAsync(true);

        return genreMapper.ToDto(genre);
    }

    public async Task<bool> DoGenresExistAsync(IEnumerable<int> genreIds)
    {
        var foundGenresCount = await dBContext.Genres.CountAsync(genre =>
            genreIds.Contains(genre.Id)
        );

        return foundGenresCount == genreIds.Count();
    }
}
