using Microsoft.EntityFrameworkCore;
using SneakersShop.ApplicationCore.Interfaces;
using Infrastructure.Data;
using Infrastructure.Repository;
using Website.Areas.Admin.Models;
using Website.Services;
using Website.Utility;

namespace Website.Configuration
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
