using Api.DTOs.User;
using Api.Mappers.Interfaces;
using DAL.Models;

namespace Api.Mappers;

public class UserMapper(
    IBookReviewMapper bookReviewMapper,
    IOrderMapper orderMapper,
    IWishListItemMapper wishListItemMapper
) : IUserMapper
{
    public UserDto ToDto(User model)
    {
        return new UserDto
        {
            Id = model.Id,
            Username = model.Username,
            Email = model.Email,
            Role = model.Role,
        };
    }

    public UserDetailDto ToDetailDto(User model)
    {
        return new UserDetailDto
        {
            Id = model.Id,
            Username = model.Username,
            Email = model.Email,
            Role = model.Role,
            BookReviews = model.Reviews.Select(bookReviewMapper.ToDto).ToList(),
            Orders = model.Orders.Select(orderMapper.ToDto).ToList(),
            WishListItems = model.WishListItems.Select(wishListItemMapper.ToDto).ToList(),
        };
    }

    public User ToModel(UserCreateDto dto)
    {
        return new User()
        {
            Username = dto.Username,
            Password = dto.Password,
            Email = dto.Email,
            Role = dto.Role,
        };
    }

    public void UpdateModel(User model, UserUpdateDto updateDto)
    {
        model.Username = updateDto.Username;
        model.Password = updateDto.Password;
        model.Email = updateDto.Email;
        model.Role = updateDto.Role;
    }
}
