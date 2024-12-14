using System.ComponentModel.DataAnnotations;

namespace WebMVC.ViewModels.User;

public class UserUpdateViewModel
{
    [Required]
    public required string Username { get; init; }

    [Required]
    [EmailAddress]
    public required string Email { get; init; }
}
