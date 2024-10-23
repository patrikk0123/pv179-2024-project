using Api.DTOs.Interfaces;
using DAL.Models;

namespace Api.DTOs.User;

public class UserDto : BaseDto
{
    public required string Username { get; init; }

    public required string Email { get; init; }

    public required UserRole Role { get; init; }
}
