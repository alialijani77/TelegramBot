using Telegram.Bot.Types;
using TelegramBot.Core.DTOs.ApiResult;
using TelegramBot.Core.Services.Interfaces;

namespace TelegramBot.Core.Services.Implementions
{
    public class TelegramService : ITelegramService
    {
        public Task<ApiResultDto<string>> StartMessageAsync(Update telegramBotDto, CancellationToken ct)
        {
            throw new NotImplementedException();
        }
    }
}
