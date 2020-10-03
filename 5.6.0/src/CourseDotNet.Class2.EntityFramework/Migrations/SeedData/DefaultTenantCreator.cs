using System.Linq;
using CourseDotNet.Class2.EntityFramework;
using CourseDotNet.Class2.MultiTenancy;

namespace CourseDotNet.Class2.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly Class2DbContext _context;

        public DefaultTenantCreator(Class2DbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
