using Abp.Application.Services;
using Abp.Application.Services.Dto;
using maxwell.MyABP.MultiTenancy.Dto;

namespace maxwell.MyABP.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

