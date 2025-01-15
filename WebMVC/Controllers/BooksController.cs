using BusinessLayer.DTOs.Book;
using BusinessLayer.DTOs.BookReview;
using BusinessLayer.Services.Book.Interfaces;
using BusinessLayer.Services.BookReview.Interfaces;
using BusinessLayer.Services.Genre.Interfaces;
using BusinessLayer.Services.Publisher.Interfaces;
using BusinessLayer.Services.WishList.Interfaces;
using DAL.Models.Auth;
using Mapster;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using WebMVC.ViewModels.Book;
using WebMVC.ViewModels.Genres;
using WebMVC.ViewModels.Publishers;

namespace WebMVC.Controllers;

public class BooksController(
    UserManager<LocalIdentityUser> userManager,
    IBookService bookService,
    IWishlistService wishlistService,
    IBookReviewService bookReviewService,
    IGenreService genreService,
    IPublisherService publisherService,
    IMemoryCache memoryCache
) : Controller
{
    [HttpGet("")]
    public async Task<IActionResult> List([FromQuery] BookQueryParameters bookQueryParameters)
    {
        var bookPage = await bookService.GetAllBooksQueryAsync(
            bookQueryParameters.Pagination,
            bookQueryParameters.Search,
            bookQueryParameters.MinPrice,
            bookQueryParameters.MaxPrice,
            bookQueryParameters.Publisher,
            bookQueryParameters.Genre
        );

        var model = bookPage.Adapt<BookPageViewModel>();

        model.Genres = await GetCachedGenres();

        model.Publishers = await GetCachedPublishers();

        model.BookQueryParameters = bookQueryParameters;

        return View(model);
    }

    private async Task<GenreListPageViewModel?> GetCachedGenres()
    {
        const string cacheKey = "genres";
        if (!memoryCache.TryGetValue(cacheKey, out GenreListPageViewModel? genres))
        {
            var genreDto = await genreService.GetAllGenresAsync(null);
            genres = genreDto.Adapt<GenreListPageViewModel>();
            memoryCache.Set(
                cacheKey,
                genres,
                new MemoryCacheEntryOptions
                {
                    AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(5),
                }
            );
        }

        return genres;
    }

    private async Task<PublisherListPageViewModel?> GetCachedPublishers()
    {
        const string cacheKey = "publishers";
        if (!memoryCache.TryGetValue(cacheKey, out PublisherListPageViewModel? publishers))
        {
            var publisherDto = await publisherService.GetAllPublishersAsync();
            publishers = publisherDto.Adapt<PublisherListPageViewModel>();
            memoryCache.Set(
                cacheKey,
                publishers,
                new MemoryCacheEntryOptions
                {
                    AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(5),
                }
            );
        }

        return publishers;
    }

    private async Task<BookDetailViewModel?> GetCachedBookDetailModel(int bookId)
    {
        var cacheKey = $"book-detail-{bookId}";
        if (!memoryCache.TryGetValue(cacheKey, out BookDetailViewModel? bookModel))
        {
            var bookDto = await bookService.GetSingleBookAsync(bookId);
            if (bookDto == null)
            {
                return null;
            }

            bookModel = bookDto.Adapt<BookDetailViewModel>();
            memoryCache.Set(
                cacheKey,
                bookModel,
                new MemoryCacheEntryOptions
                {
                    AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(5),
                }
            );
        }

        return bookModel;
    }

    [HttpGet("detail/{bookId}")]
    public async Task<IActionResult> Detail(int bookId)
    {
        var bookModel = await GetCachedBookDetailModel(bookId);
        if (bookModel == null)
        {
            return NotFound();
        }

        var isInUserWishList = false;

        var user = await userManager.GetUserAsync(User);
        if (user != null)
        {
            var wishlistItem = await wishlistService.GetSingleWishlistItemAsync(
                user.UserId,
                bookId
            );

            if (wishlistItem != null)
            {
                isInUserWishList = true;
            }
        }

        var model = new UserBookViewModel { Book = bookModel, IsInUserWishList = isInUserWishList };

        return View(model);
    }

    [HttpPost("detail/{bookId}")]
    [Authorize]
    public async Task<IActionResult> Detail(int bookId, BookFormReviewViewModel viewModelReviewView)
    {
        var book = await bookService.GetSingleBookAsync(bookId);
        if (book == null)
        {
            return NotFound();
        }

        var user = await userManager.GetUserAsync(User);
        if (user == null)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                await bookReviewService.CreateSingleReviewAsync(
                    bookId,
                    user.UserId,
                    new BookReviewCreateDto()
                    {
                        Rating = viewModelReviewView.Rating,
                        Body = viewModelReviewView.Body,
                    }
                );
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                ModelState.AddModelError(string.Empty, "Something wrong occured.");
            }
        }

        return RedirectToAction(nameof(Detail));
    }
}
