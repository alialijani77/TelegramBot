using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TelegramBot.Domain.Entities;

namespace TelegramBot.Infra.Data.Configurations
{
    public class ServiceProviderConfig : IEntityTypeConfiguration<ServiceProvider>
    {
        public void Configure(EntityTypeBuilder<ServiceProvider> builder)
        {
            builder.HasKey(c => c.ServiceProviderId);

        }
    }
}