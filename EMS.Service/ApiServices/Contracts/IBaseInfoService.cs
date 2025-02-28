﻿using StatusGeneric;

namespace EMS.Services.ApiServices.Contracts;

public interface IBaseInfoService<TEntity> : IStatusGeneric
{
    Task<List<TDto>> GetAll<TDto>();
    Task<TDto?> GetById<TDto, TId>(TId id);
    Task<string> Create<TModel>(TModel model);
    Task<string?> Update<TId, TModel>(TId id, TModel model);
    Task<string?> DeleteById<TId>(TId id);
}