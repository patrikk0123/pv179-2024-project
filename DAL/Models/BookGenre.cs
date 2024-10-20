using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models;

public class BookGenre : BaseEntity
{
    public int BookId { get; set; }

    [ForeignKey(nameof(BookId))]
    public virtual Book? Book { get; set; }

    public int GenreId { get; set; }

    [ForeignKey(nameof(GenreId))]
    public virtual Genre? Genre { get; set; }
}
