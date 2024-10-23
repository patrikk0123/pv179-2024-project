using System.ComponentModel.DataAnnotations;

namespace DAL.Models;

public class User : BaseEntity
{
    [Required]
    [Range(3, 20)]
    public required string Username { get; set; }

    [Required]
    public required string Password { get; set; }

    [Required]
    [EmailAddress]
    public required string Email { get; set; }

    [Required]
    public required UserRole Role { get; set; }

    public virtual IEnumerable<Review>? Reviews { get; set; }

    public virtual IEnumerable<Order>? Orders { get; set; }

    public virtual IEnumerable<WishListItem>? WishListItems { get; set; }
}
