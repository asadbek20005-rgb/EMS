using Microsoft.AspNetCore.Http;

namespace EMS.Services.ApiServices.Contracts;

public interface IAdminService
{
    Task AddContent(IFormFile file);
}