using Api.DTOs.Interfaces;
using DAL.Models;

namespace Api.Mappers.Interfaces;

public interface IEntityMapper<TModel, TDto>
    where TModel : BaseEntity
    where TDto : BaseDto
{
    public TDto ToDto(TModel model);

    public TModel ToModel(TDto dto);
}
