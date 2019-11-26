using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace maxwell.MyABP.EntityFrameworkCore
{
    public static class MyABPDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<MyABPDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<MyABPDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection,b=>b.UseRowNumberForPaging());
        }
    }
}
