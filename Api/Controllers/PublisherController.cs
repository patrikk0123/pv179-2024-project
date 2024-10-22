using Api.DTOs.Publisher;
using Api.Mappers.Interfaces;
using DAL.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Controllers;

[ApiController]
[Route("/publishers")]
public class PublisherController(BookHubDBContext dBContext, IPublisherMapper publisherMapper)
    : Controller
{
    [HttpGet]
    [Route("")]
    public async Task<IActionResult> GetAllPublisher()
    {
        var publishers = await dBContext.Publishers.ToListAsync();

        return Ok(publishers.Select(publisher => publisherMapper.ToDto(publisher)));
    }

    [HttpGet]
    [Route("{publisherId}")]
    public async Task<IActionResult> GetPublisherDetail(int publisherId)
    {
        var book = await dBContext.Publishers.FindAsync(publisherId);
        if (book == null)
        {
            return NotFound();
        }

        return Ok(publisherMapper.ToDetailDto(book));
    }

    [HttpPost]
    [Route("")]
    public async Task<IActionResult> CreatePublisher([FromBody] CreatePublisherDto publisherDto)
    {
        var createdPublisher = await dBContext.Publishers.AddAsync(
            publisherMapper.ToModel(publisherDto)
        );
        await dBContext.SaveChangesAsync();
        return Ok(publisherMapper.ToDto(createdPublisher.Entity));
    }

    [HttpPut]
    [Route("{publisherId}")]
    public async Task<IActionResult> UpdatePublisher(
        int publisherId,
        [FromBody] UpdatePublisherDto publisherDto
    )
    {
        var publisherToUpdate = await dBContext.Publishers.FindAsync(publisherId);
        if (publisherToUpdate == null)
        {
            return NotFound();
        }

        publisherMapper.UpdateModel(publisherToUpdate, publisherDto);
        await dBContext.SaveChangesAsync();

        return Ok(publisherMapper.ToDto(publisherToUpdate));
    }

    [HttpDelete]
    [Route("{publisherId}")]
    public async Task<IActionResult> DeletePublisher(int publisherId)
    {
        var publisher = await dBContext.Publishers.FindAsync(publisherId);
        if (publisher == null)
        {
            return NotFound();
        }

        publisher.DeletedAt = DateTime.Now;
        await dBContext.SaveChangesAsync();

        return Ok(publisherMapper.ToDto(publisher));
    }
}
