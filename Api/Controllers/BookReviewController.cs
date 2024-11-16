using BusinessLayer.DTOs.BookReview;
using BusinessLayer.Mappers.Interfaces;
using DAL.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Controllers;

[ApiController]
[Route("/books/{bookId}/reviews")]
public class BookReviewController(BookHubDBContext dBContext, IBookReviewMapper bookReviewMapper)
    : Controller
{
    [HttpGet]
    public async Task<IActionResult> GetAllReviews([FromRoute] int bookId)
    {
        var reviews = await dBContext.Reviews.Where(r => r.BookId == bookId).ToListAsync();

        return Ok(reviews.Select(bookReviewMapper.ToDto));
    }

    [HttpGet]
    [Route("{reviewId}")]
    public async Task<IActionResult> GetSingleReview(
        [FromRoute] int bookId,
        [FromRoute] int reviewId
    )
    {
        var review = await dBContext.Reviews.FirstOrDefaultAsync(r =>
            r.Id == reviewId && r.BookId == bookId
        );

        if (review == null)
        {
            return NotFound();
        }

        return Ok(bookReviewMapper.ToDetailDto(review));
    }

    [HttpPost]
    public async Task<IActionResult> AddReview(
        [FromRoute] int bookId,
        [FromBody] BookReviewCreateDto reviewDto
    )
    {
        var book = await dBContext.Books.FindAsync(bookId);
        if (book == null)
        {
            return NotFound();
        }

        const int userId = 1;
        var user = await dBContext.Users.FindAsync(userId); // TODO: Get the user ID from the JWT token
        if (user == null)
        {
            return NotFound();
        }

        var review = bookReviewMapper.ToModel(reviewDto);
        review.BookId = bookId;
        review.UserId = userId;

        var createdReview = await dBContext.Reviews.AddAsync(review);
        await dBContext.SaveChangesAsync();

        return CreatedAtAction(
            nameof(GetSingleReview),
            new { bookId, reviewId = createdReview.Entity.Id },
            bookReviewMapper.ToDto(createdReview.Entity)
        );
    }

    [HttpPut]
    [Route("{reviewId}")]
    public async Task<IActionResult> UpdateReview(
        [FromRoute] int bookId,
        [FromRoute] int reviewId,
        [FromBody] BookReviewUpdateDto reviewDto
    )
    {
        var review = await dBContext.Reviews.FirstOrDefaultAsync(r =>
            r.Id == reviewId && r.BookId == bookId
        );

        if (review == null)
        {
            return NotFound();
        }

        bookReviewMapper.UpdateModel(review, reviewDto);
        await dBContext.SaveChangesAsync();

        return Ok(bookReviewMapper.ToDto(review));
    }

    [HttpDelete]
    [Route("{reviewId}")]
    public async Task<IActionResult> DeleteReview([FromRoute] int bookId, [FromRoute] int reviewId)
    {
        var review = await dBContext.Reviews.FirstOrDefaultAsync(r =>
            r.Id == reviewId && r.BookId == bookId
        );

        if (review == null)
        {
            return NotFound();
        }

        review.DeletedAt = DateTime.UtcNow;
        await dBContext.SaveChangesAsync();

        return Ok(bookReviewMapper.ToDto(review));
    }
}
