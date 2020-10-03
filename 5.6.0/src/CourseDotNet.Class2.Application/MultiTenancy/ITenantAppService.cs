using Abp.Application.Services;
using Abp.Application.Services.Dto;
using CourseDotNet.Class2.MultiTenancy.Dto;

namespace CourseDotNet.Class2.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
