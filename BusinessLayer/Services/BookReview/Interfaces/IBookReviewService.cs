using BusinessLayer.DTOs.BookReview;

namespace BusinessLayer.Services.BookReview.Interfaces;

public interface IBookReviewService
{
    public Task<List<BookReviewDto>> GetAllReviewsAsync(int bookId);

    public Task<BookReviewDetailDto?> GetSingleReviewAsync(int bookId, int reviewId);

    public Task<BookReviewDto> CreateSingleReviewAsync(
        int bookId,
        int userId,
        BookReviewCreateDto reviewCreateDto
    );

    public Task<BookReviewDto?> UpdateSingleReviewAsync(
        int bookId,
        int reviewId,
        BookReviewUpdateDto reviewUpdateDto
    );

    public Task<BookReviewDto?> DeleteSingleReviewAsync(int bookId, int reviewId);
}
