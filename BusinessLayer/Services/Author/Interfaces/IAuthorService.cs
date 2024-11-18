using BusinessLayer.DTOs.Author;

namespace BusinessLayer.Services.Author.Interfaces;

public interface IAuthorService
{
    public Task<List<AuthorDto>> GetAllAuthorsAsync(String? name, String? surname);

    public Task<AuthorDetailDto?> GetSingleAuthorAsync(int id);

    public Task<AuthorDto> CreateSingleAuthorAsync(AuthorCreateDto authorCreateDto);

    public Task<AuthorDto?> UpdateSingleAuthorAsync(int id, AuthorUpdateDto authorUpdateDto);

    public Task<AuthorDto?> DeleteSingleAuthorAsync(int id);

    public Task<bool> DoAuthorsExistAsync(IEnumerable<int> authorsId);
}
