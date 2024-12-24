using BusinessLayer.DTOs.Book;

namespace BusinessLayer.Facades.BookFacades.Interfaces;

public interface IBookFacade
{
    public Task<BookDetailDto> CreateBookWithImagesAsync(BookCreateDto bookCreateDto);

    public Task<string?> AddImageToBookAsync(int bookId, byte[] file);

    public Task<bool> DeleteImageFromBooksAsync(string imageId);
}
