using BusinessLayer.DTOs.Author;
using BusinessLayer.Mappers.Interfaces;
using BusinessLayer.Services.Author.Interfaces;
using DAL.Data;
using DAL.Extensions;
using Microsoft.EntityFrameworkCore;

namespace BusinessLayer.Services.Author;

public class AuthorService(BookHubDBContext dBContext, IAuthorMapper authorMapper)
    : BaseService(dBContext),
        IAuthorService
{
    public async Task<List<AuthorDto>> GetAllAuthorsAsync(String? name, String? surname)
    {
        var authors = await dBContext
            .Authors.WhereIf(
                !string.IsNullOrEmpty(name),
                author => EF.Functions.Like(author.Name, $"%{name}%")
            )
            .WhereIf(
                !string.IsNullOrEmpty(surname),
                author => EF.Functions.Like(author.Surname, $"%{surname}%")
            )
            .ToListAsync();

        return authors.ConvertAll(authorMapper.ToDto);
    }

    public async Task<AuthorDetailDto?> GetSingleAuthorAsync(int id)
    {
        var author = await dBContext.Authors.FindAsync(id);

        if (author == null)
        {
            return null;
        }

        return authorMapper.ToDetailDto(author);
    }

    public async Task<AuthorDto> CreateSingleAuthorAsync(AuthorCreateDto authorCreateDto)
    {
        var author = await dBContext.Authors.AddAsync(authorMapper.ToModel(authorCreateDto));
        await SaveAsync(true);

        return authorMapper.ToDto(author.Entity);
    }

    public async Task<AuthorDto?> UpdateSingleAuthorAsync(
        int authorId,
        AuthorUpdateDto authorUpdateDto
    )
    {
        var authorToUpdate = await dBContext.Authors.FindAsync(authorId);
        if (authorToUpdate == null)
        {
            return null;
        }

        authorMapper.UpdateModel(authorToUpdate, authorUpdateDto);
        dBContext.Authors.Update(authorToUpdate);
        await SaveAsync(true);

        return authorMapper.ToDto(authorToUpdate);
    }

    public async Task<AuthorDto?> DeleteSingleAuthorAsync(int authorId)
    {
        var author = await dBContext.Authors.FindAsync(authorId);
        if (author == null)
        {
            return null;
        }

        author.DeletedAt = DateTime.Now;
        await SaveAsync(true);

        return authorMapper.ToDto(author);
    }

    public async Task<bool> DoAuthorsExistAsync(IEnumerable<int> authorsId)
    {
        var foundAuthorCount = await dBContext.Authors.CountAsync(author =>
            authorsId.Contains(author.Id)
        );

        return foundAuthorCount == authorsId.Count();
    }
}
