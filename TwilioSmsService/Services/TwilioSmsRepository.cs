using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;
using TwilioSmsService.Contacts;
using TwilioSmsService.Models;

namespace TwilioSmsService.Services
{
    public class TwilioSmsRepository : ITwilioSmsRepository
    {
        private readonly string _accountSid;
        private readonly string _authToken;
        private readonly string _fromPhoneNumber;

        public TwilioSmsRepository(IConfiguration config)
        {
            _accountSid = config["Twilio:AccountSid"];
            _authToken = config["Twilio:AuthToken"];
            _fromPhoneNumber = config["Twilio:FromPhoneNumber"];

            TwilioClient.Init(_accountSid, _authToken);
        }

        public void SendSms(SmsRequest smsRequest)
        {
            var message = MessageResource.Create(
                body: smsRequest.Message,
                from: new PhoneNumber(_fromPhoneNumber),
                to: new PhoneNumber(smsRequest.ToPhoneNumber)
            );

            Console.WriteLine($"SMS sent with SID: {message.Sid}");
        }
    }
}
