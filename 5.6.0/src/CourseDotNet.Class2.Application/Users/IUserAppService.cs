using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using CourseDotNet.Class2.Roles.Dto;
using CourseDotNet.Class2.Users.Dto;

namespace CourseDotNet.Class2.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}