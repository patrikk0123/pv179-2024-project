using BusinessLayer.DTOs.User;
using BusinessLayer.Services.Order.Interfaces;
using BusinessLayer.Services.User.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("/users")]
public class UserController(IUserService userService, IOrderService orderService) : Controller
{
    [HttpGet]
    public async Task<IActionResult> GetAllUsers()
    {
        return Ok(await userService.GetAllUsersAsync());
    }

    [HttpGet]
    [Route("{userId}")]
    public async Task<IActionResult> GetSingleUser(int userId)
    {
        var user = await userService.GetSingleUserAsync(userId);
        if (user == null)
        {
            return NotFound();
        }

        return Ok(user);
    }

    [HttpPost]
    public async Task<IActionResult> CreateSingleUser([FromBody] UserCreateDto userCreateDto)
    {
        var createdUser = await userService.CreateSingleUserAsync(userCreateDto);

        return CreatedAtAction(nameof(GetSingleUser), new { userId = createdUser.Id }, createdUser);
    }

    [HttpPut]
    [Route("{userId}")]
    public async Task<IActionResult> UpdateSingleUser(
        int userId,
        [FromBody] UserUpdateDto userUpdateDto
    )
    {
        var updatedUser = await userService.UpdateSingleUserAsync(userId, userUpdateDto);
        if (updatedUser == null)
        {
            return NotFound();
        }

        return Ok(updatedUser);
    }

    [HttpDelete]
    [Route("{userId}")]
    public async Task<IActionResult> DeleteSingleUser(int userId)
    {
        var deletedUser = await userService.DeleteSingleUserAsync(userId);
        if (deletedUser == null)
        {
            return NotFound();
        }

        return Ok(deletedUser);
    }

    [HttpGet]
    [Route("{userId}/orders")]
    public async Task<IActionResult> GetAllUserOrders(int userId)
    {
        return Ok(await orderService.GetAllOrdersAsync(userId));
    }
}
