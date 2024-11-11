using Api.DTOs.Author;
using DAL.Models;

namespace Api.Mappers.Interfaces;

public interface IAuthorMapper
    : IEntityMapper<Author, AuthorDto, AuthorDetailDto, AuthorCreateDto, AuthorUpdateDto>;
