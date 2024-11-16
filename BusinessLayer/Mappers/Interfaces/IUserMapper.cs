using BusinessLayer.DTOs.User;
using DAL.Models;

namespace BusinessLayer.Mappers.Interfaces;

public interface IUserMapper
    : IEntityMapper<User, UserDto, UserDetailDto, UserCreateDto, UserUpdateDto>;
