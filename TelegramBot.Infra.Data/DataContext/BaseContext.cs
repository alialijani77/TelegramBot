using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace TelegramBot.Infra.Data.DataContext
{
    public abstract class BaseContext : DbContext
    {
        protected BaseContext() { }

        public static BaseContext CreateInstance(string connectionString, ILoggerFactory loggerFactory)
        {
            return new SqlServerContext(connectionString, loggerFactory);
        }

        #region DbSet

        #endregion

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.HasDefaultSchema("TelegramBot");

            #region Configurations
            //new EmailSettingConfiguration().Configure(builder.Entity<EmailSetting>());         
            #endregion
        }
    }
}