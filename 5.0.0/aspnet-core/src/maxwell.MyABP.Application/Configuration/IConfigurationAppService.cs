using System.Threading.Tasks;
using maxwell.MyABP.Configuration.Dto;

namespace maxwell.MyABP.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
