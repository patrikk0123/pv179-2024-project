using BusinessLayer.DTOs.Author;
using BusinessLayer.Mappers;
using BusinessLayer.Services.Author;
using DAL.Data;
using Infrastructure.UnitOfWork;
using TestUtilities.MockedObjects;

namespace BusinessLayer.Tests.Services;

public class AuthorServiceTest
{
    private readonly DbContextOptions<BookHubDBContext> _dbContextOptions;
    private readonly BookHubDBContext _dbContext;
    private readonly AuthorService _authorService;

    public AuthorServiceTest()
    {
        _dbContextOptions = MockedDBContext.GenerateNewInMemoryDBContextOptons();
        _dbContext = MockedDBContext.CreateFromOptions(_dbContextOptions);
        _authorService = new AuthorService(
            _dbContext,
            new AuthorMapper(
                new BookMapper(
                    new ImageUnitOfWork("../../../../images", "../../../../images/previewImages")
                )
            )
        );
    }

    [Fact]
    public async Task GetAllAuthorsAsync_ExactMatch()
    {
        // Act
        var authors = await _authorService.GetAllAuthorsAsync(null, null);

        // Assert
        Assert.Equal(3, authors.Count);
        Assert.Equal("John", authors[0].Name);
        Assert.Equal("Doe", authors[0].Surname);
        Assert.Equal("Jane", authors[1].Name);
        Assert.Equal("Doe", authors[1].Surname);
        Assert.Equal("John", authors[2].Name);
        Assert.Equal("Smith", authors[2].Surname);
    }

    [Fact]
    public async Task GetSingleAuthorAsync_ExactMatch()
    {
        // Act
        var author = await _authorService.GetSingleAuthorAsync(3);

        // Assert
        Assert.Equal("John", author.Name);
        Assert.Equal("Smith", author.Surname);
        Assert.Equal(3, author.Id);
    }

    [Fact]
    public async Task GetSingleAuthorAsync_DoesNotExist()
    {
        // Act
        var author = await _authorService.GetSingleAuthorAsync(10000);

        // Assert
        Assert.Null(author);
    }

    [Fact]
    public async Task GetSingleAuthorAsync_InvalidId()
    {
        // Act
        var author = await _authorService.GetSingleAuthorAsync(-1);

        // Assert
        Assert.Null(author);
    }

    [Fact]
    public async Task CreateSingleAuthorAsync_Created()
    {
        // Arrange
        var authorCreateDto = new AuthorCreateDto { Name = "Donald", Surname = "Douchebag" };

        // Act
        var createdAuthor = await _authorService.CreateSingleAuthorAsync(authorCreateDto);

        // Assert
        Assert.Equal("Donald", createdAuthor.Name);
        Assert.Equal("Douchebag", createdAuthor.Surname);
        Assert.Equal(4, createdAuthor.Id);
        Assert.Equal(4, _dbContext.Authors.Count());
    }

    [Fact]
    public async Task UpdateSingleAuthorAsync_NameAndSurnameUpdated()
    {
        // Arrange
        var authorUpdateDto = new AuthorUpdateDto { Name = "Jane", Surname = "Doeowitz" };

        // Act
        var updatedAuthor = await _authorService.UpdateSingleAuthorAsync(2, authorUpdateDto);

        // Assert
        Assert.Equal("Jane", updatedAuthor.Name);
        Assert.Equal("Doeowitz", updatedAuthor.Surname);
        Assert.Equal(2, updatedAuthor.Id);
    }

    [Fact]
    public async Task UpdateSingleAuthorAsync_DoesNotExist()
    {
        // Arrange
        var authorUpdateDto = new AuthorUpdateDto { Name = "Tom", Surname = "Nada" };

        // Act
        var updatedAuthor = await _authorService.UpdateSingleAuthorAsync(10000, authorUpdateDto);

        // Assert
        Assert.Null(updatedAuthor);
    }

    [Fact]
    public async Task UpdateSingleAuthorAsync_InvalidId()
    {
        // Arrange
        var authorUpdateDto = new AuthorUpdateDto { Name = "Tom", Surname = "Nada" };

        // Act
        var updatedAuthor = await _authorService.UpdateSingleAuthorAsync(-1, authorUpdateDto);

        // Assert
        Assert.Null(updatedAuthor);
    }

    [Fact]
    public async Task DeleteSingleAuthorAsync_Deleted()
    {
        // Act
        var deletedAuthor = await _authorService.DeleteSingleAuthorAsync(1);

        // Assert
        Assert.Equal("John", deletedAuthor.Name);
        Assert.Equal("Doe", deletedAuthor.Surname);
        Assert.Equal(1, deletedAuthor.Id);
        Assert.Equal(2, _dbContext.Authors.Count());
    }
}
