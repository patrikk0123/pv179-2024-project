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
    IPublisherService publisherService
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

        var genres = await genreService.GetAllGenresAsync(null);
        model.Genres = genres.Adapt<GenreListPageViewModel>();

        var publishers = await publisherService.GetAllPublishersAsync();
        model.Publishers = publishers.Adapt<PublisherListPageViewModel>();

        model.BookQueryParameters = bookQueryParameters;

        return View(model);
    }

    [HttpGet("detail/{bookId}")]
    public async Task<IActionResult> Detail(int bookId)
    {
        var book = await bookService.GetSingleBookAsync(bookId);
        if (book == null)
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

        var bookModel = book.Adapt<BookDetailViewModel>();
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

                book = await bookService.GetSingleBookAsync(bookId);
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
