using BusinessLayer.DTOs.Book;

namespace BusinessLayer.Services.Book.Interfaces;

public interface IBookService
{
    public Task<List<BookDto>> GetAllBooksAsync(
        string? name,
        string? description,
        double? minPrice,
        double? maxPrice,
        string? publisherName,
        string? genreType
    );

    public Task<BookDetailDto?> GetSingleBookAsync(int bookId);

    public Task<BookDto?> UpdateBookAsync(int bookId, BookUpdateDto bookCreateDto);

    public Task<BookDetailDto?> AddBookAsync(BookCreateDto bookCreateDto, List<string> imagesIds);

    public Task<BookDetailDto?> DeleteBookAsync(int bookId);

    public Task<bool> AddImageToBookAsync(int bookId, string imageId);

    public Task<bool> RemoveImageFromBooksAsync(string imageId);

    public Task<bool> DoBooksExistAsync(IEnumerable<int> bookIds);

    public Task<bool> DoesBookExistAsync(int bookId);
}
