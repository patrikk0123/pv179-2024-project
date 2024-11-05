using System.ComponentModel.DataAnnotations;

namespace DAL.Models;

public class Publisher : BaseEntity
{
    [Required]
    [MinLength(1)]
    public required string Name { get; set; }

    public virtual IEnumerable<Book>? Books { get; set; }
}
