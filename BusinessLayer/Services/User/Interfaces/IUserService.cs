using BusinessLayer.DTOs.User;

namespace BusinessLayer.Services.User.Interfaces;

public interface IUserService
{
    public Task<List<UserDto>> GetAllUsersAsync();

    public Task<UserDetailDto> GetSingleUserAsync(int userId);

    public Task<UserDto> CreateSingleUserAsync(UserCreateDto userCreateDto);

    public Task<UserDto> UpdateSingleUserAsync(int userId, UserUpdateDto userUpdateDto);

    public Task<UserDto> DeleteSingleUserAsync(int userId);

    public Task<bool> DoesUserExistAsync(int userId);
}
