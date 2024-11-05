using System.ComponentModel.DataAnnotations;

namespace DAL.Models;

public class Author : BaseEntity
{
    [Required]
    [MinLength(1)]
    public required string Name { get; set; }

    [Required]
    [MinLength(1)]
    public required string Surname { get; set; }

    public virtual IEnumerable<BookAuthor>? BookAuthors { get; set; }
}
