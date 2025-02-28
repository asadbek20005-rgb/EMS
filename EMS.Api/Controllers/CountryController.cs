using EMS.Common.Dtos;
using EMS.Common.Models.BaseModels;
using EMS.Data.Entities;
using EMS.Services.ApiServices.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace EMS.API.Controllers;
[ApiController]
[Route("api/[controller]/[action]")]
public class CountryController(IBaseInfoService<Country> service) : BaseInfoController<Country, CountryDto, CreateBaseInfoModel, UpdateBaseInfoModel, int>(service)
{

}