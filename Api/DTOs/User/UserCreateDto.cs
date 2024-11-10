using System.ComponentModel.DataAnnotations;
using DAL.Models;

namespace Api.DTOs.User;

public class UserCreateDto
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
