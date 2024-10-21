using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models;

public class WishListItem : BaseEntity
{
    public int UserId { get; set; }

    [ForeignKey(nameof(UserId))]
    public virtual User? User { get; set; }

    public int BookId { get; set; }

    [ForeignKey(nameof(BookId)), Required]
    public virtual Book Book { get; set; } = null!;
}
