using WebMVC.ViewModels.User;

namespace WebMVC.Areas.Admin.ViewModels.Users;

public class UserListViewModel
{
    public required List<UserViewModel> Users { get; init; } = [];
}
