using Api.DTOs.Book;
using DAL.Models;

namespace Api.Mappers.Interfaces;

public interface IBookMapper
    : IEntityMapper<Book, BookDto, BookDetailDto, BookCreateDto, BookUpdateDto>;
