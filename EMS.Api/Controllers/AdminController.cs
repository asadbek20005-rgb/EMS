using System.Net;
using EMS.Data.Entities;
using EMS.Services.ApiServices.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace EMS.API.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class AdminController(IAdminService adminService) : Controller
{
    private readonly IAdminService _adminService = adminService;

    [HttpPost]
    public async Task<ActionResult> AddContent(IFormFile file)
    {
        await _adminService.AddContent(file);
        // return Ok("Content added");
        return File(new MemoryStream(), "image/png");
    }
}