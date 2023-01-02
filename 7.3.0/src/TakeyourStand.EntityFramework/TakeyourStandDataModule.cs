using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using TakeyourStand.EntityFramework;

namespace TakeyourStand
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(TakeyourStandCoreModule))]
    public class TakeyourStandDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<TakeyourStandDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
