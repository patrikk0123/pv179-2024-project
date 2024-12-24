using BusinessLayer.DTOs.Genre;
using BusinessLayer.Mappers;
using BusinessLayer.Services.Genre;
using DAL.Data;
using Infrastructure.UnitOfWork;
using TestUtilities.MockedObjects;

namespace BusinessLayer.Tests.Services;

public class GenreServiceTest
{
    private readonly DbContextOptions<BookHubDBContext> _dbContextOptions;
    private readonly BookHubDBContext _dbContext;
    private readonly GenreService _genreService;

    public GenreServiceTest()
    {
        _dbContextOptions = MockedDBContext.GenerateNewInMemoryDBContextOptons();
        _dbContext = MockedDBContext.CreateFromOptions(_dbContextOptions);
        _genreService = new GenreService(
            _dbContext,
            new GenreMapper(
                new BookMapper(
                    new ImageUnitOfWork("../../../../images", "../../../../images/previewImages"),
                    new ImageMapper()
                )
            )
        );
    }

    [Fact]
    public async Task GetAllGenresAsync_ExactMatch()
    {
        // Act
        var genres = await _genreService.GetAllGenresAsync(null);

        // Assert
        Assert.Equal(3, genres.Count);
        Assert.Equal("Fantasy", genres[0].GenreType);
        Assert.Equal("Science Fiction", genres[1].GenreType);
        Assert.Equal("Horror", genres[2].GenreType);
    }

    [Fact]
    public async Task GetSingleGenreAsync_ExactMatch()
    {
        // Act
        var genre = await _genreService.GetSingleGenreAsync(3);

        // Assert
        Assert.Equal("Horror", genre.GenreType);
        Assert.Equal(3, genre.Id);
    }

    [Fact]
    public async Task GetSingleGenreAsync_DoesNotExist()
    {
        // Act
        var genre = await _genreService.GetSingleGenreAsync(10000);

        // Assert
        Assert.Null(genre);
    }

    [Fact]
    public async Task GetSingleGenreAsync_InvalidId()
    {
        // Act
        var genre = await _genreService.GetSingleGenreAsync(-1);

        // Assert
        Assert.Null(genre);
    }

    [Fact]
    public async Task CreateSingleGenreAsync_Created()
    {
        // Arrange
        var genreCreateDto = new GenreCreateDto { GenreType = "Drama" };

        // Act
        var createdGenre = await _genreService.CreateSingleGenreAsync(genreCreateDto);

        // Assert
        Assert.Equal("Drama", createdGenre.GenreType);
        Assert.Equal(4, createdGenre.Id);
        Assert.Equal(4, _dbContext.Genres.Count());
    }

    [Fact]
    public async Task UpdateSingleGenreAsync_NameUpdated()
    {
        // Arrange
        var genreUpdateDto = new GenreUpdateDto { GenreType = "Comedy" };

        // Act
        var updatedGenre = await _genreService.UpdateSingleGenreAsync(2, genreUpdateDto);

        // Assert
        Assert.Equal("Comedy", updatedGenre.GenreType);
        Assert.Equal(2, updatedGenre.Id);
    }

    [Fact]
    public async Task UpdateSingleGenreAsync_DoesNotExist()
    {
        // Arrange
        var genreUpdateDto = new GenreUpdateDto { GenreType = "Comedy" };

        // Act
        var updatedGenre = await _genreService.UpdateSingleGenreAsync(10000, genreUpdateDto);

        // Assert
        Assert.Null(updatedGenre);
    }

    [Fact]
    public async Task UpdateSingleGenreAsync_InvalidId()
    {
        // Arrange
        var genreUpdateDto = new GenreUpdateDto { GenreType = "Comedy" };

        // Act
        var updatedGenre = await _genreService.UpdateSingleGenreAsync(-1, genreUpdateDto);

        // Assert
        Assert.Null(updatedGenre);
    }

    [Fact]
    public async Task DeleteSingleGenreAsync_Deleted()
    {
        // Act
        var deletedGenre = await _genreService.DeleteSingleGenreAsync(1);
        var doesGenreExist = _dbContext.Genres.Any(genre => genre.Id == 1);

        // Assert
        Assert.Equal("Fantasy", deletedGenre.GenreType);
        Assert.Equal(1, deletedGenre.Id);
        Assert.False(doesGenreExist);
    }

    [Fact]
    public async Task DoGenresExistAsync_ExactMatch()
    {
        // Act
        var doGenresExist = await _genreService.DoGenresExistAsync([1, 2]);

        // Assert
        Assert.True(doGenresExist);
    }

    [Fact]
    public async Task DoGenresExistAsync_NotAllExist()
    {
        // Act
        var doGenresExist = await _genreService.DoGenresExistAsync([1, 2, 10000]);

        // Assert
        Assert.False(doGenresExist);
    }
}
