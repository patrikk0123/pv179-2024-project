using BusinessLayer.DTOs.Publisher;
using BusinessLayer.Mappers.Interfaces;
using BusinessLayer.Services.Publisher.Interfaces;
using DAL.Data;
using Microsoft.EntityFrameworkCore;

namespace BusinessLayer.Services.Publisher;

public class PublisherService(BookHubDBContext dBContext, IPublisherMapper publisherMapper)
    : BaseService(dBContext),
        IPublisherService
{
    public async Task<List<PublisherDto>> GetAllPublishersAsync()
    {
        var publishers = await dBContext.Publishers.ToListAsync();
        if (publishers == null)
        {
            return [];
        }

        return publishers.ConvertAll(publisherMapper.ToDto);
    }

    public async Task<PublisherDetailDto> GetSinglePublisherAsync(int publisherId)
    {
        var publisher = await dBContext.Publishers.FindAsync(publisherId);
        if (publisher == null)
        {
            return null;
        }

        return publisherMapper.ToDetailDto(publisher);
    }

    public async Task<PublisherDto> CreateSinglePublisherAsync(
        PublisherCreateDto publisherCreateDto
    )
    {
        var createdPublisher = await dBContext.Publishers.AddAsync(
            publisherMapper.ToModel(publisherCreateDto)
        );

        await SaveAsync(true);

        return publisherMapper.ToDto(createdPublisher.Entity);
    }

    public async Task<PublisherDto> UpdateSinglePublisherAsync(
        int publisherId,
        PublisherUpdateDto publisherUpdateDto
    )
    {
        var publisherToUpdate = await dBContext.Publishers.FindAsync(publisherId);
        if (publisherToUpdate == null)
        {
            return null;
        }

        publisherMapper.UpdateModel(publisherToUpdate, publisherUpdateDto);

        await SaveAsync(true);

        return publisherMapper.ToDto(publisherToUpdate);
    }

    public async Task<PublisherDto> DeleteSinglePublisherAsync(int publisherId)
    {
        var publisher = await dBContext.Publishers.FindAsync(publisherId);
        if (publisher == null)
        {
            return null;
        }

        publisher.DeletedAt = DateTime.Now;

        await SaveAsync(true);

        return publisherMapper.ToDto(publisher);
    }

    public async Task<bool> DoesPublisherExistAsync(int publisherId)
    {
        var publisher = await dBContext.Publishers.FindAsync(publisherId);

        return publisher != null;
    }
}
