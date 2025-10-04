namespace TelegramBot.Domain.Entities
{
    public class ServiceProvider
    {
        public long ServiceProviderId { get; set; }
        public string? Token { get; set; }
        public string? BotWebhookUrl { get; set; }
    }
}