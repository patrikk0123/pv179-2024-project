using System.ComponentModel.DataAnnotations;

namespace BusinessLayer.DTOs.WishListItem;

public class WishListItemCreateDto
{
    [Required]
    public required int UserId { get; init; }

    [Required]
    public required int BookId { get; init; }
}
