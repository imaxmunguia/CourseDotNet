using Abp.Application.Features;
using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using CourseDotNet.Class2.Authorization.Users;
using CourseDotNet.Class2.Editions;

namespace CourseDotNet.Class2.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager,
            IAbpZeroFeatureValueStore featureValueStore
            ) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager,
                featureValueStore
            )
        {
        }
    }
}