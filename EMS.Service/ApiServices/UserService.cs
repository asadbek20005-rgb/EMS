using EMS.Common.Dtos;
using EMS.Common.Models.UserModels;
using EMS.Data.Entities;
using EMS.Data.Repositories.Contracts;
using EMS.Services.ApiServices.Contracts;
using EMS.Services.Extensions;
using StatusGeneric;

namespace EMS.Services.ApiServices;

public class UserService(IBaseRepository<User> userRepository) : StatusGenericHandler, IUserService
{
    private readonly IBaseRepository<User> _userRepository = userRepository;

    public async Task<List<UserDto>> GetAllUsers()
    {
        var users = (await _userRepository.GetAll()).ToList();
        return users.MapToDtos<User, UserDto>();
    }

    public async Task<UserDto?> GetUserById(Guid id)
    {
        var user = await _userRepository.GetById(id);

        if (user is null)
        {
            AddError("User not found");
            return null;
        }

        return user.MapToDto<User, UserDto>();
    }

    public async Task Register(CreateUserModel model)
    {
        var user = model.MapToEntity<User, CreateUserModel>();
        await _userRepository.Add(user);
        await _userRepository.SaveChanges();
    }

    public async Task CreateEmployee()
    {
        throw new NotImplementedException();
    }

    public async Task<string> Login(LoginModel model)
    {
        throw new NotImplementedException();
    }
}