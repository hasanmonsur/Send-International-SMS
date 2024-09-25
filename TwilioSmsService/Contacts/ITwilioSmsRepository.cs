using TwilioSmsService.Models;

namespace TwilioSmsService.Contacts
{
    public interface ITwilioSmsRepository
    {
        void SendSms(SmsRequest smsRequest);
    }
}