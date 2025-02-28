using EMS.Services.ApiServices.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace EMS.API.Controllers;

[ApiController]
public class BaseInfoController<TEntity, TDto, TCreateModel, TUpdateModel, TId>(IBaseInfoService<TEntity> service) : ControllerBase
    where TEntity : class
{
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var result = await service.GetAll<TDto>();
        if (service.IsValid)
            return Ok(result);

        return BadRequest(service.Errors);
    }

    [HttpGet]
    public async Task<IActionResult> GetById(TId id)
    {
        var result = await service.GetById<TDto, TId>(id);
        if (service.IsValid)
            return Ok(result);

        return BadRequest(service.Errors);
    }

    [HttpPost]
    public async Task<IActionResult> Create(TCreateModel model)
    {
        var result = await service.Create(model);
        if (service.IsValid)
            return Ok(result);

        return BadRequest(service.Errors);
    }

    [HttpPut]
    public async Task<IActionResult> Update(TId id, TUpdateModel model)
    {
        var result = await service.Update(id, model);
        if (service.IsValid)
            return Ok(result);

        return BadRequest(service.Errors);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete(TId id)
    {
        var result = await service.DeleteById(id);
        if (service.IsValid)
            return Ok(result);

        return BadRequest(service.Errors);
    }
}