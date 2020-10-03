using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using CourseDotNet.Class2.MultiTenancy;

namespace CourseDotNet.Class2.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}