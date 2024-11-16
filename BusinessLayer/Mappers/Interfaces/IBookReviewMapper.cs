using BusinessLayer.DTOs.BookReview;
using DAL.Models;

namespace BusinessLayer.Mappers.Interfaces;

public interface IBookReviewMapper
    : IEntityMapper<
        Review,
        BookReviewDto,
        BookReviewDetailDto,
        BookReviewCreateDto,
        BookReviewUpdateDto
    >;
