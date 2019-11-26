using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using maxwell.MyABP.Authorization.Roles;
using maxwell.MyABP.Authorization.Users;
using maxwell.MyABP.MultiTenancy;

namespace maxwell.MyABP.EntityFrameworkCore
{
    public class MyABPDbContext : AbpZeroDbContext<Tenant, Role, User, MyABPDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public MyABPDbContext(DbContextOptions<MyABPDbContext> options)
            : base(options)
        {
        }
    }
}
