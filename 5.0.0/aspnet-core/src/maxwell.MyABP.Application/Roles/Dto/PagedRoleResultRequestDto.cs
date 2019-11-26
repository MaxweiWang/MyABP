using Abp.Application.Services.Dto;

namespace maxwell.MyABP.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

