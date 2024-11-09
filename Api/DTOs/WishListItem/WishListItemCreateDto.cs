using System.ComponentModel.DataAnnotations;

namespace Api.DTOs.WishListItem;

public class WishListItemCreateDto
{
    [Required]
    public required int UserId { get; init; }

    [Required]
    public required int BookId { get; init; }
}
