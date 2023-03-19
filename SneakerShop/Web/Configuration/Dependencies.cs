using Microsoft.EntityFrameworkCore;
using SneakersShop.ApplicationCore.Interfaces;
using SneakersShop.Infrastructure.Data;
using SneakersShop.Infrastructure.Repositor;
using SneakersShop.Web.Areas.Admin.Models;
using SneakersShop.Web.Services;
using SneakersShop.Web.Utility;

namespace SneakersShop.Web.Configuration
{
    public static class Dependencies
    {
        public static void ConfigureServices(IConfiguration configuration, IServiceCollection services, ILoggingBuilder loggingBuilder)
        {
            services.AddDbContext<CatalogContext>(context => context.UseSqlServer(configuration.GetConnectionString("CatalogConnection")));
            services.AddSingleton(typeof(IAppLogger<>), typeof(LoggerAdapter<>));
            services.AddAutoMapper(typeof(MappingProfile));

            #region Model Crud Services
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IItemGenericService<ColorViewModel>, ColorService>();
            #endregion
        }
    }
}
