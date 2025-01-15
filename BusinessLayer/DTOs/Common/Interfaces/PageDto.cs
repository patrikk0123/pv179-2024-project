namespace BusinessLayer.DTOs.Common.Interfaces;

public abstract class PageDto<T>
{
    public int PageIndex { get; init; }

    public int PageSize { get; init; }

    public int TotalCount { get; init; }

    public int TotalPages { get; init; }

    public List<T> Content { get; init; }
}
