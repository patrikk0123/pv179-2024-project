using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models;

public class Review : BaseEntity
{
    public int UserId { get; set; }

    [ForeignKey(nameof(UserId))]
    public virtual User? User { get; set; }

    public int BookId { get; set; }

    [ForeignKey(nameof(BookId))]
    public virtual Book? Book { get; set; }

    [Required]
    [Range(1, 5)]
    public required int Rating { get; set; }

    [Required]
    [MaxLength(2000)]
    public required string Body { get; set; }
}
