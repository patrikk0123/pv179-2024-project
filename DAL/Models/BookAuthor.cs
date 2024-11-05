using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models;

public class BookAuthor : BaseEntity
{
    public int BookId { get; set; }

    [ForeignKey(nameof(BookId))]
    public virtual Book? Book { get; set; }

    public int AuthorId { get; set; }

    [ForeignKey(nameof(AuthorId))]
    public virtual Author? Author { get; set; }
}
