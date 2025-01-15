using BusinessLayer.Services.User.Interfaces;
using DAL.Models.Auth;
using Mapster;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebMVC.Areas.Admin.ViewModels.Users;

namespace WebMVC.Areas.Admin.Controllers;

public class UsersController(UserManager<LocalIdentityUser> userManager, IUserService userService)
    : AdminController
{
    public async Task<IActionResult> Index()
    {
        var users = await userService.GetAllUsersAsync();

        var model = users.Adapt<UserListViewModel>();

        return View(model);
    }

    [HttpGet("admin/users/update/{userId}")]
    public IActionResult Update()
    {
        return View();
    }

    [HttpPost("admin/users/update/{userId}")]
    public async Task<IActionResult> Update(int userId, UserUpdateViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }

        var user = await userManager.Users.FirstOrDefaultAsync(u => u.UserId == userId);

        if (user == null)
        {
            ModelState.AddModelError(string.Empty, "User not found.");
            return View(model);
        }

        var removePasswordResult = await userManager.RemovePasswordAsync(user);
        if (!removePasswordResult.Succeeded)
        {
            foreach (var error in removePasswordResult.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }

            return View(model);
        }

        var addPasswordResult = await userManager.AddPasswordAsync(user, model.Password);
        if (!addPasswordResult.Succeeded)
        {
            foreach (var error in addPasswordResult.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
            return View(model);
        }

        return RedirectToAction("Index");
    }
}
