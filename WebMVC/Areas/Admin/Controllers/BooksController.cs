using BusinessLayer.DTOs.Book;
using BusinessLayer.DTOs.Common;
using BusinessLayer.Facades.BookFacades.Interfaces;
using BusinessLayer.Services.Author.Interfaces;
using BusinessLayer.Services.Book.Interfaces;
using BusinessLayer.Services.Genre.Interfaces;
using BusinessLayer.Services.Publisher.Interfaces;
using Mapster;
using Microsoft.AspNetCore.Mvc;
using WebMVC.Areas.Admin.ViewModels.Authors;
using WebMVC.Areas.Admin.ViewModels.Books;
using WebMVC.Areas.Admin.ViewModels.Genres;
using WebMVC.Areas.Admin.ViewModels.Publisher;

namespace WebMVC.Areas.Admin.Controllers;

public class BooksController(
    ILogger<BooksController> logger,
    IBookFacade bookFacade,
    IBookService bookService,
    IAuthorService authorService,
    IGenreService genreService,
    IPublisherService publisherService
) : AdminController
{
    public async Task<IActionResult> Index([FromQuery] Pagination pagination)
    {
        var bookPage = await bookService.GetAllBooksAsync(
            pagination,
            null,
            null,
            null,
            null,
            null,
            null
        );

        var model = bookPage.Adapt<BookListPageViewModel>();

        return View(model);
    }

    [HttpGet("admin/books/{id}")]
    public async Task<IActionResult> Detail(int id)
    {
        var book = await bookService.GetSingleBookAsync(id);
        if (book == null)
        {
            return NotFound();
        }

        var model = book.Adapt<BookDetailPageViewModel>();

        return View(model);
    }

    [HttpGet("admin/books/create")]
    public async Task<IActionResult> Create()
    {
        var authors = await authorService.GetAllAuthorsAsync(null, null);
        var genres = await genreService.GetAllGenresAsync(null);
        var publishers = await publisherService.GetAllPublishersAsync();

        var model = new BookFormPageViewModel
        {
            Authors = authors.ConvertAll(author => author.Adapt<AuthorDetailViewModel>()),
            Genres = genres.ConvertAll(genre => genre.Adapt<GenreDetailViewModel>()),
            Publishers = publishers.ConvertAll(publisher =>
                publisher.Adapt<PublisherDetailViewModel>()
            ),
        };

        return View(model);
    }

    [HttpPost("admin/books/create")]
    public async Task<IActionResult> Create(BookFormPageViewModel bookFormViewModel)
    {
        if (!ModelState.IsValid)
        {
            var authors = await authorService.GetAllAuthorsAsync(null, null);
            var genres = await genreService.GetAllGenresAsync(null);
            var publishers = await publisherService.GetAllPublishersAsync();

            var model = new BookFormPageViewModel
            {
                Authors = authors.ConvertAll(author => author.Adapt<AuthorDetailViewModel>()),
                Genres = genres.ConvertAll(genre => genre.Adapt<GenreDetailViewModel>()),
                Publishers = publishers.ConvertAll(publisher =>
                    publisher.Adapt<PublisherDetailViewModel>()
                ),
                BookForm = bookFormViewModel.BookForm,
            };

            return View(model);
        }

        var bookCreateDto = bookFormViewModel.BookForm.Adapt<BookCreateDto>();
        var book = await bookFacade.CreateBookWithImagesAsync(
            bookCreateDto,
            bookFormViewModel?.BookForm.Images ?? []
        );

        return RedirectToAction(nameof(Detail), new { id = book.Id });
    }

    [HttpGet("admin/books/update/{id}")]
    public async Task<IActionResult> Update(int id)
    {
        var book = await bookService.GetSingleBookAsync(id);

        if (book == null)
        {
            return NotFound();
        }

        var authors = await authorService.GetAllAuthorsAsync(null, null);
        var genres = await genreService.GetAllGenresAsync(null);
        var publishers = await publisherService.GetAllPublishersAsync();

        var model = new BookFormPageViewModel
        {
            Authors = authors.ConvertAll(author => author.Adapt<AuthorDetailViewModel>()),
            Genres = genres.ConvertAll(genre => genre.Adapt<GenreDetailViewModel>()),
            Publishers = publishers.ConvertAll(publisher =>
                publisher.Adapt<PublisherDetailViewModel>()
            ),
            BookForm = new BookFormViewModel()
            {
                Name = book.Name,
                Description = book.Description,
                Pages = book.Pages,
                Price = book.Price,
                Rating = book.Rating,
                AuthorIds = book.Authors.ConvertAll(author => author.Id),
                GenreIds = book.Genres.ConvertAll(genre => genre.Id),
                ISBN = book.ISBN,
#pragma warning disable CA1305
                PublishDate = book.PublishDate.ToString("yyyy-MM-dd"),
#pragma warning restore CA1305
                Images = [],
                PublisherId = book.PublisherId,
                PrimaryGenreId = book.PrimaryGenre.Id,
            },
        };

        return View(model);
    }

    [HttpPost("admin/books/update/{id}")]
    public async Task<IActionResult> Update(int id, BookFormPageViewModel bookViewModel)
    {
        var book = await bookService.GetSingleBookAsync(id);

        if (book == null)
        {
            return NotFound();
        }

        if (!ModelState.IsValid)
        {
            var authors = await authorService.GetAllAuthorsAsync(null, null);
            var genres = await genreService.GetAllGenresAsync(null);
            var publishers = await publisherService.GetAllPublishersAsync();

            var model = new BookFormPageViewModel
            {
                Authors = authors.ConvertAll(author => author.Adapt<AuthorDetailViewModel>()),
                Genres = genres.ConvertAll(genre => genre.Adapt<GenreDetailViewModel>()),
                Publishers = publishers.ConvertAll(publisher =>
                    publisher.Adapt<PublisherDetailViewModel>()
                ),
                BookForm = bookViewModel.BookForm,
            };
            return View(model);
        }

        var bookUpdateDto = bookViewModel.BookForm.Adapt<BookUpdateDto>();
        await bookService.UpdateBookAsync(id, bookUpdateDto);

        return RedirectToAction(nameof(Detail), new { id = book.Id });
    }

    [HttpGet("admin/books/delete/{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var book = await bookService.DeleteBookAsync(id);
        if (book == null)
        {
            return NotFound();
        }

        return RedirectToAction("Index");
    }
}
