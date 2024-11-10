using Api.DTOs.BookReview;
using DAL.Models;

namespace Api.Mappers.Interfaces;

public interface IBookReviewMapper
    : IEntityMapper<
        Review,
        BookReviewDto,
        BookReviewDetailDto,
        BookReviewCreateDto,
        BookReviewUpdateDto
    >;
