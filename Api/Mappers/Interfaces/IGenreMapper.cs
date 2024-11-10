using Api.DTOs.Genre;
using DAL.Models;

namespace Api.Mappers.Interfaces;

public interface IGenreMapper
    : IEntityMapper<Genre, GenreDto, GenreDetailDto, GenreCreateDto, GenreUpdateDto>;
