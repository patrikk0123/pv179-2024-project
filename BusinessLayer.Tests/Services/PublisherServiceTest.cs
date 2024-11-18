using BusinessLayer.DTOs.Publisher;
using BusinessLayer.Mappers;
using BusinessLayer.Services.Publisher;
using DAL.Data;
using Infrastructure.UnitOfWork;
using TestUtilities.MockedObjects;

namespace BusinessLayer.Tests;

public class PublisherServiceTest
{
    private DbContextOptions<BookHubDBContext> _dbContextOptions;
    private BookHubDBContext _dbContext;
    private PublisherService _publisherService;

    public PublisherServiceTest()
    {
        _dbContextOptions = MockedDBContext.GenerateNewInMemoryDBContextOptons();
        _dbContext = MockedDBContext.CreateFromOptions(_dbContextOptions);
        _publisherService = new PublisherService(
            _dbContext,
            new PublisherMapper(
                new ImageUnitOfWork("../../../../images", "../../../../images/previewImages")
            )
        );
    }

    [Fact]
    public async Task GetAllPublishersAsync_ExactMatch()
    {
        // Act
        var publishers = await _publisherService.GetAllPublishersAsync();

        // Assert
        Assert.Equal(2, publishers.Count);
        Assert.Equal("Penguin s.r.o", publishers[0].Name);
        Assert.Equal("Panta Rhei Books", publishers[1].Name);
    }

    [Fact]
    public async Task GetSinglePublisherAsync_ExactMatch()
    {
        // Act
        var publisher = await _publisherService.GetSinglePublisherAsync(2);

        // Assert
        Assert.Equal("Panta Rhei Books", publisher.Name);
        Assert.Equal(2, publisher.Id);
    }

    [Fact]
    public async Task GetSinglePublisherAsync_DoesNotExist()
    {
        // Act
        var publisher = await _publisherService.GetSinglePublisherAsync(10000);

        // Assert
        Assert.Null(publisher);
    }

    [Fact]
    public async Task GetSinglePublisherAsync_InvalidId()
    {
        // Act
        var publisher = await _publisherService.GetSinglePublisherAsync(-1);

        // Assert
        Assert.Null(publisher);
    }

    [Fact]
    public async Task CreateSinglePublisherAsync_ExactMatch()
    {
        // Arrange
        var publisherCreateDto = new PublisherCreateDto { Name = "Publisher3" };

        // Act
        var createdPublisher = await _publisherService.CreateSinglePublisherAsync(
            publisherCreateDto
        );

        // Assert
        Assert.Equal("Publisher3", createdPublisher.Name);
        Assert.Equal(3, createdPublisher.Id);
    }

    [Fact]
    public async Task UpdateSinglePublisherAsync_ExactMatch()
    {
        // Arrange
        var publisherUpdateDto = new PublisherUpdateDto { Name = "Publisher4" };

        // Act
        var updatedPublisher = await _publisherService.UpdateSinglePublisherAsync(
            2,
            publisherUpdateDto
        );

        // Assert
        Assert.Equal("Publisher4", updatedPublisher.Name);
        Assert.Equal(2, updatedPublisher.Id);
    }

    [Fact]
    public async Task UpdateSinglePublisherAsync_DoesNotExist()
    {
        // Arrange
        var publisherUpdateDto = new PublisherUpdateDto { Name = "Publisher4" };

        // Act
        var updatedPublisher = await _publisherService.UpdateSinglePublisherAsync(
            10000,
            publisherUpdateDto
        );

        // Assert
        Assert.Null(updatedPublisher);
    }

    [Fact]
    public async Task UpdateSinglePublisherAsync_InvalidId()
    {
        // Arrange
        var publisherUpdateDto = new PublisherUpdateDto { Name = "Publisher4" };

        // Act
        var updatedPublisher = await _publisherService.UpdateSinglePublisherAsync(
            -1,
            publisherUpdateDto
        );

        // Assert
        Assert.Null(updatedPublisher);
    }

    [Fact]
    public async Task DeleteSinglePublisherAsync_ExactMatch()
    {
        // Act
        var deletedPublisher = await _publisherService.DeleteSinglePublisherAsync(2);

        // Assert
        Assert.Equal("Panta Rhei Books", deletedPublisher.Name);
        Assert.Equal(2, deletedPublisher.Id);
    }
}
