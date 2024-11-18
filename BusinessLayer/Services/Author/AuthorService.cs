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
    public async Task<List<AuthorDto>> GetAllAuthors(String? name, String? surname)
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

    public async Task<AuthorDetailDto?> GetSingleAuthor(int id)
    {
        var author = await dBContext.Authors.FindAsync(id);

        if (author == null)
        {
            return null;
        }

        return authorMapper.ToDetailDto(author);
    }

    public async Task<AuthorDto> CreateSingleAuthor(AuthorCreateDto authorCreateDto)
    {
        var author = await dBContext.Authors.AddAsync(authorMapper.ToModel(authorCreateDto));
        await dBContext.SaveChangesAsync();

        return authorMapper.ToDto(author.Entity);
    }

    public async Task<AuthorDto?> UpdateSingleAuthor(int authorId, AuthorUpdateDto authorUpdateDto)
    {
        var authorToUpdate = await dBContext.Authors.FindAsync(authorId);
        if (authorToUpdate == null)
        {
            return null;
        }

        authorMapper.UpdateModel(authorToUpdate, authorUpdateDto);
        dBContext.Authors.Update(authorToUpdate);
        await dBContext.SaveChangesAsync();

        return authorMapper.ToDto(authorToUpdate);
    }

    public async Task<AuthorDto?> DeleteSingleAuthor(int authorId)
    {
        var author = await dBContext.Authors.FindAsync(authorId);
        if (author == null)
        {
            return null;
        }

        author.DeletedAt = DateTime.Now;
        await dBContext.SaveChangesAsync();

        return authorMapper.ToDto(author);
    }
}
