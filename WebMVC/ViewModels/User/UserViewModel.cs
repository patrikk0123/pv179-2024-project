using DAL.Models;

namespace WebMVC.ViewModels.User;

public class UserViewModel
{
    public int Id { get; init; }

    public required string Username { get; init; }

    public required string Email { get; init; }

    public required UserRole Role { get; init; }
}
