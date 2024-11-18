using BusinessLayer.DTOs.User;
using BusinessLayer.Mappers.Interfaces;
using BusinessLayer.Services.User.Interfaces;
using DAL.Data;
using Microsoft.EntityFrameworkCore;

namespace BusinessLayer.Services.User;

public class UserService(BookHubDBContext dBContext, IUserMapper userMapper)
    : BaseService(dBContext),
        IUserService
{
    public async Task<List<UserDto>> GetAllUsersAsync()
    {
        var users = await dBContext.Users.ToListAsync();
        if (users == null)
        {
            return [];
        }

        return users.ConvertAll(userMapper.ToDto);
    }

    public async Task<UserDetailDto> GetSingleUserAsync(int userId)
    {
        var user = await dBContext.Users.FindAsync(userId);
        if (user == null)
        {
            return null;
        }

        return userMapper.ToDetailDto(user);
    }

    public async Task<UserDto> CreateSingleUserAsync(UserCreateDto userCreateDto)
    {
        var createdUser = await dBContext.Users.AddAsync(userMapper.ToModel(userCreateDto));

        await SaveAsync(true);

        return userMapper.ToDto(createdUser.Entity);
    }

    public async Task<UserDto> UpdateSingleUserAsync(int userId, UserUpdateDto userUpdateDto)
    {
        var userToUpdate = await dBContext.Users.FindAsync(userId);
        if (userToUpdate == null)
        {
            return null;
        }

        userMapper.UpdateModel(userToUpdate, userUpdateDto);
        dBContext.Users.Update(userToUpdate);

        await SaveAsync(true);

        return userMapper.ToDto(userToUpdate);
    }

    public async Task<UserDto> DeleteSingleUserAsync(int userId)
    {
        var user = await dBContext.Users.FindAsync(userId);
        if (user == null)
        {
            return null;
        }

        user.DeletedAt = DateTime.Now;

        await SaveAsync(true);

        return userMapper.ToDto(user);
    }

    public async Task<bool> DoesUserExistAsync(int userId)
    {
        var user = await dBContext.Users.FindAsync(userId);

        return user != null;
    }
}
