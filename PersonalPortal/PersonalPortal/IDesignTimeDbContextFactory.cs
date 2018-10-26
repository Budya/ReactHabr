using Microsoft.EntityFrameworkCore;

namespace PersonalPortal
{
    interface IDesignTimeDbContextFactory<out TContext> 
        where TContext : DbContext
    {
        TContext CreateDbContext(string[] args);
    }
}
