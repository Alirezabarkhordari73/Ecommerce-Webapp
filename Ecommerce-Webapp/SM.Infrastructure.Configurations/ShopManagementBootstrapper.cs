using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SM.Infrastructure.EfCore;

namespace SM.Infrastructure.Configurations
{
    public class ShopManagementBootstrapper
    {
        public static void Configure(IServiceCollection services, string? connectionString)
        {
            services.AddDbContext<ShopContext>(x => x.UseSqlServer(connectionString));
        }
    }
}
