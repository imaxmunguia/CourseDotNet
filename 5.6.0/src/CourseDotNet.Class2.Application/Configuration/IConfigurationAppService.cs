using System.Threading.Tasks;
using Abp.Application.Services;
using CourseDotNet.Class2.Configuration.Dto;

namespace CourseDotNet.Class2.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}