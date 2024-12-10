using DAL.Models;
using DAL.Models.Auth;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebMVC.ViewModels.Auth;

namespace WebMVC.Controllers;

public class AccountController(
    UserManager<LocalIdentityUser> userManager,
    SignInManager<LocalIdentityUser> signInManager
) : Controller
{
    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Register(RegisterViewModel model)
    {
        if (ModelState.IsValid)
        {
            var user = new LocalIdentityUser
            {
                UserName = model.Username,
                Email = model.Email,
                User = new()
                {
                    Username = model.Username,
                    Email = model.Email,
                    Role = model.IsAdmin ? UserRole.Admin : UserRole.User,
                },
            };
            var result = await userManager.CreateAsync(user, model.Password);

            if (model.IsAdmin)
            {
                await userManager.AddToRoleAsync(user, "Admin");
            }
            else
            {
                await userManager.AddToRoleAsync(user, "User");
            }

            if (result.Succeeded)
            {
                await signInManager.SignInAsync(user, isPersistent: false);
                return RedirectToAction(
                    nameof(Login),
                    nameof(AccountController).Replace("Controller", "")
                );
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
        }

        return View(model);
    }

    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Login(LoginViewModel model)
    {
        if (ModelState.IsValid)
        {
            var result = await signInManager.PasswordSignInAsync(
                model.Username,
                model.Password,
                model.RememberMe,
                lockoutOnFailure: false
            );

            if (result.Succeeded)
            {
                return RedirectToAction(
                    nameof(LoginSuccess),
                    nameof(AccountController).Replace("Controller", "")
                );
            }

            ModelState.AddModelError(string.Empty, "Invalid login attempt.");
        }

        return View(model);
    }

    public async Task<IActionResult> Logout()
    {
        await signInManager.SignOutAsync();
        return RedirectToAction(
            nameof(HomeController.Index),
            nameof(HomeController).Replace("Controller", "")
        );
    }

    public IActionResult LoginSuccess()
    {
        return View();
    }

    [HttpGet("/account/wishlist")]
    public async Task<IActionResult> GetAllUserWishListItems()
    {
        return View();
    }

    [HttpGet("/account/orders")]
    public async Task<IActionResult> GetAllUserOrders()
    {
        return View();
    }
}
