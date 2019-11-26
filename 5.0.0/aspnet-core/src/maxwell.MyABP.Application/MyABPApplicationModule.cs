using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using maxwell.MyABP.Authorization;

namespace maxwell.MyABP
{
    [DependsOn(
        typeof(MyABPCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class MyABPApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<MyABPAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(MyABPApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
