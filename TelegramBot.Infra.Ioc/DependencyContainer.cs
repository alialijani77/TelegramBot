using Microsoft.Extensions.DependencyInjection;
using TelegramBot.Infra.Data.DataContext;
using TelegramBot.Core.Services.Implementions;
using TelegramBot.Core.Services.Interfaces;

namespace TelegramBot.Infra.Ioc
{
    public static class DependencyContainer
    {
        public static void RegisterDependencies(IServiceCollection services, string connectionString)
        {
            #region Context
            services.AddScoped(_ => { return BaseContext.CreateInstance(connectionString, null); });
            #endregion

            #region Services
            services.AddScoped<ITelegramService, TelegramService>();
    

            #endregion

            #region Repositories
            

            #endregion
        }
    }
}
