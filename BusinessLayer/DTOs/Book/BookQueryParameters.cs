using BusinessLayer.DTOs.Common;

namespace BusinessLayer.DTOs.Book;

public class BookQueryParameters
{
    public Pagination Pagination { get; set; } = new();

    public string? Search { get; set; }

    public double? MinPrice { get; set; }

    public double? MaxPrice { get; set; }

    public string? Publisher { get; set; }

    public string? Genre { get; set; }
}
