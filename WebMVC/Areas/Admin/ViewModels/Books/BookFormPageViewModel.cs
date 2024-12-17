using WebMVC.Areas.Admin.ViewModels.Authors;
using WebMVC.Areas.Admin.ViewModels.Genres;
using WebMVC.Areas.Admin.ViewModels.Publisher;

namespace WebMVC.Areas.Admin.ViewModels.Books;

public class BookFormPageViewModel
{
    public required List<AuthorDetailViewModel> Authors { get; init; } = [];

    public required List<GenreDetailViewModel> Genres { get; init; } = [];

    public required List<PublisherDetailViewModel> Publishers { get; init; } = [];

    public BookFormViewModel? BookForm { get; init; }
}
