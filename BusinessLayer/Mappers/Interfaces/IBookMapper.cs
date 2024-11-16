using BusinessLayer.DTOs.Book;
using DAL.Models;

namespace BusinessLayer.Mappers.Interfaces;

public interface IBookMapper
    : IEntityMapper<Book, BookDto, BookDetailDto, BookCreateDto, BookUpdateDto>;
