using Microsoft.AspNetCore.Mvc;
using TwilioSmsService.Contacts;
using TwilioSmsService.Models;

namespace TwilioSmsService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SmsController : ControllerBase
    {
        private readonly ITwilioSmsRepository _twilioSmsService;

        public SmsController(ITwilioSmsRepository twilioSmsService)
        {
            _twilioSmsService = twilioSmsService;
        }

        [HttpPost("send")]
        public IActionResult SendSms([FromBody] SmsRequest smsRequest)
        {
            _twilioSmsService.SendSms(smsRequest);
            return Ok("SMS sent successfully.");
        }
    }
}
