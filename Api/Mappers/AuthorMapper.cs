using Api.DTOs.Author;
using Api.Mappers.Interfaces;
using DAL.Models;

namespace Api.Mappers;

public class AuthorMapper(IBookMapper bookMapper) : IAuthorMapper
{
    public AuthorDto ToDto(Author author)
    {
        return new AuthorDto()
        {
            Id = author.Id,
            Name = author.Name,
            Surname = author.Surname,
        };
    }

    public AuthorDetailDto ToDetailDto(Author author)
    {
        return new AuthorDetailDto()
        {
            Id = author.Id,
            Name = author.Name,
            Surname = author.Surname,
            Books = author
                .BookAuthors.Select(bookAuthor => bookMapper.ToDetailDto(bookAuthor.Book))
                .ToList(),
        };
    }

    public Author ToModel(AuthorCreateDto authorDto)
    {
        return new Author { Name = authorDto.Name, Surname = authorDto.Surname };
    }

    public void UpdateModel(Author author, AuthorUpdateDto authorUpdateDto)
    {
        author.Name = authorUpdateDto.Name;
        author.Surname = authorUpdateDto.Surname;
    }
}
