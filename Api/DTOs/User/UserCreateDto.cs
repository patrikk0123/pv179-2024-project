using DAL.Models;

namespace Api.DTOs.User;

public class UserCreateDto
{
    public required string Username { get; init; }

    public required string Password { get; init; }

    public required string Email { get; init; }

    public required UserRole Role { get; init; }
}
