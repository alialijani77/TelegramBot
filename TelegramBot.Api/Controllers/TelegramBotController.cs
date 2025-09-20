using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TelegramBot.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TelegramBotController : ControllerBase
    {
        [AllowAnonymous]
        [HttpPost("TelegramBot")]
        public async Task<IActionResult> TelegramBot([FromBody] Telegram.Bot.Types.Update update)
        {
            return Ok();
        }
    }
}