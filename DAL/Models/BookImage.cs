using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models;

public class BookImage : BaseEntity
{
    public int BookId { get; set; }

    [ForeignKey(nameof(BookId))]
    public virtual Book? Book { get; set; }

    public string ImageId { get; set; }
}
