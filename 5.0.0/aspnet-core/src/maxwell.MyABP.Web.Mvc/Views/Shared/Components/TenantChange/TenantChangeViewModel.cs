using Abp.AutoMapper;
using maxwell.MyABP.Sessions.Dto;

namespace maxwell.MyABP.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}
