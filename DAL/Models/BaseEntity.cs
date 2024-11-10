using System.ComponentModel.DataAnnotations;

namespace DAL.Models;

public class BaseEntity
{
    [Key]
    public int Id { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public DateTime? EditedAt { get; set; }

    public DateTime? DeletedAt { get; set; }
}
