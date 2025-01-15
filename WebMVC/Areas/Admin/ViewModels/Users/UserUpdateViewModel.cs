using System.ComponentModel.DataAnnotations;

namespace WebMVC.Areas.Admin.ViewModels.Users;

public class UserUpdateViewModel
{
    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }
}
