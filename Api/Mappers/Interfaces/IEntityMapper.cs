using Api.DTOs.Interfaces;
using DAL.Models;

namespace Api.Mappers.Interfaces;

public interface IEntityMapper<TModel, TDto, out TDetailDto>
    where TModel : BaseEntity
    where TDto : BaseDto
    where TDetailDto : BaseDto
{
    public TDto ToDto(TModel model);

    public TDetailDto ToDetailDto(TModel model);

    public TModel ToModel(TDto dto);
}
