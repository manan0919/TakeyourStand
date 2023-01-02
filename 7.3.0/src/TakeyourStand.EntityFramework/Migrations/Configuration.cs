using System.Data.Entity.Migrations;
using Abp.MultiTenancy;
using Abp.Zero.EntityFramework;
using TakeyourStand.Migrations.SeedData;
using EntityFramework.DynamicFilters;

namespace TakeyourStand.Migrations
{
    public sealed class Configuration : DbMigrationsConfiguration<TakeyourStand.EntityFramework.TakeyourStandDbContext>, IMultiTenantSeed
    {
        public AbpTenantBase Tenant { get; set; }

        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "TakeyourStand";
        }

        protected override void Seed(TakeyourStand.EntityFramework.TakeyourStandDbContext context)
        {
            context.DisableAllFilters();

            if (Tenant == null)
            {
                //Host seed
                new InitialHostDbBuilder(context).Create();

                //Default tenant seed (in host database).
                new DefaultTenantCreator(context).Create();
                new TenantRoleAndUserBuilder(context, 1).Create();
            }
            else
            {
                //You can add seed for tenant databases and use Tenant property...
            }

            context.SaveChanges();
        }
    }
}
