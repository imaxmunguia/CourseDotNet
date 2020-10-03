using System.Threading.Tasks;
using Abp.Application.Services;
using CourseDotNet.Class2.Sessions.Dto;

namespace CourseDotNet.Class2.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
