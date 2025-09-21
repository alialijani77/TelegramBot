using Telegram.Bot.Types;
using TelegramBot.Core.DTOs.ApiResult;

namespace TelegramBot.Core.Services.Interfaces
{
    public interface ITelegramService
    {
        Task<ApiResultDto<string>> StartMessageAsync(Update telegramBotDto, CancellationToken ct);
    }
}
