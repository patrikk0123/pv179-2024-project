using BusinessLayer.DTOs.BookReview;
using BusinessLayer.Services.Book.Interfaces;
using BusinessLayer.Services.BookReview.Interfaces;
using BusinessLayer.Services.User.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("/books/{bookId}/reviews")]
public class BookReviewController(
    IUserService userService,
    IBookService bookService,
    IBookReviewService bookReviewService
) : Controller
{
    [HttpGet]
    public async Task<IActionResult> GetAllReviews([FromRoute] int bookId)
    {
        return Ok(await bookReviewService.GetAllReviewsAsync(bookId));
    }

    [HttpGet]
    [Route("{reviewId}")]
    public async Task<IActionResult> GetSingleReview(
        [FromRoute] int bookId,
        [FromRoute] int reviewId
    )
    {
        var review = await bookReviewService.GetSingleReviewAsync(bookId, reviewId);

        if (review == null)
        {
            return NotFound();
        }

        return Ok(review);
    }

    [HttpPost]
    public async Task<IActionResult> AddReview(
        [FromRoute] int bookId,
        [FromBody] BookReviewCreateDto reviewDto
    )
    {
        if (!await bookService.DoesBookExistAsync(bookId))
        {
            return NotFound();
        }

        const int userId = 1; // TODO: Get the user ID from the JWT token
        if (!await userService.DoesUserExistAsync(userId))
        {
            return NotFound();
        }

        var createdReview = await bookReviewService.CreateSingleReviewAsync(
            bookId,
            userId,
            reviewDto
        );

        return CreatedAtAction(
            nameof(GetSingleReview),
            new { bookId, reviewId = createdReview.Id },
            createdReview
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
        var review = await bookReviewService.UpdateSingleReviewAsync(bookId, reviewId, reviewDto);

        if (review == null)
        {
            return NotFound();
        }

        return Ok(review);
    }

    [HttpDelete]
    [Route("{reviewId}")]
    public async Task<IActionResult> DeleteReview([FromRoute] int bookId, [FromRoute] int reviewId)
    {
        var review = await bookReviewService.DeleteSingleReviewAsync(bookId, reviewId);

        if (review == null)
        {
            return NotFound();
        }

        return Ok(review);
    }
}
