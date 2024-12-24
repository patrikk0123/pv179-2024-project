using BusinessLayer.DTOs.BookReview;
using BusinessLayer.Mappers.Interfaces;
using DAL.Models;

namespace BusinessLayer.Mappers;

public class BookReviewMapper : IBookReviewMapper
{
    public BookReviewDto ToDto(Review model)
    {
        return new BookReviewDto
        {
            Id = model.Id,
            BookName = model.Book.Name,
            ReviewerName = model.User.Username,
            Body = model.Body,
            Rating = model.Rating,
            CreatedAt = model.CreatedAt,
        };
    }

    public BookReviewDetailDto ToDetailDto(Review model)
    {
        return new BookReviewDetailDto()
        {
            Id = model.Id,
            BookName = model.Book.Name,
            ReviewerName = model.User.Username,
            Body = model.Body,
            Rating = model.Rating,
            CreatedAt = model.CreatedAt,
        };
    }

    public Review ToModel(BookReviewCreateDto dto)
    {
        return new Review() { Body = dto.Body, Rating = dto.Rating };
    }

    public void UpdateModel(Review model, BookReviewUpdateDto updateDto)
    {
        model.Body = updateDto.Body;
        model.Rating = updateDto.Rating;
    }
}
