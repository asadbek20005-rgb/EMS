using EMS.Common.Dtos;
using EMS.Common.Models.UserModels;
using StatusGeneric;

namespace EMS.Services.ApiServices.Contracts;

public interface IUserService : IStatusGeneric
{
    Task<List<UserDto>> GetAllUsers();
    Task<UserDto?> GetUserById(Guid id);
    Task Register(CreateUserModel model);

    Task CreateEmployee();
    Task<string> Login(LoginModel model);
}