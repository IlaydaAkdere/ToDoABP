using ToDoApp.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace ToDoApp.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ToDoAppEntityFrameworkCoreModule),
    typeof(ToDoAppApplicationContractsModule)
    )]
public class ToDoAppDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
