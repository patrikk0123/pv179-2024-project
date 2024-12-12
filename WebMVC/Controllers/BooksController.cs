using BusinessLayer.DTOs.BookReview;
using BusinessLayer.DTOs.Common;
using BusinessLayer.Services.Book.Interfaces;
using BusinessLayer.Services.BookReview.Interfaces;
using BusinessLayer.Services.WishList.Interfaces;
using DAL.Models.Auth;
using Mapster;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebMVC.ViewModels.Book;

namespace WebMVC.Controllers;

public class BooksController(
    UserManager<LocalIdentityUser> userManager,
    IBookService bookService,
    IWishlistService wishlistService,
    IBookReviewService bookReviewService
) : Controller
{
    [HttpGet("")]
    public async Task<IActionResult> List([FromQuery] Pagination pagination)
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

        var model = bookPage.Adapt<BookPageViewModel>();

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
    public async Task<IActionResult> Detail(int bookId, BookReviewModel modelReview)
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
                        Rating = modelReview.Rating,
                        Body = modelReview.Body,
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
