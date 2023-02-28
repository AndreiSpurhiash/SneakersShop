using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SneakersShop.Infrastructure.Data;

namespace SneakersShop.Web.Configuration
{
    public static class Dependencies
    {
        public static void ConfigureServices(IConfiguration configuration, IServiceCollection services, ILoggingBuilder loggingBuilder)
        {
            services.AddDbContext<CatalogContext>(context => context.UseSqlServer(configuration.GetConnectionString("CatalogConnection")));
           
        }
    }
}
