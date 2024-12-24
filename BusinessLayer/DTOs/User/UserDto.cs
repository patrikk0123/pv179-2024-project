using BusinessLayer.DTOs.Interfaces;
using DAL.Models;

namespace BusinessLayer.DTOs.User;

public class UserDto : BaseDto
{
    public required string Username { get; init; }

    public required string Email { get; init; }

    public required UserRole Role { get; init; }
}
