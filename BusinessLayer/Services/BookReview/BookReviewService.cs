using BusinessLayer.DTOs.BookReview;
using BusinessLayer.Mappers.Interfaces;
using BusinessLayer.Services.BookReview.Interfaces;
using DAL.Data;
using Microsoft.EntityFrameworkCore;

namespace BusinessLayer.Services.BookReview;

public class BookReviewService(BookHubDBContext dBContext, IBookReviewMapper bookReviewMapper)
    : BaseService(dBContext),
        IBookReviewService
{
    public async Task<List<BookReviewDto>> GetAllReviewsAsync(int bookId)
    {
        var reviews = await dBContext.Reviews.Where(r => r.BookId == bookId).ToListAsync();
        return reviews.ConvertAll(bookReviewMapper.ToDto);
    }

    public async Task<BookReviewDetailDto?> GetSingleReviewAsync(int bookId, int reviewId)
    {
        var review = await dBContext.Reviews.FirstOrDefaultAsync(r =>
            r.Id == reviewId && r.BookId == bookId
        );

        if (review == null)
        {
            return null;
        }

        return bookReviewMapper.ToDetailDto(review);
    }

    public async Task<BookReviewDto> CreateSingleReviewAsync(
        int bookId,
        int userId,
        BookReviewCreateDto reviewCreateDto
    )
    {
        var review = bookReviewMapper.ToModel(reviewCreateDto);
        review.BookId = bookId;
        review.Book = await dBContext.Books.FindAsync(bookId);
        review.UserId = userId;
        review.User = await dBContext.Users.FindAsync(userId);

        var createdReview = await dBContext.Reviews.AddAsync(review);
        await SaveAsync(true);

        return bookReviewMapper.ToDto(createdReview.Entity);
    }

    public async Task<BookReviewDto?> UpdateSingleReviewAsync(
        int bookId,
        int reviewId,
        BookReviewUpdateDto reviewUpdateDto
    )
    {
        var review = await dBContext.Reviews.FirstOrDefaultAsync(r =>
            r.Id == reviewId && r.BookId == bookId
        );

        if (review == null)
        {
            return null;
        }

        bookReviewMapper.UpdateModel(review, reviewUpdateDto);
        await SaveAsync(true);

        return bookReviewMapper.ToDto(review);
    }

    public async Task<BookReviewDto?> DeleteSingleReviewAsync(int bookId, int reviewId)
    {
        var review = await dBContext.Reviews.FirstOrDefaultAsync(r =>
            r.Id == reviewId && r.BookId == bookId
        );

        if (review == null)
        {
            return null;
        }

        review.DeletedAt = DateTime.UtcNow;
        await SaveAsync(true);

        return bookReviewMapper.ToDto(review);
    }
}
