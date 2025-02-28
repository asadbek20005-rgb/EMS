using Mapster;

namespace EMS.Services.Extensions;

public static class MapExtension
{
    public static TEntity MapToEntity<TEntity, TModel>(this TModel model)
    {
        var entity = model.Adapt<TEntity>();
        return entity;
    }

    public static TDto MapToDto<TEntity, TDto>(this TEntity source)
    {
        var dto = source.Adapt<TDto>();
        return dto;
    }

    public static List<TDto> MapToDtos<TEntity, TDto>(this List<TEntity>? entities)
    {
        if (entities is null)
            return new();

        return entities.Select(entity => entity.MapToDto<TEntity, TDto>()).ToList();
    }

    public static TEntity MapForUpdate<TEntity, TModel>(this TModel model, TEntity entity)
    {
        entity = model.Adapt(entity);
        return entity;
    }

    //ex:  country  : {shortname = "uzb,code="01"}\
    //model : {code = "03"}
}