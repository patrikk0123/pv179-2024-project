using BusinessLayer.DTOs.Book;
using WebMVC.ViewModels.Common.Interfaces;
using WebMVC.ViewModels.Genres;
using WebMVC.ViewModels.Publishers;

namespace WebMVC.ViewModels.Book;

public class BookPageViewModel : PageViewModel<BookViewModel>
{
    public GenreListPageViewModel? Genres { get; set; }

    public PublisherListPageViewModel? Publishers { get; set; }

    public BookQueryParameters BookQueryParameters { get; set; } = new();
}
