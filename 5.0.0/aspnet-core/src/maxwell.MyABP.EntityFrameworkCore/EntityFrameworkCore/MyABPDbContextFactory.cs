using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using maxwell.MyABP.Configuration;
using maxwell.MyABP.Web;

namespace maxwell.MyABP.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class MyABPDbContextFactory : IDesignTimeDbContextFactory<MyABPDbContext>
    {
        public MyABPDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<MyABPDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            MyABPDbContextConfigurer.Configure(builder, configuration.GetConnectionString(MyABPConsts.ConnectionStringName));

            return new MyABPDbContext(builder.Options);
        }
    }
}
