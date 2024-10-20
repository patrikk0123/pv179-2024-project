using System.ComponentModel.DataAnnotations;

namespace DAL.Models;

public class Genre : BaseEntity
{
    [Required]
    [MinLength(1)]
    public required string GenreType { get; set; }

    public virtual IEnumerable<BookGenre>? BookGenres { get; set; }
}
