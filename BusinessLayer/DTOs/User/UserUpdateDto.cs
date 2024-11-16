using System.ComponentModel.DataAnnotations;
using DAL.Models;

namespace BusinessLayer.DTOs.User;

public class UserUpdateDto
{
    [Required]
    public required string Username { get; init; }

    [Required]
    public required string Password { get; init; }

    [Required]
    [EmailAddress]
    public required string Email { get; init; }

    [Required]
    public required UserRole Role { get; init; }
}
