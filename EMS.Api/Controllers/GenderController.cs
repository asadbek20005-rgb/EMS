using EMS.Common.Dtos;
using EMS.Common.Models.BaseModels;
using EMS.Data.Entities;
using EMS.Services.ApiServices.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace EMS.API.Controllers;


[ApiController]
[Route("api/[controller]/[action]")]
public class GenderController(IBaseInfoService<Gender> service) : BaseInfoController<Gender, GenderDto, CreateBaseInfoModel, UpdateBaseInfoModel, int>(service)
{

}