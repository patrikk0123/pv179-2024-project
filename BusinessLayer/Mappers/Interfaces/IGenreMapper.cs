using BusinessLayer.DTOs.Genre;
using DAL.Models;

namespace BusinessLayer.Mappers.Interfaces;

public interface IGenreMapper
    : IEntityMapper<Genre, GenreDto, GenreDetailDto, GenreCreateDto, GenreUpdateDto>;
