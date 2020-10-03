using Abp.MultiTenancy;
using CourseDotNet.Class2.Authorization.Users;

namespace CourseDotNet.Class2.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {
            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}