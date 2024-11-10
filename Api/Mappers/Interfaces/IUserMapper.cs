using Api.DTOs.User;
using DAL.Models;

namespace Api.Mappers.Interfaces;

public interface IUserMapper
    : IEntityMapper<User, UserDto, UserDetailDto, UserCreateDto, UserUpdateDto>;
