using System.Threading.Tasks;
using Abp.Application.Services;
using maxwell.MyABP.Authorization.Accounts.Dto;

namespace maxwell.MyABP.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
