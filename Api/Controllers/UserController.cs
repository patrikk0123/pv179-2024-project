using Api.DTOs.BookReview;
using Api.DTOs.User;
using Api.Mappers;
using Api.Mappers.Interfaces;
using DAL.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Controllers;

[ApiController]
[Route("/users")]
public class UserController(BookHubDBContext dBContext, IUserMapper userMapper) : Controller
{
    [HttpGet]
    public async Task<IActionResult> GetAllUsers()
    {
        var reviews = await dBContext.Users.ToListAsync();

        return Ok(reviews.Select(u => userMapper.ToDto(u)));
    }

    [HttpGet]
    [Route("{userId}")]
    public async Task<IActionResult> GetSingleUser(int userId)
    {
        var user = await dBContext.Users.FirstOrDefaultAsync(u => u.Id == userId);

        if (user == null)
        {
            return NotFound();
        }

        return Ok(userMapper.ToDetailDto(user));
    }

    [HttpPost]
    public async Task<IActionResult> AddUser([FromBody] UserCreateDto userCreateDto)
    {
        var user = userMapper.ToModel(userCreateDto);

        var createdUser = await dBContext.Users.AddAsync(user);
        await dBContext.SaveChangesAsync();

        return CreatedAtAction(
            nameof(GetSingleUser),
            new { userId = createdUser.Entity.Id },
            userMapper.ToDto(createdUser.Entity)
        );
    }

    [HttpPut]
    [Route("{userId}")]
    public async Task<IActionResult> UpdateUser(int userId, [FromBody] UserUpdateDto userUpdateDto)
    {
        var user = await dBContext.Users.FirstOrDefaultAsync(u => u.Id == userId);

        if (user == null)
        {
            return NotFound();
        }

        userMapper.UpdateModel(user, userUpdateDto);
        await dBContext.SaveChangesAsync();

        return Ok(userMapper.ToDto(user));
    }

    [HttpDelete]
    [Route("{userId}")]
    public async Task<IActionResult> DeleteUser(int userId)
    {
        var user = await dBContext.Users.FirstOrDefaultAsync(u => u.Id == userId);

        if (user == null)
        {
            return NotFound();
        }

        user.DeletedAt = DateTime.UtcNow;
        await dBContext.SaveChangesAsync();

        return Ok(userMapper.ToDto(user));
    }
}
