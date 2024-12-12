using BusinessLayer.DTOs.Publisher;

namespace BusinessLayer.Services.Publisher.Interfaces;

public interface IPublisherService
{
    public Task<List<PublisherDto>> GetAllPublishersAsync();

    public Task<PublisherDetailDto?> GetSinglePublisherAsync(int publisherId);

    public Task<PublisherDto> CreateSinglePublisherAsync(PublisherCreateDto publisherCreateDto);

    public Task<PublisherDto> UpdateSinglePublisherAsync(
        int publisherId,
        PublisherUpdateDto publisherUpdateDto
    );

    public Task<PublisherDto?> DeleteSinglePublisherAsync(int publisherId);

    public Task<bool> DoesPublisherExistAsync(int publisherId);
}
