using Api.DTOs.Genre;
using Api.Mappers.Interfaces;
using DAL.Models;

namespace Api.Mappers;

public class GenreMapper(IBookMapper bookMapper) : IGenreMapper
{
    public GenreDto ToDto(Genre genre)
    {
        return new GenreDto { Id = genre.Id, GenreType = genre.GenreType };
    }

    public GenreDetailDto ToDetailDto(Genre genre)
    {
        return new GenreDetailDto()
        {
            Id = genre.Id,
            GenreType = genre.GenreType,
            Books = genre
                .BookGenres.Select(bookGenre => bookMapper.ToDetailDto(bookGenre.Book))
                .ToList(),
        };
    }

    public Genre ToModel(GenreCreateDto genreCreateDto)
    {
        return new Genre { GenreType = genreCreateDto.GenreType };
    }

    public void UpdateModel(Genre genre, GenreUpdateDto genreUpdateDto)
    {
        genre.GenreType = genreUpdateDto.GenreType;
    }
}
