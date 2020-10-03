using Abp.AutoMapper;
using CourseDotNet.Class2.Sessions.Dto;

namespace CourseDotNet.Class2.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}