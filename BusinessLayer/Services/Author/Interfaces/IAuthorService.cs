using BusinessLayer.DTOs.Author;

namespace BusinessLayer.Services.Author.Interfaces;

public interface IAuthorService
{
    public Task<List<AuthorDto>> GetAllAuthors(String? name, String? surname);

    public Task<AuthorDetailDto?> GetSingleAuthor(int id);

    public Task<AuthorDto> CreateSingleAuthor(AuthorCreateDto authorCreateDto);

    public Task<AuthorDto?> UpdateSingleAuthor(int id, AuthorUpdateDto authorUpdateDto);

    public Task<AuthorDto?> DeleteSingleAuthor(int id);
}
