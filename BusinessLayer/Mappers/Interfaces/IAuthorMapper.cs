using BusinessLayer.DTOs.Author;
using DAL.Models;

namespace BusinessLayer.Mappers.Interfaces;

public interface IAuthorMapper
    : IEntityMapper<Author, AuthorDto, AuthorDetailDto, AuthorCreateDto, AuthorUpdateDto>;
