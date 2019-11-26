using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using maxwell.MyABP.Roles.Dto;
using maxwell.MyABP.Users.Dto;

namespace maxwell.MyABP.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
