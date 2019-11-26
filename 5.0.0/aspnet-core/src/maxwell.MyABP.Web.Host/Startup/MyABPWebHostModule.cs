using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using maxwell.MyABP.Configuration;

namespace maxwell.MyABP.Web.Host.Startup
{
    [DependsOn(
       typeof(MyABPWebCoreModule))]
    public class MyABPWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public MyABPWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyABPWebHostModule).GetAssembly());
        }
    }
}
