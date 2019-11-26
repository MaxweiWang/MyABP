using System.Threading.Tasks;
using Abp.Application.Services;
using maxwell.MyABP.Sessions.Dto;

namespace maxwell.MyABP.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
