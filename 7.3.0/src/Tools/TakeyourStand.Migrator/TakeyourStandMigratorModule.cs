using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using TakeyourStand.EntityFramework;

namespace TakeyourStand.Migrator
{
    [DependsOn(typeof(TakeyourStandDataModule))]
    public class TakeyourStandMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<TakeyourStandDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}