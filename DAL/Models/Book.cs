using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models;

public class Book : BaseEntity
{
    [Required]
    [MinLength(1)]
    public required string Name { get; set; }

    [Required]
    [MinLength(1)]
    public required string ISBN { get; set; }

    [Required]
    public required string Description { get; set; }

    [Required]
    public required DateOnly PublishDate { get; set; }

    [Required]
    [Range(1, int.MaxValue)]
    public required int Pages { get; set; }

    [Required]
    [Range(1, 5)]
    public required double Rating { get; set; }

    [Required]
    [Range(0, double.MaxValue)]
    public required double Price { get; set; }

    public int PublisherId { get; set; }

    [ForeignKey(nameof(PublisherId))]
    public virtual Publisher? Publisher { get; set; }
}
