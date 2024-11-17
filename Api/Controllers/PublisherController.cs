using BusinessLayer.DTOs.Publisher;
using BusinessLayer.Services.Publisher.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("/publishers")]
public class PublisherController(IPublisherService publisherService) : Controller
{
    [HttpGet]
    public async Task<IActionResult> GetAllPublishers()
    {
        return Ok(await publisherService.GetAllPublishersAsync());
    }

    [HttpGet]
    [Route("{publisherId}")]
    public async Task<IActionResult> GetPublisherDetail(int publisherId)
    {
        var publisher = await publisherService.GetSinglePublisherAsync(publisherId);
        if (publisher == null)
        {
            return NotFound();
        }

        return Ok(publisher);
    }

    [HttpPost]
    public async Task<IActionResult> CreatePublisher(
        [FromBody] PublisherCreateDto publisherCreateDto
    )
    {
        var createdPublisher = await publisherService.CreateSinglePublisherAsync(
            publisherCreateDto
        );

        return CreatedAtAction(
            nameof(GetPublisherDetail),
            new { publisherId = createdPublisher.Id },
            createdPublisher
        );
    }

    [HttpPut]
    [Route("{publisherId}")]
    public async Task<IActionResult> UpdatePublisher(
        int publisherId,
        [FromBody] PublisherUpdateDto publisherUpdateDto
    )
    {
        var updatedPublisher = await publisherService.UpdateSinglePublisherAsync(
            publisherId,
            publisherUpdateDto
        );
        if (updatedPublisher == null)
        {
            return NotFound();
        }

        return Ok(updatedPublisher);
    }

    [HttpDelete]
    [Route("{publisherId}")]
    public async Task<IActionResult> DeletePublisher(int publisherId)
    {
        var deletedPublisher = await publisherService.DeleteSinglePublisherAsync(publisherId);
        if (deletedPublisher == null)
        {
            return NotFound();
        }

        return Ok(deletedPublisher);
    }
}
